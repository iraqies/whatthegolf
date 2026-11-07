using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x200000A")]
	public class ChallengeName : ConstantClass
	{
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ChallengeName Mfa;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ChallengeName Password;

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x10E046C", Offset = "0x10E046C", VA = "0x10E046C")]
		public ChallengeName(string value)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x10E04F8", Offset = "0x10E04F8", VA = "0x10E04F8")]
		public static ChallengeName FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x10E0588", Offset = "0x10E0588", VA = "0x10E0588")]
		public static implicit operator ChallengeName(string value)
		{
			return null;
		}
	}
}
