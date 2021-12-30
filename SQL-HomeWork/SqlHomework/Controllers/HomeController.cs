using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SqlHomework.Models;
using SqlHomework.ViewModels;

namespace SqlHomework.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Courses = _context.Courses.ToList(),
                Features = _context.Features.ToList(),
                WhyUs = _context.WhyUs.ToList(),
                Trainers = _context.Trainers.ToList()

            };
            return View(homeVM);
        }
        public IActionResult About()
        {
            return View(_context.Testimonials.ToList());
        }
        public IActionResult Events()
        {
            return View(_context.Events.ToList());
        }
    }
}
