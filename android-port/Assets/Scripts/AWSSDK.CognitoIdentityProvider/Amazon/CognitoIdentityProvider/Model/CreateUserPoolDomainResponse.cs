using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000086")]
	public class CreateUserPoolDomainResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x28")]
		private string _cloudFrontDomain;

		[Token(Token = "0x170000F2")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1D4F0", Offset = "0x1D4F0")]
		public string CloudFrontDomain
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x10F5E70", Offset = "0x10F5E70", VA = "0x10F5E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x10F5E78", Offset = "0x10F5E78", VA = "0x10F5E78")]
			set
			{
			}
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x10F5E80", Offset = "0x10F5E80", VA = "0x10F5E80")]
		internal bool IsSetCloudFrontDomain()
		{
			return default;
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x10F5E90", Offset = "0x10F5E90", VA = "0x10F5E90")]
		public CreateUserPoolDomainResponse()
		{
		}
	}
}
