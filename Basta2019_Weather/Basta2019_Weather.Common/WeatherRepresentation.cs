namespace Basta2019_Weather.Common
{
    public class WeatherRepresentation //TODO: 2 different classes for this representation
    {
        public WeatherRepresentationKind WeatherRepresentationKind { get; set; }

        public byte[] Data { get; set; }
    }
}