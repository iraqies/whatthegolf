using System.Collections.Generic;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class CompromisedCredentialsRiskConfigurationType
	{
		private CompromisedCredentialsActionsType _actions;

		private List<string> _eventFilter;

		[AWSProperty]
		public CompromisedCredentialsActionsType Actions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<string> EventFilter
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

		internal bool IsSetEventFilter()
		{
			return false;
		}
	}
}
