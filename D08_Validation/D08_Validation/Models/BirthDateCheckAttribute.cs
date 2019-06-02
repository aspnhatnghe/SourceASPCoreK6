using System;
using System.ComponentModel.DataAnnotations;

namespace D08_Validation.Models
{
    public class BirthDateCheckAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime data = (DateTime) value;
            return data < DateTime.Now;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime data = (DateTime)value;
            if(data < DateTime.Now)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Không thể sinh trong tương lai");
        }        
    }
}