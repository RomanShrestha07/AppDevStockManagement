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
    public class PurchaseDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PurchaseDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PurchaseDetails
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PurchaseDetail.Include(p => p.item).Include(p => p.purchase);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PurchaseDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseDetail = await _context.PurchaseDetail
                .Include(p => p.item)
                .Include(p => p.purchase)
                .FirstOrDefaultAsync(m => m.id == id);
            if (purchaseDetail == null)
            {
                return NotFound();
            }

            return View(purchaseDetail);
        }

        // GET: PurchaseDetails/Create
        public IActionResult Create()
        {
            ViewData["itemId"] = new SelectList(_context.Item, "id", "itemCode");
            ViewData["purchaseId"] = new SelectList(_context.Purchase, "id", "id");
            return View();
        }

        // POST: PurchaseDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PurchaseDetail purchaseDetail)
        {
            if (ModelState.IsValid)
            {
                purchaseDetail.totalAmount = purchaseDetail.quantity * purchaseDetail.unitPrice;
                _context.Add(purchaseDetail);
                await _context.SaveChangesAsync();
                int stockQuantity = 0;
                try
                {
                    stockQuantity = _context.Stock.Where(x => x.itemId == purchaseDetail.itemId).Select(u => u.quantity).First();
                }
                catch
                {
                    stockQuantity = 0;
                }

                int qty = stockQuantity + purchaseDetail.quantity;
                using (var command = _context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = "UPDATE Stock SET quantity=" + qty + "WHERE itemId=" + purchaseDetail.itemId;
                    _context.Database.OpenConnection();
                    using (var result = command.ExecuteReader()) { }
                }

                return RedirectToAction(nameof(Index));
            }
            ViewData["itemId"] = new SelectList(_context.Item, "id", "itemCode", purchaseDetail.itemId);
            ViewData["purchaseId"] = new SelectList(_context.Purchase, "id", "id", purchaseDetail.purchaseId);
            return View(purchaseDetail);
        }

        // GET: PurchaseDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseDetail = await _context.PurchaseDetail.FindAsync(id);
            if (purchaseDetail == null)
            {
                return NotFound();
            }
            ViewData["itemId"] = new SelectList(_context.Item, "id", "itemCode", purchaseDetail.itemId);
            ViewData["purchaseId"] = new SelectList(_context.Purchase, "id", "id", purchaseDetail.purchaseId);
            return View(purchaseDetail);
        }

        // POST: PurchaseDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,quantity,unitPrice,totalAmount,purchaseId,itemId")] PurchaseDetail purchaseDetail)
        {
            if (id != purchaseDetail.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchaseDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseDetailExists(purchaseDetail.id))
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
            ViewData["itemId"] = new SelectList(_context.Item, "id", "itemCode", purchaseDetail.itemId);
            ViewData["purchaseId"] = new SelectList(_context.Purchase, "id", "id", purchaseDetail.purchaseId);
            return View(purchaseDetail);
        }

        // GET: PurchaseDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchaseDetail = await _context.PurchaseDetail
                .Include(p => p.item)
                .Include(p => p.purchase)
                .FirstOrDefaultAsync(m => m.id == id);
            if (purchaseDetail == null)
            {
                return NotFound();
            }

            return View(purchaseDetail);
        }

        // POST: PurchaseDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purchaseDetail = await _context.PurchaseDetail.FindAsync(id);
            _context.PurchaseDetail.Remove(purchaseDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchaseDetailExists(int id)
        {
            return _context.PurchaseDetail.Any(e => e.id == id);
        }
    }
}
