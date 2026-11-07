using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000F5")]
	public class NotifyConfigurationType
	{
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x10")]
		private NotifyEmailType _blockEmail;

		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x18")]
		private string _from;

		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x20")]
		private NotifyEmailType _mfaEmail;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x28")]
		private NotifyEmailType _noActionEmail;

		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x30")]
		private string _replyTo;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x38")]
		private string _sourceArn;

		[Token(Token = "0x170001D2")]
		public NotifyEmailType BlockEmail
		{
			[Token(Token = "0x600085A")]
			[Address(RVA = "0x113E26C", Offset = "0x113E26C", VA = "0x113E26C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085B")]
			[Address(RVA = "0x113E274", Offset = "0x113E274", VA = "0x113E274")]
			set
			{
			}
		}

		[Token(Token = "0x170001D3")]
		public string From
		{
			[Token(Token = "0x600085D")]
			[Address(RVA = "0x113E28C", Offset = "0x113E28C", VA = "0x113E28C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085E")]
			[Address(RVA = "0x113E294", Offset = "0x113E294", VA = "0x113E294")]
			set
			{
			}
		}

		[Token(Token = "0x170001D4")]
		public NotifyEmailType MfaEmail
		{
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x113E2AC", Offset = "0x113E2AC", VA = "0x113E2AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x113E2B4", Offset = "0x113E2B4", VA = "0x113E2B4")]
			set
			{
			}
		}

		[Token(Token = "0x170001D5")]
		public NotifyEmailType NoActionEmail
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0x113E2CC", Offset = "0x113E2CC", VA = "0x113E2CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x113E2D4", Offset = "0x113E2D4", VA = "0x113E2D4")]
			set
			{
			}
		}

		[Token(Token = "0x170001D6")]
		public string ReplyTo
		{
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x113E2EC", Offset = "0x113E2EC", VA = "0x113E2EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x113E2F4", Offset = "0x113E2F4", VA = "0x113E2F4")]
			set
			{
			}
		}

		[Token(Token = "0x170001D7")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1FA58", Offset = "0x1FA58")]
		public string SourceArn
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x113E30C", Offset = "0x113E30C", VA = "0x113E30C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086A")]
			[Address(RVA = "0x113E314", Offset = "0x113E314", VA = "0x113E314")]
			set
			{
			}
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x113E27C", Offset = "0x113E27C", VA = "0x113E27C")]
		internal bool IsSetBlockEmail()
		{
			return default;
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x113E29C", Offset = "0x113E29C", VA = "0x113E29C")]
		internal bool IsSetFrom()
		{
			return default;
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x113E2BC", Offset = "0x113E2BC", VA = "0x113E2BC")]
		internal bool IsSetMfaEmail()
		{
			return default;
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x113E2DC", Offset = "0x113E2DC", VA = "0x113E2DC")]
		internal bool IsSetNoActionEmail()
		{
			return default;
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x113E2FC", Offset = "0x113E2FC", VA = "0x113E2FC")]
		internal bool IsSetReplyTo()
		{
			return default;
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x113E31C", Offset = "0x113E31C", VA = "0x113E31C")]
		internal bool IsSetSourceArn()
		{
			return default;
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x113E32C", Offset = "0x113E32C", VA = "0x113E32C")]
		public NotifyConfigurationType()
		{
		}
	}
}
