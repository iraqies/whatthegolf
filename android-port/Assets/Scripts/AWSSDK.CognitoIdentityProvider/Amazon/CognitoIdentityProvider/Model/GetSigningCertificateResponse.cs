using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000C0")]
	public class GetSigningCertificateResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x28")]
		private string _certificate;

		[Token(Token = "0x17000162")]
		public string Certificate
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x111EC64", Offset = "0x111EC64", VA = "0x111EC64")]
			get
			{
				return null;
			}
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x111EC6C", Offset = "0x111EC6C", VA = "0x111EC6C")]
			set
			{
			}
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x111EC74", Offset = "0x111EC74", VA = "0x111EC74")]
		internal bool IsSetCertificate()
		{
			return default;
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x111EC84", Offset = "0x111EC84", VA = "0x111EC84")]
		public GetSigningCertificateResponse()
		{
		}
	}
}
