using AppDevCW2.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevCW2.Controllers
{
    public class BillController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BillController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
