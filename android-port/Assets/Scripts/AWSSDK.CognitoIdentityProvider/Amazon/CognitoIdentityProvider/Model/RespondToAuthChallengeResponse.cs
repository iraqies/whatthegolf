using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class RespondToAuthChallengeResponse : AmazonWebServiceResponse
	{
		private AuthenticationResultType _authenticationResult;

		private ChallengeNameType _challengeName;

		private Dictionary<string, string> _challengeParameters;

		private string _session;

		public AuthenticationResultType AuthenticationResult
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public Dictionary<string, string> ChallengeParameters
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

		internal bool IsSetAuthenticationResult()
		{
			return false;
		}

		internal bool IsSetChallengeName()
		{
			return false;
		}

		internal bool IsSetChallengeParameters()
		{
			return false;
		}

		internal bool IsSetSession()
		{
			return false;
		}
	}
}
