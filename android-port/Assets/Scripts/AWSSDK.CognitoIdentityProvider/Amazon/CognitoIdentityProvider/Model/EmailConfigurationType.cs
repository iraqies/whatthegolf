using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000AD")]
	public class EmailConfigurationType
	{
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x10")]
		private string _configurationSet;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x18")]
		private EmailSendingAccountType _emailSendingAccount;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x20")]
		private string _from;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x28")]
		private string _replyToEmailAddress;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x30")]
		private string _sourceArn;

		[Token(Token = "0x1700013C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E108", Offset = "0x1E108")]
		public string ConfigurationSet
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x111049C", Offset = "0x111049C", VA = "0x111049C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x11104A4", Offset = "0x11104A4", VA = "0x11104A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700013D")]
		public EmailSendingAccountType EmailSendingAccount
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x11104BC", Offset = "0x11104BC", VA = "0x11104BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x11104C4", Offset = "0x11104C4", VA = "0x11104C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public string From
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x1110548", Offset = "0x1110548", VA = "0x1110548")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x1110550", Offset = "0x1110550", VA = "0x1110550")]
			set
			{
			}
		}

		[Token(Token = "0x1700013F")]
		public string ReplyToEmailAddress
		{
			[Token(Token = "0x6000619")]
			[Address(RVA = "0x1110568", Offset = "0x1110568", VA = "0x1110568")]
			get
			{
				return null;
			}
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x1110570", Offset = "0x1110570", VA = "0x1110570")]
			set
			{
			}
		}

		[Token(Token = "0x17000140")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E150", Offset = "0x1E150")]
		public string SourceArn
		{
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x1110588", Offset = "0x1110588", VA = "0x1110588")]
			get
			{
				return null;
			}
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x1110590", Offset = "0x1110590", VA = "0x1110590")]
			set
			{
			}
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x11104AC", Offset = "0x11104AC", VA = "0x11104AC")]
		internal bool IsSetConfigurationSet()
		{
			return default;
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x11104CC", Offset = "0x11104CC", VA = "0x11104CC")]
		internal bool IsSetEmailSendingAccount()
		{
			return default;
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1110558", Offset = "0x1110558", VA = "0x1110558")]
		internal bool IsSetFrom()
		{
			return default;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1110578", Offset = "0x1110578", VA = "0x1110578")]
		internal bool IsSetReplyToEmailAddress()
		{
			return default;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x1110598", Offset = "0x1110598", VA = "0x1110598")]
		internal bool IsSetSourceArn()
		{
			return default;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x11105A8", Offset = "0x11105A8", VA = "0x11105A8")]
		public EmailConfigurationType()
		{
		}
	}
}
