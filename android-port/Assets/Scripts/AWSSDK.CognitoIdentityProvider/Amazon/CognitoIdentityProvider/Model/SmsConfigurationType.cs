using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000115")]
	public class SmsConfigurationType
	{
		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x10")]
		private string _externalId;

		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x18")]
		private string _snsCallerArn;

		[Token(Token = "0x17000236")]
		public string ExternalId
		{
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x115663C", Offset = "0x115663C", VA = "0x115663C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x1156644", Offset = "0x1156644", VA = "0x1156644")]
			set
			{
			}
		}

		[Token(Token = "0x17000237")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20644", Offset = "0x20644")]
		public string SnsCallerArn
		{
			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x115665C", Offset = "0x115665C", VA = "0x115665C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x1156664", Offset = "0x1156664", VA = "0x1156664")]
			set
			{
			}
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x115664C", Offset = "0x115664C", VA = "0x115664C")]
		internal bool IsSetExternalId()
		{
			return default;
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x115666C", Offset = "0x115666C", VA = "0x115666C")]
		internal bool IsSetSnsCallerArn()
		{
			return default;
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x115667C", Offset = "0x115667C", VA = "0x115667C")]
		public SmsConfigurationType()
		{
		}
	}
}
