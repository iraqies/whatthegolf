using System;

namespace Amazon.Runtime.Internal
{
	public abstract class EndpointOperationContextBase
	{
		private string _customerCredentials;

		private string _operationName;

		private EndpointDiscoveryDataBase _endpointDiscoveryData;

		private bool _evictCacheKey;

		private Uri _evictUri;

		public virtual string CustomerCredentials
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public virtual string OperationName
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public virtual EndpointDiscoveryDataBase EndpointDiscoveryData
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public virtual bool EvictCacheKey
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public virtual Uri EvictUri
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		protected EndpointOperationContextBase(string customerCredentials, string operationName, EndpointDiscoveryDataBase endpointDiscoveryData, bool evictCacheKey, Uri evictUri)
		{
		}
	}
}
