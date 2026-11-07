using System.Collections.Generic;
using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x20012A7")]
	public static class GUIUtil
	{
		[Token(Token = "0x40064AB")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<ButtonGroupType, List<PersistentButton>> panelButtons;

		[Token(Token = "0x60056B6")]
		[Address(RVA = "0x1476210", Offset = "0x1476210", VA = "0x1476210")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x71B30", Offset = "0x71B30")]
		private static void Init()
		{
		}

		[Token(Token = "0x60056B7")]
		[Address(RVA = "0x14762A0", Offset = "0x14762A0", VA = "0x14762A0")]
		public static void RegisterButton(PersistentButton _button)
		{
		}

		[Token(Token = "0x60056B8")]
		[Address(RVA = "0x1476424", Offset = "0x1476424", VA = "0x1476424")]
		public static void UnregisterButton(PersistentButton _button)
		{
		}

		[Token(Token = "0x60056B9")]
		[Address(RVA = "0x1476508", Offset = "0x1476508", VA = "0x1476508")]
		public static void OnPersistentButtonClicked(PersistentButton _button)
		{
		}

		[Token(Token = "0x60056BA")]
		[Address(RVA = "0x14766B4", Offset = "0x14766B4", VA = "0x14766B4")]
		public static void DeselectGroup(ButtonGroupType groupType)
		{
		}
	}
}
