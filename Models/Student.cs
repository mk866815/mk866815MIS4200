using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mk866815MIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }

        //public string fullName { get { return lastName + ", " + firstName; } }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please Enter Student First Name")]
        [StringLength(40)]
        public  string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please Enter Stuednt Last Name")]
        [StringLength(40)]
        public  string lastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please Enter A Student Email")]
        [StringLength(50)]
        public  string email { get; set;  }

        [Display(Name = "Street Address")]
        [Required(ErrorMessage = "Please Enter Your street Address")]
        [StringLength(50)]
        public string address { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please Enter The city")]
        [StringLength(50)]
        public string city { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "Please Enter The State Abbreviation")]
        [StringLength(2)]
        public string state { get; set; }

        [Display(Name = "Zip Code")]
        [Required(ErrorMessage = "Please Enter Your 5 digit Zip Cd=ode")]
        [StringLength(5)]
        public string zipCode { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) | \d{3}-)\d{4}$",
            ErrorMessage = "Phone Number must be in the fomrat of (XXX)-XXX-XXXX or XXX-XXX-XXXX")]
 
        public string phoneNumber { get; set; }

        [Display(Name = "Year")]
        [Required(ErrorMessage = "Please Enter The Year The Student Is (ex: Freshmen)")]
        [StringLength(40)]
        public string studentGrade { get; set; }

        [Display (Name = "Student Name")]
       public string fullName { get { return lastName + ", " + firstName; } } 
        public ICollection<Grade> Grade { get; set; }
    }
}