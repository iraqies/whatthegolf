using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x200000C")]
	public class ChallengeResponse : ConstantClass
	{
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ChallengeResponse Failure;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ChallengeResponse Success;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x10E0E24", Offset = "0x10E0E24", VA = "0x10E0E24")]
		public ChallengeResponse(string value)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x10E0EB0", Offset = "0x10E0EB0", VA = "0x10E0EB0")]
		public static ChallengeResponse FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x10E0F40", Offset = "0x10E0F40", VA = "0x10E0F40")]
		public static implicit operator ChallengeResponse(string value)
		{
			return null;
		}
	}
}
