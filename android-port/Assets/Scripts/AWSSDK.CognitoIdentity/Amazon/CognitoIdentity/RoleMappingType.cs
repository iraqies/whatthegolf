using Amazon.Runtime;

namespace Amazon.CognitoIdentity
{
	public class RoleMappingType : ConstantClass
	{
		public static readonly RoleMappingType Rules;

		public static readonly RoleMappingType Token;

		public RoleMappingType(string value)
			: base(null)
		{
		}

		public static RoleMappingType FindValue(string value)
		{
			return null;
		}

		public static implicit operator RoleMappingType(string value)
		{
			return null;
		}
	}
}
