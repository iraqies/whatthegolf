using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AccountRecoverySettingType
	{
		private List<RecoveryOptionType> _recoveryMechanisms;

		[AWSProperty]
		public List<RecoveryOptionType> RecoveryMechanisms
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetRecoveryMechanisms()
		{
			return false;
		}
	}
}
