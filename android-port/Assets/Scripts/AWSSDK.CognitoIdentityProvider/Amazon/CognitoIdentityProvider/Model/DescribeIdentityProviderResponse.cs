using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200009B")]
	public class DescribeIdentityProviderResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x28")]
		private IdentityProviderType _identityProvider;

		[Token(Token = "0x1700011A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DBEC", Offset = "0x1DBEC")]
		public IdentityProviderType IdentityProvider
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x1105878", Offset = "0x1105878", VA = "0x1105878")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x1105880", Offset = "0x1105880", VA = "0x1105880")]
			set
			{
			}
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1105888", Offset = "0x1105888", VA = "0x1105888")]
		internal bool IsSetIdentityProvider()
		{
			return default;
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1105898", Offset = "0x1105898", VA = "0x1105898")]
		public DescribeIdentityProviderResponse()
		{
		}
	}
}
