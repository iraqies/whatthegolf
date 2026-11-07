using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001351")]
	public class ApplyAudioMaterialFromCollisionAudio : MonoBehaviour
	{
		[Token(Token = "0x4006763")]
		[FieldOffset(Offset = "0x18")]
		public AudioMaterial audioMaterial;

		[Token(Token = "0x4006764")]
		[FieldOffset(Offset = "0x20")]
		private OnCollisionAudioRemote collisionAudio;

		[Token(Token = "0x6005A27")]
		[Address(RVA = "0x141C5F4", Offset = "0x141C5F4", VA = "0x141C5F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6005A28")]
		[Address(RVA = "0x141C774", Offset = "0x141C774", VA = "0x141C774")]
		public ApplyAudioMaterialFromCollisionAudio()
		{
		}
	}
}
