using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SqlHomework.Models;

namespace SqlHomework.Controllers
{
    public class CoursesController:Controller
    {
        private readonly DataContext _context;
        public CoursesController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Courses.ToList());
        }
        public IActionResult Details()
        {
            return View(_context.Detail.ToList());
        }
    }
}
