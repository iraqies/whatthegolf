using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001396")]
	public class PlayAndFadeAudio : MonoBehaviour
	{
		[Token(Token = "0x2001397")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x48EBC", Offset = "0x48EBC")]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			[Token(Token = "0x400692E")]
			[FieldOffset(Offset = "0x10")]
			public PlayAndFadeAudio _003C_003E4__this;

			[Token(Token = "0x400692F")]
			[FieldOffset(Offset = "0x18")]
			public float vol;

			[Token(Token = "0x6005B67")]
			[Address(RVA = "0x1827728", Offset = "0x1827728", VA = "0x1827728")]
			public _003C_003Ec__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6005B68")]
			[Address(RVA = "0x1827730", Offset = "0x1827730", VA = "0x1827730")]
			internal void _003CPlay_003Eb__0(float t)
			{
			}

			[Token(Token = "0x6005B69")]
			[Address(RVA = "0x1827778", Offset = "0x1827778", VA = "0x1827778")]
			internal void _003CPlay_003Eb__1(float t)
			{
			}

			[Token(Token = "0x6005B6A")]
			[Address(RVA = "0x18277C0", Offset = "0x18277C0", VA = "0x18277C0")]
			internal void _003CPlay_003Eb__2()
			{
			}
		}

		[Token(Token = "0x4006928")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ClipSettingsCollection Sound;

		[Token(Token = "0x4006929")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool loop;

		[Token(Token = "0x400692A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float fadeIn;

		[Token(Token = "0x400692B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float fadeOut;

		[Token(Token = "0x400692C")]
		[FieldOffset(Offset = "0x30")]
		private AudioSource m_audioSource;

		[Token(Token = "0x400692D")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isPlaying;

		[Token(Token = "0x6005B64")]
		[Address(RVA = "0x15E8E64", Offset = "0x15E8E64", VA = "0x15E8E64")]
		public void Play()
		{
		}

		[Token(Token = "0x6005B65")]
		[Address(RVA = "0x15E90F0", Offset = "0x15E90F0", VA = "0x15E90F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6005B66")]
		[Address(RVA = "0x15E9190", Offset = "0x15E9190", VA = "0x15E9190")]
		public PlayAndFadeAudio()
		{
		}
	}
}
