using Amazon.Runtime;

namespace Amazon.SecurityToken.Model
{
	public class GetSessionTokenResponse : AmazonWebServiceResponse
	{
		private Credentials _credentials;

		public Credentials Credentials
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetCredentials()
		{
			return false;
		}
	}
}
