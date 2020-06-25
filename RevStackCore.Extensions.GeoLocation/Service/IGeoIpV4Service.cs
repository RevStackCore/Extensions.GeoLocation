using System.Threading.Tasks;

namespace RevStackCore.Extensions.GeoLocation
{
    public interface IGeoIpV4Service
    {
        Task<GeoCoordinate> GetAsync(string ipAddress);
    }
}
