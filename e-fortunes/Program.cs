// See https://aka.ms/new-console-template for more information

using System.Net.Http;
using e_fortunes;
using Newtonsoft.Json.Linq;

var mainMenu = 0;
var client = new HttpClient();
Console.WriteLine("Please pick a category");
Console.WriteLine("1: Decipher your fortune.");
Console.WriteLine("2: Receive a chuckle.");

while(!int.TryParse(Console.ReadLine(), out mainMenu) || mainMenu < 1 || mainMenu > 2)
{
    Console.WriteLine("Please choose a number from our Options..."); 
}

if (mainMenu == 1)
{
    Console.WriteLine("Fortunes must be earned: through deep, insightful pondering we discover true meaning. Therefore we give you a relevant quote to study...Take from it what you will.");
    Console.WriteLine();
    Console.WriteLine(RonSwanson.RonSwansonJoke(client));
}

else
{
    Console.WriteLine(ChuckNorris.ChuckNorrisJoke(client));
}

