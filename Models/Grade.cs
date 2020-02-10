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
        public  string courseGrade { get; set; }

        public DateTime gradeDate { get; set; }

        public int studentID { get; set; }
        public virtual Student Student { get; set; }

        public int courseID { get; set; }
        public virtual Course Course { get; set; }

        
       


    }
}