using Il2CppDummyDll;

namespace Audio
{
	[Token(Token = "0x200138D")]
	public class PitchModifierMultiple : ModifyAudiosource
	{
		[Token(Token = "0x40068EC")]
		[FieldOffset(Offset = "0x40")]
		public float basePitch;

		[Token(Token = "0x6005B44")]
		[Address(RVA = "0x15E32B0", Offset = "0x15E32B0", VA = "0x15E32B0", Slot = "5")]
		protected override void UpdateModifier()
		{
		}

		[Token(Token = "0x6005B45")]
		[Address(RVA = "0x15E32DC", Offset = "0x15E32DC", VA = "0x15E32DC")]
		public PitchModifierMultiple()
		{
		}
	}
}
