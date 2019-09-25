namespace Basta2019_Weather.Common
{
    public class WeatherRepresentation //TODO: 2 representations of representation
    {
        public WeatherRepresentationKind WeatherRepresentationKind { get; set; }

        public byte[] Data { get; set; }
    }
}