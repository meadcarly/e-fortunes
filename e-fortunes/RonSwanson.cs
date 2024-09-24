using Newtonsoft.Json.Linq;

namespace e_fortunes;

public class RonSwanson
{
    public static string RonSwansonJoke(HttpClient client)
    {
        var ronQuoteUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

        var ronResponse = client.GetStringAsync(ronQuoteUrl).Result;

        var ronQuote = JArray.Parse(ronResponse);
        var quote = ronQuote[0].ToString();
        return quote;
    }
}