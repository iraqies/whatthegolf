using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000146")]
	public class UserPoolClientDescription
	{
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x10")]
		private string _clientId;

		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x18")]
		private string _clientName;

		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x20")]
		private string _userPoolId;

		[Token(Token = "0x170002A5")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x216F4", Offset = "0x216F4")]
		public string ClientId
		{
			[Token(Token = "0x6000B69")]
			[Address(RVA = "0x1173A98", Offset = "0x1173A98", VA = "0x1173A98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B6A")]
			[Address(RVA = "0x1173AA0", Offset = "0x1173AA0", VA = "0x1173AA0")]
			set
			{
			}
		}

		[Token(Token = "0x170002A6")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2173C", Offset = "0x2173C")]
		public string ClientName
		{
			[Token(Token = "0x6000B6C")]
			[Address(RVA = "0x1173AB8", Offset = "0x1173AB8", VA = "0x1173AB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B6D")]
			[Address(RVA = "0x1173AC0", Offset = "0x1173AC0", VA = "0x1173AC0")]
			set
			{
			}
		}

		[Token(Token = "0x170002A7")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21784", Offset = "0x21784")]
		public string UserPoolId
		{
			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0x1173AD8", Offset = "0x1173AD8", VA = "0x1173AD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x1173AE0", Offset = "0x1173AE0", VA = "0x1173AE0")]
			set
			{
			}
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x1173AA8", Offset = "0x1173AA8", VA = "0x1173AA8")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x1173AC8", Offset = "0x1173AC8", VA = "0x1173AC8")]
		internal bool IsSetClientName()
		{
			return default;
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x1173AE8", Offset = "0x1173AE8", VA = "0x1173AE8")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x1173AF8", Offset = "0x1173AF8", VA = "0x1173AF8")]
		public UserPoolClientDescription()
		{
		}
	}
}
