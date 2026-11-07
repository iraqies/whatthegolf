using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000EF")]
	public class ListUsersResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x28")]
		private string _paginationToken;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x30")]
		private List<UserType> _users;

		[Token(Token = "0x170001C9")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F8B8", Offset = "0x1F8B8")]
		public string PaginationToken
		{
			[Token(Token = "0x6000831")]
			[Address(RVA = "0x113BFB8", Offset = "0x113BFB8", VA = "0x113BFB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000832")]
			[Address(RVA = "0x113BFC0", Offset = "0x113BFC0", VA = "0x113BFC0")]
			set
			{
			}
		}

		[Token(Token = "0x170001CA")]
		public List<UserType> Users
		{
			[Token(Token = "0x6000834")]
			[Address(RVA = "0x113BFD8", Offset = "0x113BFD8", VA = "0x113BFD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x113BFE0", Offset = "0x113BFE0", VA = "0x113BFE0")]
			set
			{
			}
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x113BFC8", Offset = "0x113BFC8", VA = "0x113BFC8")]
		internal bool IsSetPaginationToken()
		{
			return default;
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x113BFE8", Offset = "0x113BFE8", VA = "0x113BFE8")]
		internal bool IsSetUsers()
		{
			return default;
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x113C040", Offset = "0x113C040", VA = "0x113C040")]
		public ListUsersResponse()
		{
		}
	}
}
