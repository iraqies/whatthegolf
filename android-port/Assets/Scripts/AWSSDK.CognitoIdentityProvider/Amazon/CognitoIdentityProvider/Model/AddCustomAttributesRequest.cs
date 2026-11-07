using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AddCustomAttributesRequest : AmazonCognitoIdentityProviderRequest
	{
		private List<SchemaAttributeType> _customAttributes;

		private string _userPoolId;

		[AWSProperty]
		public List<SchemaAttributeType> CustomAttributes
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

		internal bool IsSetCustomAttributes()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
