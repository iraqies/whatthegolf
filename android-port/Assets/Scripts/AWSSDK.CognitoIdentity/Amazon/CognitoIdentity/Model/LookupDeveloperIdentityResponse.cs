using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000040")]
	public class LookupDeveloperIdentityResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x28")]
		private List<string> _developerUserIdentifierList;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x30")]
		private string _identityId;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x38")]
		private string _nextToken;

		[Token(Token = "0x17000073")]
		public List<string> DeveloperUserIdentifierList
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x10930F8", Offset = "0x10930F8", VA = "0x10930F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x1093100", Offset = "0x1093100", VA = "0x1093100")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23494", Offset = "0x23494")]
		public string IdentityId
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x1093160", Offset = "0x1093160", VA = "0x1093160")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x1093168", Offset = "0x1093168", VA = "0x1093168")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x234DC", Offset = "0x234DC")]
		public string NextToken
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x1093180", Offset = "0x1093180", VA = "0x1093180")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x1093188", Offset = "0x1093188", VA = "0x1093188")]
			set
			{
			}
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1093108", Offset = "0x1093108", VA = "0x1093108")]
		internal bool IsSetDeveloperUserIdentifierList()
		{
			return default;
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1093170", Offset = "0x1093170", VA = "0x1093170")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1093190", Offset = "0x1093190", VA = "0x1093190")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x10931A0", Offset = "0x10931A0", VA = "0x10931A0")]
		public LookupDeveloperIdentityResponse()
		{
		}
	}
}
