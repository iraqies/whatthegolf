using System.Collections.Generic;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class DeleteUserAttributesRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _accessToken;

		private List<string> _userAttributeNames;

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
		public List<string> UserAttributeNames
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

		internal bool IsSetUserAttributeNames()
		{
			return false;
		}

		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}
	}
}
