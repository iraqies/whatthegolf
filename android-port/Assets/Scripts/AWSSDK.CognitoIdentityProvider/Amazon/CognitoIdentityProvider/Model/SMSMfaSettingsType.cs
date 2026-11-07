using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000117")]
	public class SMSMfaSettingsType
	{
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x10")]
		private bool? _enabled;

		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x12")]
		private bool? _preferredMfa;

		[Token(Token = "0x1700023A")]
		public bool Enabled
		{
			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x114A0DC", Offset = "0x114A0DC", VA = "0x114A0DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x114A11C", Offset = "0x114A11C", VA = "0x114A11C")]
			set
			{
			}
		}

		[Token(Token = "0x1700023B")]
		public bool PreferredMfa
		{
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x114A1D0", Offset = "0x114A1D0", VA = "0x114A1D0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x114A210", Offset = "0x114A210", VA = "0x114A210")]
			set
			{
			}
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x114A190", Offset = "0x114A190", VA = "0x114A190")]
		internal bool IsSetEnabled()
		{
			return default;
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x114A284", Offset = "0x114A284", VA = "0x114A284")]
		internal bool IsSetPreferredMfa()
		{
			return default;
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x114A2C4", Offset = "0x114A2C4", VA = "0x114A2C4")]
		public SMSMfaSettingsType()
		{
		}
	}
}
