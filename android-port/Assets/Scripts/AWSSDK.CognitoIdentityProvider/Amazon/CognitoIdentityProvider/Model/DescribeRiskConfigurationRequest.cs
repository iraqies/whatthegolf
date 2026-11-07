using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class DescribeRiskConfigurationRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _clientId;

		private string _userPoolId;

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

		internal bool IsSetClientId()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
