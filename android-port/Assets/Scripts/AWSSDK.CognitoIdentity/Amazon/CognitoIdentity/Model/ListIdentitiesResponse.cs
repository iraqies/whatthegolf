using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200003A")]
	public class ListIdentitiesResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x28")]
		private List<IdentityDescription> _identities;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x30")]
		private string _identityPoolId;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x38")]
		private string _nextToken;

		[Token(Token = "0x17000065")]
		public List<IdentityDescription> Identities
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x108E788", Offset = "0x108E788", VA = "0x108E788")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x108E790", Offset = "0x108E790", VA = "0x108E790")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x231A4", Offset = "0x231A4")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x108E7F0", Offset = "0x108E7F0", VA = "0x108E7F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x108E7F8", Offset = "0x108E7F8", VA = "0x108E7F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x231EC", Offset = "0x231EC")]
		public string NextToken
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x108E810", Offset = "0x108E810", VA = "0x108E810")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x108E818", Offset = "0x108E818", VA = "0x108E818")]
			set
			{
			}
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x108E798", Offset = "0x108E798", VA = "0x108E798")]
		internal bool IsSetIdentities()
		{
			return default;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x108E800", Offset = "0x108E800", VA = "0x108E800")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x108E820", Offset = "0x108E820", VA = "0x108E820")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x108E830", Offset = "0x108E830", VA = "0x108E830")]
		public ListIdentitiesResponse()
		{
		}
	}
}
