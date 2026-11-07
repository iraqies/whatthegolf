using Amazon.Runtime;

namespace Amazon.CognitoIdentity
{
	public class AmbiguousRoleResolutionType : ConstantClass
	{
		public static readonly AmbiguousRoleResolutionType AuthenticatedRole;

		public static readonly AmbiguousRoleResolutionType Deny;

		public AmbiguousRoleResolutionType(string value)
			: base(null)
		{
		}

		public static AmbiguousRoleResolutionType FindValue(string value)
		{
			return null;
		}

		public static implicit operator AmbiguousRoleResolutionType(string value)
		{
			return null;
		}
	}
}
