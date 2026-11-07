using Il2CppDummyDll;

namespace Audio
{
	[Token(Token = "0x200138E")]
	public class VolumeModifierMultiple : ModifyAudiosource
	{
		[Token(Token = "0x40068ED")]
		[FieldOffset(Offset = "0x40")]
		public float baseVolume;

		[Token(Token = "0x40068EE")]
		[FieldOffset(Offset = "0x44")]
		public bool startAndStopByVolume;

		[Token(Token = "0x6005B46")]
		[Address(RVA = "0x174BAE8", Offset = "0x174BAE8", VA = "0x174BAE8", Slot = "5")]
		protected override void UpdateModifier()
		{
		}

		[Token(Token = "0x6005B47")]
		[Address(RVA = "0x174BC34", Offset = "0x174BC34", VA = "0x174BC34")]
		public VolumeModifierMultiple()
		{
		}
	}
}
