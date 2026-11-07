using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200011A")]
	public class SoftwareTokenMfaSettingsType
	{
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x10")]
		private bool? _enabled;

		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x12")]
		private bool? _preferredMfa;

		[Token(Token = "0x1700023D")]
		public bool Enabled
		{
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x11570A8", Offset = "0x11570A8", VA = "0x11570A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x11570E8", Offset = "0x11570E8", VA = "0x11570E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700023E")]
		public bool PreferredMfa
		{
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x115719C", Offset = "0x115719C", VA = "0x115719C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x11571DC", Offset = "0x11571DC", VA = "0x11571DC")]
			set
			{
			}
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x115715C", Offset = "0x115715C", VA = "0x115715C")]
		internal bool IsSetEnabled()
		{
			return default;
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x1157250", Offset = "0x1157250", VA = "0x1157250")]
		internal bool IsSetPreferredMfa()
		{
			return default;
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x1157290", Offset = "0x1157290", VA = "0x1157290")]
		public SoftwareTokenMfaSettingsType()
		{
		}
	}
}
