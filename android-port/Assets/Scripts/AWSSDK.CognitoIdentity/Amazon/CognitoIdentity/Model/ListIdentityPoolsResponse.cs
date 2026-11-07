using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x200003C")]
	public class ListIdentityPoolsResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x28")]
		private List<IdentityPoolShortDescription> _identityPools;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x30")]
		private string _nextToken;

		[Token(Token = "0x1700006A")]
		public List<IdentityPoolShortDescription> IdentityPools
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x10900C0", Offset = "0x10900C0", VA = "0x10900C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x10900C8", Offset = "0x10900C8", VA = "0x10900C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x232AC", Offset = "0x232AC")]
		public string NextToken
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x1090128", Offset = "0x1090128", VA = "0x1090128")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x1090130", Offset = "0x1090130", VA = "0x1090130")]
			set
			{
			}
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x10900D0", Offset = "0x10900D0", VA = "0x10900D0")]
		internal bool IsSetIdentityPools()
		{
			return default;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1090138", Offset = "0x1090138", VA = "0x1090138")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1090148", Offset = "0x1090148", VA = "0x1090148")]
		public ListIdentityPoolsResponse()
		{
		}
	}
}
