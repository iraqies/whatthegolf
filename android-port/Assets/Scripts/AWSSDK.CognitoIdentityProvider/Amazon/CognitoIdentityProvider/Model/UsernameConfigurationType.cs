using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class UsernameConfigurationType
	{
		private bool? _caseSensitive;

		[AWSProperty]
		public bool CaseSensitive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool IsSetCaseSensitive()
		{
			return false;
		}
	}
}
