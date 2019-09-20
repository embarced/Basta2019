using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Basta2019_Weather.Common;
using Microsoft.AspNetCore.Mvc;

namespace Basta2019_WeatherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private static string apiKey = "197da5e10fb1ebbb22f1959434f629b8";

        private OpenWeatherMap.OpenWeatherMapClient openWeatherClient = new OpenWeatherMap.OpenWeatherMapClient(apiKey);

        // GET api/weather
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "weather1", "weather2" };
        }

        // GET api/weather/london
        [HttpGet("{city}")]
        public ActionResult<Weather> Get(string city)
        {
            Console.WriteLine("Call Get; city:" + city);

            Weather result = GetWeatherAsync(city).Result;

            return result;

            //return new Weather() {CountryCode=null, City=city, Temperature=null };
        }

        private async Task<Weather> GetWeatherAsync(string city)
        {
            //TODO Polly - catch (OpenWeatherMapException owme)
            var currentWeather = await openWeatherClient.CurrentWeather.GetByName(city, OpenWeatherMap.MetricSystem.Metric);

            Console.WriteLine(currentWeather.Weather.Value);

            return new Weather()
            {
                City = city,
                Temperature = new Temperature(currentWeather.Temperature.Value),
                Value = currentWeather.Weather.Value
            };
        }
    }
}
