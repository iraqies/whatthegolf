using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AccountTakeoverActionType
	{
		private AccountTakeoverEventActionType _eventAction;

		private bool? _notify;

		[AWSProperty]
		public AccountTakeoverEventActionType EventAction
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
		public bool Notify
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool IsSetEventAction()
		{
			return false;
		}

		internal bool IsSetNotify()
		{
			return false;
		}
	}
}
