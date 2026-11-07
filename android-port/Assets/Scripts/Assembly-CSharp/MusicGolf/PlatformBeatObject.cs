using Il2CppDummyDll;
using UnityEngine;

namespace MusicGolf
{
	[Token(Token = "0x20010C5")]
	public class PlatformBeatObject : BeatObject
	{
		[Token(Token = "0x4005858")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float filledDuration;

		[Token(Token = "0x4005859")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float width;

		[Token(Token = "0x400585A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Collider2D collider;

		[Token(Token = "0x400585B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform platformTransform;

		[Token(Token = "0x400585C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float normalizedEnvelopeLength;

		[Token(Token = "0x400585D")]
		[FieldOffset(Offset = "0x60")]
		private Renderer[] platformRenderers;

		[Token(Token = "0x400585E")]
		[FieldOffset(Offset = "0x68")]
		private Rigidbody2D m_rigid;

		[Token(Token = "0x6004B1D")]
		[Address(RVA = "0x15E6AC4", Offset = "0x15E6AC4", VA = "0x15E6AC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004B1E")]
		[Address(RVA = "0x15E6BEC", Offset = "0x15E6BEC", VA = "0x15E6BEC", Slot = "4")]
		public override void PlayStart()
		{
		}

		[Token(Token = "0x6004B1F")]
		[Address(RVA = "0x15E6B4C", Offset = "0x15E6B4C", VA = "0x15E6B4C")]
		private void SetPlatformStatus(bool status)
		{
		}

		[Token(Token = "0x6004B20")]
		[Address(RVA = "0x15E6BF4", Offset = "0x15E6BF4", VA = "0x15E6BF4", Slot = "5")]
		public override void PlayProgress(float t)
		{
		}

		[Token(Token = "0x6004B21")]
		[Address(RVA = "0x15E6CFC", Offset = "0x15E6CFC", VA = "0x15E6CFC", Slot = "6")]
		public override void PlayStop()
		{
		}

		[Token(Token = "0x6004B22")]
		[Address(RVA = "0x15E6D04", Offset = "0x15E6D04", VA = "0x15E6D04")]
		public PlatformBeatObject()
		{
		}
	}
}
