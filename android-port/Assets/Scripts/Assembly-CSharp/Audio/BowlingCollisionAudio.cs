using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200135B")]
	public class BowlingCollisionAudio : MonoBehaviour
	{
		[Token(Token = "0x400679C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rigidbody rigid;

		[Token(Token = "0x400679D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource rollAudioSource;

		[Token(Token = "0x400679E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RandomAudioClips collisionBowlingCourt;

		[Token(Token = "0x400679F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RandomAudioClips groundClips;

		[Token(Token = "0x40067A0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MinMax velocityMinMax;

		[Token(Token = "0x40067A1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AudioMaterial CourtMaterial;

		[Token(Token = "0x40067A2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioMaterial GroundMaterial;

		[Token(Token = "0x40067A3")]
		[FieldOffset(Offset = "0x50")]
		private RigidbodyCollisionInfo col;

		[Token(Token = "0x40067A4")]
		[FieldOffset(Offset = "0x58")]
		private float nextSoundTime;

		[Token(Token = "0x40067A5")]
		[FieldOffset(Offset = "0x5C")]
		private bool onCourt;

		[Token(Token = "0x6005A4A")]
		[Address(RVA = "0x1703740", Offset = "0x1703740", VA = "0x1703740")]
		private void Start()
		{
		}

		[Token(Token = "0x6005A4B")]
		[Address(RVA = "0x1703884", Offset = "0x1703884", VA = "0x1703884")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6005A4C")]
		[Address(RVA = "0x1703A58", Offset = "0x1703A58", VA = "0x1703A58")]
		private void Info_OnCollision(HitInfo info)
		{
		}

		[Token(Token = "0x6005A4D")]
		[Address(RVA = "0x1703D18", Offset = "0x1703D18", VA = "0x1703D18")]
		private void Play(RandomAudioClips clips, float pct)
		{
		}

		[Token(Token = "0x6005A4E")]
		[Address(RVA = "0x1703DA0", Offset = "0x1703DA0", VA = "0x1703DA0")]
		public BowlingCollisionAudio()
		{
		}
	}
}
