using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000020")]
	public class DeleteIdentitiesResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x28")]
		private List<UnprocessedIdentityId> _unprocessedIdentityIds;

		[Token(Token = "0x17000032")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x227BC", Offset = "0x227BC")]
		public List<UnprocessedIdentityId> UnprocessedIdentityIds
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x107DD54", Offset = "0x107DD54", VA = "0x107DD54")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x107DD5C", Offset = "0x107DD5C", VA = "0x107DD5C")]
			set
			{
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x107DD64", Offset = "0x107DD64", VA = "0x107DD64")]
		internal bool IsSetUnprocessedIdentityIds()
		{
			return default;
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x107DDBC", Offset = "0x107DDBC", VA = "0x107DDBC")]
		public DeleteIdentitiesResponse()
		{
		}
	}
}
