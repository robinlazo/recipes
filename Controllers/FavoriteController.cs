using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebRecipe.Models;

namespace WebRecipe.Controllers;


public class FavoriteController : Controller {

    private Repository<Recipe> data { get; set; }
    private IFav FavSession { get; }
    public FavoriteController(RecipeContext ctx, IFav fav) {
        data = new(ctx);
        FavSession = fav;
    } 

    private IFav GetFav() {
        FavSession.Load();
        return FavSession;
    }
    
    public IActionResult Index() {
        IFav FavSession = GetFav();
        return View(FavSession.List);
    }

    [HttpPost]
    public IActionResult Add(int id) {
        IFav FavSession = GetFav();

        Recipe recipeToAdd = data.Get(id);
        
        if(recipeToAdd is null) {
            TempData["message"] = "Recipe couldn't be added";
        } else {
            FavSession.Add(recipeToAdd);
            TempData["message"] = $"{recipeToAdd.Name} is in your favorite list";     
            FavSession.Save();     
        }

        return RedirectToAction("Index", "Recipe");
    }


    [HttpPost]
    public IActionResult Remove(int id) {
        IFav FavSession = GetFav();

        Recipe recipeToDelete = FavSession.GetById(id);

        FavSession.Remove(recipeToDelete);

        FavSession.Save();

        TempData["message"] = $"{recipeToDelete.Name} was removed";

        return RedirectToAction("Index", "Recipe");
    }
}