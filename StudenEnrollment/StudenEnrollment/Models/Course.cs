using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Class 13 Demo Code:
namespace StudenEnrollment.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Technology Technology { get; set; }
        public int LengthInWeeks { get; set; }
    }

    public enum Technology
    {
        DotNet,
        JavaScript,
        Java,
        Python
    }
}
