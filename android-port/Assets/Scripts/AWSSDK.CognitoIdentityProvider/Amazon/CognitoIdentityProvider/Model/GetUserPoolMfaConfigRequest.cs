using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000C5")]
	public class GetUserPoolMfaConfigRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x30")]
		private string _userPoolId;

		[Token(Token = "0x1700016A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E768", Offset = "0x1E768")]
		public string UserPoolId
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x1122AEC", Offset = "0x1122AEC", VA = "0x1122AEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x1122AF4", Offset = "0x1122AF4", VA = "0x1122AF4")]
			set
			{
			}
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x1122AFC", Offset = "0x1122AFC", VA = "0x1122AFC")]
		internal bool IsSetUserPoolId()
		{
			return default;
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x1122B0C", Offset = "0x1122B0C", VA = "0x1122B0C")]
		public GetUserPoolMfaConfigRequest()
		{
		}
	}
}
