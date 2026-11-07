using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity
{
	[Token(Token = "0x2000013")]
	public class AmbiguousRoleResolutionType : ConstantClass
	{
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AmbiguousRoleResolutionType AuthenticatedRole;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x8")]
		public static readonly AmbiguousRoleResolutionType Deny;

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1075EAC", Offset = "0x1075EAC", VA = "0x1075EAC")]
		public AmbiguousRoleResolutionType(string value)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1075F38", Offset = "0x1075F38", VA = "0x1075F38")]
		public static AmbiguousRoleResolutionType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1075FC8", Offset = "0x1075FC8", VA = "0x1075FC8")]
		public static implicit operator AmbiguousRoleResolutionType(string value)
		{
			return null;
		}
	}
}
