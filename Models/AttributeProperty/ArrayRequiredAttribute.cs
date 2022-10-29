using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace WebRecipe.Models;
public class ArrayRequiredAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext context)
    {
        string[] array = value as string[];

        if (array == null || array.Any(inf => string.IsNullOrEmpty(inf)))
        {
            string msg = base.ErrorMessage ?? "You must fill out all the inputs";
            return new ValidationResult(msg);
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}