using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000A5")]
	public class DescribeUserPoolDomainResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x28")]
		private DomainDescriptionType _domainDescription;

		[Token(Token = "0x17000128")]
		public DomainDescriptionType DomainDescription
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x110C1F4", Offset = "0x110C1F4", VA = "0x110C1F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x110C1FC", Offset = "0x110C1FC", VA = "0x110C1FC")]
			set
			{
			}
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x110C204", Offset = "0x110C204", VA = "0x110C204")]
		internal bool IsSetDomainDescription()
		{
			return default;
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x110C214", Offset = "0x110C214", VA = "0x110C214")]
		public DescribeUserPoolDomainResponse()
		{
		}
	}
}
