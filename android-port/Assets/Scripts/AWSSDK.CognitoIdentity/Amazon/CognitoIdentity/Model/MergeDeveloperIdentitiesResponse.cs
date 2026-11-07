using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000043")]
	public class MergeDeveloperIdentitiesResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x28")]
		private string _identityId;

		[Token(Token = "0x1700007E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23778", Offset = "0x23778")]
		public string IdentityId
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x1095724", Offset = "0x1095724", VA = "0x1095724")]
			get
			{
				return null;
			}
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x109572C", Offset = "0x109572C", VA = "0x109572C")]
			set
			{
			}
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1095734", Offset = "0x1095734", VA = "0x1095734")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x1095744", Offset = "0x1095744", VA = "0x1095744")]
		public MergeDeveloperIdentitiesResponse()
		{
		}
	}
}
