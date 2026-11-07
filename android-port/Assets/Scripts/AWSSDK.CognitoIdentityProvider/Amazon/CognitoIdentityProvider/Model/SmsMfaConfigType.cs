using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000116")]
	public class SmsMfaConfigType
	{
		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x10")]
		private string _smsAuthenticationMessage;

		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x18")]
		private SmsConfigurationType _smsConfiguration;

		[Token(Token = "0x17000238")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20694", Offset = "0x20694")]
		public string SmsAuthenticationMessage
		{
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x1156B20", Offset = "0x1156B20", VA = "0x1156B20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x1156B28", Offset = "0x1156B28", VA = "0x1156B28")]
			set
			{
			}
		}

		[Token(Token = "0x17000239")]
		public SmsConfigurationType SmsConfiguration
		{
			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x1156B40", Offset = "0x1156B40", VA = "0x1156B40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x1156B48", Offset = "0x1156B48", VA = "0x1156B48")]
			set
			{
			}
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x1156B30", Offset = "0x1156B30", VA = "0x1156B30")]
		internal bool IsSetSmsAuthenticationMessage()
		{
			return default;
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x1156B50", Offset = "0x1156B50", VA = "0x1156B50")]
		internal bool IsSetSmsConfiguration()
		{
			return default;
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x1156B60", Offset = "0x1156B60", VA = "0x1156B60")]
		public SmsMfaConfigType()
		{
		}
	}
}
