let chart;

console.log("Script loaded ✅");

window.onload = function () {
    const tableSelector = document.getElementById('tableSelector');
    const groupByField = document.getElementById('groupByField');
    const valueField = document.getElementById('valueField');
    const chartType = document.getElementById('chartType');

    tableSelector.addEventListener('change', async () => {
        const table = tableSelector.value;
        const res = await fetch(`/Chart/GetColumns?tableName=${table}`);
        const columns = await res.json();

        groupByField.innerHTML = columns.map(c => `<option value="${c}">${c}</option>`).join('');
        valueField.innerHTML = columns.map(c => `<option value="${c}">${c}</option>`).join('');

        loadChart();
    });

    groupByField.addEventListener('change', loadChart);
    valueField.addEventListener('change', loadChart);
    chartType.addEventListener('change', loadChart);
};


async function loadChart() {
    const table = document.getElementById('tableSelector').value;
    const groupField = document.getElementById('groupByField').value;
    const valueField = document.getElementById('valueField').value;
    const chartType = document.getElementById('chartType').value;

    if (!table || !groupField || !valueField) {
        return;
    }

    const url = `/Chart/GetAggregatedChartData?tableName=${table}&groupByField=${groupField}&valueField=${valueField}`;

    try {
        const res = await fetch(url);
        if (!res.ok) {
            console.error("Server returned error:", res.statusText);
            return;
        }

        const text = await res.text();
        let data;
        try {
            data = JSON.parse(text);
            console.log("Chart data:", data);
        } catch (e) {
            console.error("Invalid JSON:", text);
            return;
        }
        if (!Array.isArray(data)) {
            console.error("Expected array, got:", data);
            return;
        }

        const labels = data.map(d => d.group);
        const values = data.map(d => d.value);

        if (chart) chart.destroy();

        chart = new Chart(document.getElementById('chartCanvas'), {
            type: chartType,
            data: {
                labels: labels,
                datasets: [{
                    label: `Values of ${valueField}`,
                    data: values,
                    backgroundColor: 'rgba(54, 162, 235, 0.6)'
                }]
            }
        });

    } catch (err) {
        console.error("Error fetching chart data:", err);
    }
}
