using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class IdentityPoolShortDescription
	{
		private string _identityPoolId;

		private string _identityPoolName;

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

		[AWSProperty]
		public string IdentityPoolName
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

		internal bool IsSetIdentityPoolName()
		{
			return false;
		}
	}
}
