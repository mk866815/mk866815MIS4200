using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mk866815MIS4200.Models
{
    public class Grade
    {
        [Key]
        public int gradeID { get; set; }

        [Display(Name = "Course Grade")]
        [Required(ErrorMessage = "Please Enter A Grade For This Course")]
        [StringLength(2)]
        public  string courseGrade { get; set; }
        [Display(Name = "Date of Grade")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> gradeDate { get; set; }

        public int studentID { get; set; }
        public virtual Student Student { get; set; }

        public int courseID { get; set; }
        public virtual Course Course { get; set; }

        
       


    }
}