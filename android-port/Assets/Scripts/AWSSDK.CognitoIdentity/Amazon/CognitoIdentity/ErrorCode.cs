using Amazon.Runtime;

namespace Amazon.CognitoIdentity
{
	public class ErrorCode : ConstantClass
	{
		public static readonly ErrorCode AccessDenied;

		public static readonly ErrorCode InternalServerError;

		public ErrorCode(string value)
			: base(null)
		{
		}

		public static ErrorCode FindValue(string value)
		{
			return null;
		}

		public static implicit operator ErrorCode(string value)
		{
			return null;
		}
	}
}
