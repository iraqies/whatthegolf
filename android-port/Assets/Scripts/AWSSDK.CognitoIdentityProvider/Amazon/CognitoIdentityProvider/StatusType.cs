using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider
{
	[Token(Token = "0x200001F")]
	public class StatusType : ConstantClass
	{
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly StatusType Disabled;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x8")]
		public static readonly StatusType Enabled;

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x11588CC", Offset = "0x11588CC", VA = "0x11588CC")]
		public StatusType(string value)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1158958", Offset = "0x1158958", VA = "0x1158958")]
		public static StatusType FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x11589E8", Offset = "0x11589E8", VA = "0x11589E8")]
		public static implicit operator StatusType(string value)
		{
			return null;
		}
	}
}
