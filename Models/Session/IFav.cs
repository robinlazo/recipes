namespace WebRecipe.Models;


public interface IFav
{
    int Count { get; }
    void Add(Recipe recipe);
    void Remove(Recipe recipe);
    void Clear();
    void Save();

    IEnumerable<Recipe> List { get; }
    void Load();

    Recipe GetById(int id);
}