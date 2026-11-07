using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200005B")]
	public class AdminUpdateAuthEventFeedbackRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x30")]
		private string _eventId;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x38")]
		private FeedbackValueType _feedbackValue;

		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x40")]
		private string _username;

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x48")]
		private string _userPoolId;

		[Token(Token = "0x1700007C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C178", Offset = "0x1C178")]
		public string EventId
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x10C08C0", Offset = "0x10C08C0", VA = "0x10C08C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x10C08C8", Offset = "0x10C08C8", VA = "0x10C08C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C1C8", Offset = "0x1C1C8")]
		public FeedbackValueType FeedbackValue
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x10C08E0", Offset = "0x10C08E0", VA = "0x10C08E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x10C08E8", Offset = "0x10C08E8", VA = "0x10C08E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C1FC", Offset = "0x1C1FC")]
		public string Username
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x10C096C", Offset = "0x10C096C", VA = "0x10C096C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x10C0974", Offset = "0x10C0974", VA = "0x10C0974")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C24C", Offset = "0x1C24C")]
		public string UserPoolId
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x10C098C", Offset = "0x10C098C", VA = "0x10C098C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x10C0994", Offset = "0x10C0994", VA = "0x10C0994")]
			set
			{
			}
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x10C08D0", Offset = "0x10C08D0", VA = "0x10C08D0")]
		internal bool IsSetEventId()
		{
			return default;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x10C08F0", Offset = "0x10C08F0", VA = "0x10C08F0")]
		internal bool IsSetFeedbackValue()
		{
			return default;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x10C097C", Offset = "0x10C097C", VA = "0x10C097C")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x10C099C", Offset = "0x10C099C", VA = "0x10C099C")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x10C09AC", Offset = "0x10C09AC", VA = "0x10C09AC")]
		public AdminUpdateAuthEventFeedbackRequest()
		{
		}
	}
}
