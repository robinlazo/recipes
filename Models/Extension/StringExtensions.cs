namespace WebRecipe.Models;

public static class StringExtensions {
    public static string Slug(this string value) => value.Replace(" ", "-");
    public static string TrimDescription(this string description) => description.Length <= 40 ? description : description.Substring(0, 40) + "...";
}