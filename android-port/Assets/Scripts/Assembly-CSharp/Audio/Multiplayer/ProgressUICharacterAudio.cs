using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Multiplayer
{
	[Token(Token = "0x2001414")]
	public class ProgressUICharacterAudio : MonoBehaviour
	{
		[Token(Token = "0x4006BAD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ClipSettingsCollection walkOneshot;

		[Token(Token = "0x4006BAE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float footstepInterval;

		[Token(Token = "0x6005D58")]
		[Address(RVA = "0x16262AC", Offset = "0x16262AC", VA = "0x16262AC")]
		private void PlayWalkOneshot()
		{
		}

		[Token(Token = "0x6005D59")]
		[Address(RVA = "0x16262E8", Offset = "0x16262E8", VA = "0x16262E8")]
		public void PlayCharacterWalk()
		{
		}

		[Token(Token = "0x6005D5A")]
		[Address(RVA = "0x1626354", Offset = "0x1626354", VA = "0x1626354")]
		public void StopCharacterWalk()
		{
		}

		[Token(Token = "0x6005D5B")]
		[Address(RVA = "0x16263B0", Offset = "0x16263B0", VA = "0x16263B0")]
		public ProgressUICharacterAudio()
		{
		}
	}
}
