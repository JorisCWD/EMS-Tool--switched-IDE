using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace EMS_Tool.Areas.Identity.Data
{
    public class UserProject
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        public string ProjectNumber { get; set; }
        public string ConnectionString { get; set; }
    }

}
