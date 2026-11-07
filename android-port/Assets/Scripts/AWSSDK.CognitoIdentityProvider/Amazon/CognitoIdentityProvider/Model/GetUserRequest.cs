using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000C7")]
	public class GetUserRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x30")]
		private string _accessToken;

		[Token(Token = "0x1700016E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E7B8", Offset = "0x1E7B8")]
		public string AccessToken
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x11241D8", Offset = "0x11241D8", VA = "0x11241D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x11241E0", Offset = "0x11241E0", VA = "0x11241E0")]
			set
			{
			}
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x11241E8", Offset = "0x11241E8", VA = "0x11241E8")]
		internal bool IsSetAccessToken()
		{
			return default;
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x11241F8", Offset = "0x11241F8", VA = "0x11241F8", Slot = "13")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1124250", Offset = "0x1124250", VA = "0x1124250")]
		public GetUserRequest()
		{
		}
	}
}
