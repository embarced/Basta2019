using System;

namespace Basta2019_Weather.Common
{
    public class Weather
    {
        public string CountryCode { get; set; }
        public string City { get; set; }

        public Temperature Temperature { get; set; }

        public override string ToString()
        {
            return string.Format("{0}:{1}; Temperature: {2}", CountryCode, City, Temperature);
        }
    }
}
