using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000012")]
	public class EmailSendingAccountType : ConstantClass
	{
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x0")]
		public static readonly EmailSendingAccountType COGNITO_DEFAULT;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x8")]
		public static readonly EmailSendingAccountType DEVELOPER;

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1110B9C", Offset = "0x1110B9C", VA = "0x1110B9C")]
		public EmailSendingAccountType(string value)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1110C28", Offset = "0x1110C28", VA = "0x1110C28")]
		public static EmailSendingAccountType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1110CB8", Offset = "0x1110CB8", VA = "0x1110CB8")]
		public static implicit operator EmailSendingAccountType(string value)
		{
			return null;
		}
	}
}
