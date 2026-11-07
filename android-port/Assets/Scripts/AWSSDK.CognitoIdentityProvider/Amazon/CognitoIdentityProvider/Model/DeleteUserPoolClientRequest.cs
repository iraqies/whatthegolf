using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000092")]
	public class DeleteUserPoolClientRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x30")]
		private string _clientId;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x17000112")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D988", Offset = "0x1D988")]
		public string ClientId
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x10FF9BC", Offset = "0x10FF9BC", VA = "0x10FF9BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x10FF9C4", Offset = "0x10FF9C4", VA = "0x10FF9C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000113")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D9D8", Offset = "0x1D9D8")]
		public string UserPoolId
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x10FF9DC", Offset = "0x10FF9DC", VA = "0x10FF9DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x10FF9E4", Offset = "0x10FF9E4", VA = "0x10FF9E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x10FF9CC", Offset = "0x10FF9CC", VA = "0x10FF9CC")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x10FF9EC", Offset = "0x10FF9EC", VA = "0x10FF9EC")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x10FF9FC", Offset = "0x10FF9FC", VA = "0x10FF9FC")]
		public DeleteUserPoolClientRequest()
		{
		}
	}
}
