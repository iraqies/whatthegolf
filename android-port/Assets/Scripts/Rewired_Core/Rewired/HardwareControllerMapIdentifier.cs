using System;
using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2000025")]
	internal struct HardwareControllerMapIdentifier
	{
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x0")]
		public readonly Guid guid;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x10")]
		public readonly InputSource inputSource;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x14")]
		public readonly InputPlatform actualInputPlatform;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x18")]
		public readonly int variantIndex;

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x23CB128", Offset = "0x23CB128", VA = "0x23CB128")]
		public HardwareControllerMapIdentifier(Guid P_0, InputSource P_1, InputPlatform P_2, int P_3)
		{
		}
	}
}
