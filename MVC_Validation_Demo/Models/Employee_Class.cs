using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;

namespace MVC_Validation_Demo.Models
{
    public class Employee_Class 
    {
        [Required(ErrorMessage ="Enter employee id")]
        [DisplayName("Employee ID")]

        public int EmpId { get; set; }

        [Required(ErrorMessage = "Enter employee name")]
        [MinLength(5, ErrorMessage = "Name should contain only alphabets with minimum count of 5")]
        [DisplayName("Name")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Enter employee email id")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}",ErrorMessage ="Invalid email id")]
        [DisplayName("Email")]
        public string EmpEmail { get; set; }

        [Required(ErrorMessage = "Enter employee salary")]
        [Range(10000,60000, ErrorMessage = "Salary should be between 10000 to 60000")]
        [DisplayName("Salary")]
        public int EmpSal { get; set; }

        [CustomEmployeeClass(ErrorMessage = "CG must be present in your referral code")]
        [DisplayName("Referral Code")]
        public string RefCode { get; set; }

    }
}