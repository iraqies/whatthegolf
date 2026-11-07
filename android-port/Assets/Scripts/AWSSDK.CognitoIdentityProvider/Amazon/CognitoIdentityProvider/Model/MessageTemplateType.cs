using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000F0")]
	public class MessageTemplateType
	{
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x10")]
		private string _emailMessage;

		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x18")]
		private string _emailSubject;

		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x20")]
		private string _smsMessage;

		[Token(Token = "0x170001CB")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F8F0", Offset = "0x1F8F0")]
		public string EmailMessage
		{
			[Token(Token = "0x6000838")]
			[Address(RVA = "0x113D77C", Offset = "0x113D77C", VA = "0x113D77C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x113D784", Offset = "0x113D784", VA = "0x113D784")]
			set
			{
			}
		}

		[Token(Token = "0x170001CC")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F938", Offset = "0x1F938")]
		public string EmailSubject
		{
			[Token(Token = "0x600083B")]
			[Address(RVA = "0x113D79C", Offset = "0x113D79C", VA = "0x113D79C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600083C")]
			[Address(RVA = "0x113D7A4", Offset = "0x113D7A4", VA = "0x113D7A4")]
			set
			{
			}
		}

		[Token(Token = "0x170001CD")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F980", Offset = "0x1F980")]
		public string SMSMessage
		{
			[Token(Token = "0x600083E")]
			[Address(RVA = "0x113D7BC", Offset = "0x113D7BC", VA = "0x113D7BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x113D7C4", Offset = "0x113D7C4", VA = "0x113D7C4")]
			set
			{
			}
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x113D78C", Offset = "0x113D78C", VA = "0x113D78C")]
		internal bool IsSetEmailMessage()
		{
			return default;
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x113D7AC", Offset = "0x113D7AC", VA = "0x113D7AC")]
		internal bool IsSetEmailSubject()
		{
			return default;
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x113D7CC", Offset = "0x113D7CC", VA = "0x113D7CC")]
		internal bool IsSetSMSMessage()
		{
			return default;
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x113D7DC", Offset = "0x113D7DC", VA = "0x113D7DC")]
		public MessageTemplateType()
		{
		}
	}
}
