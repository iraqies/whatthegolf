using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AccountTakeoverRiskConfigurationType
	{
		private AccountTakeoverActionsType _actions;

		private NotifyConfigurationType _notifyConfiguration;

		[AWSProperty]
		public AccountTakeoverActionsType Actions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public NotifyConfigurationType NotifyConfiguration
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetActions()
		{
			return false;
		}

		internal bool IsSetNotifyConfiguration()
		{
			return false;
		}
	}
}
