using System;
namespace Basta2019_Weather.Common
{
    public class Temperature
    {
        public TemperatureKind TemperatureKind { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Value, TemperatureKind);
        }
    }

    public enum TemperatureKind
    {
        Celsius,
        Fahrendheit
    }


}
