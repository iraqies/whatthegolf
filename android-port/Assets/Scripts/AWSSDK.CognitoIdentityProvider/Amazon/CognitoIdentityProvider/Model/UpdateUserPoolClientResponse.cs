using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000137")]
	public class UpdateUserPoolClientResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x28")]
		private UserPoolClientType _userPoolClient;

		[Token(Token = "0x1700027F")]
		public UserPoolClientType UserPoolClient
		{
			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x116C074", Offset = "0x116C074", VA = "0x116C074")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x116C07C", Offset = "0x116C07C", VA = "0x116C07C")]
			set
			{
			}
		}

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x116C084", Offset = "0x116C084", VA = "0x116C084")]
		internal bool IsSetUserPoolClient()
		{
			return default;
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x116C094", Offset = "0x116C094", VA = "0x116C094")]
		public UpdateUserPoolClientResponse()
		{
		}
	}
}
