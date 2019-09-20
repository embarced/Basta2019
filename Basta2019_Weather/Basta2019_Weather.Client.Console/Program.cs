using System;
using Basta2019_Watcher.Client.Common;

namespace Basta2019_Weather.Client.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            string uri = "https://localhost:5001/";

            using (WeatherClient client = new WeatherClient(uri)) {
                System.Console.WriteLine(client.GetWeatherAsync("London").Result);
             }
        }
    }
}
