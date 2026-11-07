using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200004C")]
	public class AdminListGroupsForUserResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x28")]
		private List<GroupType> _groups;

		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x30")]
		private string _nextToken;

		[Token(Token = "0x17000057")]
		public List<GroupType> Groups
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x10B389C", Offset = "0x10B389C", VA = "0x10B389C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x10B38A4", Offset = "0x10B38A4", VA = "0x10B38A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x1BA90", Offset = "0x1BA90")]
		public string NextToken
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x10B3904", Offset = "0x10B3904", VA = "0x10B3904")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x10B390C", Offset = "0x10B390C", VA = "0x10B390C")]
			set
			{
			}
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x10B38AC", Offset = "0x10B38AC", VA = "0x10B38AC")]
		internal bool IsSetGroups()
		{
			return default;
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x10B3914", Offset = "0x10B3914", VA = "0x10B3914")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x10B3924", Offset = "0x10B3924", VA = "0x10B3924")]
		public AdminListGroupsForUserResponse()
		{
		}
	}
}
