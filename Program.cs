using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api.chucknorris.io/jokes/random";
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(url).Result;
            string joke2 = JObject.Parse(response).GetValue("value").ToString();
            Console.WriteLine(joke2);
        }
    }
}