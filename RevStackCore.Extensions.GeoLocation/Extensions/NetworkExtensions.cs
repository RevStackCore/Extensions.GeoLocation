using System;
using System.Threading.Tasks;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Http;

namespace RevStackCore.Extensions.GeoLocation
{
    public static partial class Extensions
    {
		public async static Task<string> ToIpV4AddressAsync(this HttpRequest request)
        {
			var ipAddress =request.HttpContext.Connection.RemoteIpAddress;
			if (ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
			{
				var hostEntry = await Dns.GetHostEntryAsync(ipAddress);
				ipAddress = hostEntry.AddressList.First(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
			}
			return ipAddress.ToString();
        }

        public async static Task<string> ToIpV4AddressAsync(this string source)
		{
			if (source == null) return null;
			IPAddress ipAddress;
			IPAddress.TryParse(source, out ipAddress);
			if (ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
			{
                var hostEntry = await Dns.GetHostEntryAsync(ipAddress);
                ipAddress=hostEntry.AddressList.First(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
			}
			return ipAddress.ToString();
		}

		public static bool IsLocalIpAddress(this string ipAddress)
		{
            return IsLocalAddress(ipAddress);
		}

		public static bool IsLocalAddress(string ipAddress)
		{
            if(ipAddress=="0.0.0.1" || ipAddress=="0.0.0.0" || ipAddress=="127.0.0.1" || ipAddress=="localhost")
            {
                return true;
            }
           
            int[] ipParts = ipAddress.Split(new String[] { "." }, StringSplitOptions.RemoveEmptyEntries)
							 .Select(s => int.Parse(s)).ToArray();
			// in private ip range
			if (ipParts[0] == 10 ||
				(ipParts[0] == 192 && ipParts[1] == 168) ||
				(ipParts[0] == 172 && (ipParts[1] >= 16 && ipParts[1] <= 31)))
			{
				return true;
			}

			return false;
		}
    }
}
