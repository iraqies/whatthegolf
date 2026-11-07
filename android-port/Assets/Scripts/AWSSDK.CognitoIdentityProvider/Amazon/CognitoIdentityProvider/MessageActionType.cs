using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x2000019")]
	public class MessageActionType : ConstantClass
	{
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MessageActionType RESEND;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x8")]
		public static readonly MessageActionType SUPPRESS;

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x113D460", Offset = "0x113D460", VA = "0x113D460")]
		public MessageActionType(string value)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x113D4EC", Offset = "0x113D4EC", VA = "0x113D4EC")]
		public static MessageActionType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x113D57C", Offset = "0x113D57C", VA = "0x113D57C")]
		public static implicit operator MessageActionType(string value)
		{
			return null;
		}
	}
}
