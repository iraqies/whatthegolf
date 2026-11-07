using System;
using Il2CppDummyDll;

namespace Audio.Rumble
{
	[Serializable]
	[Token(Token = "0x2001402")]
	public class VelocityRumble
	{
		[Token(Token = "0x4006B68")]
		[FieldOffset(Offset = "0x10")]
		public float min;

		[Token(Token = "0x4006B69")]
		[FieldOffset(Offset = "0x14")]
		public float max;

		[Token(Token = "0x4006B6A")]
		[FieldOffset(Offset = "0x18")]
		public RumbleEventAsset rumble;

		[Token(Token = "0x6005D26")]
		[Address(RVA = "0x174A4D4", Offset = "0x174A4D4", VA = "0x174A4D4")]
		public VelocityRumble()
		{
		}
	}
}
