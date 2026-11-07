using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000080")]
	public class CreateResourceServerResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x28")]
		private ResourceServerType _resourceServer;

		[Token(Token = "0x170000D9")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D0EC", Offset = "0x1D0EC")]
		public ResourceServerType ResourceServer
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x10EFDF4", Offset = "0x10EFDF4", VA = "0x10EFDF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x10EFDFC", Offset = "0x10EFDFC", VA = "0x10EFDFC")]
			set
			{
			}
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x10EFE04", Offset = "0x10EFE04", VA = "0x10EFE04")]
		internal bool IsSetResourceServer()
		{
			return default;
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x10EFE14", Offset = "0x10EFE14", VA = "0x10EFE14")]
		public CreateResourceServerResponse()
		{
		}
	}
}
