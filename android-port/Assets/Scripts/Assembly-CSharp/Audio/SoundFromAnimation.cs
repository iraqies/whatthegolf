using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013AF")]
	public class SoundFromAnimation : MonoBehaviour
	{
		[Token(Token = "0x40069FE")]
		[FieldOffset(Offset = "0x18")]
		public RandomAudioClips clips;

		[Token(Token = "0x40069FF")]
		[FieldOffset(Offset = "0x20")]
		public AudioSource audioSource;

		[Token(Token = "0x4006A00")]
		[FieldOffset(Offset = "0x28")]
		public bool startRandomPosition;

		[Token(Token = "0x6005BEB")]
		[Address(RVA = "0x16C1438", Offset = "0x16C1438", VA = "0x16C1438")]
		public void Play()
		{
		}

		[Token(Token = "0x6005BEC")]
		[Address(RVA = "0x16C14AC", Offset = "0x16C14AC", VA = "0x16C14AC")]
		public void Stop()
		{
		}

		[Token(Token = "0x6005BED")]
		[Address(RVA = "0x16C14C8", Offset = "0x16C14C8", VA = "0x16C14C8")]
		public SoundFromAnimation()
		{
		}
	}
}
