using Il2CppDummyDll;
using UnityEngine;

namespace MusicGolf
{
	[Token(Token = "0x20010BB")]
	public class ElevatorPlatformBeatObject : BeatObject
	{
		[Token(Token = "0x400581E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x400581F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve elevationCurve;

		[Token(Token = "0x4005820")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float elevationMax;

		[Token(Token = "0x6004AF6")]
		[Address(RVA = "0x144010C", Offset = "0x144010C", VA = "0x144010C", Slot = "5")]
		public override void PlayProgress(float t)
		{
		}

		[Token(Token = "0x6004AF7")]
		[Address(RVA = "0x14401C4", Offset = "0x14401C4", VA = "0x14401C4")]
		public ElevatorPlatformBeatObject()
		{
		}
	}
}
