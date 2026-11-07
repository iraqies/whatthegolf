using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001398")]
	public class PlayerBicycleAudio : MonoBehaviour
	{
		[Token(Token = "0x4006930")]
		[FieldOffset(Offset = "0x18")]
		public BikeBallShooter bike;

		[Token(Token = "0x4006931")]
		[FieldOffset(Offset = "0x20")]
		public AudioClip clipWhileAiming;

		[Token(Token = "0x4006932")]
		[FieldOffset(Offset = "0x28")]
		public AudioClip clipWhileFree;

		[Token(Token = "0x4006933")]
		[FieldOffset(Offset = "0x30")]
		public AudioSource audioSource;

		[Token(Token = "0x6005B6B")]
		[Address(RVA = "0x15F772C", Offset = "0x15F772C", VA = "0x15F772C")]
		private void Update()
		{
		}

		[Token(Token = "0x6005B6C")]
		[Address(RVA = "0x15F7918", Offset = "0x15F7918", VA = "0x15F7918")]
		public PlayerBicycleAudio()
		{
		}
	}
}
