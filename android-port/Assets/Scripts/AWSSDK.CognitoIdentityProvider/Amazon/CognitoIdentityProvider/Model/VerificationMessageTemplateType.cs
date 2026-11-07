using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200014D")]
	public class VerificationMessageTemplateType
	{
		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x10")]
		private DefaultEmailOptionType _defaultEmailOption;

		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x18")]
		private string _emailMessage;

		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x20")]
		private string _emailMessageByLink;

		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x28")]
		private string _emailSubject;

		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x30")]
		private string _emailSubjectByLink;

		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x38")]
		private string _smsMessage;

		[Token(Token = "0x170002E8")]
		public DefaultEmailOptionType DefaultEmailOption
		{
			[Token(Token = "0x6000C3D")]
			[Address(RVA = "0x1179D2C", Offset = "0x1179D2C", VA = "0x1179D2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0x1179D34", Offset = "0x1179D34", VA = "0x1179D34")]
			set
			{
			}
		}

		[Token(Token = "0x170002E9")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21E34", Offset = "0x21E34")]
		public string EmailMessage
		{
			[Token(Token = "0x6000C40")]
			[Address(RVA = "0x1179DB8", Offset = "0x1179DB8", VA = "0x1179DB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C41")]
			[Address(RVA = "0x1179DC0", Offset = "0x1179DC0", VA = "0x1179DC0")]
			set
			{
			}
		}

		[Token(Token = "0x170002EA")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21E7C", Offset = "0x21E7C")]
		public string EmailMessageByLink
		{
			[Token(Token = "0x6000C43")]
			[Address(RVA = "0x1179DD8", Offset = "0x1179DD8", VA = "0x1179DD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C44")]
			[Address(RVA = "0x1179DE0", Offset = "0x1179DE0", VA = "0x1179DE0")]
			set
			{
			}
		}

		[Token(Token = "0x170002EB")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21EC4", Offset = "0x21EC4")]
		public string EmailSubject
		{
			[Token(Token = "0x6000C46")]
			[Address(RVA = "0x1179DF8", Offset = "0x1179DF8", VA = "0x1179DF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C47")]
			[Address(RVA = "0x1179E00", Offset = "0x1179E00", VA = "0x1179E00")]
			set
			{
			}
		}

		[Token(Token = "0x170002EC")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21F0C", Offset = "0x21F0C")]
		public string EmailSubjectByLink
		{
			[Token(Token = "0x6000C49")]
			[Address(RVA = "0x1179E18", Offset = "0x1179E18", VA = "0x1179E18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C4A")]
			[Address(RVA = "0x1179E20", Offset = "0x1179E20", VA = "0x1179E20")]
			set
			{
			}
		}

		[Token(Token = "0x170002ED")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21F54", Offset = "0x21F54")]
		public string SmsMessage
		{
			[Token(Token = "0x6000C4C")]
			[Address(RVA = "0x1179E38", Offset = "0x1179E38", VA = "0x1179E38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C4D")]
			[Address(RVA = "0x1179E40", Offset = "0x1179E40", VA = "0x1179E40")]
			set
			{
			}
		}

		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x1179D3C", Offset = "0x1179D3C", VA = "0x1179D3C")]
		internal bool IsSetDefaultEmailOption()
		{
			return default;
		}

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x1179DC8", Offset = "0x1179DC8", VA = "0x1179DC8")]
		internal bool IsSetEmailMessage()
		{
			return default;
		}

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x1179DE8", Offset = "0x1179DE8", VA = "0x1179DE8")]
		internal bool IsSetEmailMessageByLink()
		{
			return default;
		}

		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x1179E08", Offset = "0x1179E08", VA = "0x1179E08")]
		internal bool IsSetEmailSubject()
		{
			return default;
		}

		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x1179E28", Offset = "0x1179E28", VA = "0x1179E28")]
		internal bool IsSetEmailSubjectByLink()
		{
			return default;
		}

		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x1179E48", Offset = "0x1179E48", VA = "0x1179E48")]
		internal bool IsSetSmsMessage()
		{
			return default;
		}

		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x1179E58", Offset = "0x1179E58", VA = "0x1179E58")]
		public VerificationMessageTemplateType()
		{
		}
	}
}
