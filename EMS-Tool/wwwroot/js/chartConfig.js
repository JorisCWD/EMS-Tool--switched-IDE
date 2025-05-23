Chart.defaults.font.family = 'Arial';
Chart.defaults.font.size = 10;
Chart.defaults.color = '#333';

Chart.defaults.plugins.legend.position = 'bottom';
Chart.defaults.plugins.tooltip.backgroundColor = '#007bff';

Chart.defaults.elements.line.borderWidth = 2;
Chart.defaults.elements.point.radius = 0;

const defaultColors = [
    'rgba(153, 102, 255, 0.7)', // Purple
    'rgba(153, 102, 255, 0.7)', // Purple
    'rgba(153, 102, 255, 0.7)', // Purple
    'rgba(255, 99, 132, 0.7)', // Red
    'rgba(255, 206, 86, 0.7)', // Yellow
    'rgba(75, 192, 192, 0.7)', // Teal
    'rgba(255, 159, 64, 0.7)', // Orange
];

Chart.register({
    id: 'defaultDatasetColors',
    beforeUpdate(chart) {
        chart.data.datasets.forEach((dataset, index) => {
            const color = defaultColors[index % defaultColors.length];
            if (!dataset.backgroundColor) dataset.backgroundColor = color;
            if (!dataset.borderColor) dataset.borderColor = color;
        });
    }
});
