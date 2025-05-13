using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using EMS_Tool.Areas.Identity.Data;

namespace EMS_Tool.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<UserProject> UserProjects { get; set; } = new List<UserProject>();
    }
}

