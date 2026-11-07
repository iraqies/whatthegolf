using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000084")]
	public class CreateUserPoolClientResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x28")]
		private UserPoolClientType _userPoolClient;

		[Token(Token = "0x170000EE")]
		public UserPoolClientType UserPoolClient
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0x10F4570", Offset = "0x10F4570", VA = "0x10F4570")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0x10F4578", Offset = "0x10F4578", VA = "0x10F4578")]
			set
			{
			}
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x10F4580", Offset = "0x10F4580", VA = "0x10F4580")]
		internal bool IsSetUserPoolClient()
		{
			return default;
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x10F4590", Offset = "0x10F4590", VA = "0x10F4590")]
		public CreateUserPoolClientResponse()
		{
		}
	}
}
