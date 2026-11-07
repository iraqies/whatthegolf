using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000A2")]
	public class DescribeUserPoolClientRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x30")]
		private string _clientId;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x17000124")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DE60", Offset = "0x1DE60")]
		public string ClientId
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x110A258", Offset = "0x110A258", VA = "0x110A258")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x110A260", Offset = "0x110A260", VA = "0x110A260")]
			set
			{
			}
		}

		[Token(Token = "0x17000125")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DEB0", Offset = "0x1DEB0")]
		public string UserPoolId
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x110A278", Offset = "0x110A278", VA = "0x110A278")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x110A280", Offset = "0x110A280", VA = "0x110A280")]
			set
			{
			}
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x110A268", Offset = "0x110A268", VA = "0x110A268")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x110A288", Offset = "0x110A288", VA = "0x110A288")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x110A298", Offset = "0x110A298", VA = "0x110A298")]
		public DescribeUserPoolClientRequest()
		{
		}
	}
}
