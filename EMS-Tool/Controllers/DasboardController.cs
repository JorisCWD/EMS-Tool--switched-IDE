using EMS_Tool.Areas.Identity.Data;
using EMS_Tool.Data;
using EMS_Tool.Model;
using EMS_Tool.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace EMS_Tool.Controllers
{
    [Authorize(Roles = "Admin, User")]
    public class DashboardController : Controller
    {
        private readonly DashboardDataService _dashboardService;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public DashboardController(DashboardDataService dashboardService, ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _dashboardService = dashboardService;
            _context = context;
            _userManager = userManager;
        }

        private async Task<UserProject> GetUserLinkedProjectAsync(int projectId)
        {
            if (User.IsInRole("Admin"))
            {
                return await _context.UserProjects.FirstOrDefaultAsync(p => p.Id == projectId);
            }
            var userId = _userManager.GetUserId(User);
            return await _context.UserProjects
                .FirstOrDefaultAsync(p => p.Id == projectId && p.UserId == userId);
        }

        // Helper method to parse SQL queries to get table name, X column, Y column
        private (string TableName, string XColumn, string YColumn) ParseSqlQuery(string sql)
        {
            if (string.IsNullOrWhiteSpace(sql))
                return (null, null, null);

            string tableName = null;
            string xColumn = null;
            string yColumn = null;

            try
            {
                // Match FROM <tableName>
                var fromMatch = Regex.Match(sql, @"FROM\s+([^\s;]+)", RegexOptions.IgnoreCase);
                if (fromMatch.Success)
                    tableName = fromMatch.Groups[1].Value;

                // Match columns between SELECT and FROM
                var selectMatch = Regex.Match(sql, @"SELECT\s+(.*?)\s+FROM", RegexOptions.IgnoreCase);
                if (selectMatch.Success)
                {
                    var columnsPart = selectMatch.Groups[1].Value;
                    var columns = columnsPart.Split(',')
                                             .Select(c => c.Trim())
                                             .ToArray();

                    if (columns.Length >= 2)
                    {
                        xColumn = columns[0];
                        yColumn = columns[1];
                    }
                    else if (columns.Length == 1)
                    {
                        xColumn = columns[0];
                        yColumn = null;
                    }
                }
            }
            catch
            {
                // ignore parse errors
            }

            return (tableName, xColumn, yColumn);
        }

        // GET: /Dashboard/Details/{projectId}
        public async Task<IActionResult> Details(int projectId)
        {
            var userProject = await GetUserLinkedProjectAsync(projectId);
            if (userProject == null)
                return Forbid(); // or Unauthorized(), or redirect, depending on your UX needs

            var connectionString = userProject.ConnectionString;
            var tables = await _dashboardService.GetTablesAsync(connectionString);
            return View(tables);
        }

        public IActionResult TestError() => throw new Exception("Deliberate test exception");

        // GET: /Dashboard/Dashboard/{projectId}/{navId}
        [HttpGet]
        public async Task<IActionResult> Dashboard(int projectId, int navId)
        {
            var userProject = await GetUserLinkedProjectAsync(projectId);
            if (userProject == null)
                return Forbid();

            var connectionString = userProject.ConnectionString;

            var navbarItems = await _dashboardService.GetNavbarItemsAsync(connectionString);
            var tables = await _dashboardService.GetTablesAsync(connectionString);

            var navbar = navbarItems.FirstOrDefault(n => n.ID == navId) ?? new Navbar
            {
                Name = "Home",
                Sequence = 1
            };
            
            var charts = await _dashboardService.GetChartsAsync(connectionString, navId);
            
            // Parse SQL query for each chart to extract tableName, X and Y columns
            var tableNames = new Dictionary<int, string>();
            var xColumns = new Dictionary<int, string>();
            var yColumns = new Dictionary<int, string>();

            foreach (var chart in charts)
            {
                var (tableName, xCol, yCol) = ParseSqlQuery(chart.DataQuery);
                tableNames[chart.ID] = tableName ?? "";
                xColumns[chart.ID] = xCol ?? "";
                yColumns[chart.ID] = yCol ?? "";
            }

            ViewBag.Tables = tables;
            ViewBag.NavbarItems = navbarItems;
            ViewBag.Navbar = navbar;
            ViewBag.NavID = navId;
            ViewBag.ProjectId = projectId;

            ViewBag.TableNames = tableNames;
            ViewBag.XColumns = xColumns;
            ViewBag.YColumns = yColumns;

            return View(charts);
        }

        [HttpGet("/api/dashboard/columns")]
        public async Task<IActionResult> GetTableColumns(int projectId, string tableName)
        {
            var userProject = await GetUserLinkedProjectAsync(projectId);
            if (userProject == null)
                return Forbid(); // or Unauthorized(), or redirect, depending on your UX needs

            var connectionString = userProject.ConnectionString;
            var columns = await _dashboardService.GetColumnsAsync(connectionString, tableName);

            return Json(columns);
        }

        [HttpPost]
        public async Task<IActionResult> AddNavbar(int projectId, string name)
        {
            var userProject = await GetUserLinkedProjectAsync(projectId);
            if (userProject == null)
                return Forbid(); // or Unauthorized(), or redirect, depending on your UX needs

            var connectionString = userProject.ConnectionString;
            var newId = await _dashboardService.AddNavbarItemAsync(connectionString, name);

            return RedirectToAction("Dashboard", new { projectId, navId = newId });
        }

        [HttpPost]
        public async Task<IActionResult> AddChart(int projectId, Chart chart)
        {
            var userProject = await GetUserLinkedProjectAsync(projectId);
            if (userProject == null)
                return Forbid(); // or Unauthorized(), or redirect, depending on your UX needs
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
            var userProject = await GetUserLinkedProjectAsync(projectId);
            if(userProject == null)
                return Forbid(); // or Unauthorized(), or redirect, depending on your UX needs


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

        [HttpGet("/api/dashboard/chart-data")]
        public async Task<IActionResult> GetChartData(int projectId, int chartId)
        {
            var userProject = await GetUserLinkedProjectAsync(projectId);
            if (userProject == null)
                return Forbid(); // or Unauthorized(), or redirect, depending on your UX needs


            var connectionString = userProject.ConnectionString;

            var chart = await _dashboardService.GetChartByIdAsync(connectionString, chartId);
            if (chart == null)
                return NotFound("Chart not found.");

            var data = await _dashboardService.GetChartDataAsync(connectionString, chart.DataQuery);

            return Json(data);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteChart(int projectId, int chartId)
        {
            var userProject = await GetUserLinkedProjectAsync(projectId);
            if (userProject == null)
                return Forbid(); // or Unauthorized(), or redirect, depending on your UX needs


            var connectionString = userProject.ConnectionString;
            await _dashboardService.DeleteChartAsync(connectionString, chartId);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> EditChart(int projectId, int chartId)
        {
            var userProject = await GetUserLinkedProjectAsync(projectId);
            if (userProject == null)
                return Forbid(); // or Unauthorized(), or redirect, depending on your UX needs


            var connectionString = userProject.ConnectionString;
            var chart = await _dashboardService.GetChartByIdAsync(connectionString, chartId);

            if (chart == null)
                return NotFound("Chart not found.");

            var tables = await _dashboardService.GetTablesAsync(connectionString);
            var (tableName, xCol, yCol) = ParseSqlQuery(chart.DataQuery);
            var columns = !string.IsNullOrEmpty(tableName) ? await _dashboardService.GetColumnsAsync(connectionString, tableName) : new List<string>();

            var navbarItems = await _dashboardService.GetNavbarItemsAsync(connectionString);
            var navbar = navbarItems.FirstOrDefault(n => n.ID == chart.NavID) ?? new Navbar { Name = "Default", Sequence = 1 };

            ViewBag.Tables = tables;
            ViewBag.Columns = columns;
            ViewBag.NavbarItems = navbarItems;
            ViewBag.Navbar = navbar;
            ViewBag.TableName = tableName;
            ViewBag.XColumn = xCol;
            ViewBag.YColumn = yCol;
            ViewBag.ProjectId = projectId;

            return View(chart);
        }

        [HttpPost]
        public async Task<IActionResult> EditChart(int projectId, Chart chart)
        {
            var userProject = await GetUserLinkedProjectAsync(projectId);
            if (userProject == null)
                return Forbid(); // or Unauthorized(), or redirect, depending on your UX needs


            var connectionString = userProject.ConnectionString;
            await _dashboardService.UpdateChartAsync(connectionString, chart);

            return RedirectToAction("Dashboard", new { projectId, navId = chart.NavID });
        }
    }
}
