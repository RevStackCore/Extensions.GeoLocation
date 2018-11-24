using System;
namespace RevStackCore.Extensions.GeoLocation
{
    public static partial class Extensions
    {
		public static string ToGoogleMapLink(this IAddressLocation source)
		{
			return "http://maps.google.com/maps?saddr=&daddr=" + source.Street + "," + source.City + "," + source.RegionCode;

		}

		public static string ToGoogleAddress(this IAddressLocation source)
		{
            return source.Street + ", " + source.City + ", " + source.RegionCode + " " + source.ZipCode;
		}
    }
}
