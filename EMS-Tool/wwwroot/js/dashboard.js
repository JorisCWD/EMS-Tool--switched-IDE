document.addEventListener("DOMContentLoaded", function () {
    if (window.Chart && window['chartjs-plugin-zoom']) {
        const zoomPlugin = window['chartjs-plugin-zoom'].default || window['chartjs-plugin-zoom'].zoom;
        if (zoomPlugin) {
            Chart.register(zoomPlugin);
        }
    }

    // --- GRIDSTACK INIT (v12) ---
    const grid = GridStack.init({
        float: true,          // allows free movement
        cellHeight: 20,       // 20px row height
        column: 60,           // number of columns in the grid
        margin: 2,            // optional: 2px margin between items (default was 20px before)
        disableOneColumnMode: true  // optional: prevents collapsing to single-column on small screens
    });


    grid.on('change', function (event, items) {
        items.forEach(item => {
            const chartId = item.el.getAttribute('data-id');
            const update = {
                chartId: parseInt(chartId),
                x: item.x,
                y: item.y,
                width: item.w * 100,
                height: item.h * 100
            };

            fetch(`/Dashboard/UpdateChartPosition?projectId=${window.projectId}`, {
                method: "POST",
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(update)
            });
        });
    });

    document.addEventListener("click", function (e) {
        const btn = e.target.closest(".toggle-lock-btn");
        if (!btn) return;

        const chartId = btn.dataset.id;
        const el = document.querySelector(`[data-id='${chartId}']`);
        const grid = GridStack.getGridElement(document.querySelector(".grid-stack")).gridstack;

        const isLocked = el.classList.contains("locked");

        grid.update(el, {
            noMove: !isLocked,
            noResize: !isLocked
        });

        el.classList.toggle("locked");
        btn.innerHTML = isLocked
            ? '<i class="bi bi-unlock"></i> Lock Widget'
            : '<i class="bi bi-lock"></i> Unlock Widget';
    });






    // --- Render charts with real data ---
    const canvasElements = document.querySelectorAll("canvas[id^='chart-']");

    // --- Helper functions ---
    function isValidDate(d) {
        return d instanceof Date && !isNaN(d);
    }

    function isLikelyDate(val) {
        if (typeof val !== 'string' && typeof val !== 'number') return false;
        const parsed = new Date(val);
        return isValidDate(parsed) && /\d{4}-\d{1,2}-\d{1,2}/.test(parsed.toISOString());
    }

    canvasElements.forEach(canvas => {
        const chartId = canvas.id.replace("chart-", "");
        const type = canvas.dataset.type || "bar";
        const ctx = canvas.getContext('2d');

        const metaUrl = `/api/chart-meta/chart-meta?chartId=${chartId}&projectId=${window.projectId}`;
        const dataUrl = `/api/dashboard/chart-data?projectId=${window.projectId}&chartId=${chartId}`;

        Promise.all([
            fetch(metaUrl).then(res => res.json()),
            fetch(dataUrl).then(res => res.json())
        ])
            .then(([metaResult, data]) => {
                const meta = metaResult.meta || {};
                if (!data || data.length === 0) {
                    throw new Error("No data returned from chart-data API.");
                }

                const xKeys = Object.keys(data[0]);
                if (xKeys.length < 2) {
                    throw new Error("Expected at least 2 columns (X and Y).");
                }

                const xValues = data.map(row => row[xKeys[0]]);
                const yValues = data.map(row => row[xKeys[1]]);

                const labels = xValues.map(val => isLikelyDate(val) ? new Date(val).toISOString().split('T')[0] : val);
                const values = yValues.map(val => isNaN(val) ? val : Number(val));

                const chartData = {
                    labels: labels,
                    datasets: [{
                        label: meta.label || `Chart ${chartId}`,
                        data: values,
                        backgroundColor: '#007bff'
                    }]
                };

                const config = {
                    type: type.toLowerCase(),
                    data: chartData,
                    options: {
                        responsive: true,
                        maintainAspectRatio: false,
                        plugins: {
                            title: {
                                display: true,
                                text: canvas.dataset.title || meta.label || `Chart ${chartId}`
                            },
                            tooltip: {
                                callbacks: {
                                    label: function (context) {
                                        return `${context.dataset.label}: ${context.formattedValue} ${meta.unit || ''}`;
                                    }
                                }
                            },
                            zoom: {
                                pan: {
                                    enabled: true,
                                    mode: 'x',
                                },
                                zoom: {
                                    wheel: {
                                        enabled: true,
                                        modifierKey: 'ctrl'
                                    },
                                    pinch: {
                                        enabled: true
                                    },
                                    drag: {
                                        enabled: true,
                                        backgroundColor: 'rgba(0,0,0,0.1)',
                                        modifierKey: 'ctrl'
                                    },
                                    mode: 'x' // belongs inside zoom, not directly under plugins.zoom
                                }
                            }
                        },
                        scales: {
                            y: {
                                title: {
                                    display: !!meta.unit,
                                    text: meta.unit || ''
                                }
                            },
                            x: {
                                ticks: {
                                    type: 'time',
                                    time: {
                                        unit: 'day'
                                    },
                                    //maxRotation: 45,
                                    //minRotation: 30,
                                    //autoSkip: true,
                                    //maxTicksLimit: 10
                                }
                            }
                        }
                    }
                };

                new Chart(ctx, config);
            })
            .catch(err => {
                console.error(`Failed to render chart ${chartId}`, err);
                ctx.fillText("Error loading data", 10, 50);
            });
    });

    // --- Populate column selects based on selected table ---
    const tableSelect = document.getElementById('tableSelect');
    const xColumnSelect = document.getElementById('xColumnSelect');
    const yColumnSelect = document.getElementById('yColumnSelect');
    const dataQueryInput = document.getElementById('dataQueryInput');

    tableSelect?.addEventListener('change', function () {
        const table = tableSelect.value;
        if (!table) return;

        fetch(`/api/dashboard/columns?projectId=${window.projectId}&tableName=${table}`)
            .then(res => res.json())
            .then(columns => {
                xColumnSelect.innerHTML = '<option value="">Select X Column</option>';
                yColumnSelect.innerHTML = '<option value="">Select Y Column</option>';

                columns.forEach(col => {
                    const xOpt = document.createElement('option');
                    xOpt.value = col;
                    xOpt.textContent = col;

                    const yOpt = xOpt.cloneNode(true);
                    xColumnSelect.appendChild(xOpt);
                    yColumnSelect.appendChild(yOpt);
                });
            });
    });
    // --- Live Chart Preview Logic ---
    let previewChart;

    const chartTypeSelect = document.querySelector("select[name='ChartType']");
    const chartPreviewCanvas = document.getElementById("chartPreview");

    function updatePreviewChart() {
        const table = tableSelect.value;
        const xCol = xColumnSelect.value;
        const yCol = yColumnSelect.value;
        const chartType = chartTypeSelect?.value;

        if (!table || !xCol || !yCol || !chartType || !chartPreviewCanvas) return;

        fetch(`/api/dashboard/sample-data?projectId=${window.projectId}&tableName=${table}&xColumn=${xCol}&yColumn=${yCol}`)
            .then(async res => {
                if (!res.ok) {
                    const text = await res.text();
                    throw new Error(`HTTP ${res.status} - ${text}`);
                }

                // Try parsing response as JSON
                const data = await res.json();

                if (!Array.isArray(data) || data.length === 0) {
                    throw new Error("No valid data returned for preview.");
                }

                const labels = data.map(row => {
                    const val = row[xCol];
                    return isLikelyDate(val) ? new Date(val).toISOString().split('T')[0] : val;
                });

                const values = data.map(row => {
                    const val = row[yCol];
                    return isNaN(val) ? val : Number(val);
                });

                const ctx = chartPreviewCanvas.getContext("2d");
                if (previewChart) previewChart.destroy();

                previewChart = new Chart(ctx, {
                    type: chartType.toLowerCase(),
                    data: {
                        labels: labels,
                        datasets: [{
                            label: yCol,
                            data: values,
                            backgroundColor: 'rgba(0,123,255,0.5)',
                            borderColor: 'rgba(0,123,255,1)',
                            borderWidth: 1
                        }]
                    },
                    options: {
                        responsive: true,
                        maintainAspectRatio: false,
                        scales: chartType === 'Pie' ? {} : {
                            y: {
                                beginAtZero: true
                            }
                        }
                    }
                });
            })
            .catch(err => {
                console.error("Chart preview error:", err);

                const ctx = chartPreviewCanvas.getContext("2d");
                ctx.clearRect(0, 0, chartPreviewCanvas.width, chartPreviewCanvas.height);
                ctx.font = "16px sans-serif";
                ctx.fillStyle = "red";
                ctx.fillText("Preview error: " + err.message, 10, 50);
            });
    }

    // Update preview when user selects X/Y columns or chart type
    xColumnSelect?.addEventListener('change', updatePreviewChart);
    yColumnSelect?.addEventListener('change', updatePreviewChart);
    chartTypeSelect?.addEventListener('change', updatePreviewChart);


    // --- Build query before submitting add widget form ---
    document.querySelector('#addWidgetModal form')?.addEventListener('submit', function (e) {
        const table = tableSelect.value;
        const xCol = xColumnSelect.value;
        const yCol = yColumnSelect.value;

        if (table && xCol && yCol) {
            const query = `SELECT [${xCol}], [${yCol}] FROM [${table}] ORDER BY CONVERT(DATETIME, [${xCol}])`;
            dataQueryInput.value = query;
        }
    });

    document.querySelectorAll('.delete-chart').forEach(button => {
        button.addEventListener('click', async () => {
            const chartId = button.dataset.id;
            if (!confirm('Are you sure you want to delete this chart?')) return;

            const res = await fetch(`/Dashboard/DeleteChart?projectId=${window.projectId}&chartId=${chartId}`, { method: 'POST' });
            if (res.ok) location.reload();
            else alert('Failed to delete chart');
        });
    });

    document.querySelectorAll('.export-chart').forEach(button => {
        button.addEventListener('click', async () => {
            const chartId = button.dataset.id;

            try {
                const response = await fetch(`/api/chartdata/${window.projectId}/${chartId}`);

                if (!response.ok) {
                    const text = await response.text();
                    throw new Error(`Export API returned ${response.status}: ${text}`);
                }

                const result = await response.json();

                if (!result || !result.data || result.data.length === 0) {
                    alert('No data available to export.');
                    return;
                }

                const rows = result.data;
                const headers = Object.keys(rows[0]);

                const csv = [
                    headers.join(','),
                    ...rows.map(row => headers.map(h => `"${(row[h] ?? '').toString().replace(/"/g, '""')}"`).join(','))
                ].join('\n');

                const blob = new Blob([csv], { type: 'text/csv' });
                const url = URL.createObjectURL(blob);

                const link = document.createElement('a');
                link.href = url;
                link.download = `chart-${chartId}.csv`;
                document.body.appendChild(link);
                link.click();
                link.remove();
                URL.revokeObjectURL(url);
            } catch (err) {
                console.error("Export error:", err);
                alert("Failed to export chart. See console for details.");
            }
        });
    });
    document.querySelectorAll('.reset-zoom-btn').forEach(button => {
        button.addEventListener('click', () => {
            const chartId = button.dataset.id;
            const chartInstance = Chart.getChart(`chart-${chartId}`);
            if (chartInstance) {
                chartInstance.resetZoom();
            }
        });
    });


});
