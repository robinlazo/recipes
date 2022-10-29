using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebRecipe.Models;

namespace WebRecipe.Controllers;


public class CategoryController : Controller {

    private Repository<Category> data { get; }
    public CategoryController(RecipeContext context) => data = new Repository<Category>(context);
    
    public IActionResult Index() {
        return View(data.List(new QueryOptions<Category>
        {
            OrderBy = c => c.Name, 
            Includes = "Recipes"
        }));
    }

    public IActionResult Details(string id) {
        return View(data.Get(new QueryOptions<Category> {
            Where = c => c.CategoryID == id, 
            Includes = "Recipes"
        }));
    }
}