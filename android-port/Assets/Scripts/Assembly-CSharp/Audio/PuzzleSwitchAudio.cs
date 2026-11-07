using Il2CppDummyDll;
using Puzzle;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013A0")]
	public class PuzzleSwitchAudio : MonoBehaviour
	{
		[Token(Token = "0x400697F")]
		[FieldOffset(Offset = "0x18")]
		public RandomAudioClips downClips;

		[Token(Token = "0x4006980")]
		[FieldOffset(Offset = "0x20")]
		public RandomAudioClips upClips;

		[Token(Token = "0x4006981")]
		[FieldOffset(Offset = "0x28")]
		private PuzzleSwitchBase puzzleSwitch;

		[Token(Token = "0x6005BA3")]
		[Address(RVA = "0x1631498", Offset = "0x1631498", VA = "0x1631498")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005BA4")]
		[Address(RVA = "0x16314F4", Offset = "0x16314F4", VA = "0x16314F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005BA5")]
		[Address(RVA = "0x16315D8", Offset = "0x16315D8", VA = "0x16315D8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005BA6")]
		[Address(RVA = "0x16316BC", Offset = "0x16316BC", VA = "0x16316BC")]
		private void OnSwitchChanged(bool down)
		{
		}

		[Token(Token = "0x6005BA7")]
		[Address(RVA = "0x1631704", Offset = "0x1631704", VA = "0x1631704")]
		public PuzzleSwitchAudio()
		{
		}
	}
}
