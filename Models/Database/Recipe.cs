using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace WebRecipe.Models;

public class Recipe {

    public int RecipeID { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Steps { get; set; }

    public int PreparationTime { get; set; }

    public int Rating { get; set; }

    public string FoodImage { get; set; }

    public string CategoryID { get; set; }
    public Category Category { get; set; }
}