using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000098")]
	public class DeleteUserRequest : AmazonCognitoIdentityProviderRequest
	{
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x30")]
		private string _accessToken;

		[Token(Token = "0x17000117")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DB18", Offset = "0x1DB18")]
		public string AccessToken
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x1103458", Offset = "0x1103458", VA = "0x1103458")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x1103460", Offset = "0x1103460", VA = "0x1103460")]
			set
			{
			}
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1103468", Offset = "0x1103468", VA = "0x1103468")]
		internal bool IsSetAccessToken()
		{
			return default;
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1103478", Offset = "0x1103478", VA = "0x1103478", Slot = "13")]
		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x11034D0", Offset = "0x11034D0", VA = "0x11034D0")]
		public DeleteUserRequest()
		{
		}
	}
}
