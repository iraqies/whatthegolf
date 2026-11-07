using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200138C")]
	public class LowpassModifierMultiple : BaseAudioModifierMultiple
	{
		[Token(Token = "0x40068EA")]
		[FieldOffset(Offset = "0x38")]
		public float baseFrequency;

		[Token(Token = "0x40068EB")]
		[FieldOffset(Offset = "0x40")]
		public AudioLowPassFilter lowpassFilter;

		[Token(Token = "0x6005B41")]
		[Address(RVA = "0x154C230", Offset = "0x154C230", VA = "0x154C230", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6005B42")]
		[Address(RVA = "0x154C354", Offset = "0x154C354", VA = "0x154C354", Slot = "5")]
		protected override void UpdateModifier()
		{
		}

		[Token(Token = "0x6005B43")]
		[Address(RVA = "0x154C380", Offset = "0x154C380", VA = "0x154C380")]
		public LowpassModifierMultiple()
		{
		}
	}
}
