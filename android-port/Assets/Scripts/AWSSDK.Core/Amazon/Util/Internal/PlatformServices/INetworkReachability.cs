using System;
using Il2CppDummyDll;

namespace Amazon.Util.Internal.PlatformServices
{
	[Token(Token = "0x2000091")]
	public interface INetworkReachability
	{
		[Token(Token = "0x17000150")]
		NetworkStatus NetworkStatus
		{
			[Token(Token = "0x600055D")]
			get;
		}

		[Token(Token = "0x14000002")]
		event EventHandler<NetworkStatusEventArgs> NetworkReachabilityChanged;
	}
}
