using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000006")]
	public class AdvancedSecurityModeType : ConstantClass
	{
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AdvancedSecurityModeType AUDIT;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x8")]
		public static readonly AdvancedSecurityModeType ENFORCED;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x10")]
		public static readonly AdvancedSecurityModeType OFF;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x10C6E54", Offset = "0x10C6E54", VA = "0x10C6E54")]
		public AdvancedSecurityModeType(string value)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x10C6EE0", Offset = "0x10C6EE0", VA = "0x10C6EE0")]
		public static AdvancedSecurityModeType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x10C6F70", Offset = "0x10C6F70", VA = "0x10C6F70")]
		public static implicit operator AdvancedSecurityModeType(string value)
		{
			return null;
		}
	}
}
