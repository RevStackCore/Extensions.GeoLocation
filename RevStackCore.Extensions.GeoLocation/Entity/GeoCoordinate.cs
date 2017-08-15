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

        public GeoCoordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

    }
}
