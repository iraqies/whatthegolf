using Il2CppDummyDll;

namespace Amazon.Internal
{
	[Token(Token = "0x200003C")]
	public interface IRegionEndpoint
	{
		[Token(Token = "0x17000081")]
		string RegionName
		{
			[Token(Token = "0x6000260")]
			get;
		}

		[Token(Token = "0x17000082")]
		string DisplayName
		{
			[Token(Token = "0x6000261")]
			get;
		}

		[Token(Token = "0x6000262")]
		RegionEndpoint.Endpoint GetEndpointForService(string serviceName, bool dualStack);
	}
}
