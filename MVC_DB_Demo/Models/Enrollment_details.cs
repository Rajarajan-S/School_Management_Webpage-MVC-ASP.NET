//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_DB_Demo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Enrollment_details
    {
        [Required]
        [Display(Name = "Enrollment id")]
        public string eId { get; set; }

        [Required]
        [Display(Name ="Student name")]
        public Nullable<int> sID { get; set; }

        [Required]
        [Display(Name = "Course name")]
        public Nullable<int> CId { get; set; }

        [Required]
        [Display(Name = "Admission date")]
        public Nullable<System.DateTime> Adm { get; set; }
    
        public virtual Course_details Course_details { get; set; }
        public virtual Student_VMHSS Student_VMHSS { get; set; }
    }
}
