using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x20000BC")]
	public class GetGroupResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x28")]
		private GroupType _group;

		[Token(Token = "0x1700015D")]
		public GroupType Group
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x111B438", Offset = "0x111B438", VA = "0x111B438")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x111B440", Offset = "0x111B440", VA = "0x111B440")]
			set
			{
			}
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x111B448", Offset = "0x111B448", VA = "0x111B448")]
		internal bool IsSetGroup()
		{
			return default;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x111B458", Offset = "0x111B458", VA = "0x111B458")]
		public GetGroupResponse()
		{
		}
	}
}
