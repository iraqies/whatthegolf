using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Serializable]
	[Token(Token = "0x2001415")]
	public class MainMenuData : ScriptableObject
	{
		[Token(Token = "0x4006BAF")]
		[FieldOffset(Offset = "0x18")]
		public bool canShowOfflineWarning;

		[Token(Token = "0x4006BB0")]
		[FieldOffset(Offset = "0x19")]
		public bool showItemExit;

		[Token(Token = "0x4006BB1")]
		[FieldOffset(Offset = "0x1A")]
		public bool showItemSocial;

		[Token(Token = "0x4006BB2")]
		[FieldOffset(Offset = "0x1B")]
		public bool showMouse;

		[Token(Token = "0x4006BB3")]
		[FieldOffset(Offset = "0x1C")]
		public bool showTouch;

		[Token(Token = "0x4006BB4")]
		[FieldOffset(Offset = "0x1D")]
		public bool showSiriRemote;

		[Token(Token = "0x4006BB5")]
		[FieldOffset(Offset = "0x1E")]
		public bool showController;

		[Token(Token = "0x4006BB6")]
		[FieldOffset(Offset = "0x1F")]
		public bool useSettingLanguage;

		[Token(Token = "0x4006BB7")]
		[FieldOffset(Offset = "0x20")]
		public bool useSettingMusic;

		[Token(Token = "0x4006BB8")]
		[FieldOffset(Offset = "0x21")]
		public bool useSettingSFX;

		[Token(Token = "0x4006BB9")]
		[FieldOffset(Offset = "0x22")]
		public bool useSettingResolution;

		[Token(Token = "0x4006BBA")]
		[FieldOffset(Offset = "0x23")]
		public bool useSettingFullscreen;

		[Token(Token = "0x4006BBB")]
		[FieldOffset(Offset = "0x24")]
		public bool userSettingAA;

		[Token(Token = "0x4006BBC")]
		[FieldOffset(Offset = "0x25")]
		public bool useSettingSsaveSlot;

		[Token(Token = "0x4006BBD")]
		[FieldOffset(Offset = "0x26")]
		public bool useSettingSwitchGyroOn;

		[Token(Token = "0x4006BBE")]
		[FieldOffset(Offset = "0x27")]
		public bool useSettingsReconfigureControls;

		[Token(Token = "0x6005D5C")]
		[Address(RVA = "0x1558F58", Offset = "0x1558F58", VA = "0x1558F58")]
		public MainMenuData()
		{
		}
	}
}
