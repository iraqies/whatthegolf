using System.Net.Http;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000EF")]
	public abstract class HttpClientFactory
	{
		[Token(Token = "0x6000830")]
		public abstract HttpClient CreateHttpClient(IClientConfig clientConfig);

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x120E928", Offset = "0x120E928", VA = "0x120E928", Slot = "5")]
		public virtual bool UseSDKHttpClientCaching(IClientConfig clientConfig)
		{
			return default;
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x120E9DC", Offset = "0x120E9DC", VA = "0x120E9DC", Slot = "6")]
		public virtual bool DisposeHttpClientsAfterUse(IClientConfig clientConfig)
		{
			return default;
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x120E9FC", Offset = "0x120E9FC", VA = "0x120E9FC", Slot = "7")]
		public virtual string GetConfigUniqueString(IClientConfig clientConfig)
		{
			return null;
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x120EA04", Offset = "0x120EA04", VA = "0x120EA04")]
		protected HttpClientFactory()
		{
		}
	}
}
