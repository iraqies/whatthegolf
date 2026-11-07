using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001353")]
	public class AudioClipFromParticleBurst : MonoBehaviour
	{
		[Token(Token = "0x400676D")]
		[FieldOffset(Offset = "0x18")]
		public ParticleSystem particle;

		[Token(Token = "0x400676E")]
		[FieldOffset(Offset = "0x20")]
		public AudioSource source;

		[Token(Token = "0x400676F")]
		[FieldOffset(Offset = "0x28")]
		public RandomAudioClips audioClips;

		[Token(Token = "0x4006770")]
		[FieldOffset(Offset = "0x30")]
		public float cooldown;

		[Token(Token = "0x4006771")]
		[FieldOffset(Offset = "0x34")]
		private float nextSoundTime;

		[Token(Token = "0x6005A30")]
		[Address(RVA = "0x142C290", Offset = "0x142C290", VA = "0x142C290")]
		private void Update()
		{
		}

		[Token(Token = "0x6005A31")]
		[Address(RVA = "0x142C3D8", Offset = "0x142C3D8", VA = "0x142C3D8")]
		private void Play()
		{
		}

		[Token(Token = "0x6005A32")]
		[Address(RVA = "0x142C4A0", Offset = "0x142C4A0", VA = "0x142C4A0")]
		public AudioClipFromParticleBurst()
		{
		}
	}
}
