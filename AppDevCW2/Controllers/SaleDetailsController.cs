using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppDevCW2.Data;
using AppDevCW2.Models;

namespace AppDevCW2.Controllers
{
    public class SaleDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SaleDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SaleDetails
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SaleDetail.Include(s => s.item).Include(s => s.sale);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SaleDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleDetail = await _context.SaleDetail
                .Include(s => s.item)
                .Include(s => s.sale)
                .FirstOrDefaultAsync(m => m.id == id);
            if (saleDetail == null)
            {
                return NotFound();
            }

            return View(saleDetail);
        }

        // GET: SaleDetails/Create
        public IActionResult Create()
        {
            ViewData["itemId"] = new SelectList(_context.Item, "id", "itemCode");
            ViewData["saleId"] = new SelectList(_context.Sale, "id", "id");
            return View();
        }

        // POST: SaleDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SaleDetail saleDetail)
        {
            if (ModelState.IsValid)
            {
                saleDetail.totalAmount = saleDetail.quantity * saleDetail.unitPrice;
                
                _context.Add(saleDetail);
                await _context.SaveChangesAsync();

                int stockQuantity = _context.Stock.Where(x => x.itemId == saleDetail.itemId).Select(u => u.quantity).First();
                int qty = stockQuantity - saleDetail.quantity;
                using (var command = _context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = "UPDATE Stock SET quantity=" + qty + "WHERE itemId=" + saleDetail.itemId;
                    _context.Database.OpenConnection();
                    using (var result = command.ExecuteReader()) { }
                }

                return RedirectToAction(nameof(Index));
            }
            ViewData["itemId"] = new SelectList(_context.Item, "id", "itemCode", saleDetail.itemId);
            ViewData["saleId"] = new SelectList(_context.Sale, "id", "id", saleDetail.saleId);
            return View(saleDetail);
        }

        // GET: SaleDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleDetail = await _context.SaleDetail.FindAsync(id);
            if (saleDetail == null)
            {
                return NotFound();
            }
            ViewData["itemId"] = new SelectList(_context.Item, "id", "itemCode", saleDetail.itemId);
            ViewData["saleId"] = new SelectList(_context.Sale, "id", "id", saleDetail.saleId);
            return View(saleDetail);
        }

        // POST: SaleDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,quantity,unitPrice,totalAmount,saleId,itemId")] SaleDetail saleDetail)
        {
            if (id != saleDetail.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(saleDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SaleDetailExists(saleDetail.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["itemId"] = new SelectList(_context.Item, "id", "itemCode", saleDetail.itemId);
            ViewData["saleId"] = new SelectList(_context.Sale, "id", "id", saleDetail.saleId);
            return View(saleDetail);
        }

        // GET: SaleDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleDetail = await _context.SaleDetail
                .Include(s => s.item)
                .Include(s => s.sale)
                .FirstOrDefaultAsync(m => m.id == id);
            if (saleDetail == null)
            {
                return NotFound();
            }

            return View(saleDetail);
        }

        // POST: SaleDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var saleDetail = await _context.SaleDetail.FindAsync(id);
            _context.SaleDetail.Remove(saleDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SaleDetailExists(int id)
        {
            return _context.SaleDetail.Any(e => e.id == id);
        }
    }
}
