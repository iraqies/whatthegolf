using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x200000B")]
	public class ChallengeNameType : ConstantClass
	{
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ChallengeNameType ADMIN_NO_SRP_AUTH;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x8")]
		public static readonly ChallengeNameType CUSTOM_CHALLENGE;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x10")]
		public static readonly ChallengeNameType DEVICE_PASSWORD_VERIFIER;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x18")]
		public static readonly ChallengeNameType DEVICE_SRP_AUTH;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x20")]
		public static readonly ChallengeNameType MFA_SETUP;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x28")]
		public static readonly ChallengeNameType NEW_PASSWORD_REQUIRED;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x30")]
		public static readonly ChallengeNameType PASSWORD_VERIFIER;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x38")]
		public static readonly ChallengeNameType SELECT_MFA_TYPE;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x40")]
		public static readonly ChallengeNameType SMS_MFA;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x48")]
		public static readonly ChallengeNameType SOFTWARE_TOKEN_MFA;

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x10E0788", Offset = "0x10E0788", VA = "0x10E0788")]
		public ChallengeNameType(string value)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x10E0814", Offset = "0x10E0814", VA = "0x10E0814")]
		public static ChallengeNameType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x10E08A4", Offset = "0x10E08A4", VA = "0x10E08A4")]
		public static implicit operator ChallengeNameType(string value)
		{
			return null;
		}
	}
}
