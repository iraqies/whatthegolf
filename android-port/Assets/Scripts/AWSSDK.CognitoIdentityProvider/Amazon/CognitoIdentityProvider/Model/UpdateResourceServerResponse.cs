using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000133")]
	public class UpdateResourceServerResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x28")]
		private ResourceServerType _resourceServer;

		[Token(Token = "0x1700026A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20F2C", Offset = "0x20F2C")]
		public ResourceServerType ResourceServer
		{
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x1166A54", Offset = "0x1166A54", VA = "0x1166A54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x1166A5C", Offset = "0x1166A5C", VA = "0x1166A5C")]
			set
			{
			}
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x1166A64", Offset = "0x1166A64", VA = "0x1166A64")]
		internal bool IsSetResourceServer()
		{
			return default;
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x1166A74", Offset = "0x1166A74", VA = "0x1166A74")]
		public UpdateResourceServerResponse()
		{
		}
	}
}
