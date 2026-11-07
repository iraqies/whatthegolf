using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class RiskDecisionType : ConstantClass
	{
		public static readonly RiskDecisionType AccountTakeover;

		public static readonly RiskDecisionType Block;

		public static readonly RiskDecisionType NoRisk;

		public RiskDecisionType(string value)
			: base(null)
		{
		}

		public static RiskDecisionType FindValue(string value)
		{
			return null;
		}

		public static implicit operator RiskDecisionType(string value)
		{
			return null;
		}
	}
}
