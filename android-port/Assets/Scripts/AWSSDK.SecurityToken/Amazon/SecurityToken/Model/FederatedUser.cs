using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class FederatedUser
	{
		private string _arn;

		private string _federatedUserId;

		[AWSProperty]
		public string Arn
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
		public string FederatedUserId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FederatedUser()
		{
		}

		public FederatedUser(string federatedUserId, string arn)
		{
		}

		internal bool IsSetArn()
		{
			return false;
		}

		internal bool IsSetFederatedUserId()
		{
			return false;
		}
	}
}
