using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class GetIdentityPoolRolesRequest : AmazonCognitoIdentityRequest
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
