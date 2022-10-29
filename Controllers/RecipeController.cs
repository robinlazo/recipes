using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebRecipe.Models;

namespace WebRecipe.Controllers;

public class RecipeController : Controller
{

    private Repository<Recipe> data { get; set; }
    private RecipeContext Context { get; set; }

    public RecipeController(RecipeContext context) {
        data = new Repository<Recipe>(context);
        Context = context;
    } 


    [HttpGet]
    public IActionResult Add() {
        ViewBag.Action = "Add";
        ViewBag.Categories = Context.Categories.ToList();
        return View("Edit", new AddViewModel());
    }

    [HttpPost]
    public IActionResult Add(AddViewModel recipe) {
        if(ModelState.IsValid) {
            Recipe recipeToAdd = new();
            recipe.Load(recipeToAdd);
            data.Insert(recipeToAdd);
            data.Save();
            TempData["message"] = $"{recipe.Name} has been addeds";
            return RedirectToAction("Index");
        } else {
            ViewBag.Action = "Add";
            ViewBag.Categories = Context.Categories.ToList();
            return View("Edit", recipe);
        }
    }

    public IActionResult Index()
    {
        return View(data.List(new QueryOptions<Recipe> {
            OrderBy = r => r.Name,
            Includes = "Category"
        }));
    }

    public IActionResult Details(int id) {

        var recipe = data.Get(new QueryOptions<Recipe>
        {
            Includes = "Category",
            Where = r => r.RecipeID == id
        });

        DetailsViewModel detailsData = new()
        {   
            ListSteps = recipe.Steps.Split("|"),
            Recipe = recipe,
        };

        return View(detailsData);
    }


}
