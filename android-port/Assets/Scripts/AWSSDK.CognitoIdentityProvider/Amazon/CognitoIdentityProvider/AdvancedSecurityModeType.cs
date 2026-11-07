using Amazon.Runtime;

namespace Amazon.CognitoIdentityProvider
{
	public class AdvancedSecurityModeType : ConstantClass
	{
		public static readonly AdvancedSecurityModeType AUDIT;

		public static readonly AdvancedSecurityModeType ENFORCED;

		public static readonly AdvancedSecurityModeType OFF;

		public AdvancedSecurityModeType(string value)
			: base(null)
		{
		}

		public static AdvancedSecurityModeType FindValue(string value)
		{
			return null;
		}

		public static implicit operator AdvancedSecurityModeType(string value)
		{
			return null;
		}
	}
}
