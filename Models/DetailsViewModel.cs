namespace WebRecipe.Models;

public class DetailsViewModel {
    public string[] ListSteps { get; set; }

    public Recipe Recipe { get; set; }

    public string ToHours(int minutes) {
        int hour = minutes / 60;
        int min = minutes % 60;

        string result = "";

        if(hour > 0 && min > 0) result += $"{hour} h : {min} m";
        else result += hour > 0 ? $"{hour} h" : $"{min} m";

        return result;
    }
}