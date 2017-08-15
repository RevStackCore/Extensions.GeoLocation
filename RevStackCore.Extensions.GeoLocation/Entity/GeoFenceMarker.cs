using System;
using RevStackCore.Pattern;

namespace RevStackCore.Extensions.GeoLocation
{
    public class GeoFenceMarker: GeoLocationMarker, IEntity<string>
    {
        public double Radius { get; set; }
        public UnitDistance RadiusUnit { get; set; }

        public GeoFenceMarker() : base()
        {
            RadiusUnit = UnitDistance.Miles;
        }

		public GeoFenceMarker(string id) : base(id)
		{
			RadiusUnit = UnitDistance.Miles;
		}

        public GeoFenceMarker(UnitDistance unit)
		{
            Id = Guid.NewGuid().ToString();
            RadiusUnit = unit;
		}

		public GeoFenceMarker(string id,UnitDistance unit)
		{
            Id = id;
			RadiusUnit = unit;
		}

    }

    public class GeoFenceMarkerDescription
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Radius { get; set; }
    }
}
