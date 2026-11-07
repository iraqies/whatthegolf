using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x200128B")]
	internal struct MenuStateCache
	{
		[Token(Token = "0x40063B6")]
		[FieldOffset(Offset = "0x0")]
		public readonly MenuGUI.MenuState state;

		[Token(Token = "0x40063B7")]
		[FieldOffset(Offset = "0x8")]
		public readonly string searchString;

		[Token(Token = "0x60055CD")]
		[Address(RVA = "0x1566F20", Offset = "0x1566F20", VA = "0x1566F20")]
		public MenuStateCache(MenuGUI.MenuState state, string searchString)
		{
		}
	}
}
