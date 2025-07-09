using EMS_Tool.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

public class ProjectNameViewComponent : ViewComponent
{
    private readonly ApplicationDbContext _context;

    public ProjectNameViewComponent(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        // Try to get projectId from route or query string
        var routeValues = ViewContext.RouteData.Values;
        int? projectId = null;

        if (routeValues.TryGetValue("projectId", out var routeValue))
        {
            int.TryParse(routeValue?.ToString(), out int id);
            projectId = id;
        }
        else if (HttpContext.Request.Query.TryGetValue("projectId", out var queryValue))
        {
            int.TryParse(queryValue.ToString(), out int id);
            projectId = id;
        }

        if (projectId.HasValue)
        {
            var project = await _context.UserProjects.FindAsync(projectId.Value);
            if (project != null)
            {
                return View("Default", project.ProjectNumber);
            }
        }

        return View("Default", "Onbekend project");
    }
}
