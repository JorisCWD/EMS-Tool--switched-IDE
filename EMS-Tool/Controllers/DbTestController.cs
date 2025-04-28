using System.Diagnostics;
using EMS_Tool.Data;
using EMS_Tool.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EMS_Tool.Controllers
{
    public class DbTestController : Controller
    {
        private readonly TchP0994106Context _context;

        public DbTestController(TchP0994106Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var info = await _context.Puntens.ToListAsync();
            return View(info);
        }

    }
}
