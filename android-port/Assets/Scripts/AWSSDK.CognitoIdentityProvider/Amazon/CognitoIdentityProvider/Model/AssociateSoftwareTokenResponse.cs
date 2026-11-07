using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000067")]
	public class AssociateSoftwareTokenResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x28")]
		private string _secretCode;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x30")]
		private string _session;

		[Token(Token = "0x17000091")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C600", Offset = "0x1C600")]
		public string SecretCode
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x10DD788", Offset = "0x10DD788", VA = "0x10DD788")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x10DD790", Offset = "0x10DD790", VA = "0x10DD790")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1C638", Offset = "0x1C638")]
		public string Session
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x10DD7A8", Offset = "0x10DD7A8", VA = "0x10DD7A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x10DD7B0", Offset = "0x10DD7B0", VA = "0x10DD7B0")]
			set
			{
			}
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x10DD798", Offset = "0x10DD798", VA = "0x10DD798")]
		internal bool IsSetSecretCode()
		{
			return default;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x10DD7B8", Offset = "0x10DD7B8", VA = "0x10DD7B8")]
		internal bool IsSetSession()
		{
			return default;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x10DD7C8", Offset = "0x10DD7C8", VA = "0x10DD7C8")]
		public AssociateSoftwareTokenResponse()
		{
		}
	}
}
