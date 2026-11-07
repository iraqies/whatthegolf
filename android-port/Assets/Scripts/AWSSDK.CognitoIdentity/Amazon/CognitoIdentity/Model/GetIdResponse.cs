using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200002E")]
	public class GetIdResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x28")]
		private string _identityId;

		[Token(Token = "0x17000050")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22D70", Offset = "0x22D70")]
		public string IdentityId
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x1086ADC", Offset = "0x1086ADC", VA = "0x1086ADC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x1086AE4", Offset = "0x1086AE4", VA = "0x1086AE4")]
			set
			{
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1086AEC", Offset = "0x1086AEC", VA = "0x1086AEC")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1086AFC", Offset = "0x1086AFC", VA = "0x1086AFC")]
		public GetIdResponse()
		{
		}
	}
}
