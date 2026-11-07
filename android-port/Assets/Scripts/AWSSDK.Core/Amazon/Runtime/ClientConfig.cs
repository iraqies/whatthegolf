using System;
using System.Net;

namespace Amazon.Runtime
{
	public abstract class ClientConfig : IClientConfig
	{
		internal static readonly TimeSpan InfiniteTimeout;

		public static readonly TimeSpan MaxTimeout;

		private RegionEndpoint regionEndpoint;

		private bool probeForRegionEndpoint;

		private bool throttleRetries;

		private bool useHttp;

		private bool useAlternateUserAgentHeader;

		private string serviceURL;

		private string authRegion;

		private string authServiceName;

		private string signatureVersion;

		private SigningAlgorithm signatureMethod;

		private bool readEntireResponse;

		private bool logResponse;

		private int bufferSize;

		private long progressUpdateInterval;

		private bool resignRetries;

		private ICredentials proxyCredentials;

		private bool logMetrics;

		private bool disableLogging;

		private TimeSpan? timeout;

		private bool allowAutoRedirect;

		private bool useDualstackEndpoint;

		private TimeSpan? readWriteTimeout;

		private bool disableHostPrefixInjection;

		private bool? endpointDiscoveryEnabled;

		private int endpointDiscoveryCacheLimit;

		private RequestRetryMode? retryMode;

		private int? maxRetries;

		private const int MaxRetriesDefault = 2;

		private const int MaxRetriesLegacyDefault = 4;

		private bool cacheHttpClient;

		private int? _httpClientCacheSize;

		private IWebProxy proxy;

		private string proxyHost;

		private int proxyPort;

		public abstract string ServiceVersion { get; }

		public SigningAlgorithm SignatureMethod
		{
			get
			{
				return SigningAlgorithm.HmacSHA1;
			}
			set
			{
			}
		}

		public string SignatureVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public abstract string UserAgent { get; }

		public bool UseAlternateUserAgentHeader
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public RegionEndpoint RegionEndpoint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public abstract string RegionEndpointServiceName { get; }

		public string ServiceURL
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseHttp
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string AuthenticationRegion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string AuthenticationServiceName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int MaxErrorRetry
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsMaxErrorRetrySet => false;

		public bool LogResponse
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete]
		public bool ReadEntireResponse
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int BufferSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long ProgressUpdateInterval
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public bool ResignRetries
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AllowAutoRedirect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool LogMetrics
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DisableLogging
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ICredentials ProxyCredentials
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TimeSpan? Timeout
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseDualstackEndpoint
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ThrottleRetries
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete]
		public DateTime CorrectedUtcNow => default;

		public TimeSpan ClockOffset => default;

		public bool DisableHostPrefixInjection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool EndpointDiscoveryEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int EndpointDiscoveryCacheLimit
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public RequestRetryMode RetryMode
		{
			get
			{
				return RequestRetryMode.Legacy;
			}
			set
			{
			}
		}

		public bool FastFailRequests { get; set; }

		public bool CacheHttpClient
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int HttpClientCacheSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[Obsolete]
		public TimeSpan? ReadWriteTimeout
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ProxyHost
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int ProxyPort
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int? MaxConnectionsPerServer { get; set; }

		public HttpClientFactory HttpClientFactory { get; set; }

		public virtual string DetermineServiceURL()
		{
			return null;
		}

		internal static string GetUrl(RegionEndpoint regionEndpoint, string regionEndpointServiceName, bool useHttp, bool useDualStack)
		{
			return null;
		}

		public ClientConfig()
		{
		}

		protected virtual void Initialize()
		{
		}

		public void SetUseNagleIfAvailable(bool useNagle)
		{
		}

		public virtual void Validate()
		{
		}

		public static void ValidateTimeout(TimeSpan? timeout)
		{
		}

		public static TimeSpan? GetTimeoutValue(TimeSpan? clientTimeout, TimeSpan? requestTimeout)
		{
			return null;
		}

		private static RegionEndpoint GetDefaultRegionEndpoint()
		{
			return null;
		}

		public IWebProxy GetWebProxy()
		{
			return null;
		}

		public void SetWebProxy(IWebProxy proxy)
		{
		}

		internal static bool CacheHttpClients(IClientConfig clientConfig)
		{
			return false;
		}

		internal static bool DisposeHttpClients(IClientConfig clientConfig)
		{
			return false;
		}

		internal static string CreateConfigUniqueString(IClientConfig clientConfig)
		{
			return null;
		}

		internal static bool UseGlobalHttpClientCache(IClientConfig clientConfig)
		{
			return false;
		}
	}
}
