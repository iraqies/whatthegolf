using System.Collections.Generic;
using System.Threading.Tasks;
using ThirdParty.Json.LitJson;

namespace Amazon.Runtime.Internal
{
	public static class CSMUtilities
	{
		private const string requestKey = "Request";

		public static Task SerializetoJsonAndPostOverUDPAsync(MonitoringAPICall monitoringAPICall)
		{
			return null;
		}

		public static void SerializetoJsonAndPostOverUDP(MonitoringAPICall monitoringAPICall)
		{
		}

		public static string GetApiNameFromRequest(string requestName, IDictionary<string, string> serviceApiNameMapping, string serviceName)
		{
			return null;
		}

		private static bool CreateUDPMessage(MonitoringAPICallAttempt monitoringAPICallAttempt, out string response)
		{
			response = null;
			return false;
		}

		private static bool CreateUDPMessage(MonitoringAPICallEvent monitoringAPICallEvent, out string response)
		{
			response = null;
			return false;
		}

		private static JsonWriter CreateUDPMessage(MonitoringAPICall monitoringAPICall, JsonWriter jw)
		{
			return null;
		}
	}
}
