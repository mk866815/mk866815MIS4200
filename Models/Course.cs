using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mk866815MIS4200.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }

        [Display (Name = "Course Name")]
        [Required (ErrorMessage = "Please Enter A Course Name")]
        [StringLength (40)]
        public string courseName { get; set; }
        [Display(Name = "Course Size")]
        [Required(ErrorMessage = "Please Enter The Amount of Students In The Course")]
        public decimal courseSize { get; set; }
        [Display(Name = "Course Description")]
        [Required(ErrorMessage = "Please Enter A Course Description")]
        [StringLength(140)]
        public string courseDescription { get; set; }

        public ICollection<Grade> Grade { get; set; }
    }
}