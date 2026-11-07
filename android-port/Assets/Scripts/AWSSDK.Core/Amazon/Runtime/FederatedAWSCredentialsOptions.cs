using System;
using System.Net;

namespace Amazon.Runtime
{
	public class FederatedAWSCredentialsOptions
	{
		private readonly object syncLock;

		private Func<CredentialRequestCallbackArgs, NetworkCredential> credentialRequestCallback;

		private object customCallbackState;

		private string userIdentity;

		private string profileName;

		private RegionEndpoint stsRegion;

		private WebProxy proxySettings;

		public string UserIdentity
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Func<CredentialRequestCallbackArgs, NetworkCredential> CredentialRequestCallback
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public object CustomCallbackState
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public WebProxy ProxySettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RegionEndpoint STSRegion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ProfileName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
