using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x200001D")]
	public class RiskDecisionType : ConstantClass
	{
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RiskDecisionType AccountTakeover;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x8")]
		public static readonly RiskDecisionType Block;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x10")]
		public static readonly RiskDecisionType NoRisk;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1149398", Offset = "0x1149398", VA = "0x1149398")]
		public RiskDecisionType(string value)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1149424", Offset = "0x1149424", VA = "0x1149424")]
		public static RiskDecisionType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x11494B4", Offset = "0x11494B4", VA = "0x11494B4")]
		public static implicit operator RiskDecisionType(string value)
		{
			return null;
		}
	}
}
