using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
	public class GetCognitoEventsRequest : AmazonCognitoSyncRequest
	{
		private string _identityPoolId;

		[AWSProperty]
		public string IdentityPoolId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetIdentityPoolId()
		{
			return false;
		}
	}
}
