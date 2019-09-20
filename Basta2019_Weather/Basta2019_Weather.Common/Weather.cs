using System;

namespace Basta2019_Weather.Common
{
    public class Weather
    {
        public string City { get; set; }

        public Temperature Temperature { get; set; }

        public string Value { get; set; }

        public override string ToString()
        {
            return string.Format("{0}; Temperature: {1}", City, Temperature);
        }
    }
}
