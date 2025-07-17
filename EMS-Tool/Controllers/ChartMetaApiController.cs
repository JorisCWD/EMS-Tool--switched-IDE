using EMS_Tool.Data;
using EMS_Tool.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Controllers
{
    [Route("api/chart-meta")]
    public class ChartMetaApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly DashboardDataService _dashboardService;
        private readonly IConfiguration _configuration;

        public ChartMetaApiController(IConfiguration configuration, ApplicationDbContext context, DashboardDataService dashboardService)
        {
            _configuration = configuration;
            _context = context;
            _dashboardService = dashboardService;
        }

        [HttpGet("chart-meta")]
        public async Task<IActionResult> GetChartMeta(int chartId, int projectId)
        {
            var userProject = await _context.UserProjects
                .FirstOrDefaultAsync(p => p.Id == projectId);

            if (userProject == null)
                return NotFound($"Project with ID {projectId} not found.");

            var connectionString = userProject.ConnectionString;

            // Get the chart to extract the table name
            var chart = await _dashboardService.GetChartByIdAsync(connectionString, chartId);
            if (chart == null || string.IsNullOrEmpty(chart.DataQuery))
                return NotFound($"Chart with ID {chartId} not found or has no DataQuery.");

            // Try to extract table name from the DataQuery (simple example)
            var tableName = ExtractTableNameFromQuery(chart.DataQuery);
            if (string.IsNullOrEmpty(tableName))
                return BadRequest("Could not determine table name from DataQuery.");

            // Now query meta info based on the table name
            using var connection = new SqlConnection(connectionString);
            await connection.OpenAsync();

            var query = @"
        SELECT TOP 1 [Eenheid], [History_Omschrijving]
        FROM [Punten_extra_info]
        WHERE [History_tabel] = @Tabel
          AND [Eenheid] != 'Mbus koppeling'";

            using var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Tabel", tableName);

            using var reader = await command.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                var meta = new
                {
                    unit = reader["Eenheid"]?.ToString(),
                    label = reader["History_Omschrijving"]?.ToString()
                };

                return new JsonResult(new { meta });
            }

            return new JsonResult(new { meta = new { unit = "", label = "" } });
        }
        private string? ExtractTableNameFromQuery(string query)
        {
            try
            {
                var regex = new System.Text.RegularExpressions.Regex(@"FROM\s+\[?(?<table>\w+)\]?", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                var match = regex.Match(query);
                if (match.Success)
                {
                    return match.Groups["table"].Value;
                }
            }
            catch
            {
                // log if needed
            }

            return null;
        }



    }
}


