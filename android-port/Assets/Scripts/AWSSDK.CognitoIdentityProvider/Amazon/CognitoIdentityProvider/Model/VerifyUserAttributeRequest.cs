using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class VerifyUserAttributeRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _accessToken;

		private string _attributeName;

		private string _code;

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
		public string AttributeName
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
		public string Code
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

		internal bool IsSetAttributeName()
		{
			return false;
		}

		internal bool IsSetCode()
		{
			return false;
		}

		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}
	}
}
