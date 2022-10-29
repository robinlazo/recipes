using System.ComponentModel.DataAnnotations;
namespace WebRecipe.Models;

public class ArrayRangeAttribute : ValidationAttribute {
    private int MinLength;
    private int MaxLength;
    public ArrayRangeAttribute(int min, int max) {
        MinLength = min;
        MaxLength = max;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
        string[] array = value as string[];

        if(array != null && array.Length >= MinLength && array.Length <= MaxLength) return ValidationResult.Success;

        string msg = base.ErrorMessage ??
                $"the range for ${validationContext.DisplayName} must be between ${MinLength} and {MaxLength}";
        
        return new ValidationResult(msg);
    }
}