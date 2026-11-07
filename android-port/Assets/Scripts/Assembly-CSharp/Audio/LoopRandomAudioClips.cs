using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001381")]
	[Attribute(Name = "RequireComponent", RVA = "0x48DDC", Offset = "0x48DDC")]
	public class LoopRandomAudioClips : MonoBehaviour
	{
		[Token(Token = "0x40068A0")]
		[FieldOffset(Offset = "0x18")]
		public float minInterval;

		[Token(Token = "0x40068A1")]
		[FieldOffset(Offset = "0x1C")]
		public float maxInterval;

		[Token(Token = "0x40068A2")]
		[FieldOffset(Offset = "0x20")]
		public RandomAudioClips clips;

		[Token(Token = "0x40068A3")]
		[FieldOffset(Offset = "0x28")]
		public bool startOnAwake;

		[Token(Token = "0x40068A4")]
		[FieldOffset(Offset = "0x29")]
		public bool changeClipOnNewPlay;

		[Token(Token = "0x40068A5")]
		[FieldOffset(Offset = "0x30")]
		private AudioSource _audioSource;

		[Token(Token = "0x40068A6")]
		[FieldOffset(Offset = "0x38")]
		private bool running;

		[Token(Token = "0x40068A7")]
		[FieldOffset(Offset = "0x3C")]
		private float nextEventTime;

		[Token(Token = "0x40068A8")]
		[FieldOffset(Offset = "0x40")]
		private bool isSourcePlaying;

		[Token(Token = "0x6005B15")]
		[Address(RVA = "0x154C050", Offset = "0x154C050", VA = "0x154C050")]
		public void StartPlaying()
		{
		}

		[Token(Token = "0x6005B16")]
		[Address(RVA = "0x154C098", Offset = "0x154C098", VA = "0x154C098")]
		public void StopPlaying()
		{
		}

		[Token(Token = "0x6005B17")]
		[Address(RVA = "0x154C0A0", Offset = "0x154C0A0", VA = "0x154C0A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005B18")]
		[Address(RVA = "0x154C130", Offset = "0x154C130", VA = "0x154C130")]
		private void Update()
		{
		}

		[Token(Token = "0x6005B19")]
		[Address(RVA = "0x154C21C", Offset = "0x154C21C", VA = "0x154C21C")]
		public LoopRandomAudioClips()
		{
		}
	}
}
