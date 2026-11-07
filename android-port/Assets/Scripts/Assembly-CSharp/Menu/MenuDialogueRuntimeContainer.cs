using System.Collections.Generic;
using Core;
using Il2CppDummyDll;

namespace Menu
{
	[Token(Token = "0x2001066")]
	public class MenuDialogueRuntimeContainer : AddressableSingleton<MenuDialogueRuntimeContainer>
	{
		[Token(Token = "0x4005672")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, MenuDialogueConfig.Entry> entries;

		[Token(Token = "0x6004994")]
		[Address(RVA = "0x1561DA8", Offset = "0x1561DA8", VA = "0x1561DA8")]
		public void ClearEntries()
		{
		}

		[Token(Token = "0x6004995")]
		[Address(RVA = "0x1561DFC", Offset = "0x1561DFC", VA = "0x1561DFC")]
		public void AddEntry(string n, MenuDialogueConfig.Entry entry)
		{
		}

		[Token(Token = "0x6004996")]
		[Address(RVA = "0x1561EC0", Offset = "0x1561EC0", VA = "0x1561EC0")]
		public MenuDialogueConfig.Entry GetEntry(string n)
		{
			return null;
		}

		[Token(Token = "0x6004997")]
		[Address(RVA = "0x1561F24", Offset = "0x1561F24", VA = "0x1561F24")]
		public bool HasEntry(string n)
		{
			return default;
		}

		[Token(Token = "0x6004998")]
		[Address(RVA = "0x1561F88", Offset = "0x1561F88", VA = "0x1561F88")]
		public MenuDialogueRuntimeContainer()
		{
		}
	}
}
