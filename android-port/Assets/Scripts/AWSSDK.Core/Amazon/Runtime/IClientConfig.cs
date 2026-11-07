using System;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000E0")]
	public interface IClientConfig
	{
		[Token(Token = "0x170001EE")]
		RegionEndpoint RegionEndpoint
		{
			[Token(Token = "0x60007C2")]
			get;
		}

		[Token(Token = "0x170001EF")]
		string RegionEndpointServiceName
		{
			[Token(Token = "0x60007C3")]
			get;
		}

		[Token(Token = "0x170001F0")]
		string ServiceURL
		{
			[Token(Token = "0x60007C4")]
			get;
		}

		[Token(Token = "0x170001F1")]
		bool UseHttp
		{
			[Token(Token = "0x60007C5")]
			get;
		}

		[Token(Token = "0x170001F2")]
		string ServiceVersion
		{
			[Token(Token = "0x60007C6")]
			get;
		}

		[Token(Token = "0x170001F3")]
		SigningAlgorithm SignatureMethod
		{
			[Token(Token = "0x60007C7")]
			get;
		}

		[Token(Token = "0x170001F4")]
		string SignatureVersion
		{
			[Token(Token = "0x60007C8")]
			get;
		}

		[Token(Token = "0x170001F5")]
		string AuthenticationRegion
		{
			[Token(Token = "0x60007C9")]
			get;
		}

		[Token(Token = "0x170001F6")]
		string AuthenticationServiceName
		{
			[Token(Token = "0x60007CA")]
			get;
		}

		[Token(Token = "0x170001F7")]
		string UserAgent
		{
			[Token(Token = "0x60007CB")]
			get;
		}

		[Token(Token = "0x170001F8")]
		bool DisableLogging
		{
			[Token(Token = "0x60007CC")]
			get;
		}

		[Token(Token = "0x170001F9")]
		bool LogMetrics
		{
			[Token(Token = "0x60007CD")]
			get;
		}

		[Token(Token = "0x170001FA")]
		bool LogResponse
		{
			[Token(Token = "0x60007CE")]
			get;
		}

		[Token(Token = "0x170001FB")]
		bool ReadEntireResponse
		{
			[Token(Token = "0x60007CF")]
			get;
		}

		[Token(Token = "0x170001FC")]
		bool AllowAutoRedirect
		{
			[Token(Token = "0x60007D0")]
			get;
		}

		[Token(Token = "0x170001FD")]
		int BufferSize
		{
			[Token(Token = "0x60007D1")]
			get;
		}

		[Token(Token = "0x170001FE")]
		int MaxErrorRetry
		{
			[Token(Token = "0x60007D2")]
			get;
		}

		[Token(Token = "0x170001FF")]
		bool IsMaxErrorRetrySet
		{
			[Token(Token = "0x60007D3")]
			get;
		}

		[Token(Token = "0x17000200")]
		long ProgressUpdateInterval
		{
			[Token(Token = "0x60007D4")]
			get;
		}

		[Token(Token = "0x17000201")]
		bool ResignRetries
		{
			[Token(Token = "0x60007D5")]
			get;
		}

		[Token(Token = "0x17000202")]
		ICredentials ProxyCredentials
		{
			[Token(Token = "0x60007D6")]
			get;
		}

		[Token(Token = "0x17000203")]
		TimeSpan? Timeout
		{
			[Token(Token = "0x60007D7")]
			get;
		}

		[Token(Token = "0x17000204")]
		bool UseDualstackEndpoint
		{
			[Token(Token = "0x60007D8")]
			get;
		}

		[Token(Token = "0x17000205")]
		bool ThrottleRetries
		{
			[Token(Token = "0x60007D9")]
			get;
		}

		[Token(Token = "0x17000206")]
		DateTime CorrectedUtcNow
		{
			[Token(Token = "0x60007DC")]
			get;
		}

		[Token(Token = "0x17000207")]
		TimeSpan ClockOffset
		{
			[Token(Token = "0x60007DD")]
			get;
		}

		[Token(Token = "0x17000208")]
		bool DisableHostPrefixInjection
		{
			[Token(Token = "0x60007DE")]
			get;
		}

		[Token(Token = "0x17000209")]
		bool EndpointDiscoveryEnabled
		{
			[Token(Token = "0x60007DF")]
			get;
		}

		[Token(Token = "0x1700020A")]
		int EndpointDiscoveryCacheLimit
		{
			[Token(Token = "0x60007E0")]
			get;
		}

		[Token(Token = "0x1700020B")]
		RequestRetryMode RetryMode
		{
			[Token(Token = "0x60007E1")]
			get;
		}

		[Token(Token = "0x1700020C")]
		bool FastFailRequests
		{
			[Token(Token = "0x60007E2")]
			get;
		}

		[Token(Token = "0x1700020D")]
		int? MaxConnectionsPerServer
		{
			[Token(Token = "0x60007E3")]
			get;
		}

		[Token(Token = "0x1700020E")]
		bool CacheHttpClient
		{
			[Token(Token = "0x60007E4")]
			get;
		}

		[Token(Token = "0x1700020F")]
		int HttpClientCacheSize
		{
			[Token(Token = "0x60007E5")]
			get;
		}

		[Token(Token = "0x17000210")]
		string ProxyHost
		{
			[Token(Token = "0x60007E6")]
			get;
		}

		[Token(Token = "0x17000211")]
		int ProxyPort
		{
			[Token(Token = "0x60007E7")]
			get;
		}

		[Token(Token = "0x17000212")]
		HttpClientFactory HttpClientFactory
		{
			[Token(Token = "0x60007E9")]
			get;
		}

		[Token(Token = "0x60007DA")]
		string DetermineServiceURL();

		[Token(Token = "0x60007DB")]
		void Validate();

		[Token(Token = "0x60007E8")]
		IWebProxy GetWebProxy();
	}
}
