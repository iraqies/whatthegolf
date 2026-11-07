using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001375")]
	public class HarmonikaDyrAudioV2 : MonoBehaviour
	{
		[Token(Token = "0x4006857")]
		[FieldOffset(Offset = "0x18")]
		public HarmonikaDyrShooter harmonika;

		[Token(Token = "0x4006858")]
		[FieldOffset(Offset = "0x20")]
		public ADSREnvelope envelope;

		[Token(Token = "0x4006859")]
		[FieldOffset(Offset = "0x28")]
		public AudioClip clipOut;

		[Token(Token = "0x400685A")]
		[FieldOffset(Offset = "0x30")]
		public AudioClip clipIn;

		[Token(Token = "0x400685B")]
		[FieldOffset(Offset = "0x38")]
		public int fullStretchNoteAmount;

		[Token(Token = "0x400685C")]
		[FieldOffset(Offset = "0x3C")]
		public int baseNote;

		[Token(Token = "0x400685D")]
		[FieldOffset(Offset = "0x40")]
		public MusicMathUtils.Scale scale;

		[Token(Token = "0x400685E")]
		[FieldOffset(Offset = "0x44")]
		public float maxNoteDuration;

		[Token(Token = "0x400685F")]
		[FieldOffset(Offset = "0x48")]
		public float cooldown;

		[Token(Token = "0x4006860")]
		[FieldOffset(Offset = "0x4C")]
		public float maxSpeed;

		[Token(Token = "0x4006861")]
		[FieldOffset(Offset = "0x50")]
		public int queued;

		[Token(Token = "0x4006862")]
		[FieldOffset(Offset = "0x58")]
		private int[] m_notes;

		[Token(Token = "0x4006863")]
		[FieldOffset(Offset = "0x60")]
		private int m_baseNote;

		[Token(Token = "0x4006864")]
		[FieldOffset(Offset = "0x64")]
		private float maxDistance;

		[Token(Token = "0x4006865")]
		[FieldOffset(Offset = "0x68")]
		private int randomBase;

		[Token(Token = "0x4006866")]
		[FieldOffset(Offset = "0x6C")]
		private float currDistance;

		[Token(Token = "0x4006867")]
		[FieldOffset(Offset = "0x70")]
		private int lastNote;

		[Token(Token = "0x4006868")]
		[FieldOffset(Offset = "0x74")]
		private float speed;

		[Token(Token = "0x4006869")]
		[FieldOffset(Offset = "0x78")]
		private double length;

		[Token(Token = "0x400686A")]
		[FieldOffset(Offset = "0x80")]
		private AudioSource audioSource;

		[Token(Token = "0x400686B")]
		[FieldOffset(Offset = "0x88")]
		private float lastDist;

		[Token(Token = "0x6005AE4")]
		[Address(RVA = "0x14C43FC", Offset = "0x14C43FC", VA = "0x14C43FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6005AE5")]
		[Address(RVA = "0x14C44B0", Offset = "0x14C44B0", VA = "0x14C44B0")]
		private int ReturnNote(int index)
		{
			return default;
		}

		[Token(Token = "0x6005AE6")]
		[Address(RVA = "0x14C45A4", Offset = "0x14C45A4", VA = "0x14C45A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6005AE7")]
		[Address(RVA = "0x14C47F8", Offset = "0x14C47F8", VA = "0x14C47F8")]
		public HarmonikaDyrAudioV2()
		{
		}
	}
}
