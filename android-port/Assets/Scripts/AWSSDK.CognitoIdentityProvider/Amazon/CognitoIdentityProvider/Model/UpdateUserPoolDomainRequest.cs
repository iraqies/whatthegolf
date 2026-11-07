using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UpdateUserPoolDomainRequest : AmazonCognitoIdentityProviderRequest
	{
		private CustomDomainConfigType _customDomainConfig;

		private string _domain;

		private string _userPoolId;

		[AWSProperty]
		public CustomDomainConfigType CustomDomainConfig
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
		public string Domain
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

		internal bool IsSetCustomDomainConfig()
		{
			return false;
		}

		internal bool IsSetDomain()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
