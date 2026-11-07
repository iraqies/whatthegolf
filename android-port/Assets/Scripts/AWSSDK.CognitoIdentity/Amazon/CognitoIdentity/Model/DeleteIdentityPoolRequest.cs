using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class DeleteIdentityPoolRequest : AmazonCognitoIdentityRequest
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
