using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200009D")]
	public class DescribeResourceServerResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x28")]
		private ResourceServerType _resourceServer;

		[Token(Token = "0x1700011D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1DCC0", Offset = "0x1DCC0")]
		public ResourceServerType ResourceServer
		{
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x1106D84", Offset = "0x1106D84", VA = "0x1106D84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x1106D8C", Offset = "0x1106D8C", VA = "0x1106D8C")]
			set
			{
			}
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1106D94", Offset = "0x1106D94", VA = "0x1106D94")]
		internal bool IsSetResourceServer()
		{
			return default;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1106DA4", Offset = "0x1106DA4", VA = "0x1106DA4")]
		public DescribeResourceServerResponse()
		{
		}
	}
}
