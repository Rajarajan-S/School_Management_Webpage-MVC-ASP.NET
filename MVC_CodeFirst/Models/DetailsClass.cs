using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CodeFirst.Models
{
    public class DetailsClass
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Enter the name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter the city")]
        public string City { get; set; }
        [Required(ErrorMessage = "Enter the email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter the phone number")]
        //[RegularExpression(@"^[6 - 9][0 - 9]{9}$", ErrorMessage = "Enter proper phone number with 10 digits and should start with 6 or 7 or 8 or 9")]
        public long Phone { get; set; }
    }
}