using System;
using System.Net;

namespace Amazon.Runtime
{
	public interface IClientConfig
	{
		RegionEndpoint RegionEndpoint { get; }

		string RegionEndpointServiceName { get; }

		string ServiceURL { get; }

		bool UseHttp { get; }

		string ServiceVersion { get; }

		SigningAlgorithm SignatureMethod { get; }

		string SignatureVersion { get; }

		string AuthenticationRegion { get; }

		string AuthenticationServiceName { get; }

		string UserAgent { get; }

		bool DisableLogging { get; }

		bool LogMetrics { get; }

		bool LogResponse { get; }

		bool ReadEntireResponse { get; }

		bool AllowAutoRedirect { get; }

		int BufferSize { get; }

		int MaxErrorRetry { get; }

		bool IsMaxErrorRetrySet { get; }

		long ProgressUpdateInterval { get; }

		bool ResignRetries { get; }

		ICredentials ProxyCredentials { get; }

		TimeSpan? Timeout { get; }

		bool UseDualstackEndpoint { get; }

		bool ThrottleRetries { get; }

		DateTime CorrectedUtcNow { get; }

		TimeSpan ClockOffset { get; }

		bool DisableHostPrefixInjection { get; }

		bool EndpointDiscoveryEnabled { get; }

		int EndpointDiscoveryCacheLimit { get; }

		RequestRetryMode RetryMode { get; }

		bool FastFailRequests { get; }

		int? MaxConnectionsPerServer { get; }

		bool CacheHttpClient { get; }

		int HttpClientCacheSize { get; }

		string ProxyHost { get; }

		int ProxyPort { get; }

		HttpClientFactory HttpClientFactory { get; }

		string DetermineServiceURL();

		void Validate();

		IWebProxy GetWebProxy();
	}
}
