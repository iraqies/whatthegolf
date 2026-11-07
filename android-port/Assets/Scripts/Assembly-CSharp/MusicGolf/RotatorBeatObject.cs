using Il2CppDummyDll;
using UnityEngine;

namespace MusicGolf
{
	[Token(Token = "0x20010C6")]
	public class RotatorBeatObject : BeatObject
	{
		[Token(Token = "0x400585F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Rigidbody2D rigidbody2D;

		[Token(Token = "0x4005860")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve rotationCurve;

		[Token(Token = "0x4005861")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool isUsingSceneRotationAsStartRotation;

		[Token(Token = "0x4005862")]
		[FieldOffset(Offset = "0x54")]
		private Quaternion startRotation;

		[Token(Token = "0x4005863")]
		[FieldOffset(Offset = "0x64")]
		private float startAngleOffset;

		[Token(Token = "0x6004B23")]
		[Address(RVA = "0x16617D4", Offset = "0x16617D4", VA = "0x16617D4", Slot = "4")]
		public override void PlayStart()
		{
		}

		[Token(Token = "0x6004B24")]
		[Address(RVA = "0x166186C", Offset = "0x166186C", VA = "0x166186C", Slot = "5")]
		public override void PlayProgress(float t)
		{
		}

		[Token(Token = "0x6004B25")]
		[Address(RVA = "0x16618BC", Offset = "0x16618BC", VA = "0x16618BC")]
		public RotatorBeatObject()
		{
		}
	}
}
