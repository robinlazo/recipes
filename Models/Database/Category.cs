namespace WebRecipe.Models;

public class Category {
    public string Name { get; set; }
    public string CategoryID { get; set; }

    public string Description { get; set; }

    public ICollection<Recipe> Recipes { get; set; }
}