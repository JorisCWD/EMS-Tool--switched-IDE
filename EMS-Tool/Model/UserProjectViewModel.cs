using EMS_Tool.Areas.Identity.Data;
namespace EMS_Tool.Model
{
    public class UserProjectViewModel
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public List<UserProject> AssignedProjects { get; set; } = new();
        public List<ProjectInputModel> NewProjects { get; set; } = new() { new ProjectInputModel() };
    }

    

    public class ProjectInputModel
    {
        public string ProjectNumber { get; set; }
        public string ConnectionString { get; set; }
    }


}
