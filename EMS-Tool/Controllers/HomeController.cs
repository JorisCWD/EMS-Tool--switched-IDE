using System.Diagnostics;
using EMS_Tool.Areas.Identity.Data;
using EMS_Tool.Data;
using EMS_Tool.Migrations;
using EMS_Tool.Model;
using EMS_Tool.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Construction;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _logger = logger;
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index(string userId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
                return RedirectToAction("Login", "Account");

            List<Areas.Identity.Data.UserProject> assignedProjects;

            if (User.IsInRole("Admin"))
            {
                // Admin: Get all projects
                assignedProjects = await _context.UserProjects.ToListAsync();

                assignedProjects = assignedProjects
                    .DistinctBy(p => p.ProjectNumber)
                    .ToList();
            }
            else
            {
                // Regular user: Only see their own projects
                assignedProjects = await _context.UserProjects
                    .Where(up => up.UserId == user.Id)
                    .ToListAsync();
            }

            var model = new UserProjectViewModel
            {
                UserId = user.Id,
                Email = user.Email,
                AssignedProjects = assignedProjects
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
