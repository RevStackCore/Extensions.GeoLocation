using System;

namespace RevStackCore.Extensions.GeoLocation
{
    public class MapMarkerLocation : IAddressLocation
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Street { get; set; }
		public string AddressFormat { get; set; }
		public string RegionCode { get; set; }
		public string City { get; set; }
		public string ZipCode { get; set; }
		public string CountryCode { get; set; }
		public string Phone { get; set; }
		public string Url { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Label { get; set; }
    }
}
