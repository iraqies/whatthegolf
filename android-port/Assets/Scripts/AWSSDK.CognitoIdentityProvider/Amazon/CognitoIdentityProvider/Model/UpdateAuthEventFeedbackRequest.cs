using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200012A")]
	public class UpdateAuthEventFeedbackRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40002C5")]
		[FieldOffset(Offset = "0x30")]
		private string _eventId;

		[Token(Token = "0x40002C6")]
		[FieldOffset(Offset = "0x38")]
		private string _feedbackToken;

		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x40")]
		private FeedbackValueType _feedbackValue;

		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x48")]
		private string _username;

		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x50")]
		private string _userPoolId;

		[Token(Token = "0x17000252")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x209B4", Offset = "0x209B4")]
		public string EventId
		{
			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x115F298", Offset = "0x115F298", VA = "0x115F298")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x115F2A0", Offset = "0x115F2A0", VA = "0x115F2A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000253")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20A04", Offset = "0x20A04")]
		public string FeedbackToken
		{
			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x115F2B8", Offset = "0x115F2B8", VA = "0x115F2B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x115F2C0", Offset = "0x115F2C0", VA = "0x115F2C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000254")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20A38", Offset = "0x20A38")]
		public FeedbackValueType FeedbackValue
		{
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x115F2D8", Offset = "0x115F2D8", VA = "0x115F2D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x115F2E0", Offset = "0x115F2E0", VA = "0x115F2E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000255")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20A6C", Offset = "0x20A6C")]
		public string Username
		{
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x115F364", Offset = "0x115F364", VA = "0x115F364")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x115F36C", Offset = "0x115F36C", VA = "0x115F36C")]
			set
			{
			}
		}

		[Token(Token = "0x17000256")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20ABC", Offset = "0x20ABC")]
		public string UserPoolId
		{
			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x115F384", Offset = "0x115F384", VA = "0x115F384")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x115F38C", Offset = "0x115F38C", VA = "0x115F38C")]
			set
			{
			}
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x115F2A8", Offset = "0x115F2A8", VA = "0x115F2A8")]
		internal bool IsSetEventId()
		{
			return default;
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x115F2C8", Offset = "0x115F2C8", VA = "0x115F2C8")]
		internal bool IsSetFeedbackToken()
		{
			return default;
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x115F2E8", Offset = "0x115F2E8", VA = "0x115F2E8")]
		internal bool IsSetFeedbackValue()
		{
			return default;
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x115F374", Offset = "0x115F374", VA = "0x115F374")]
		internal bool IsSetUsername()
		{
			return default;
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x115F394", Offset = "0x115F394", VA = "0x115F394")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x115F3A4", Offset = "0x115F3A4", VA = "0x115F3A4")]
		public UpdateAuthEventFeedbackRequest()
		{
		}
	}
}
