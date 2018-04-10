using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudenEnrollment.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Technology Course { get; set; } // Why is Course name used in two places?
        public decimal GPA { get; set; }

        // Could pre-populate some data here

        public List<Student> BuildStudents()
        {
            return new List<Student>() {
                new Student() { Name = "Arthur Allen", Course = 0, GPA = (-4) }
            };
        }


    }
}
