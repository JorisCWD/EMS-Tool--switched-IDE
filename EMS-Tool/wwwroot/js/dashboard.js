document.addEventListener("DOMContentLoaded", function () {
    // --- GRIDSTACK INIT (if present) ---
    const grid = GridStack.init({
        float: true,
        cellHeight: 100,
        disableOneColumnMode: true
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

                const labels = data.map(row => row[xKeys[0]]);
                const values = data.map(row => row[xKeys[1]]);

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

    document.querySelectorAll(".delete-chart").forEach(btn => {
        btn.addEventListener("click", function () {
            const chartId = this.getAttribute("data-id");
            if (confirm("Are you sure you want to delete this chart?")) {
                fetch(`/Dashboard/DeleteChart?projectId=${window.projectId}&chartId=${chartId}`, {
                    method: "POST"
                }).then(() => location.reload());
            }
        });
    });
});
