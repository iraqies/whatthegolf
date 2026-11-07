using System.Collections.Generic;
using Il2CppDummyDll;

namespace Menu
{
	[Token(Token = "0x2001065")]
	public class MenuDialogueConversation : IConversation
	{
		[Token(Token = "0x4005670")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<SpeechbubbleList.SpeechbubbleTextInfo> _textList;

		[Token(Token = "0x4005671")]
		[FieldOffset(Offset = "0x18")]
		private int index;

		[Token(Token = "0x6004992")]
		[Address(RVA = "0x1561A80", Offset = "0x1561A80", VA = "0x1561A80")]
		public MenuDialogueConversation(MenuDialogueConfig.Entry entry)
		{
		}

		[Token(Token = "0x6004993")]
		[Address(RVA = "0x1561D14", Offset = "0x1561D14", VA = "0x1561D14", Slot = "4")]
		public SpeechbubbleList.SpeechbubbleTextInfo GetText()
		{
			return null;
		}
	}
}
