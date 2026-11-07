using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000030")]
	public class GetOpenIdTokenForDeveloperIdentityResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x28")]
		private string _identityId;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x30")]
		private string _token;

		[Token(Token = "0x17000055")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22EDC", Offset = "0x22EDC")]
		public string IdentityId
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x108A07C", Offset = "0x108A07C", VA = "0x108A07C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x108A084", Offset = "0x108A084", VA = "0x108A084")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public string Token
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x108A09C", Offset = "0x108A09C", VA = "0x108A09C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x108A0A4", Offset = "0x108A0A4", VA = "0x108A0A4")]
			set
			{
			}
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x108A08C", Offset = "0x108A08C", VA = "0x108A08C")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x108A0AC", Offset = "0x108A0AC", VA = "0x108A0AC")]
		internal bool IsSetToken()
		{
			return default;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x108A0BC", Offset = "0x108A0BC", VA = "0x108A0BC")]
		public GetOpenIdTokenForDeveloperIdentityResponse()
		{
		}
	}
}
