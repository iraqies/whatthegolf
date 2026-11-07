using System.Collections.Generic;
using Core;

namespace Menu
{
	public class MenuDialogueRuntimeContainer : AddressableSingleton<MenuDialogueRuntimeContainer>
	{
		private Dictionary<string, MenuDialogueConfig.Entry> entries;

		public void ClearEntries()
		{
		}

		public void AddEntry(string n, MenuDialogueConfig.Entry entry)
		{
		}

		public MenuDialogueConfig.Entry GetEntry(string n)
		{
			return null;
		}

		public bool HasEntry(string n)
		{
			return false;
		}
	}
}
