using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Validation_Demo
{
    public class CustomEmployeeClass : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string nm = value.ToString();

                if (nm.Contains("CG"))
                {
                    return ValidationResult.Success;
                }
                else
                {
                    ErrorMessage = ErrorMessage ?? "Must contain CG";
                    //ErrorMessage = "Must contain CG";
                    return new ValidationResult(ErrorMessage);
                }
            }
            else
            {
                ErrorMessage = ErrorMessage ?? "Enter Referral code";
                // ErrorMessage = "Enter Referral code";
                return new ValidationResult(ErrorMessage);
            }
        }

    }
}