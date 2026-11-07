using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider.Model
{
	public class StopUserImportJobResponse : AmazonWebServiceResponse
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
