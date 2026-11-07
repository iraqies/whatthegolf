using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x200001E")]
	public class RiskLevelType : ConstantClass
	{
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RiskLevelType High;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x8")]
		public static readonly RiskLevelType Low;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x10")]
		public static readonly RiskLevelType Medium;

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1149D50", Offset = "0x1149D50", VA = "0x1149D50")]
		public RiskLevelType(string value)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1149DDC", Offset = "0x1149DDC", VA = "0x1149DDC")]
		public static RiskLevelType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1149E6C", Offset = "0x1149E6C", VA = "0x1149E6C")]
		public static implicit operator RiskLevelType(string value)
		{
			return null;
		}
	}
}
