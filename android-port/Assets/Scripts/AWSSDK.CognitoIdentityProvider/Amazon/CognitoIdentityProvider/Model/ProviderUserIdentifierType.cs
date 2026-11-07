using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ProviderUserIdentifierType
	{
		private string _providerAttributeName;

		private string _providerAttributeValue;

		private string _providerName;

		public string ProviderAttributeName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ProviderAttributeValue
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
		public string ProviderName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetProviderAttributeName()
		{
			return false;
		}

		internal bool IsSetProviderAttributeValue()
		{
			return false;
		}

		internal bool IsSetProviderName()
		{
			return false;
		}
	}
}
