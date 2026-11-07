using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Internal
{
	[Token(Token = "0x200003D")]
	public interface IRegionEndpointProvider
	{
		[Token(Token = "0x17000083")]
		IEnumerable<IRegionEndpoint> AllRegionEndpoints
		{
			[Token(Token = "0x6000263")]
			get;
		}

		[Token(Token = "0x6000264")]
		IRegionEndpoint GetRegionEndpoint(string regionName);
	}
}
