using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200012F")]
	public class UpdateGroupResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x28")]
		private GroupType _group;

		[Token(Token = "0x1700025F")]
		public GroupType Group
		{
			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x1163370", Offset = "0x1163370", VA = "0x1163370")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x1163378", Offset = "0x1163378", VA = "0x1163378")]
			set
			{
			}
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x1163380", Offset = "0x1163380", VA = "0x1163380")]
		internal bool IsSetGroup()
		{
			return default;
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x1163390", Offset = "0x1163390", VA = "0x1163390")]
		public UpdateGroupResponse()
		{
		}
	}
}
