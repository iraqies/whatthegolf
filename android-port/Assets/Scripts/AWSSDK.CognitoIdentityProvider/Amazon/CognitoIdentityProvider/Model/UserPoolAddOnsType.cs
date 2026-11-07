using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UserPoolAddOnsType
	{
		private AdvancedSecurityModeType _advancedSecurityMode;

		[AWSProperty]
		public AdvancedSecurityModeType AdvancedSecurityMode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetAdvancedSecurityMode()
		{
			return false;
		}
	}
}
