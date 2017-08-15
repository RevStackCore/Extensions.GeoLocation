using System;
namespace RevStackCore.Extensions.GeoLocation
{
    public static partial class Extensions
    {
        public static double GetDistanceTo(this GeoCoordinate src, GeoCoordinate other)
        {
            return getDistanceTo(src, other, UnitDistance.Miles);
        }

        public static double GetDistanceTo(this GeoCoordinate src, GeoCoordinate other, UnitDistance unit)
		{
            return getDistanceTo(src, other, unit);
		}

        public static bool WithinRadialDistanceOf(this GeoCoordinate src, GeoCoordinate other, double radialDistance)
        {
            if(Math.Abs(other.Latitude) < .1 || Math.Abs(other.Latitude) < .1)
            {
                return false;
            }
            var distance=getDistanceTo(src, other, UnitDistance.Miles);
            return (distance <= radialDistance);
        }

        public static bool WithinRadialDistanceOf(this GeoCoordinate src, GeoCoordinate other, double radialDistance, UnitDistance unit)
		{
			var distance = getDistanceTo(src, other, unit);
            return (distance <= radialDistance);
		}

        public static MapMarkerLocation ToMapMarkerLocation(this GeoFenceMarker src)
        {
            return toMapMarkerLocation(src, null);
        }

		public static MapMarkerLocation ToMapMarkerLocation(this GeoFenceMarker src, string addressFormat)
		{
            return toMapMarkerLocation(src, addressFormat);
		}

        private static double getDistanceTo(GeoCoordinate src, GeoCoordinate other, UnitDistance unit)
        {
			var srcRad = Math.PI * src.Latitude / 180;
			var otherRad = Math.PI * other.Latitude / 180;
			var theta = src.Longitude - other.Longitude;
			var thetaRad = Math.PI * theta / 180;

			double dist =
				Math.Sin(srcRad) * Math.Sin(otherRad) + Math.Cos(srcRad) *
				Math.Cos(otherRad) * Math.Cos(thetaRad);
			dist = Math.Acos(dist);

			dist = dist * 180 / Math.PI;
			dist = dist * 60 * 1.1515;

            return dist.toUnitDistance(unit);
        }

        private static double toUnitDistance(this double src, UnitDistance unit)
        {
            if (unit == UnitDistance.Kilometers)
                return src * 1.609344;
            else if (unit == UnitDistance.Meters)
                return src * 1609.344;
            else return src;
        }

		private static MapMarkerLocation toMapMarkerLocation(this GeoFenceMarker src, string addressFormat)
		{

			var location = new MapMarkerLocation();
			location.Latitude = src.Coordinates.Latitude;
			location.Longitude = src.Coordinates.Longitude;
			location.City = src.City;
			location.AddressFormat = null;
			location.Name = src.Name;
			location.RegionCode = src.RegionCode;
			location.Street = src.Street;
			location.ZipCode = src.ZipCode;
			location.CountryCode = src.CountryCode;

			return location;
		}
    }
}
