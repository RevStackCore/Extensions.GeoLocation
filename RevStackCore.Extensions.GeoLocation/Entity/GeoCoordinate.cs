using System;

namespace RevStackCore.Extensions.GeoLocation
{
    public class GeoCoordinate
    {
        public double? Altitude { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double? Accuracy { get; set; }
        public double? AltitudeAccuracy { get; set; }
        public double? Heading { get; set; }

        public GeoCoordinate()
        {

        }
        public GeoCoordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

    }

    public class ExtendedGeoCoordinate : GeoCoordinate
    {
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public bool IsProxy { get; set; }
        public bool  IsBot { get; set; }
    }
}
