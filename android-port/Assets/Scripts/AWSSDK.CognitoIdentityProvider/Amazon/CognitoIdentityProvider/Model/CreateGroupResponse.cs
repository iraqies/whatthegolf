using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200007C")]
	public class CreateGroupResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x28")]
		private GroupType _group;

		[Token(Token = "0x170000CD")]
		public GroupType Group
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x10EC238", Offset = "0x10EC238", VA = "0x10EC238")]
			get
			{
				return null;
			}
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x10EC240", Offset = "0x10EC240", VA = "0x10EC240")]
			set
			{
			}
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x10EC248", Offset = "0x10EC248", VA = "0x10EC248")]
		internal bool IsSetGroup()
		{
			return default;
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x10EC258", Offset = "0x10EC258", VA = "0x10EC258")]
		public CreateGroupResponse()
		{
		}
	}
}
