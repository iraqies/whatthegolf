using System.Net.Http;

namespace Amazon.Runtime
{
	public abstract class HttpClientFactory
	{
		public abstract HttpClient CreateHttpClient(IClientConfig clientConfig);

		public virtual bool UseSDKHttpClientCaching(IClientConfig clientConfig)
		{
			return false;
		}

		public virtual bool DisposeHttpClientsAfterUse(IClientConfig clientConfig)
		{
			return false;
		}

		public virtual string GetConfigUniqueString(IClientConfig clientConfig)
		{
			return null;
		}
	}
}
