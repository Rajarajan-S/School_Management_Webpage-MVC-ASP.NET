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
    using System.Data.Entity.Validation;

    public partial class Student_VMHSS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student_VMHSS()
        {
            this.Enrollment_details = new HashSet<Enrollment_details>();
        }    

        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter first name")]
        [RegularExpression("^[a-zA-Z ]+$",ErrorMessage ="Should contain only alphabets")]
        [Display(Name ="First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter last name")]
        [RegularExpression("^[a-zA-Z ]+$",ErrorMessage ="Should contain only alphabets")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter DOB")]
        [Display(Name = "DOB (MM/DD/YYYY)")]
        public Nullable<System.DateTime> DOB { get; set; }

        [Required(ErrorMessage = "Enter Gender")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Enter Phone number")]
        [RegularExpression("^[6-9][0-9]{9}",ErrorMessage = "Should contain 10 digits. Should start with 6/7/8/9")]
        [Display(Name = "Mobile number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Enter Address")]
        [Display(Name = "Address")]
        public string Address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enrollment_details> Enrollment_details { get; set; }
    }
}
