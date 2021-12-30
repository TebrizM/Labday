using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SqlHomework.Models;

namespace SqlHomework.Controllers
{
    public class PricingController : Controller
    {
        private readonly DataContext _context;
        public PricingController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Prices.ToList());
        }
        public IActionResult Details(int id)
        {
            var item = _context.Prices.ToList().Find(x => x.Id == id);
            if (item == null)
            {
                TempData["Error"] = "This Pricing's Information Does not Exist!";
                return RedirectToAction("Error");
            }
            return View(item);
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
