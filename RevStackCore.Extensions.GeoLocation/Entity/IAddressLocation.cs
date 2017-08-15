using System;
namespace RevStackCore.Extensions.GeoLocation
{
    public interface IAddressLocation
    {
		string Street { get; set; }
		string RegionCode { get; set; }
		string City { get; set; }
		string ZipCode { get; set; }
    }
}
