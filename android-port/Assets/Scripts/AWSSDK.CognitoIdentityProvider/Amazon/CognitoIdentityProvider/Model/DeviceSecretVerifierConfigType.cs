using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000A9")]
	public class DeviceSecretVerifierConfigType
	{
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x10")]
		private string _passwordVerifier;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x18")]
		private string _salt;

		[Token(Token = "0x1700012D")]
		public string PasswordVerifier
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x110EFE8", Offset = "0x110EFE8", VA = "0x110EFE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x110EFF0", Offset = "0x110EFF0", VA = "0x110EFF0")]
			set
			{
			}
		}

		[Token(Token = "0x1700012E")]
		public string Salt
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x110F008", Offset = "0x110F008", VA = "0x110F008")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x110F010", Offset = "0x110F010", VA = "0x110F010")]
			set
			{
			}
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x110EFF8", Offset = "0x110EFF8", VA = "0x110EFF8")]
		internal bool IsSetPasswordVerifier()
		{
			return default;
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x110F018", Offset = "0x110F018", VA = "0x110F018")]
		internal bool IsSetSalt()
		{
			return default;
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x110F028", Offset = "0x110F028", VA = "0x110F028")]
		public DeviceSecretVerifierConfigType()
		{
		}
	}
}
