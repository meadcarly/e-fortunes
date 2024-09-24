using Newtonsoft.Json.Linq;

namespace e_fortunes;

public class ChuckNorris
{
    
    public static string ChuckNorrisJoke(HttpClient client)
    {
        var chuckNorrisUrl = "https://api.chucknorris.io/jokes/random";

        var chuckResponse = client.GetStringAsync(chuckNorrisUrl).Result;

        return JObject.Parse(chuckResponse)["value"].ToString();
    }
    
}