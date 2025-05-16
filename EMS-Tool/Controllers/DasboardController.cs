using EMS_Tool.Areas.Identity.Data;
using EMS_Tool.Data;
using EMS_Tool.Model;
using EMS_Tool.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Controllers
{
    [Authorize(Roles = "Admin, User")]
    public class DashboardController : Controller
    {
        private readonly DashboardDataService _dashboardService;
        private readonly ApplicationDbContext _context;

        public DashboardController(DashboardDataService dashboardService, ApplicationDbContext context)
        {
            _dashboardService = dashboardService;
            _context = context;
        }

        // GET: /Dashboard/Details/{projectId}
        public async Task<IActionResult> Details(int projectId)
        {
            var userProject = await _context.UserProjects.FirstOrDefaultAsync(p => p.Id == projectId);
            if (userProject == null)
                return NotFound("Project not found.");

            var connectionString = userProject.ConnectionString;
            var tables = await _dashboardService.GetTablesAsync(connectionString);
            return View(tables);
        }

        public IActionResult TestError() => throw new Exception("Deliberate test exception");

        // GET: /Dashboard/Dashboard/{projectId}/{navId}
        [HttpGet]
        public async Task<IActionResult> Dashboard(int projectId, int navId)
        {
            var userProject = await _context.UserProjects.FirstOrDefaultAsync(p => p.Id == projectId);
            if (userProject == null)
                return NotFound("Project not found.");

            var connectionString = userProject.ConnectionString;
            var navbarItems = await _dashboardService.GetNavbarItemsAsync(connectionString);

            var navbar = navbarItems.FirstOrDefault(n => n.ID == navId) ?? new Navbar
            {
                Name = "Default Navbar",
                Sequence = 1
            };

            var charts = await _dashboardService.GetChartsAsync(connectionString, navId);
            if (charts == null || !charts.Any())
            {
                charts = new List<Chart>
                {
                    new Chart
                    {
                        PositionX = 0,
                        PositionY = 0,
                        Width = 400,
                        Height = 300,
                        ChartTitle = "Default Chart",
                        ChartType = "bar",
                        NavID = navId
                    }
                };
            }
            ViewBag.NavbarItems = navbarItems;
            ViewBag.Navbar = navbar;
            ViewBag.NavID = navId;
            ViewBag.ProjectId = projectId;

            return View(charts);
        }

        [HttpPost]
        public async Task<IActionResult> AddNavbar(int projectId, string name)
        {
            var userProject = await _context.UserProjects.FirstOrDefaultAsync(p => p.Id == projectId);
            if (userProject == null)
                return NotFound("Project not found.");

            var connectionString = userProject.ConnectionString;
            var newId = await _dashboardService.AddNavbarItemAsync(connectionString, name);

            return RedirectToAction("Dashboard", new { projectId, navId = newId });
        }

        [HttpPost]
        public async Task<IActionResult> AddChart(int projectId, Chart chart)
        {
            var userProject = await _context.UserProjects.FirstOrDefaultAsync(p => p.Id == projectId);
            if (userProject == null)
                return NotFound("Project not found.");

            var connectionString = userProject.ConnectionString;

            chart.PositionX = chart.PositionX == 0 ? 0 : chart.PositionX;
            chart.PositionY = chart.PositionY == 0 ? 0 : chart.PositionY;
            chart.Width = chart.Width == 0 ? 400 : chart.Width;
            chart.Height = chart.Height == 0 ? 300 : chart.Height;

            await _dashboardService.AddChartAsync(connectionString, chart);

            return RedirectToAction("Dashboard", new { projectId, navId = chart.NavID });
        }

        [HttpPost]
        public async Task<IActionResult> UpdateChartPosition(int projectId, [FromBody] ChartPositionUpdate update)
        {
            var userProject = await _context.UserProjects.FirstOrDefaultAsync(p => p.Id == projectId);
            if (userProject == null)
                return NotFound("Project not found.");

            var connectionString = userProject.ConnectionString;

            await _dashboardService.UpdateChartPositionAsync(connectionString, update.ChartId, update.X, update.Y, update.Width, update.Height);
            return Ok();
        }

        public class ChartPositionUpdate
        {
            public int ChartId { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }
    }
}
