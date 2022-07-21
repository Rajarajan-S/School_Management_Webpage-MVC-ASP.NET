using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Template_HTML.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee Id")]
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public bool IsOnline { get; set; }
    }
}