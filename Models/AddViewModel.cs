using System.ComponentModel.DataAnnotations;
namespace WebRecipe.Models;

public class AddViewModel {

    [Required(ErrorMessage = "Please enter a Name")]
    [StringLength(50, ErrorMessage = "The Name must be a string with a max length of 50")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter a description")]
    [StringLength(400, ErrorMessage = "The description must be a string with a max length of 400")]
    public string Description { get; set; }


    [ArrayRequired(ErrorMessage = "Fill out every step input")]
    [ArrayRange(1, 10, ErrorMessage = "Number of steps must be between 1 and 10")]
    public string[] Steps { get; set; }

    [Required(ErrorMessage = "Please enter a time for preparation")]
    [Range(1, 600, ErrorMessage = "The preparation must be between 1 and 600 mins")]
    public int? PreparationTime { get; set; }

    [Required(ErrorMessage = "Please enter a rating")]
    [Range(1, 5, ErrorMessage = "The Range Must Be Between 1 and 5")]
    public int? Rating { get; set; }

    [Required(ErrorMessage = "Please enter a image")]
    public string FoodImage { get; set; }

    [Required(ErrorMessage = "Please enter a category")]
    public string CategoryID { get; set; }

    public void Load(Recipe recipe) {
        recipe.Name = Name;
        recipe.CategoryID = CategoryID;
        recipe.Description = Description;
        recipe.PreparationTime = PreparationTime ?? 10;
        recipe.Rating = Rating ?? 5;
        recipe.FoodImage = FoodImage;
        recipe.Steps = string.Join("|", Steps);
    }
}
