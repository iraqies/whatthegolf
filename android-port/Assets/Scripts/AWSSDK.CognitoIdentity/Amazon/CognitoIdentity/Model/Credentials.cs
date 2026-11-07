using System;
using Amazon.Runtime;

namespace Amazon.CognitoIdentity.Model
{
	public class Credentials : AWSCredentials
	{
		private ImmutableCredentials _credentials;

		private string _accessKeyId;

		private DateTime? _expiration;

		private string _secretKey;

		private string _sessionToken;

		public string AccessKeyId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DateTime Expiration
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public string SecretKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string SessionToken
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override ImmutableCredentials GetCredentials()
		{
			return null;
		}

		internal bool IsSetAccessKeyId()
		{
			return false;
		}

		internal bool IsSetExpiration()
		{
			return false;
		}

		internal bool IsSetSecretKey()
		{
			return false;
		}

		internal bool IsSetSessionToken()
		{
			return false;
		}
	}
}
