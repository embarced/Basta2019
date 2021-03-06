﻿using System;
using Basta2019_Watcher.Client.Common;

namespace Basta2019_Weather.Client.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter city name to retrieve weather [Enter]! (just hit [Enter] to close)");

            string uri = "https://localhost:5001/";

            string inputCity;

            while (!string.IsNullOrEmpty(inputCity = System.Console.ReadLine()))
            { 
                using (WeatherClient client = new WeatherClient(uri))
                {
                    System.Console.WriteLine(client.GetWeatherAsync(inputCity).Result);

                    // use resilient version of API
                    //System.Console.WriteLine(client.GetWeatherResilientAsync(inputCity).Result);
                }
            }
        }
    }
}
