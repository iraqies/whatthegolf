using Amazon.Runtime;

namespace Amazon.CognitoIdentity
{
	public class MappingRuleMatchType : ConstantClass
	{
		public static readonly MappingRuleMatchType Contains;

		public new static readonly MappingRuleMatchType Equals;

		public static readonly MappingRuleMatchType NotEqual;

		public static readonly MappingRuleMatchType StartsWith;

		public MappingRuleMatchType(string value)
			: base(null)
		{
		}

		public static MappingRuleMatchType FindValue(string value)
		{
			return null;
		}

		public static implicit operator MappingRuleMatchType(string value)
		{
			return null;
		}
	}
}
