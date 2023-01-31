using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRN_Project.Models;

namespace PRN_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StatisticController : Controller
    {
        private readonly SWP_DB_FinalContext _context;

        public StatisticController(SWP_DB_FinalContext context)
        {
            _context = context;
        }

        // GET: Statistic
        public ActionResult Index()
        {
            return View();
        }

        // GET: Statistic/Details/5
        public async Task<IActionResult> ThongKe(DateTime startDate, DateTime endDate)
        {
            string startDate1 = startDate.ToString();
            string endDate1 = endDate.ToString();
            var orders = await _context.Bills.ToListAsync();
            HttpContext.Session.SetString("StartDate", startDate1);
            HttpContext.Session.SetString("EndDate", endDate1);

            return View(orders);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bill = await _context.Bills
                .Include(b => b.IdAccountNavigation)
                .FirstOrDefaultAsync(m => m.BillId == id);
            if (bill == null)
            {
                return NotFound();
            }

            var chitietbill = _context.Details
              .AsNoTracking()
              .Where(x => x.BillId == bill.BillId)
              .OrderBy(x => x.BillId).ToList();
            ViewBag.ChiTiet = chitietbill;

            return View(bill);
        }
    }
}
