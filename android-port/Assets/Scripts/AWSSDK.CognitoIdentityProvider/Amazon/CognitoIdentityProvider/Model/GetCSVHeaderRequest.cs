using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000B7")]
	public class GetCSVHeaderRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x30")]
		private string _userPoolId;

		[Token(Token = "0x17000155")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E338", Offset = "0x1E338")]
		public string UserPoolId
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x1117A34", Offset = "0x1117A34", VA = "0x1117A34")]
			get
			{
				return null;
			}
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x1117A3C", Offset = "0x1117A3C", VA = "0x1117A3C")]
			set
			{
			}
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1117A44", Offset = "0x1117A44", VA = "0x1117A44")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1117A54", Offset = "0x1117A54", VA = "0x1117A54")]
		public GetCSVHeaderRequest()
		{
		}
	}
}
