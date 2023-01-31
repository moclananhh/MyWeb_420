using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRN_Project.Extensions;
using PRN_Project.Models;
using PRN_Project.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRN_Project.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly SWP_DB_FinalContext _context;
        public INotyfService _notyfService { get; }
        public CheckoutController(SWP_DB_FinalContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }
        public List<CartItem> GioHang
        {
            get
            {
                var gh = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (gh == default(List<CartItem>))
                {
                    gh = new List<CartItem>();
                }
                return gh;
            }
        }
        public IActionResult Index()
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
            var taikhoanID = HttpContext.Session.GetInt32("id");
            Bill bill = new Bill();
            Detail detail = new Detail();
            bill.IdAccount = taikhoanID;
            //bill.IdAccount = taikhoanID;
            if (ModelState.IsValid)
            {
                
                bill.Total = Convert.ToInt32(cart.Sum(x => x.TotalMoney));
                bill.Date = DateTime.Now;
                _context.Add(bill);
                _context.SaveChanges();
                foreach (var item in cart)
                {
                    detail.BillId = bill.BillId;
                    detail.IdProduct = item.product.Id;
                    detail.ProductName = item.product.Name;
                    detail.Amount = item.amount;
                    detail.Price = item.product.Price;
                    _context.Add(detail);
                    _context.SaveChanges();
                }
                _context.SaveChanges();
            }
                
                HttpContext.Session.Remove("GioHang");
            return RedirectToAction("Index", "Home");
        }
    }
}
