using AppDevCW2.Data;
using AppDevCW2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevCW2.Controllers
{
    public class SaleMixController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SaleMixController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PasswordChnage()
        {
            return View();
        }

        public async Task<IActionResult> Create([Bind("id,billNum,saleDate,customerId")] Sale sale, List<SaleDetail> ListSaleDetail)
        {
            sale.saleDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                _context.Add(sale);
                await _context.SaveChangesAsync();
                
                foreach (SaleDetail element in ListSaleDetail)
                {
                    element.itemId = sale.id;
                    element.totalAmount = element.quantity * element.unitPrice;

                    _context.Add(element);
                    await _context.SaveChangesAsync();

                    int itemCount = _context.Stock.Where(x => x.itemId == element.itemId).Select(y => y.quantity).First();
                    int qty = itemCount - element.quantity;
                    using (var command = _context.Database.GetDbConnection().CreateCommand())
                    {
                        command.CommandText = "UPDATE Stock SET quantity=" + qty + " WHERE itemId = " + element.itemId;
                        _context.Database.OpenConnection();
                        using (var result = command.ExecuteReader()) { }
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["customerId"] = new SelectList(_context.Customer, "id", "customerName", sale.customerId);
            return View(sale);
        }
    }
}
