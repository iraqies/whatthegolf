using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AdminUpdateUserAttributesRequest : AmazonCognitoIdentityProviderRequest
	{
		private Dictionary<string, string> _clientMetadata;

		private List<AttributeType> _userAttributes;

		private string _username;

		private string _userPoolId;

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

		internal bool IsSetClientMetadata()
		{
			return false;
		}

		internal bool IsSetUserAttributes()
		{
			return false;
		}

		internal bool IsSetUsername()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
