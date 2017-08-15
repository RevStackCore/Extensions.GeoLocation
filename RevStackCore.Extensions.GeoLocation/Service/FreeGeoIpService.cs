using System.Threading.Tasks;
using Json = RevStackCore.Extensions.Serialization.SnakeCase.Json;
using RevStackCore.Net;

namespace RevStackCore.Extensions.GeoLocation
{
    public class FreeGeoIpService : IGeoIpV4Service
    {
        private string FREE_GEO_IP_JSON_URL = "http://freegeoip.net/json/";
        public async Task<GeoCoordinate> GetAsync(string ipAddress)
        {
            string url = FREE_GEO_IP_JSON_URL + ipAddress;
            string result = await Http.GetJsonAsync(url);
            var geoResult = Json.DeserializeObject<FreeGeoIpResult>(result);
            return new GeoCoordinate(geoResult.Latitude, geoResult.Longitude);
        }
    }

    internal class FreeGeoIpResult
    {
        public string Ip { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string TimeZone { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string MetroCode { get; set; }
    }
}
