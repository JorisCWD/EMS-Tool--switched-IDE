using EMS_Tool.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EMS_Tool.Services
{
    public class DashboardDataService
    {
        private readonly IConfiguration _configuration;

        public DashboardDataService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<string>> GetTablesAsync(string connectionString)
        {
            var tables = new List<string>();
            using var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            var command = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", connection);
            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                tables.Add(reader.GetString(0));
            }
            return tables;
        }

        public async Task<List<Navbar>> GetNavbarItemsAsync(string connectionString)
        {
            var navbars = new List<Navbar>();
            var query = "SELECT * FROM Navbar ORDER BY Sequence";

            using var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            using var command = new SqlCommand(query, connection);
            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                navbars.Add(new Navbar
                {
                    ID = reader.GetInt32(reader.GetOrdinal("ID")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Sequence = reader.GetInt32(reader.GetOrdinal("Sequence"))
                });
            }

            return navbars;
        }

        public async Task<int> AddNavbarItemAsync(string connectionString, string name)
        {
            var query = "INSERT INTO Navbar (Name, Sequence) OUTPUT INSERTED.ID VALUES (@Name, (SELECT ISNULL(MAX(Sequence), 0) + 1 FROM Navbar))";

            using var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);
            var insertedId = (int)await command.ExecuteScalarAsync();

            return insertedId;
        }

        public async Task<List<Chart>> GetChartsAsync(string connectionString, int navId)
        {
            var charts = new List<Chart>();
            var query = "SELECT * FROM Chart WHERE NavID = @NavID";

            using var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NavID", navId);

            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                charts.Add(new Chart
                {
                    ID = reader.GetInt32(reader.GetOrdinal("ID")),
                    NavID = reader.GetInt32(reader.GetOrdinal("NavID")),
                    ChartTitle = reader.GetString(reader.GetOrdinal("ChartTitle")),
                    ChartType = reader.GetString(reader.GetOrdinal("ChartType")),
                    DataQuery = reader.GetString(reader.GetOrdinal("DataQuery")),
                    PositionX = reader.GetInt32(reader.GetOrdinal("PositionX")),
                    PositionY = reader.GetInt32(reader.GetOrdinal("PositionY")),
                    Width = reader.GetInt32(reader.GetOrdinal("Width")),
                    Height = reader.GetInt32(reader.GetOrdinal("Height"))
                });
            }

            return charts;
        }

        public async Task AddChartAsync(string connectionString, Chart chart)
        {
            var query = @"
                INSERT INTO Chart (NavID, ChartTitle, ChartType, DataQuery, PositionX, PositionY, Width, Height)
                VALUES (@NavID, @ChartTitle, @ChartType, @DataQuery, @PositionX, @PositionY, @Width, @Height)";

            using var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NavID", chart.NavID);
            command.Parameters.AddWithValue("@ChartTitle", chart.ChartTitle);
            command.Parameters.AddWithValue("@ChartType", chart.ChartType);
            command.Parameters.AddWithValue("@DataQuery", chart.DataQuery);
            command.Parameters.AddWithValue("@PositionX", chart.PositionX);
            command.Parameters.AddWithValue("@PositionY", chart.PositionY);
            command.Parameters.AddWithValue("@Width", chart.Width);
            command.Parameters.AddWithValue("@Height", chart.Height);

            await command.ExecuteNonQueryAsync();
        }

        public async Task UpdateChartPositionAsync(string connectionString, int chartId, int x, int y, int width, int height)
        {
            var query = @"
                UPDATE Chart
                SET PositionX = @X, PositionY = @Y, Width = @Width, Height = @Height
                WHERE ID = @ChartId";

            using var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ChartId", chartId);
            command.Parameters.AddWithValue("@X", x);
            command.Parameters.AddWithValue("@Y", y);
            command.Parameters.AddWithValue("@Width", width);
            command.Parameters.AddWithValue("@Height", height);

            await command.ExecuteNonQueryAsync();
        }

        public async Task<List<Dictionary<string, object>>> GetChartDataAsync(string connectionString, string dataQuery)
        {
            var result = new List<Dictionary<string, object>>();

            using var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            using var command = new SqlCommand(dataQuery, connection);
            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                var row = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                    row[reader.GetName(i)] = reader.GetValue(i);

                result.Add(row);
            }

            return result;
        }
        public async Task<Chart?> GetChartByIdAsync(string connectionString, int chartId)
        {
            const string query = "SELECT * FROM Chart WHERE ID = @ChartId";

            using var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ChartId", chartId);

            using var reader = await command.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new Chart
                {
                    ID = reader.GetInt32(reader.GetOrdinal("ID")),
                    NavID = reader.GetInt32(reader.GetOrdinal("NavID")),
                    ChartTitle = reader.GetString(reader.GetOrdinal("ChartTitle")),
                    ChartType = reader.GetString(reader.GetOrdinal("ChartType")),
                    DataQuery = reader.GetString(reader.GetOrdinal("DataQuery")),
                    PositionX = reader.GetInt32(reader.GetOrdinal("PositionX")),
                    PositionY = reader.GetInt32(reader.GetOrdinal("PositionY")),
                    Width = reader.GetInt32(reader.GetOrdinal("Width")),
                    Height = reader.GetInt32(reader.GetOrdinal("Height"))
                };
            }

            return null;
        }

    }
}
