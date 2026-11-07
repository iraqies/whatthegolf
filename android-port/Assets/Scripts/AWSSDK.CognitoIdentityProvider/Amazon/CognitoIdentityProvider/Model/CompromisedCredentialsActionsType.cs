using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class CompromisedCredentialsActionsType
	{
		private CompromisedCredentialsEventActionType _eventAction;

		[AWSProperty]
		public CompromisedCredentialsEventActionType EventAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetEventAction()
		{
			return false;
		}
	}
}
