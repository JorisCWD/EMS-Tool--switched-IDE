using EMS_Tool.Areas.Identity.Data;
using EMS_Tool.Data;
using EMS_Tool.Model;
using EMS_Tool.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EMS_Tool.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChartDataController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly DashboardDataService _dashboardService;

        public ChartDataController(ApplicationDbContext context, DashboardDataService dashboardService)
        {
            _context = context;
            _dashboardService = dashboardService;
        }

        // GET api/chartdata/{projectId}/{chartId}
        [HttpGet("{projectId:int}/{chartId:int}")]
        public async Task<IActionResult> GetChartData(int projectId, int chartId)
        {
            // Fetch UserProject by Id (projectId)
            var userProject = await _context.UserProjects
                .FirstOrDefaultAsync(p => p.Id == projectId);

            if (userProject == null)
                return NotFound($"Project with ID {projectId} not found.");

            var connectionString = userProject.ConnectionString;

            // Get Chart by Id from database using raw SQL or your service
            var chart = await _dashboardService.GetChartByIdAsync(connectionString, chartId);

            if (chart == null)
                return NotFound($"Chart with ID {chartId} not found.");

            var data = await _dashboardService.GetChartDataAsync(connectionString, chart.DataQuery);

            return Ok(new
            {
                type = chart.ChartType,
                data = data
            });
        }
    }
}
