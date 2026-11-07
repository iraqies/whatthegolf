using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class ConfirmDeviceResponse : AmazonWebServiceResponse
	{
		private bool? _userConfirmationNecessary;

		public bool UserConfirmationNecessary
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool IsSetUserConfirmationNecessary()
		{
			return false;
		}
	}
}
