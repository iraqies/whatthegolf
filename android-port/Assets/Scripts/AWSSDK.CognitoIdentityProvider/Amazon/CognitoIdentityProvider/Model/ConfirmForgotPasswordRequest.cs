using System.Collections.Generic;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ConfirmForgotPasswordRequest : AmazonCognitoIdentityProviderRequest
	{
		private AnalyticsMetadataType _analyticsMetadata;

		private string _clientId;

		private Dictionary<string, string> _clientMetadata;

		private string _confirmationCode;

		private string _password;

		private string _secretHash;

		private UserContextDataType _userContextData;

		private string _username;

		public AnalyticsMetadataType AnalyticsMetadata
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string ClientId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Dictionary<string, string> ClientMetadata
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string ConfirmationCode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string Password
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string SecretHash
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UserContextDataType UserContextData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string Username
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAnalyticsMetadata()
		{
			return false;
		}

		internal bool IsSetClientId()
		{
			return false;
		}

		internal bool IsSetClientMetadata()
		{
			return false;
		}

		internal bool IsSetConfirmationCode()
		{
			return false;
		}

		internal bool IsSetPassword()
		{
			return false;
		}

		internal bool IsSetSecretHash()
		{
			return false;
		}

		internal bool IsSetUserContextData()
		{
			return false;
		}

		internal bool IsSetUsername()
		{
			return false;
		}

		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}
	}
}
