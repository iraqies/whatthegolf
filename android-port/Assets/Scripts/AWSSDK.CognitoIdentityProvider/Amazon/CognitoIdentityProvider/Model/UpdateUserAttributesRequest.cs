using System.Collections.Generic;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UpdateUserAttributesRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _accessToken;

		private Dictionary<string, string> _clientMetadata;

		private List<AttributeType> _userAttributes;

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

		internal bool IsSetAccessToken()
		{
			return false;
		}

		internal bool IsSetClientMetadata()
		{
			return false;
		}

		internal bool IsSetUserAttributes()
		{
			return false;
		}

		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}
	}
}
