using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync
{
	[Token(Token = "0x2000006")]
	public class Operation : ConstantClass
	{
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Operation Remove;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Operation Replace;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x11A3CC8", Offset = "0x11A3CC8", VA = "0x11A3CC8")]
		public Operation(string value)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x11A3D54", Offset = "0x11A3D54", VA = "0x11A3D54")]
		public static Operation FindValue(string value)
		{
			return null;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x11A3DE4", Offset = "0x11A3DE4", VA = "0x11A3DE4")]
		public static implicit operator Operation(string value)
		{
			return null;
		}
	}
}
