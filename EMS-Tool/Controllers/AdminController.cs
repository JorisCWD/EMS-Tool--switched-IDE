using EMS_Tool.Areas.Identity.Data;
using EMS_Tool.Data;
using EMS_Tool.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly ApplicationDbContext _context;

    public AdminController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext context)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _context = context;
    }

    // Existing method to list users and their roles
    public async Task<IActionResult> Index()
    {
        var users = _userManager.Users.ToList();
        var model = new List<UserRolesViewModel>();

        foreach (var user in users)
        {
            var roles = await _userManager.GetRolesAsync(user);
            model.Add(new UserRolesViewModel
            {
                UserId = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                Roles = roles.ToList()
            });
        }

        return View(model);
    }

    // Existing method to assign roles to users
    [HttpPost]
    public async Task<IActionResult> AssignRole(string userId, string role)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null) return NotFound();

        if (!await _roleManager.RoleExistsAsync(role))
            await _roleManager.CreateAsync(new IdentityRole(role));

        var result = await _userManager.AddToRoleAsync(user, role);
        if (result.Succeeded)
            return RedirectToAction("Index");

        ModelState.AddModelError("", "Failed to assign role.");
        return View("Index", _userManager.Users.ToList());
    }

    // Existing method to remove roles from users
    [HttpPost]
    public async Task<IActionResult> RemoveRole(string userId, string role)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null) return NotFound();

        if (!await _userManager.IsInRoleAsync(user, role))
            return BadRequest("User is not in that role.");

        var result = await _userManager.RemoveFromRoleAsync(user, role);
        if (result.Succeeded)
            return RedirectToAction("Index");

        ModelState.AddModelError("", "Failed to remove role.");
        return RedirectToAction("Index");
    }

    // New method to display all users for managing projects
    public async Task<IActionResult> ManageUsers()
    {
        var users = await _userManager.Users.ToListAsync();
        return View(users);
    }

    // New method to show details of a user's assigned projects
    public async Task<IActionResult> UserDetails(string userId)
    {
        var user = await _userManager.Users
            .Where(u => u.Id == userId)
            .Select(u => new UserProjectViewModel
            {
                UserId = u.Id,
                Email = u.Email,
                AssignedProjects = u.UserProjects.ToList(),
            })
            .FirstOrDefaultAsync();

        if (user == null)
        {
            return NotFound();
        }

        user.NewProjects = new List<ProjectInputModel> { new ProjectInputModel() };
        return View(user);
    }

    [HttpGet]
    public async Task<IActionResult> AssignProjects(string userId)
    {
        if (string.IsNullOrEmpty(userId))
        {
            return NotFound();
        }

        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            return NotFound();
        }

        var model = new UserProjectViewModel
        {
            UserId = userId,
            Email = user.Email,
            AssignedProjects = await _context.UserProjects.Where(up => up.UserId == userId).ToListAsync()
        };

        return View(model);
    }

    // New method to assign new projects to users
    [HttpPost]
    public async Task<IActionResult> AssignProject(UserProjectViewModel model)
    {
        Console.WriteLine("POST AssignProject hit");
        Console.WriteLine($"UserId: {model.UserId}");

        if (!ModelState.IsValid)
        {
            Console.WriteLine("ModelState is invalid.");
            foreach (var error in ModelState)
            {
                foreach (var subError in error.Value.Errors)
                {
                    Console.WriteLine($"Error in '{error.Key}': {subError.ErrorMessage}");
                }
            }

            return View("UserDetails", model); // optional: re-fetch assigned projects if needed
        }

        if (ModelState.IsValid)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            Console.WriteLine($"POST AssignProject: UserId = {model.UserId}, NewProjects.Count = {model.NewProjects?.Count}");

            if (user != null && model.NewProjects != null)
            {
                foreach (var project in model.NewProjects)
                {
                    if (!string.IsNullOrWhiteSpace(project.ProjectNumber) &&
                        !string.IsNullOrWhiteSpace(project.ConnectionString))
                    {
                        var userProject = new UserProject
                        {
                            UserId = user.Id,
                            ProjectNumber = project.ProjectNumber,
                            ConnectionString = project.ConnectionString
                        };

                        _context.UserProjects.Add(userProject);
                    }
                }

                // ✅ Save all at once after loop
                await _context.SaveChangesAsync();

                // ✅ Redirect after successful insert
                return RedirectToAction(nameof(UserDetails), new { userId = model.UserId });
            }
        }

        // ❌ Something went wrong, redisplay form
        return View(nameof(UserDetails), model);
    }


    // New method to edit a user's project
    public async Task<IActionResult> EditProject(int projectId)
    {
        var project = await _context.UserProjects.FindAsync(projectId);
        if (project == null)
        {
            return NotFound();
        }

        var model = new ProjectInputModel
        {
            ProjectNumber = project.ProjectNumber,
            ConnectionString = project.ConnectionString
        };

        return View(model);
    }

    // New method to update the project after editing
    [HttpPost]
    public async Task<IActionResult> UpdateProject(int projectId, ProjectInputModel model)
    {
        if (ModelState.IsValid)
        {
            var project = await _context.UserProjects.FindAsync(projectId);
            if (project != null)
            {
                project.ProjectNumber = model.ProjectNumber;
                project.ConnectionString = model.ConnectionString;

                _context.UserProjects.Update(project);
                await _context.SaveChangesAsync();
                return RedirectToAction("UserDetails", new { userId = project.UserId });
            }
        }

        return View(model);
    }

    // New method to delete a project
    public async Task<IActionResult> DeleteProject(int projectId)
    {
        var project = await _context.UserProjects.FindAsync(projectId);
        if (project == null)
        {
            return NotFound();
        }

        return View(project);
    }

    // New method to confirm project deletion
    [HttpPost, ActionName("DeleteProject")]
    public async Task<IActionResult> DeleteConfirmed(int projectId)
    {
        var project = await _context.UserProjects.FindAsync(projectId);
        if (project != null)
        {
            _context.UserProjects.Remove(project);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction("UserDetails", new { userId = project.UserId });
    }
}
