using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200014E")]
	public class VerifySoftwareTokenRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x30")]
		private string _accessToken;

		[Token(Token = "0x4000362")]
		[FieldOffset(Offset = "0x38")]
		private string _friendlyDeviceName;

		[Token(Token = "0x4000363")]
		[FieldOffset(Offset = "0x40")]
		private string _session;

		[Token(Token = "0x4000364")]
		[FieldOffset(Offset = "0x48")]
		private string _userCode;

		[Token(Token = "0x170002EE")]
		public string AccessToken
		{
			[Token(Token = "0x6000C50")]
			[Address(RVA = "0x117AA90", Offset = "0x117AA90", VA = "0x117AA90")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C51")]
			[Address(RVA = "0x117AA98", Offset = "0x117AA98", VA = "0x117AA98")]
			set
			{
			}
		}

		[Token(Token = "0x170002EF")]
		public string FriendlyDeviceName
		{
			[Token(Token = "0x6000C53")]
			[Address(RVA = "0x117AAB0", Offset = "0x117AAB0", VA = "0x117AAB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C54")]
			[Address(RVA = "0x117AAB8", Offset = "0x117AAB8", VA = "0x117AAB8")]
			set
			{
			}
		}

		[Token(Token = "0x170002F0")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21F9C", Offset = "0x21F9C")]
		public string Session
		{
			[Token(Token = "0x6000C56")]
			[Address(RVA = "0x117AAD0", Offset = "0x117AAD0", VA = "0x117AAD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C57")]
			[Address(RVA = "0x117AAD8", Offset = "0x117AAD8", VA = "0x117AAD8")]
			set
			{
			}
		}

		[Token(Token = "0x170002F1")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21FE4", Offset = "0x21FE4")]
		public string UserCode
		{
			[Token(Token = "0x6000C59")]
			[Address(RVA = "0x117AAF0", Offset = "0x117AAF0", VA = "0x117AAF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C5A")]
			[Address(RVA = "0x117AAF8", Offset = "0x117AAF8", VA = "0x117AAF8")]
			set
			{
			}
		}

		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x117AAA0", Offset = "0x117AAA0", VA = "0x117AAA0")]
		internal bool IsSetAccessToken()
		{
			return default;
		}

		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x117AAC0", Offset = "0x117AAC0", VA = "0x117AAC0")]
		internal bool IsSetFriendlyDeviceName()
		{
			return default;
		}

		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x117AAE0", Offset = "0x117AAE0", VA = "0x117AAE0")]
		internal bool IsSetSession()
		{
			return default;
		}

		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x117AB00", Offset = "0x117AB00", VA = "0x117AB00")]
		internal bool IsSetUserCode()
		{
			return default;
		}

		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x117AB10", Offset = "0x117AB10", VA = "0x117AB10")]
		public VerifySoftwareTokenRequest()
		{
		}
	}
}
