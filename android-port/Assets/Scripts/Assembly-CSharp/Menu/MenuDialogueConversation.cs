using System.Collections.Generic;

namespace Menu
{
	public class MenuDialogueConversation : IConversation
	{
		private readonly List<SpeechbubbleList.SpeechbubbleTextInfo> _textList;

		private int index;

		public MenuDialogueConversation(MenuDialogueConfig.Entry entry)
		{
		}

		public SpeechbubbleList.SpeechbubbleTextInfo GetText()
		{
			return null;
		}
	}
}
