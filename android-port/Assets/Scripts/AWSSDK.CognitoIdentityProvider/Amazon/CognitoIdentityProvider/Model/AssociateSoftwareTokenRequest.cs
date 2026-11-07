using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000066")]
	public class AssociateSoftwareTokenRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x30")]
		private string _accessToken;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x38")]
		private string _session;

		[Token(Token = "0x1700008F")]
		public string AccessToken
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x10DCC6C", Offset = "0x10DCC6C", VA = "0x10DCC6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x10DCC74", Offset = "0x10DCC74", VA = "0x10DCC74")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C5B8", Offset = "0x1C5B8")]
		public string Session
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x10DCC8C", Offset = "0x10DCC8C", VA = "0x10DCC8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x10DCC94", Offset = "0x10DCC94", VA = "0x10DCC94")]
			set
			{
			}
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x10DCC7C", Offset = "0x10DCC7C", VA = "0x10DCC7C")]
		internal bool IsSetAccessToken()
		{
			return default;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x10DCC9C", Offset = "0x10DCC9C", VA = "0x10DCC9C")]
		internal bool IsSetSession()
		{
			return default;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x10DCCAC", Offset = "0x10DCCAC", VA = "0x10DCCAC")]
		public AssociateSoftwareTokenRequest()
		{
		}
	}
}
