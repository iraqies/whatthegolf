using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ChangePasswordRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _accessToken;

		private string _previousPassword;

		private string _proposedPassword;

		[AWSProperty]
		public string AccessToken
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
		public string PreviousPassword
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
		public string ProposedPassword
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAccessToken()
		{
			return false;
		}

		internal bool IsSetPreviousPassword()
		{
			return false;
		}

		internal bool IsSetProposedPassword()
		{
			return false;
		}

		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}
	}
}
