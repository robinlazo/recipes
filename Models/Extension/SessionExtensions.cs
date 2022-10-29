using Newtonsoft.Json;
namespace WebRecipe.Models;

public static class SessionExtensions {
    public static void SetObject<T>(this ISession session, string key, T value) {
        string jsonvalue = JsonConvert.SerializeObject(value);
        session.SetString(key, jsonvalue);
    }

    public static T GetObject<T>(this ISession session, string key) {
        string jsonvalue = session.GetString(key);

        if(string.IsNullOrEmpty(jsonvalue)) {
            return default(T);
        } else {
            return JsonConvert.DeserializeObject<T>(jsonvalue);         
        }
    }
}