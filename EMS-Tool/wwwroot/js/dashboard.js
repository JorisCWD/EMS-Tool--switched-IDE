document.addEventListener("DOMContentLoaded", function () {
    if (window.Chart && window['chartjs-plugin-zoom']) {
        Chart.register(window['chartjs-plugin-zoom']);
    }
    // --- GRIDSTACK INIT (if present) ---
    const grid = GridStack.init({
        float: true,
        cellHeight: 20,
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
        const label = canvas.dataset.title || `Chart ${chartId}`;
        const ctx = canvas.getContext('2d');

        fetch(`/api/dashboard/chart-data?projectId=${window.projectId}&chartId=${chartId}`)
            .then(response => response.json())
            .then(data => {
                if (!data || data.length === 0) {
                    throw new Error("No data returned from query.");
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
                        label: label,
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
                                text: label
                            },
                            zoom: {
                                wheel: {
                                    enabled: true,
                                },
                                pan: {
                                    enabled: true,
                                    mode:'x'
                                },
                                drag: {
                                    enabled: true,
                                    backgroundColor: 'rgba(0,0,0,0.1)',
                                    modifierKey: 'ctrl'
                                },
                                mode: 'x'
                            }
                        },
                        scales: {
                            x: {
                                ticks: {
                                    maxRotation: 45,
                                    minRotation: 30,
                                    autoSkip: true,
                                    maxTicksLimit: 10
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

    // --- Build query before submitting add widget form ---
    document.querySelector('#addWidgetModal form')?.addEventListener('submit', function (e) {
        const table = tableSelect.value;
        const xCol = xColumnSelect.value;
        const yCol = yColumnSelect.value;

        if (table && xCol && yCol) {
            const query = `SELECT [${xCol}], [${yCol}] FROM [${table}]`;
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

            const response = await fetch(`/api/chartdata/${window.projectId}/${chartId}`);
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
        });
    });
});
