// See https://aka.ms/new-console-template for more information

using System.Net.Http;
using Newtonsoft.Json.Linq;

var client = new HttpClient();
var ronQuoteUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

var ronResponse = client.GetStringAsync(ronQuoteUrl).Result;
//Console.WriteLine(ronResponse);
var ronQuote = JArray.Parse(ronResponse);
var quote = ronQuote[0].ToString();

Console.WriteLine("Fortunes must be earned: through deep, insightful pondering we discover true meaning. Therefore we give you a relevant quote to study...Take from it what you will.");
Console.WriteLine();
Console.WriteLine(quote);