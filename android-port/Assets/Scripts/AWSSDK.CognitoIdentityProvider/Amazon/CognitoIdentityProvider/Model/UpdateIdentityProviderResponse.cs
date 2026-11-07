using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000131")]
	public class UpdateIdentityProviderResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x28")]
		private IdentityProviderType _identityProvider;

		[Token(Token = "0x17000265")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20DD0", Offset = "0x20DD0")]
		public IdentityProviderType IdentityProvider
		{
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x11650A4", Offset = "0x11650A4", VA = "0x11650A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x11650AC", Offset = "0x11650AC", VA = "0x11650AC")]
			set
			{
			}
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x11650B4", Offset = "0x11650B4", VA = "0x11650B4")]
		internal bool IsSetIdentityProvider()
		{
			return default;
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x11650C4", Offset = "0x11650C4", VA = "0x11650C4")]
		public UpdateIdentityProviderResponse()
		{
		}
	}
}
