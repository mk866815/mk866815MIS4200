using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mk866815MIS4200.Models
{
    public class Grade
    {
        public int gradeID { get; set; }
        public  string grade { get; set; }

        public DateTime gradeDate { get; set; }

        public int studentID { get; set; }
        public virtual Student Student { get; set; }


    }
}