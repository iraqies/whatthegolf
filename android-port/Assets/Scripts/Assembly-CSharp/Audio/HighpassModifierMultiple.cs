using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200138B")]
	public class HighpassModifierMultiple : BaseAudioModifierMultiple
	{
		[Token(Token = "0x40068E8")]
		[FieldOffset(Offset = "0x38")]
		public float baseFrequency;

		[Token(Token = "0x40068E9")]
		[FieldOffset(Offset = "0x40")]
		public AudioHighPassFilter highPassFilter;

		[Token(Token = "0x6005B3E")]
		[Address(RVA = "0x14C9930", Offset = "0x14C9930", VA = "0x14C9930", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6005B3F")]
		[Address(RVA = "0x14C9A54", Offset = "0x14C9A54", VA = "0x14C9A54", Slot = "5")]
		protected override void UpdateModifier()
		{
		}

		[Token(Token = "0x6005B40")]
		[Address(RVA = "0x14C9A80", Offset = "0x14C9A80", VA = "0x14C9A80")]
		public HighpassModifierMultiple()
		{
		}
	}
}
