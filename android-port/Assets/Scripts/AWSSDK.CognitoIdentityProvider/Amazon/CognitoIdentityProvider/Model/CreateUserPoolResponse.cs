using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000088")]
	public class CreateUserPoolResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x28")]
		private UserPoolType _userPool;

		[Token(Token = "0x17000108")]
		public UserPoolType UserPool
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x10F9194", Offset = "0x10F9194", VA = "0x10F9194")]
			get
			{
				return null;
			}
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x10F919C", Offset = "0x10F919C", VA = "0x10F919C")]
			set
			{
			}
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x10F91A4", Offset = "0x10F91A4", VA = "0x10F91A4")]
		internal bool IsSetUserPool()
		{
			return default;
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x10F91B4", Offset = "0x10F91B4", VA = "0x10F91B4")]
		public CreateUserPoolResponse()
		{
		}
	}
}
