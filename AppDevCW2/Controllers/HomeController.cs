using AppDevCW2.Data;
using AppDevCW2.Models;
using AppDevCW2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevCW2.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
           //  _logger = logger;
        // }

        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<LowStockViewModel> listData = new List<LowStockViewModel>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT i.id as itemId, itemName, itemCode, st.quantity as itemQuantity from Item i join Stock st on i.id=st.itemId";

                _context.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    LowStockViewModel data;
                    while (result.Read())
                    {
                        data = new LowStockViewModel();
                        data.itemId = result.GetInt32(0);
                        data.itemName = result.GetString(1);
                        data.itemCode = result.GetString(2);
                        data.itemQuantity = result.GetInt32(3);
                        listData.Add(data);
                    }
                }
            }
            return View(listData.Where(x => x.itemQuantity < 10 && x.itemQuantity != 0));
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
