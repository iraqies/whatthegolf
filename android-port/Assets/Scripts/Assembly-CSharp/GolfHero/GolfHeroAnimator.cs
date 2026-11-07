using Il2CppDummyDll;
using UnityEngine;

namespace GolfHero
{
	[Token(Token = "0x20010D4")]
	public class GolfHeroAnimator : MonoBehaviour
	{
		[Token(Token = "0x40058A4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GolfHeroSequencer sequencer;

		[Token(Token = "0x40058A5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float beatDuration;

		[Token(Token = "0x40058A6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve xRotation;

		[Token(Token = "0x40058A7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve yRotation;

		[Token(Token = "0x40058A8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurve zRotation;

		[Token(Token = "0x6004B62")]
		[Address(RVA = "0x14A0D64", Offset = "0x14A0D64", VA = "0x14A0D64")]
		private void Update()
		{
		}

		[Token(Token = "0x6004B63")]
		[Address(RVA = "0x14A0EE8", Offset = "0x14A0EE8", VA = "0x14A0EE8")]
		public GolfHeroAnimator()
		{
		}
	}
}
