using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mk866815MIS4200.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string courseName { get; set; }
        public decimal courseSize { get; set; }
        public string courseDescription { get; set; }

        public ICollection<Grade> Grade { get; set; }
    }
}