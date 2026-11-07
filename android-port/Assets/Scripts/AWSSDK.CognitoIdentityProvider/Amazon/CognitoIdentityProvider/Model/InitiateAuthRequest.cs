using System.Collections.Generic;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class InitiateAuthRequest : AmazonCognitoIdentityProviderRequest
	{
		private AnalyticsMetadataType _analyticsMetadata;

		private AuthFlowType _authFlow;

		private Dictionary<string, string> _authParameters;

		private string _clientId;

		private Dictionary<string, string> _clientMetadata;

		private UserContextDataType _userContextData;

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
		public AuthFlowType AuthFlow
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Dictionary<string, string> AuthParameters
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

		internal bool IsSetAnalyticsMetadata()
		{
			return false;
		}

		internal bool IsSetAuthFlow()
		{
			return false;
		}

		internal bool IsSetAuthParameters()
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

		internal bool IsSetUserContextData()
		{
			return false;
		}

		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}
	}
}
