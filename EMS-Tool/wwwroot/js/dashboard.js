document.addEventListener('DOMContentLoaded', () => {
    const grid = GridStack.init({ resizable: { handles: 'all' } });

    grid.on('change', function (event, items) {
        items.forEach(item => {
            const chartId = item.el.dataset.id;
            const x = item.x;
            const y = item.y;
            const width = item.w * 100;  // Convert to px
            const height = item.h * 100;

            fetch('/Dashboard/UpdateChartPosition', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({
                    chartId: parseInt(chartId),
                    x,
                    y,
                    width,
                    height,
                    projectId: window.projectId  // Set this in your ViewBag
                })
            });
        });
    });
});

document.addEventListener('DOMContentLoaded', () => {
    document.querySelectorAll('.chart-box').forEach(chartBox => {
        const chartId = chartBox.dataset.id;
        fetch(`/api/chartdata/${chartId}`)  // We'll create this API endpoint below
            .then(res => res.json())
            .then(data => {
                const ctx = document.getElementById(`chart-${chartId}`).getContext('2d');
                new Chart(ctx, {
                    type: data.type.toLowerCase(),
                    data: data.data,
                    options: data.options || {}
                });
            });
    });
});

