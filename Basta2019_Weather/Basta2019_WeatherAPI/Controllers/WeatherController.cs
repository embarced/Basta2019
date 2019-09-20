using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basta2019_Weather.Common;
using Microsoft.AspNetCore.Mvc;

namespace Basta2019_WeatherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
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
            return new Weather() {CountryCode=null, City=city, Temperature=null };
        }

        // GET api/weather/DE/Mainz
        [HttpGet("{countrycode}/{city}")]
        public ActionResult<Weather> Get(string countrycode, string city)
        {
            return new Weather() { CountryCode = countrycode, City = city, Temperature = null };
        }
    }
}
