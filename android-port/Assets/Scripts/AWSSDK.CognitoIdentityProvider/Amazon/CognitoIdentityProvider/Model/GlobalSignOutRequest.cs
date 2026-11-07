using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000C9")]
	public class GlobalSignOutRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x30")]
		private string _accessToken;

		[Token(Token = "0x17000174")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E870", Offset = "0x1E870")]
		public string AccessToken
		{
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x1125F48", Offset = "0x1125F48", VA = "0x1125F48")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x1125F50", Offset = "0x1125F50", VA = "0x1125F50")]
			set
			{
			}
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1125F58", Offset = "0x1125F58", VA = "0x1125F58")]
		internal bool IsSetAccessToken()
		{
			return default;
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1125F68", Offset = "0x1125F68", VA = "0x1125F68")]
		public GlobalSignOutRequest()
		{
		}
	}
}
