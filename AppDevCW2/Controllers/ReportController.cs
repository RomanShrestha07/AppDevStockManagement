using AppDevCW2.Data;
using AppDevCW2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevCW2.Controllers
{
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StockListReport(string search)
        {
            List<ItemStockViewModel> listData = new List<ItemStockViewModel>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT i.id as itemId, itemCode, itemName, quantity as itemQuantity from Item i inner join Stock s on i.id=s.itemId";

                _context.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    ItemStockViewModel data;
                    while (result.Read())
                    {
                        data = new ItemStockViewModel();
                        data.itemId = result.GetInt32(0);
                        data.itemCode = result.GetString(1);
                        data.itemName = result.GetString(2);
                        data.itemQuantity = result.GetInt32(3);
                        listData.Add(data);
                    }
                }
            }
            return View(listData.Where(x=>x.itemName == search));
        }
    }
}
