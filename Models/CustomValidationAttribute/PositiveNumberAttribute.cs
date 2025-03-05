using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sds_technical_exam.Models.CustomValidationAttribute
{
    public class PositiveNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && value is double doubleValue)
            {
                if (doubleValue <= 0.0)
                {
                    return new ValidationResult(ErrorMessage ?? "Value cannot be less than or equal zero.");
                }
            }
            return ValidationResult.Success;
        }
    }
}