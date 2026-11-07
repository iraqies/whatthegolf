using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013B0")]
	[Attribute(Name = "RequireComponent", RVA = "0x48EEC", Offset = "0x48EEC")]
	public abstract class SpeechAudioBase : MonoBehaviour
	{
		[Token(Token = "0x4006A01")]
		[FieldOffset(Offset = "0x18")]
		protected AudioSource m_audioSource;

		[Token(Token = "0x6005BEE")]
		[Address(RVA = "0x16CEA64", Offset = "0x16CEA64", VA = "0x16CEA64", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6005BEF")]
		[Address(RVA = "0x16CEAC0", Offset = "0x16CEAC0", VA = "0x16CEAC0", Slot = "5")]
		public virtual void UpdateSpeech()
		{
		}

		[Token(Token = "0x6005BF0")]
		[Address(RVA = "0x16CEAC4", Offset = "0x16CEAC4", VA = "0x16CEAC4", Slot = "6")]
		protected virtual void PlayClip()
		{
		}

		[Token(Token = "0x6005BF1")]
		[Address(RVA = "0x16CEAC8", Offset = "0x16CEAC8", VA = "0x16CEAC8")]
		protected SpeechAudioBase()
		{
		}
	}
}
