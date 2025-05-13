using EMS_Tool.Areas.Identity.Data;
using EMS_Tool.Data;
using EMS_Tool.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace EMS_Tool.Controllers
{
    [Authorize]
    public class DynamicProjectController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _userContext;

        public DynamicProjectController(UserManager<ApplicationUser> userManager, ApplicationDbContext userContext)
        {
            _userManager = userManager;
            _userContext = userContext;
        }

        public async Task<IActionResult> Index(string projectNumber)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null || string.IsNullOrEmpty(projectNumber))
                return Unauthorized();

            var project = _userContext.UserProjects
                .FirstOrDefault(p => p.UserId == user.Id && p.ProjectNumber == projectNumber);

            if (project == null)
                return Unauthorized("Access to this project is not allowed.");

            string sql = "SELECT TOP 100 * FROM SomeTable"; // ⚠️ You can replace this or make it dynamic
            var data = await QueryDynamicDatabase(project.ConnectionString, sql);

            ViewBag.ProjectNumber = projectNumber;
            return View(data); // A view that expects List<Dictionary<string, object>>
        }

        private async Task<List<Dictionary<string, object>>> QueryDynamicDatabase(string connectionString, string sql)
        {
            var results = new List<Dictionary<string, object>>();

            using (var conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();

                using (var cmd = new SqlCommand(sql, conn))
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var row = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[reader.GetName(i)] = reader.IsDBNull(i) ? null : reader.GetValue(i);
                        }
                        results.Add(row);
                    }
                }
            }

            return results;
        }
    }
}
