using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000C1")]
	public class GetUICustomizationRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x30")]
		private string _clientId;

		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x38")]
		private string _userPoolId;

		[Token(Token = "0x17000163")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E618", Offset = "0x1E618")]
		public string ClientId
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x111F4B4", Offset = "0x111F4B4", VA = "0x111F4B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x111F4BC", Offset = "0x111F4BC", VA = "0x111F4BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000164")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E660", Offset = "0x1E660")]
		public string UserPoolId
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x111F4D4", Offset = "0x111F4D4", VA = "0x111F4D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x111F4DC", Offset = "0x111F4DC", VA = "0x111F4DC")]
			set
			{
			}
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x111F4C4", Offset = "0x111F4C4", VA = "0x111F4C4")]
		internal bool IsSetClientId()
		{
			return default;
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x111F4E4", Offset = "0x111F4E4", VA = "0x111F4E4")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x111F4F4", Offset = "0x111F4F4", VA = "0x111F4F4")]
		public GetUICustomizationRequest()
		{
		}
	}
}
