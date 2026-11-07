using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
	public class UnprocessedIdentityId
	{
		private ErrorCode _errorCode;

		private string _identityId;

		public ErrorCode ErrorCode
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
		public string IdentityId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool IsSetErrorCode()
		{
			return false;
		}

		internal bool IsSetIdentityId()
		{
			return false;
		}
	}
}
