using Microsoft.EntityFrameworkCore;
using StudenEnrollment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudenEnrollment.Data
{
    public class StudentsDbContext : DbContext
    {

        public StudentsDbContext(DbContextOptions<StudentsDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

    }

}
