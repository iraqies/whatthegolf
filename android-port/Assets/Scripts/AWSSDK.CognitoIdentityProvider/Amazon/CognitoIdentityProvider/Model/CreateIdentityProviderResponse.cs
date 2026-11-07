using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200007E")]
	public class CreateIdentityProviderResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x28")]
		private IdentityProviderType _identityProvider;

		[Token(Token = "0x170000D4")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1CF90", Offset = "0x1CF90")]
		public IdentityProviderType IdentityProvider
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x10EE290", Offset = "0x10EE290", VA = "0x10EE290")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x10EE298", Offset = "0x10EE298", VA = "0x10EE298")]
			set
			{
			}
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x10EE2A0", Offset = "0x10EE2A0", VA = "0x10EE2A0")]
		internal bool IsSetIdentityProvider()
		{
			return default;
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x10EE2B0", Offset = "0x10EE2B0", VA = "0x10EE2B0")]
		public CreateIdentityProviderResponse()
		{
		}
	}
}
