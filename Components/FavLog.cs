using Microsoft.AspNetCore.Mvc;
using WebRecipe.Models;

namespace WebRecipe.Components;

public class FavLog : ViewComponent {
    private IFav FavInfo {get; set;}

    public FavLog(IFav fav) => FavInfo = fav;

    public IViewComponentResult Invoke() => View(FavInfo.Count);
    
}