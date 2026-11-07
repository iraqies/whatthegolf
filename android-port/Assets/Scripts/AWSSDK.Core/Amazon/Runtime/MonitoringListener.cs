using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
	internal sealed class MonitoringListener : IDisposable
	{
		private static readonly MonitoringListener csmMonitoringListenerInstance;

		private readonly string _host;

		private readonly UdpClient _udpClient;

		private readonly Logger logger;

		private readonly int _port;

		private bool _disposed;

		public static MonitoringListener Instance => null;

		private MonitoringListener()
		{
		}

		static MonitoringListener()
		{
		}

		public void PostMessagesOverUDP(string response)
		{
		}

		public Task PostMessagesOverUDPAsync(string response)
		{
			return null;
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}
	}
}
