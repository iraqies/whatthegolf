using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AdminSetUserPasswordRequest : AmazonCognitoIdentityProviderRequest
	{
		private string _password;

		private bool? _permanent;

		private string _username;

		private string _userPoolId;

		[AWSProperty]
		public string Password
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Permanent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[AWSProperty]
		public string Username
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

		internal bool IsSetPassword()
		{
			return false;
		}

		internal bool IsSetPermanent()
		{
			return false;
		}

		internal bool IsSetUsername()
		{
			return false;
		}

		internal bool IsSetUserPoolId()
		{
			return false;
		}
	}
}
