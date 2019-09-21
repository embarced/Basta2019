using System;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Basta2019_Weather.Common;
using Newtonsoft.Json;

namespace Basta2019_Watcher.Client.Common
{
    public class WeatherClient : IDisposable
    {
        System.Net.Http.HttpClient client;

        public WeatherClient(string uri)
        {
            client = new System.Net.Http.HttpClient();
            client.BaseAddress = new Uri(uri + "api/weather/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        // GET /weather/city
        public async Task<Weather> GetWeatherAsync(string city)
        {
            var resp2 = await client.GetAsync(city);

            if (resp2.IsSuccessStatusCode)
            {
                string content = await resp2.Content.ReadAsStringAsync();

                return GetWeatherFromJson(content);
            }
            else
            {
                throw new InvalidOperationException(string.Format("Invalid Request (Status Code: {0})", resp2.StatusCode)); // TODO add response message to exception
            }
        }

        private Weather GetWeatherFromJson(string json)
        {
            var weather = JsonConvert.DeserializeObject<Weather>(json);
            return weather;
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}
