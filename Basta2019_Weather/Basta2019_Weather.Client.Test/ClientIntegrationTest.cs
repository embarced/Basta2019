using Basta2019_Watcher.Client.Common;
using Basta2019_Weather.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Basta2019_Weather.Client.Test
{
    [TestClass]
    public class ClientIntegrationTest
    {
        string uri = "https://localhost:5001/";

        [TestMethod]
        public void TestGetWeatherLondon()
        {
            using (WeatherClient client = new WeatherClient(uri))
            {
                string city = "London";
                Weather result = client.GetWeatherAsync(city).Result;

                Assert.AreEqual(city, result.City);
            }
        }
    }
}
