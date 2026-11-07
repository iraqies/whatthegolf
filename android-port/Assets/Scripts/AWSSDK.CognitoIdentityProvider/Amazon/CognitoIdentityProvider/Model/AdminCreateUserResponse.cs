using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000034")]
	public class AdminCreateUserResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x28")]
		private UserType _user;

		[Token(Token = "0x17000021")]
		public UserType User
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x10A0118", Offset = "0x10A0118", VA = "0x10A0118")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x10A0120", Offset = "0x10A0120", VA = "0x10A0120")]
			set
			{
			}
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x10A0128", Offset = "0x10A0128", VA = "0x10A0128")]
		internal bool IsSetUser()
		{
			return default;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x10A0138", Offset = "0x10A0138", VA = "0x10A0138")]
		public AdminCreateUserResponse()
		{
		}
	}
}
