using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class CreateUserImportJobResponse : AmazonWebServiceResponse
	{
		private UserImportJobType _userImportJob;

		public UserImportJobType UserImportJob
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetUserImportJob()
		{
			return false;
		}
	}
}
