using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AdminRespondToAuthChallengeRequest : AmazonCognitoIdentityProviderRequest
	{
		private AnalyticsMetadataType _analyticsMetadata;

		private ChallengeNameType _challengeName;

		private Dictionary<string, string> _challengeResponses;

		private string _clientId;

		private Dictionary<string, string> _clientMetadata;

		private ContextDataType _contextData;

		private string _session;

		private string _userPoolId;

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
		public ChallengeNameType ChallengeName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Dictionary<string, string> ChallengeResponses
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

		public ContextDataType ContextData
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
		public string Session
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
		public string UserPoolId
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

		internal bool IsSetChallengeName()
		{
			return false;
		}

		internal bool IsSetChallengeResponses()
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

		internal bool IsSetContextData()
		{
			return false;
		}

		internal bool IsSetSession()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
