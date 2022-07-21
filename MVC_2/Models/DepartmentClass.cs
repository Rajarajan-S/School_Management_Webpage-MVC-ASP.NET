using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_2.Models
{
    public class DepartmentClass
    {
        public int DepId { get; set; }
        public string Name { get; set; }
        public string CollegeName { get; set; }        
        public Programme Programme { get; set; }
        public int StudentCount { get; set; }
    }
    public enum Programme
    {
        Undergraduate,
        Postgraduate
    }
}