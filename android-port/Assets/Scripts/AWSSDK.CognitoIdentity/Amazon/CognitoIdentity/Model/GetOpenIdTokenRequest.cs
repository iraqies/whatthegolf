using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000031")]
	public class GetOpenIdTokenRequest : AmazonCognitoIdentityRequest
	{
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x30")]
		private string _identityId;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, string> _logins;

		[Token(Token = "0x17000057")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22F24", Offset = "0x22F24")]
		public string IdentityId
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x108ACB0", Offset = "0x108ACB0", VA = "0x108ACB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x108ACB8", Offset = "0x108ACB8", VA = "0x108ACB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x22F74", Offset = "0x22F74")]
		public Dictionary<string, string> Logins
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x108ACD0", Offset = "0x108ACD0", VA = "0x108ACD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x108ACD8", Offset = "0x108ACD8", VA = "0x108ACD8")]
			set
			{
			}
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x108ACC0", Offset = "0x108ACC0", VA = "0x108ACC0")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x108ACE0", Offset = "0x108ACE0", VA = "0x108ACE0")]
		internal bool IsSetLogins()
		{
			return default;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1073268", Offset = "0x1073268", VA = "0x1073268")]
		public GetOpenIdTokenRequest()
		{
		}
	}
}
