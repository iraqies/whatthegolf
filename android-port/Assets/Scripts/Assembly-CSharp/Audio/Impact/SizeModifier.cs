using Il2CppDummyDll;

namespace Audio.Impact
{
	[Token(Token = "0x200140D")]
	public struct SizeModifier
	{
		[Token(Token = "0x4006B99")]
		[FieldOffset(Offset = "0x0")]
		public float volumeMultiplier;

		[Token(Token = "0x4006B9A")]
		[FieldOffset(Offset = "0x4")]
		public float pitchMultiplier;

		[Token(Token = "0x4006B9B")]
		[FieldOffset(Offset = "0x0")]
		public static SizeModifier Light;

		[Token(Token = "0x4006B9C")]
		[FieldOffset(Offset = "0x8")]
		public static SizeModifier Medium;

		[Token(Token = "0x4006B9D")]
		[FieldOffset(Offset = "0x10")]
		public static SizeModifier Heavy;

		[Token(Token = "0x6005D4D")]
		[Address(RVA = "0x16B35F4", Offset = "0x16B35F4", VA = "0x16B35F4")]
		public SizeModifier(float volumeMultiplier = 1f, float pitchMultiplier = 1f)
		{
		}

		[Token(Token = "0x6005D4E")]
		[Address(RVA = "0x16B35FC", Offset = "0x16B35FC", VA = "0x16B35FC")]
		public static SizeModifier NewModifier(ObjectWeight weight)
		{
			return default;
		}
	}
}
