using System;

namespace Amazon.Util.Internal.PlatformServices
{
	public class NetworkReachability : INetworkReachability
	{
		public NetworkStatus NetworkStatus => NetworkStatus.NotReachable;

		public event EventHandler<NetworkStatusEventArgs> NetworkReachabilityChanged
		{
			add
			{
			}
			remove
			{
			}
		}
	}
}
