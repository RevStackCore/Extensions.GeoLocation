using System;
using System.Collections.Generic;

namespace RevStackCore.Extensions.GeoLocation
{
    public class MapData
    {
		public string ApiKey { get; set; }
		public string Message { get; set; }
		public double Distance { get; set; }
		public string DistanceLabel { get; set; }
		public IEnumerable<MapMarkerLocation> Locations { get; set; }
		public string ZipCode { get; set; }
		public double Longitude { get; set; }
		public double Latitude { get; set; }
    }
}
