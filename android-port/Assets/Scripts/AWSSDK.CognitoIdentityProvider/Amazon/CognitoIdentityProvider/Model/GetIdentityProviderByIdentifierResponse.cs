using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000BE")]
	public class GetIdentityProviderByIdentifierResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x28")]
		private IdentityProviderType _identityProvider;

		[Token(Token = "0x17000160")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1E594", Offset = "0x1E594")]
		public IdentityProviderType IdentityProvider
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x111CF9C", Offset = "0x111CF9C", VA = "0x111CF9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x111CFA4", Offset = "0x111CFA4", VA = "0x111CFA4")]
			set
			{
			}
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x111CFAC", Offset = "0x111CFAC", VA = "0x111CFAC")]
		internal bool IsSetIdentityProvider()
		{
			return default;
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x111CFBC", Offset = "0x111CFBC", VA = "0x111CFBC")]
		public GetIdentityProviderByIdentifierResponse()
		{
		}
	}
}
