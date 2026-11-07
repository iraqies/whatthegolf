using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
	public class AssumedRoleUser
	{
		private string _arn;

		private string _assumedRoleId;

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
		public string AssumedRoleId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetArn()
		{
			return false;
		}

		internal bool IsSetAssumedRoleId()
		{
			return false;
		}
	}
}
