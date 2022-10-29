namespace WebRecipe.Models;


public class Fav : IFav {

    private ISession Session {get;set;}

    private string CountKey = "keycountsession";
    private string ListKey = "listcountsession";

    private List<Recipe> FavoriteRecipes;

    public Fav(IHttpContextAccessor ctx) => Session = ctx.HttpContext.Session;

    public void Add(Recipe recipe) {
        Recipe recipeToAdd = GetById(recipe.RecipeID);
    
        if(recipeToAdd is null) {
            FavoriteRecipes.Add(recipe);
        }
    }

    public void Remove(Recipe recipe) => FavoriteRecipes.Remove(recipe);

    public Recipe GetById(int id) => FavoriteRecipes.FirstOrDefault(r => r.RecipeID == id);
    

    public void Clear() => FavoriteRecipes.Clear();

    public int Count => Session.GetInt32(CountKey) ?? 0;

    public void Save() {
        if(FavoriteRecipes.Count() == 0) {
            Session.Remove(ListKey);
            Session.Remove(CountKey);
        } else {
            Session.SetObject<List<Recipe>>(ListKey, FavoriteRecipes);
            Session.SetInt32(CountKey, FavoriteRecipes.Count());
        }
    }

    public void Load() {
        FavoriteRecipes = Session.GetObject<List<Recipe>>(ListKey);

        if(FavoriteRecipes is null) {
            FavoriteRecipes = new();
        }
    }

    public IEnumerable<Recipe> List => FavoriteRecipes;

}