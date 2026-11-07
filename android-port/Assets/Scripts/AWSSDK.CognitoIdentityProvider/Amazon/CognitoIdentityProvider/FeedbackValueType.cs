using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class FeedbackValueType : ConstantClass
	{
		public static readonly FeedbackValueType Invalid;

		public static readonly FeedbackValueType Valid;

		public FeedbackValueType(string value)
			: base(null)
		{
		}

		public static FeedbackValueType FindValue(string value)
		{
			return null;
		}

		public static implicit operator FeedbackValueType(string value)
		{
			return null;
		}
	}
}
