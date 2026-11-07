using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000EB")]
	public class ListUserPoolsResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x28")]
		private string _nextToken;

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x30")]
		private List<UserPoolDescriptionType> _userPools;

		[Token(Token = "0x170001BC")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1F620", Offset = "0x1F620")]
		public string NextToken
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x1138AA0", Offset = "0x1138AA0", VA = "0x1138AA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x1138AA8", Offset = "0x1138AA8", VA = "0x1138AA8")]
			set
			{
			}
		}

		[Token(Token = "0x170001BD")]
		public List<UserPoolDescriptionType> UserPools
		{
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x1138AC0", Offset = "0x1138AC0", VA = "0x1138AC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600080A")]
			[Address(RVA = "0x1138AC8", Offset = "0x1138AC8", VA = "0x1138AC8")]
			set
			{
			}
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1138AB0", Offset = "0x1138AB0", VA = "0x1138AB0")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1138AD0", Offset = "0x1138AD0", VA = "0x1138AD0")]
		internal bool IsSetUserPools()
		{
			return default;
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x1138B28", Offset = "0x1138B28", VA = "0x1138B28")]
		public ListUserPoolsResponse()
		{
		}
	}
}
