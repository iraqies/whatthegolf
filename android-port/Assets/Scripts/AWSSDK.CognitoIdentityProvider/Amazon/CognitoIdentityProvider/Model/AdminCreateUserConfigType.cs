using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000032")]
	public class AdminCreateUserConfigType
	{
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x10")]
		private bool? _allowAdminCreateUserOnly;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x18")]
		private MessageTemplateType _inviteMessageTemplate;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x20")]
		private int? _unusedAccountValidityDays;

		[Token(Token = "0x17000015")]
		public bool AllowAdminCreateUserOnly
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x109DD78", Offset = "0x109DD78", VA = "0x109DD78")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x109DDB8", Offset = "0x109DDB8", VA = "0x109DDB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public MessageTemplateType InviteMessageTemplate
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x109DE6C", Offset = "0x109DE6C", VA = "0x109DE6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x109DE74", Offset = "0x109DE74", VA = "0x109DE74")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1AF10", Offset = "0x1AF10")]
		public int UnusedAccountValidityDays
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x109DE8C", Offset = "0x109DE8C", VA = "0x109DE8C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x109DECC", Offset = "0x109DECC", VA = "0x109DECC")]
			set
			{
			}
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x109DE2C", Offset = "0x109DE2C", VA = "0x109DE2C")]
		internal bool IsSetAllowAdminCreateUserOnly()
		{
			return default;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x109DE7C", Offset = "0x109DE7C", VA = "0x109DE7C")]
		internal bool IsSetInviteMessageTemplate()
		{
			return default;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x109DF40", Offset = "0x109DF40", VA = "0x109DF40")]
		internal bool IsSetUnusedAccountValidityDays()
		{
			return default;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x109DF80", Offset = "0x109DF80", VA = "0x109DF80")]
		public AdminCreateUserConfigType()
		{
		}
	}
}
