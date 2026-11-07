using System.Collections.Generic;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class SignUpRequest : AmazonCognitoIdentityProviderRequest
	{
		private AnalyticsMetadataType _analyticsMetadata;

		private string _clientId;

		private Dictionary<string, string> _clientMetadata;

		private string _password;

		private string _secretHash;

		private List<AttributeType> _userAttributes;

		private UserContextDataType _userContextData;

		private string _username;

		private List<AttributeType> _validationData;

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

		public List<AttributeType> UserAttributes
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

		public List<AttributeType> ValidationData
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

		internal bool IsSetPassword()
		{
			return false;
		}

		internal bool IsSetSecretHash()
		{
			return false;
		}

		internal bool IsSetUserAttributes()
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

		internal bool IsSetValidationData()
		{
			return false;
		}

		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}
	}
}
