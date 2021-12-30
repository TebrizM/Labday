using SqlHomework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlHomework.ViewModels
{
    public class HomeViewModel
    {
        public List<Courses> Courses { get; set; }
        public List<WhyUs> WhyUs { get; set; }
        public List<Features> Features { get; set; }
        public List<Trainers> Trainers { get; set; }
    }
}
