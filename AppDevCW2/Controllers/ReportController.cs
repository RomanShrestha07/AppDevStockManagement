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
                command.CommandText = "SELECT i.id as itemId, itemCode, itemName, quantity as itemQuantity, c.categoryName as itemCategory from Item i inner join Stock s on i.id=s.itemId join Category c on c.id=i.categoryId";

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
                        data.itemCategory = result.GetString(4);
                        listData.Add(data);
                    }
                }
            }
            var a = listData.Where(x => x.itemQuantity > 0);
            if (search != null)
            {
                return View(listData.Where(x => x.itemName == search && x.itemQuantity > 0));
            }
            else
            {
                return View(listData.Where(x => x.itemQuantity > 0));
            }
        }

        public IActionResult SaleCustomerReport(string search)
        {
            List<SaleCustomerViewModel> listData = new List<SaleCustomerViewModel>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT c.id as customerId, customerName, saleDate, sd.quantity as saleQuantity, sd.unitPrice, totalAmount, itemName from Customer c join Sale s on c.id=s.customerId join SaleDetail sd on sd.saleId=s.id join Item i on sd.itemId=i.id";

                _context.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    SaleCustomerViewModel data;
                    while (result.Read())
                    {
                        data = new SaleCustomerViewModel();
                        data.customerId = result.GetInt32(0);
                        data.customerName = result.GetString(1);
                        data.saleDate = result.GetDateTime(2);
                        data.saleQuantity = result.GetInt32(3);
                        data.unitPrice = result.GetInt32(4);
                        data.totalAmount = result.GetInt32(5);
                        data.itemName = result.GetString(6);
                        listData.Add(data);
                    }
                }
            }
            DateTime dateNow = DateTime.Now;
            TimeSpan aMonth = new TimeSpan(31, 0, 0, 0);
            DateTime monthBefore = dateNow.Subtract(aMonth);
            return View(listData.Where(x=>x.customerName == search && x.saleDate > monthBefore));
        }

        public IActionResult LowStockReport()
        {
            List<LowStockViewModel> listData = new List<LowStockViewModel>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT i.id as itemId, itemName, itemCode, st.quantity as itemQuantity, c.categoryName as itemCategory from Item i join Stock st on i.id=st.itemId join Category c on c.id=i.categoryId";

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
                        data.itemCatgeory = result.GetString(4);
                        listData.Add(data);
                    }
                }
            }
            return View(listData.Where(x => x.itemQuantity < 10 && x.itemQuantity != 0));
        }

        public IActionResult OutOfStockReport(string option)
        {
            List<OutOfStockViewModel> listData = new List<OutOfStockViewModel>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT i.id as itemId, itemName, itemCode, st.quantity as itemQuantity, purchaseDate as stockedDate, c.categoryName as itemCategory from Item i join Stock st on i.id=st.itemId join PurchaseDetail pd on i.id=pd.itemId join Purchase p on pd.purchaseId=p.id join Category c on i.categoryId=c.id";

                _context.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    OutOfStockViewModel data;
                    while (result.Read())
                    {
                        data = new OutOfStockViewModel();
                        data.itemId = result.GetInt32(0);
                        data.itemName = result.GetString(1);
                        data.itemCode = result.GetString(2);
                        data.itemQuantity = result.GetInt32(3);
                        data.stockedDate = result.GetDateTime(4);
                        data.itemCategory = result.GetString(5);
                        listData.Add(data);
                    }
                }
            }
            if (option == "Date")
            {
                var d = listData.Where(x => x.itemQuantity == 0);
                return View(d.OrderByDescending(x => x.stockedDate));
            }
            else if (option == "Name")
            {
                var a = listData.Where(x => x.itemQuantity == 0);
                return View(a.OrderBy(x => x.itemName));
            }
            else
            {
                return View(listData.Where(x=>x.itemQuantity == 0));
            }           
        }

        public IActionResult NotBoughtReport()
        {
            List<NotBoughtViewModel> listData = new List<NotBoughtViewModel>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT c.id as customerId, customerName, customerEmail, MAX(saleDate) as lastSaleDate from Customer c join Sale s on c.id=s.customerId group by customerName, c.id, customerEmail";

                _context.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    NotBoughtViewModel data;
                    while (result.Read())
                    {
                        data = new NotBoughtViewModel();
                        data.customerId = result.GetInt32(0);
                        data.customerName = result.GetString(1);
                        data.customerEmail = result.GetString(2);
                        data.lastSaleDate = result.GetDateTime(3);
                        listData.Add(data);
                    }
                }
            }
            DateTime dateNow = DateTime.Now;
            TimeSpan aMonth = new TimeSpan(31, 0, 0, 0);
            DateTime monthBefore = dateNow.Subtract(aMonth);
            return View(listData.Where(x => x.lastSaleDate < monthBefore ));
        }

        public IActionResult NotSoldReport()
        {
            List<NotSoldViewModel> listData = new List<NotSoldViewModel>();
            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT i.id as itemId, itemName, itemCode, MAX(st.quantity) as itemQuantity, MAX(sa.saleDate) as lastSaleDate from Item i join Stock st on i.id=st.itemId join SaleDetail sd on i.id=sd.itemId join Sale sa on sa.id=sd.saleId group by i.id, itemName, itemCode";

                _context.Database.OpenConnection();
                using (var result = command.ExecuteReader())
                {
                    NotSoldViewModel data;
                    while (result.Read())
                    {
                        data = new NotSoldViewModel();
                        data.itemId = result.GetInt32(0);
                        data.itemName = result.GetString(1);
                        data.itemCode = result.GetString(2);
                        data.itemQuantity = result.GetInt32(3);
                        data.lastSaleDate = result.GetDateTime(4);
                        listData.Add(data);
                    }
                }
            }
            DateTime dateNow = DateTime.Now;
            TimeSpan aMonth = new TimeSpan(31, 0, 0, 0);
            DateTime monthBefore = dateNow.Subtract(aMonth);
            return View(listData.Where(x => x.lastSaleDate < monthBefore));
        }
    }
}
