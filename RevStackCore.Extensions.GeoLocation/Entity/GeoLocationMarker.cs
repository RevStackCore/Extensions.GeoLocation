using System;
using RevStackCore.Pattern;

namespace RevStackCore.Extensions.GeoLocation
{
    public class GeoLocationMarker : IEntity<string>
    {
        public string Id { get; set; }
        public string AppId { get; set; }
        public string IdentifierId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string RegionCode { get; set; }
        public string ZipCode { get; set; }
        public string CountryCode { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public GeoCoordinate Coordinates { get; set; }

        public GeoLocationMarker()
        {
            Id = Guid.NewGuid().ToString();
        }

        public GeoLocationMarker(string id)
        {
            Id = id;
        }

    }
}