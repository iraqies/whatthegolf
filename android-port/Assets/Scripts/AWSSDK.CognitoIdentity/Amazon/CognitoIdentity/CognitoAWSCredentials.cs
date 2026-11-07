using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Amazon.CognitoIdentity.Model;
using Amazon.Runtime;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

namespace Amazon.CognitoIdentity
{
	public class CognitoAWSCredentials : RefreshingAWSCredentials
	{
		[Flags]
		private enum RefreshIdentityOptions
		{
			None = 0,
			Refresh = 1
		}

		public class IdentityChangedArgs : EventArgs
		{
			public string OldIdentityId { get; private set; }

			public string NewIdentityId { get; private set; }

			internal IdentityChangedArgs(string oldIdentityId, string newIdentityId)
			{
			}
		}

		public class IdentityState
		{
			public string IdentityId { get; private set; }

			public string LoginProvider { get; private set; }

			public string LoginToken { get; private set; }

			public bool FromCache { get; private set; }

			public bool LoginSpecified => false;

			public IdentityState(string identityId, string provider, string token, bool fromCache)
			{
			}

			public IdentityState(string identityId, bool fromCache)
			{
			}
		}

		private static object refreshIdLock;

		private string identityId;

		private static int DefaultDurationSeconds;

		private IAmazonCognitoIdentity cib;

		private IAmazonSecurityTokenService sts;

		private IdentityState _identityState;

		private EventHandler<IdentityChangedArgs> mIdentityChangedEvent;

		private static readonly string IDENTITY_ID_CACHE_KEY;

		private bool IsIdentitySet => false;

		protected Dictionary<string, string> CloneLogins => null;

		public string AccountId { get; private set; }

		public string IdentityPoolId { get; private set; }

		public string UnAuthRoleArn { get; private set; }

		public string AuthRoleArn { get; private set; }

		private Dictionary<string, string> Logins { get; set; }

		public string[] CurrentLoginProviders => null;

		public int LoginsCount => 0;

		public event EventHandler<IdentityChangedArgs> IdentityChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		private void UpdateIdentity(string newIdentityId)
		{
		}

		protected string GetNamespacedKey(string key)
		{
			return null;
		}

		public void Clear()
		{
		}

		public bool ContainsProvider(string providerName)
		{
			return false;
		}

		public void RemoveLogin(string providerName)
		{
		}

		public void AddLogin(string providerName, string token)
		{
		}

		public string GetIdentityId()
		{
			return null;
		}

		private string GetIdentityId(RefreshIdentityOptions options)
		{
			return null;
		}

		protected virtual IdentityState RefreshIdentity()
		{
			return null;
		}

		public Task<string> GetIdentityIdAsync()
		{
			return null;
		}

		private Task<string> GetIdentityIdAsync(RefreshIdentityOptions options)
		{
			return null;
		}

		public virtual Task<IdentityState> RefreshIdentityAsync()
		{
			return null;
		}

		private bool ShouldRetry(AmazonCognitoIdentityException e)
		{
			return false;
		}

		public CognitoAWSCredentials(string identityPoolId, RegionEndpoint region)
		{
		}

		public CognitoAWSCredentials(string accountId, string identityPoolId, string unAuthRoleArn, string authRoleArn, RegionEndpoint region)
		{
		}

		public CognitoAWSCredentials(string accountId, string identityPoolId, string unAuthRoleArn, string authRoleArn, IAmazonCognitoIdentity cibClient, IAmazonSecurityTokenService stsClient)
		{
		}

		protected override Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
		{
			return null;
		}

		private Task<CredentialsRefreshState> GetCredentialsForRoleAsync(string roleArn)
		{
			return null;
		}

		private Task<CredentialsRefreshState> GetPoolCredentialsAsync()
		{
			return null;
		}

		protected override CredentialsRefreshState GenerateNewCredentials()
		{
			return null;
		}

		private CredentialsRefreshState GetPoolCredentials()
		{
			return null;
		}

		private CredentialsRefreshState GetCredentialsForRole(string roleArn)
		{
			return null;
		}

		private Amazon.SecurityToken.Model.Credentials GetStsCredentials(AssumeRoleWithWebIdentityRequest assumeRequest)
		{
			return null;
		}

		private GetOpenIdTokenResponse GetOpenId(GetOpenIdTokenRequest getTokenRequest)
		{
			return null;
		}

		private GetCredentialsForIdentityResponse GetCredentialsForIdentity(GetCredentialsForIdentityRequest getCredentialsRequest)
		{
			return null;
		}

		public virtual string GetCachedIdentityId()
		{
			return null;
		}

		public virtual void CacheIdentityId(string identityId)
		{
		}

		public virtual void ClearIdentityCache()
		{
		}

		public virtual void CacheCredentials(CredentialsRefreshState credentialsState)
		{
		}

		public virtual CredentialsRefreshState GetCachedCredentials()
		{
			return null;
		}
	}
}
