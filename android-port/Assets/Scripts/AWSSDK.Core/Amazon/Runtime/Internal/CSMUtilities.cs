using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using ThirdParty.Json.LitJson;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x20001AD")]
	public static class CSMUtilities
	{
		[Token(Token = "0x400067E")]
		private const string requestKey = "Request";

		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x11DAFC8", Offset = "0x11DAFC8", VA = "0x11DAFC8")]
		public static Task SerializetoJsonAndPostOverUDPAsync(MonitoringAPICall monitoringAPICall)
		{
			return null;
		}

		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x11D85E4", Offset = "0x11D85E4", VA = "0x11D85E4")]
		public static void SerializetoJsonAndPostOverUDP(MonitoringAPICall monitoringAPICall)
		{
		}

		[Token(Token = "0x6000D53")]
		[Address(RVA = "0x11D87A4", Offset = "0x11D87A4", VA = "0x11D87A4")]
		public static string GetApiNameFromRequest(string requestName, IDictionary<string, string> serviceApiNameMapping, string serviceName)
		{
			return null;
		}

		[Token(Token = "0x6000D54")]
		[Address(RVA = "0x11DB214", Offset = "0x11DB214", VA = "0x11DB214")]
		private static bool CreateUDPMessage(MonitoringAPICallAttempt monitoringAPICallAttempt, out string response)
		{
			return default;
		}

		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x11DB644", Offset = "0x11DB644", VA = "0x11DB644")]
		private static bool CreateUDPMessage(MonitoringAPICallEvent monitoringAPICallEvent, out string response)
		{
			return default;
		}

		[Token(Token = "0x6000D56")]
		[Address(RVA = "0x11DB94C", Offset = "0x11DB94C", VA = "0x11DB94C")]
		private static JsonWriter CreateUDPMessage(MonitoringAPICall monitoringAPICall, JsonWriter jw)
		{
			return null;
		}
	}
}
