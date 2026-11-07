using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x200000E")]
	public class DefaultEmailOptionType : ConstantClass
	{
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DefaultEmailOptionType CONFIRM_WITH_CODE;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DefaultEmailOptionType CONFIRM_WITH_LINK;

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x10FA1F4", Offset = "0x10FA1F4", VA = "0x10FA1F4")]
		public DefaultEmailOptionType(string value)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x10FA280", Offset = "0x10FA280", VA = "0x10FA280")]
		public static DefaultEmailOptionType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x10FA310", Offset = "0x10FA310", VA = "0x10FA310")]
		public static implicit operator DefaultEmailOptionType(string value)
		{
			return null;
		}
	}
}
