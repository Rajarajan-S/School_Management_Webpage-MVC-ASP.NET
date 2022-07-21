using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_2.Models
{
    public class EmployeeClass
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public Degree Degree { get; set; }
        public string City { get; set; }
        public bool IsEmployee { get; set; }
        public int Salary { get; set; }      
    }
    public enum Degree
    {
        BE,
        BTech,
        ME,
        MTech
    }
}