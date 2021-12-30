using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlHomework.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<WhyUs> WhyUs { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Trainers> Trainers { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<CourseDetail> Detail { get; set; }
        public DbSet<Pricing> Prices { get; set; }
    }
}
