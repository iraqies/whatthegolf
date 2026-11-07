using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000ED")]
	public class ListUsersInGroupResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x28")]
		private string _nextToken;

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x30")]
		private List<UserType> _users;

		[Token(Token = "0x170001C2")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F778", Offset = "0x1F778")]
		public string NextToken
		{
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x113A360", Offset = "0x113A360", VA = "0x113A360")]
			get
			{
				return null;
			}
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x113A368", Offset = "0x113A368", VA = "0x113A368")]
			set
			{
			}
		}

		[Token(Token = "0x170001C3")]
		public List<UserType> Users
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0x113A380", Offset = "0x113A380", VA = "0x113A380")]
			get
			{
				return null;
			}
			[Token(Token = "0x600081E")]
			[Address(RVA = "0x113A388", Offset = "0x113A388", VA = "0x113A388")]
			set
			{
			}
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x113A370", Offset = "0x113A370", VA = "0x113A370")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x113A390", Offset = "0x113A390", VA = "0x113A390")]
		internal bool IsSetUsers()
		{
			return default;
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x113A3E8", Offset = "0x113A3E8", VA = "0x113A3E8")]
		public ListUsersInGroupResponse()
		{
		}
	}
}
