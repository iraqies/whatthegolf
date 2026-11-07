using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace RedBlueGames.Tools.TextTyper
{
	[Token(Token = "0x2001028")]
	public class TextTyperTester : MonoBehaviour
	{
		[Token(Token = "0x4005538")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioClip printSoundEffect;

		[Token(Token = "0x4005539")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button printNextButton;

		[Token(Token = "0x400553A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button printNoSkipButton;

		[Token(Token = "0x400553B")]
		[FieldOffset(Offset = "0x30")]
		private Queue<string> dialogueLines;

		[Token(Token = "0x400553C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextTyper testTextTyper;

		[Token(Token = "0x6004845")]
		[Address(RVA = "0x1711EA0", Offset = "0x1711EA0", VA = "0x1711EA0")]
		public void Start()
		{
		}

		[Token(Token = "0x6004846")]
		[Address(RVA = "0x17121E4", Offset = "0x17121E4", VA = "0x17121E4")]
		public void Update()
		{
		}

		[Token(Token = "0x6004847")]
		[Address(RVA = "0x17123F0", Offset = "0x17123F0", VA = "0x17123F0")]
		private void HandlePrintNextClicked()
		{
		}

		[Token(Token = "0x6004848")]
		[Address(RVA = "0x1712418", Offset = "0x1712418", VA = "0x1712418")]
		private void HandlePrintNoSkipClicked()
		{
		}

		[Token(Token = "0x6004849")]
		[Address(RVA = "0x1712154", Offset = "0x1712154", VA = "0x1712154")]
		private void ShowScript()
		{
		}

		[Token(Token = "0x600484A")]
		[Address(RVA = "0x1712334", Offset = "0x1712334", VA = "0x1712334")]
		private void LogTag(RichTextTag tag)
		{
		}

		[Token(Token = "0x600484B")]
		[Address(RVA = "0x171241C", Offset = "0x171241C", VA = "0x171241C")]
		private void HandleCharacterPrinted(string printedCharacter)
		{
		}

		[Token(Token = "0x600484C")]
		[Address(RVA = "0x171256C", Offset = "0x171256C", VA = "0x171256C")]
		private void HandlePrintCompleted()
		{
		}

		[Token(Token = "0x600484D")]
		[Address(RVA = "0x17125E0", Offset = "0x17125E0", VA = "0x17125E0")]
		public TextTyperTester()
		{
		}
	}
}
