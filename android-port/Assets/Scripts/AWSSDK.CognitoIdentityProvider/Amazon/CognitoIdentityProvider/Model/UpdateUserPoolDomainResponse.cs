using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000139")]
	public class UpdateUserPoolDomainResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x28")]
		private string _cloudFrontDomain;

		[Token(Token = "0x17000283")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x21324", Offset = "0x21324")]
		public string CloudFrontDomain
		{
			[Token(Token = "0x6000ADE")]
			[Address(RVA = "0x116E8C8", Offset = "0x116E8C8", VA = "0x116E8C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ADF")]
			[Address(RVA = "0x116E8D0", Offset = "0x116E8D0", VA = "0x116E8D0")]
			set
			{
			}
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x116E8D8", Offset = "0x116E8D8", VA = "0x116E8D8")]
		internal bool IsSetCloudFrontDomain()
		{
			return default;
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x116E8E8", Offset = "0x116E8E8", VA = "0x116E8E8")]
		public UpdateUserPoolDomainResponse()
		{
		}
	}
}
