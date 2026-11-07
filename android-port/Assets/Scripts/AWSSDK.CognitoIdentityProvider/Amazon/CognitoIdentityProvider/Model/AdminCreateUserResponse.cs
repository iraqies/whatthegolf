using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class AdminCreateUserResponse : AmazonWebServiceResponse
	{
		private UserType _user;

		public UserType User
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetUser()
		{
			return false;
		}
	}
}
