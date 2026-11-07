using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class RiskLevelType : ConstantClass
	{
		public static readonly RiskLevelType High;

		public static readonly RiskLevelType Low;

		public static readonly RiskLevelType Medium;

		public RiskLevelType(string value)
			: base(null)
		{
		}

		public static RiskLevelType FindValue(string value)
		{
			return null;
		}

		public static implicit operator RiskLevelType(string value)
		{
			return null;
		}
	}
}
