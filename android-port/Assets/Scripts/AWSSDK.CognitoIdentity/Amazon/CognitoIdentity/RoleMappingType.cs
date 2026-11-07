using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity
{
	[Token(Token = "0x2000016")]
	public class RoleMappingType : ConstantClass
	{
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RoleMappingType Rules;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x8")]
		public static readonly RoleMappingType Token;

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1096D50", Offset = "0x1096D50", VA = "0x1096D50")]
		public RoleMappingType(string value)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1096DDC", Offset = "0x1096DDC", VA = "0x1096DDC")]
		public static RoleMappingType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1096E6C", Offset = "0x1096E6C", VA = "0x1096E6C")]
		public static implicit operator RoleMappingType(string value)
		{
			return null;
		}
	}
}
