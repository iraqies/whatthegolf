using System;
using Il2CppDummyDll;

namespace Amazon.Util.Internal.PlatformServices
{
	[Token(Token = "0x2000097")]
	public class NetworkReachability : INetworkReachability
	{
		[Token(Token = "0x1700015D")]
		public NetworkStatus NetworkStatus
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x1243154", Offset = "0x1243154", VA = "0x1243154", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000003")]
		public event EventHandler<NetworkStatusEventArgs> NetworkReachabilityChanged
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x12431A8", Offset = "0x12431A8", VA = "0x12431A8", Slot = "5")]
			add
			{
			}
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x12431FC", Offset = "0x12431FC", VA = "0x12431FC", Slot = "6")]
			remove
			{
			}
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1243250", Offset = "0x1243250", VA = "0x1243250")]
		public NetworkReachability()
		{
		}
	}
}
