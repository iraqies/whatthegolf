using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Rumble
{
	[Token(Token = "0x20013F7")]
	public class PS5HapticsAudioPlayer : MonoBehaviour
	{
		[Token(Token = "0x4006B41")]
		[FieldOffset(Offset = "0x18")]
		private AudioSource[] m_AudioSources;

		[Token(Token = "0x4006B42")]
		private const int k_AudioSourceCount = 50;

		[Token(Token = "0x4006B43")]
		[FieldOffset(Offset = "0x20")]
		private int m_AudioSourceIndex;

		[Token(Token = "0x6005CFC")]
		[Address(RVA = "0x15D482C", Offset = "0x15D482C", VA = "0x15D482C")]
		public PS5HapticsAudioPlayer()
		{
		}
	}
}
