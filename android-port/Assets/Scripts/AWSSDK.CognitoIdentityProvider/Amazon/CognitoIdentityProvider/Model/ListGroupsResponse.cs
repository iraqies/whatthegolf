using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000DF")]
	public class ListGroupsResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x28")]
		private List<GroupType> _groups;

		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x30")]
		private string _nextToken;

		[Token(Token = "0x170001A2")]
		public List<GroupType> Groups
		{
			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x112F644", Offset = "0x112F644", VA = "0x112F644")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x112F64C", Offset = "0x112F64C", VA = "0x112F64C")]
			set
			{
			}
		}

		[Token(Token = "0x170001A3")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F01C", Offset = "0x1F01C")]
		public string NextToken
		{
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x112F6AC", Offset = "0x112F6AC", VA = "0x112F6AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x112F6B4", Offset = "0x112F6B4", VA = "0x112F6B4")]
			set
			{
			}
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x112F654", Offset = "0x112F654", VA = "0x112F654")]
		internal bool IsSetGroups()
		{
			return default;
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x112F6BC", Offset = "0x112F6BC", VA = "0x112F6BC")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x112F6CC", Offset = "0x112F6CC", VA = "0x112F6CC")]
		public ListGroupsResponse()
		{
		}
	}
}
