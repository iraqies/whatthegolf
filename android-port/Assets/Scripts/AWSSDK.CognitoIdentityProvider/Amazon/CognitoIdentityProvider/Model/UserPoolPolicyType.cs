using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000149")]
	public class UserPoolPolicyType
	{
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x10")]
		private PasswordPolicyType _passwordPolicy;

		[Token(Token = "0x170002C1")]
		public PasswordPolicyType PasswordPolicy
		{
			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0x11756C0", Offset = "0x11756C0", VA = "0x11756C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BC1")]
			[Address(RVA = "0x11756C8", Offset = "0x11756C8", VA = "0x11756C8")]
			set
			{
			}
		}

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x11756D0", Offset = "0x11756D0", VA = "0x11756D0")]
		internal bool IsSetPasswordPolicy()
		{
			return default;
		}

		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x11756E0", Offset = "0x11756E0", VA = "0x11756E0")]
		public UserPoolPolicyType()
		{
		}
	}
}
