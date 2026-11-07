using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000118")]
	public class SoftwareTokenMfaConfigType
	{
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x10")]
		private bool? _enabled;

		[Token(Token = "0x1700023C")]
		public bool Enabled
		{
			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x1156E38", Offset = "0x1156E38", VA = "0x1156E38")]
			get
			{
				return default;
			}
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x1156E78", Offset = "0x1156E78", VA = "0x1156E78")]
			set
			{
			}
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x1156EEC", Offset = "0x1156EEC", VA = "0x1156EEC")]
		internal bool IsSetEnabled()
		{
			return default;
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x1156F2C", Offset = "0x1156F2C", VA = "0x1156F2C")]
		public SoftwareTokenMfaConfigType()
		{
		}
	}
}
