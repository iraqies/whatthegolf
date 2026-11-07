using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000052")]
	public class UnprocessedIdentityId
	{
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x10")]
		private ErrorCode _errorCode;

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x18")]
		private string _identityId;

		[Token(Token = "0x1700008F")]
		public ErrorCode ErrorCode
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x1184B64", Offset = "0x1184B64", VA = "0x1184B64")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x1184B6C", Offset = "0x1184B6C", VA = "0x1184B6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23B94", Offset = "0x23B94")]
		public string IdentityId
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x1184BF0", Offset = "0x1184BF0", VA = "0x1184BF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x1184BF8", Offset = "0x1184BF8", VA = "0x1184BF8")]
			set
			{
			}
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1184B74", Offset = "0x1184B74", VA = "0x1184B74")]
		internal bool IsSetErrorCode()
		{
			return default;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1184C00", Offset = "0x1184C00", VA = "0x1184C00")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1184C10", Offset = "0x1184C10", VA = "0x1184C10")]
		public UnprocessedIdentityId()
		{
		}
	}
}
