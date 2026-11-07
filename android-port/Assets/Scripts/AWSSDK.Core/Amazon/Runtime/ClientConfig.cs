using System;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000A9")]
	public abstract class ClientConfig : IClientConfig
	{
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly TimeSpan InfiniteTimeout;

		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x8")]
		public static readonly TimeSpan MaxTimeout;

		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x10")]
		private RegionEndpoint regionEndpoint;

		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x18")]
		private bool probeForRegionEndpoint;

		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x19")]
		private bool throttleRetries;

		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x1A")]
		private bool useHttp;

		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x1B")]
		private bool useAlternateUserAgentHeader;

		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x20")]
		private string serviceURL;

		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x28")]
		private string authRegion;

		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x30")]
		private string authServiceName;

		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x38")]
		private string signatureVersion;

		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x40")]
		private SigningAlgorithm signatureMethod;

		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x44")]
		private bool readEntireResponse;

		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x45")]
		private bool logResponse;

		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x48")]
		private int bufferSize;

		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x50")]
		private long progressUpdateInterval;

		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x58")]
		private bool resignRetries;

		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x60")]
		private ICredentials proxyCredentials;

		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x68")]
		private bool logMetrics;

		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x69")]
		private bool disableLogging;

		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x70")]
		private TimeSpan? timeout;

		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x80")]
		private bool allowAutoRedirect;

		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x81")]
		private bool useDualstackEndpoint;

		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x88")]
		private TimeSpan? readWriteTimeout;

		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x98")]
		private bool disableHostPrefixInjection;

		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x99")]
		private bool? endpointDiscoveryEnabled;

		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x9C")]
		private int endpointDiscoveryCacheLimit;

		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0xA0")]
		private RequestRetryMode? retryMode;

		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0xA8")]
		private int? maxRetries;

		[Token(Token = "0x40002ED")]
		private const int MaxRetriesDefault = 2;

		[Token(Token = "0x40002EE")]
		private const int MaxRetriesLegacyDefault = 4;

		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26808", Offset = "0x26808")]
		private bool FastFailRequests__BackingField;

		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0xB1")]
		private bool cacheHttpClient;

		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0xB4")]
		private int? _httpClientCacheSize;

		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0xC0")]
		private IWebProxy proxy;

		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0xC8")]
		private string proxyHost;

		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0xD0")]
		private int proxyPort;

		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26818", Offset = "0x26818")]
		private int? MaxConnectionsPerServer__BackingField;

		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26828", Offset = "0x26828")]
		private HttpClientFactory HttpClientFactory__BackingField;

		[Token(Token = "0x1700017A")]
		public abstract string ServiceVersion
		{
			[Token(Token = "0x600060F")]
			get;
		}

		[Token(Token = "0x1700017B")]
		public SigningAlgorithm SignatureMethod
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x11DE804", Offset = "0x11DE804", VA = "0x11DE804", Slot = "9")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x11DE80C", Offset = "0x11DE80C", VA = "0x11DE80C")]
			set
			{
			}
		}

		[Token(Token = "0x1700017C")]
		public string SignatureVersion
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x11DE814", Offset = "0x11DE814", VA = "0x11DE814", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x11DE81C", Offset = "0x11DE81C", VA = "0x11DE81C")]
			set
			{
			}
		}

		[Token(Token = "0x1700017D")]
		public abstract string UserAgent
		{
			[Token(Token = "0x6000614")]
			get;
		}

		[Token(Token = "0x1700017E")]
		public bool UseAlternateUserAgentHeader
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x11DE824", Offset = "0x11DE824", VA = "0x11DE824")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x11DE82C", Offset = "0x11DE82C", VA = "0x11DE82C")]
			set
			{
			}
		}

		[Token(Token = "0x1700017F")]
		public RegionEndpoint RegionEndpoint
		{
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x11DE834", Offset = "0x11DE834", VA = "0x11DE834", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x11DE958", Offset = "0x11DE958", VA = "0x11DE958")]
			set
			{
			}
		}

		[Token(Token = "0x17000180")]
		public abstract string RegionEndpointServiceName
		{
			[Token(Token = "0x6000619")]
			get;
		}

		[Token(Token = "0x17000181")]
		public string ServiceURL
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x11DE970", Offset = "0x11DE970", VA = "0x11DE970", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x11DE978", Offset = "0x11DE978", VA = "0x11DE978")]
			set
			{
			}
		}

		[Token(Token = "0x17000182")]
		public bool UseHttp
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x11DE988", Offset = "0x11DE988", VA = "0x11DE988", Slot = "7")]
			get
			{
				return default;
			}
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x11DE990", Offset = "0x11DE990", VA = "0x11DE990")]
			set
			{
			}
		}

		[Token(Token = "0x17000183")]
		public string AuthenticationRegion
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x11DEB94", Offset = "0x11DEB94", VA = "0x11DEB94", Slot = "11")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x11DEB9C", Offset = "0x11DEB9C", VA = "0x11DEB9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000184")]
		public string AuthenticationServiceName
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x11DEBA4", Offset = "0x11DEBA4", VA = "0x11DEBA4", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x11DEBAC", Offset = "0x11DEBAC", VA = "0x11DEBAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000185")]
		public int MaxErrorRetry
		{
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x11DEBB4", Offset = "0x11DEBB4", VA = "0x11DEBB4", Slot = "20")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x11DED70", Offset = "0x11DED70", VA = "0x11DED70")]
			set
			{
			}
		}

		[Token(Token = "0x17000186")]
		public bool IsMaxErrorRetrySet
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x11DEDE4", Offset = "0x11DEDE4", VA = "0x11DEDE4", Slot = "21")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000187")]
		public bool LogResponse
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x11DEE24", Offset = "0x11DEE24", VA = "0x11DEE24", Slot = "16")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x11DEE2C", Offset = "0x11DEE2C", VA = "0x11DEE2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000188")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x2C474", Offset = "0x2C474")]
		public bool ReadEntireResponse
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x11DEE34", Offset = "0x11DEE34", VA = "0x11DEE34", Slot = "17")]
			get
			{
				return default;
			}
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x11DEE3C", Offset = "0x11DEE3C", VA = "0x11DEE3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000189")]
		public int BufferSize
		{
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x11DEE44", Offset = "0x11DEE44", VA = "0x11DEE44", Slot = "19")]
			get
			{
				return default;
			}
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x11DEE4C", Offset = "0x11DEE4C", VA = "0x11DEE4C")]
			set
			{
			}
		}

		[Token(Token = "0x1700018A")]
		public long ProgressUpdateInterval
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x11DEE54", Offset = "0x11DEE54", VA = "0x11DEE54", Slot = "22")]
			get
			{
				return default;
			}
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x11DEE5C", Offset = "0x11DEE5C", VA = "0x11DEE5C")]
			set
			{
			}
		}

		[Token(Token = "0x1700018B")]
		public bool ResignRetries
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x11DEE64", Offset = "0x11DEE64", VA = "0x11DEE64", Slot = "23")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x11DEE6C", Offset = "0x11DEE6C", VA = "0x11DEE6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700018C")]
		public bool AllowAutoRedirect
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x11DEE74", Offset = "0x11DEE74", VA = "0x11DEE74", Slot = "18")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x11DEE7C", Offset = "0x11DEE7C", VA = "0x11DEE7C")]
			set
			{
			}
		}

		[Token(Token = "0x1700018D")]
		public bool LogMetrics
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x11DEE84", Offset = "0x11DEE84", VA = "0x11DEE84", Slot = "15")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x11DEE8C", Offset = "0x11DEE8C", VA = "0x11DEE8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700018E")]
		public bool DisableLogging
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x11DEE94", Offset = "0x11DEE94", VA = "0x11DEE94", Slot = "14")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x11DEE9C", Offset = "0x11DEE9C", VA = "0x11DEE9C")]
			set
			{
			}
		}

		[Token(Token = "0x1700018F")]
		public ICredentials ProxyCredentials
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x11DEEA4", Offset = "0x11DEEA4", VA = "0x11DEEA4", Slot = "24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x11DF008", Offset = "0x11DF008", VA = "0x11DF008")]
			set
			{
			}
		}

		[Token(Token = "0x17000190")]
		public TimeSpan? Timeout
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x11DF158", Offset = "0x11DF158", VA = "0x11DF158", Slot = "25")]
			get
			{
				return null;
			}
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x11DF164", Offset = "0x11DF164", VA = "0x11DF164")]
			set
			{
			}
		}

		[Token(Token = "0x17000191")]
		public bool UseDualstackEndpoint
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x11DF3DC", Offset = "0x11DF3DC", VA = "0x11DF3DC", Slot = "26")]
			get
			{
				return default;
			}
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x11DF3E4", Offset = "0x11DF3E4", VA = "0x11DF3E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000192")]
		public bool ThrottleRetries
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x11DF3EC", Offset = "0x11DF3EC", VA = "0x11DF3EC", Slot = "27")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x11DF3F4", Offset = "0x11DF3F4", VA = "0x11DF3F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000193")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x2C4AC", Offset = "0x2C4AC")]
		public DateTime CorrectedUtcNow
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x11DF47C", Offset = "0x11DF47C", VA = "0x11DF47C", Slot = "30")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000194")]
		public TimeSpan ClockOffset
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x11DF7F8", Offset = "0x11DF7F8", VA = "0x11DF7F8", Slot = "31")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000195")]
		public bool DisableHostPrefixInjection
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x11DFB60", Offset = "0x11DFB60", VA = "0x11DFB60", Slot = "32")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x11DFB68", Offset = "0x11DFB68", VA = "0x11DFB68")]
			set
			{
			}
		}

		[Token(Token = "0x17000196")]
		public bool EndpointDiscoveryEnabled
		{
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x11DFB70", Offset = "0x11DFB70", VA = "0x11DFB70", Slot = "33")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x11DFC20", Offset = "0x11DFC20", VA = "0x11DFC20")]
			set
			{
			}
		}

		[Token(Token = "0x17000197")]
		public int EndpointDiscoveryCacheLimit
		{
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x11DFC94", Offset = "0x11DFC94", VA = "0x11DFC94", Slot = "34")]
			get
			{
				return default;
			}
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x11DFC9C", Offset = "0x11DFC9C", VA = "0x11DFC9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000198")]
		public RequestRetryMode RetryMode
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x11DECC4", Offset = "0x11DECC4", VA = "0x11DECC4", Slot = "35")]
			get
			{
				return default;
			}
			[Token(Token = "0x600064C")]
			[Address(RVA = "0x11DFCA4", Offset = "0x11DFCA4", VA = "0x11DFCA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000199")]
		public bool FastFailRequests
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x11DFD18", Offset = "0x11DFD18", VA = "0x11DFD18", Slot = "36")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28CEC", Offset = "0x28CEC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x11DFD20", Offset = "0x11DFD20", VA = "0x11DFD20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28CFC", Offset = "0x28CFC")]
			set
			{
			}
		}

		[Token(Token = "0x1700019A")]
		public bool CacheHttpClient
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x11DFD98", Offset = "0x11DFD98", VA = "0x11DFD98", Slot = "38")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x11DFDA0", Offset = "0x11DFDA0", VA = "0x11DFDA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		public int HttpClientCacheSize
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x11DFDA8", Offset = "0x11DFDA8", VA = "0x11DFDA8", Slot = "39")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x11DFEA8", Offset = "0x11DFEA8", VA = "0x11DFEA8")]
			set
			{
			}
		}

		[Token(Token = "0x1700019C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x2C4E8", Offset = "0x2C4E8")]
		public TimeSpan? ReadWriteTimeout
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x11DFF1C", Offset = "0x11DFF1C", VA = "0x11DFF1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x11DFF28", Offset = "0x11DFF28", VA = "0x11DFF28")]
			set
			{
			}
		}

		[Token(Token = "0x1700019D")]
		public string ProxyHost
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x11DFFBC", Offset = "0x11DFFBC", VA = "0x11DFFBC", Slot = "40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600065B")]
			[Address(RVA = "0x11E0040", Offset = "0x11E0040", VA = "0x11E0040")]
			set
			{
			}
		}

		[Token(Token = "0x1700019E")]
		public int ProxyPort
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x11E01F4", Offset = "0x11E01F4", VA = "0x11E01F4", Slot = "41")]
			get
			{
				return default;
			}
			[Token(Token = "0x600065D")]
			[Address(RVA = "0x11E027C", Offset = "0x11E027C", VA = "0x11E027C")]
			set
			{
			}
		}

		[Token(Token = "0x1700019F")]
		public int? MaxConnectionsPerServer
		{
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x11E041C", Offset = "0x11E041C", VA = "0x11E041C", Slot = "37")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28D0C", Offset = "0x28D0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x11E0424", Offset = "0x11E0424", VA = "0x11E0424")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28D1C", Offset = "0x28D1C")]
			set
			{
			}
		}

		[Token(Token = "0x170001A0")]
		public HttpClientFactory HttpClientFactory
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x11E042C", Offset = "0x11E042C", VA = "0x11E042C", Slot = "43")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28D2C", Offset = "0x28D2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x11E0434", Offset = "0x11E0434", VA = "0x11E0434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28D3C", Offset = "0x28D3C")]
			set
			{
			}
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x11DE998", Offset = "0x11DE998", VA = "0x11DE998", Slot = "47")]
		public virtual string DetermineServiceURL()
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x11DEA58", Offset = "0x11DEA58", VA = "0x11DEA58")]
		internal static string GetUrl(RegionEndpoint regionEndpoint, string regionEndpointServiceName, bool useHttp, bool useDualStack)
		{
			return null;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x11DF010", Offset = "0x11DF010", VA = "0x11DF010")]
		public ClientConfig()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x11DF154", Offset = "0x11DF154", VA = "0x11DF154", Slot = "48")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x11DF3FC", Offset = "0x11DF3FC", VA = "0x11DF3FC")]
		public void SetUseNagleIfAvailable(bool useNagle)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x11DF400", Offset = "0x11DF400", VA = "0x11DF400", Slot = "49")]
		public virtual void Validate()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x11DF1E8", Offset = "0x11DF1E8", VA = "0x11DF1E8")]
		public static void ValidateTimeout(TimeSpan? timeout)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x11DFD28", Offset = "0x11DFD28", VA = "0x11DFD28")]
		public static TimeSpan? GetTimeoutValue(TimeSpan? clientTimeout, TimeSpan? requestTimeout)
		{
			return null;
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x11DE8FC", Offset = "0x11DE8FC", VA = "0x11DE8FC")]
		private static RegionEndpoint GetDefaultRegionEndpoint()
		{
			return null;
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x11DFFAC", Offset = "0x11DFFAC", VA = "0x11DFFAC", Slot = "42")]
		public IWebProxy GetWebProxy()
		{
			return null;
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x11DFFB4", Offset = "0x11DFFB4", VA = "0x11DFFB4")]
		public void SetWebProxy(IWebProxy proxy)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x11E043C", Offset = "0x11E043C", VA = "0x11E043C")]
		internal static bool CacheHttpClients(IClientConfig clientConfig)
		{
			return default;
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x11E05DC", Offset = "0x11E05DC", VA = "0x11E05DC")]
		internal static bool DisposeHttpClients(IClientConfig clientConfig)
		{
			return default;
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x11E0784", Offset = "0x11E0784", VA = "0x11E0784")]
		internal static string CreateConfigUniqueString(IClientConfig clientConfig)
		{
			return null;
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x11E0DD0", Offset = "0x11E0DD0", VA = "0x11E0DD0")]
		internal static bool UseGlobalHttpClientCache(IClientConfig clientConfig)
		{
			return default;
		}
	}
}
