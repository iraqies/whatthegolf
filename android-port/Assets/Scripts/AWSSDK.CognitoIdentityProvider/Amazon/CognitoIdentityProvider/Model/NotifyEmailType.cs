using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000F6")]
	public class NotifyEmailType
	{
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x10")]
		private string _htmlBody;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x18")]
		private string _subject;

		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x20")]
		private string _textBody;

		[Token(Token = "0x170001D8")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FAA8", Offset = "0x1FAA8")]
		public string HtmlBody
		{
			[Token(Token = "0x600086D")]
			[Address(RVA = "0x113F060", Offset = "0x113F060", VA = "0x113F060")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x113F068", Offset = "0x113F068", VA = "0x113F068")]
			set
			{
			}
		}

		[Token(Token = "0x170001D9")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FAF0", Offset = "0x1FAF0")]
		public string Subject
		{
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x113F080", Offset = "0x113F080", VA = "0x113F080")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000871")]
			[Address(RVA = "0x113F088", Offset = "0x113F088", VA = "0x113F088")]
			set
			{
			}
		}

		[Token(Token = "0x170001DA")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FB40", Offset = "0x1FB40")]
		public string TextBody
		{
			[Token(Token = "0x6000873")]
			[Address(RVA = "0x113F0A0", Offset = "0x113F0A0", VA = "0x113F0A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000874")]
			[Address(RVA = "0x113F0A8", Offset = "0x113F0A8", VA = "0x113F0A8")]
			set
			{
			}
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x113F070", Offset = "0x113F070", VA = "0x113F070")]
		internal bool IsSetHtmlBody()
		{
			return default;
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x113F090", Offset = "0x113F090", VA = "0x113F090")]
		internal bool IsSetSubject()
		{
			return default;
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x113F0B0", Offset = "0x113F0B0", VA = "0x113F0B0")]
		internal bool IsSetTextBody()
		{
			return default;
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x113F0C0", Offset = "0x113F0C0", VA = "0x113F0C0")]
		public NotifyEmailType()
		{
		}
	}
}
