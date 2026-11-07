using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x200129D")]
	public class SaveGUI : BaseGUI, IRequireEvents<GUIEvent>, IRequireEvents
	{
		[Token(Token = "0x4006473")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private LevelCoverButtonGUI levelCoverButtonGUI;

		[Token(Token = "0x4006474")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button saveButton;

		[Token(Token = "0x4006475")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject publishedLabel;

		[Token(Token = "0x4006476")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button saveAsButton;

		[Token(Token = "0x4006477")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button closeButton;

		[Token(Token = "0x4006478")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button optionsButton;

		[Token(Token = "0x4006479")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Sprite actionIcon;

		[Token(Token = "0x400647A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TextMeshProUGUI levelName;

		[Token(Token = "0x400647B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextMeshProUGUI description;

		[Token(Token = "0x400647C")]
		[FieldOffset(Offset = "0x88")]
		private SerializableLevelData levelData;

		[Token(Token = "0x400647D")]
		[FieldOffset(Offset = "0x90")]
		private bool m_IsVisible;

		[Token(Token = "0x170009D5")]
		public override bool isActiveOnOpen
		{
			[Token(Token = "0x600565A")]
			[Address(RVA = "0x166BAA4", Offset = "0x166BAA4", VA = "0x166BAA4", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600565B")]
		[Address(RVA = "0x166BAAC", Offset = "0x166BAAC", VA = "0x166BAAC", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x600565C")]
		[Address(RVA = "0x166BCF0", Offset = "0x166BCF0", VA = "0x166BCF0")]
		private void CloseButton_OnSelected()
		{
		}

		[Token(Token = "0x600565D")]
		[Address(RVA = "0x166BDC4", Offset = "0x166BDC4", VA = "0x166BDC4")]
		private void LevelCoverButtonGUI_OnSelected(SerializableLevelData obj)
		{
		}

		[Token(Token = "0x600565E")]
		[Address(RVA = "0x166BDC8", Offset = "0x166BDC8", VA = "0x166BDC8")]
		private void Save()
		{
		}

		[Token(Token = "0x600565F")]
		[Address(RVA = "0x166BEE0", Offset = "0x166BEE0", VA = "0x166BEE0")]
		private void SaveNew()
		{
		}

		[Token(Token = "0x6005660")]
		[Address(RVA = "0x166BF5C", Offset = "0x166BF5C", VA = "0x166BF5C")]
		private void SaveAs()
		{
		}

		[Token(Token = "0x6005661")]
		[Address(RVA = "0x166BFD8", Offset = "0x166BFD8", VA = "0x166BFD8")]
		private void OpenLevelOptions()
		{
		}

		[Token(Token = "0x6005662")]
		[Address(RVA = "0x166C12C", Offset = "0x166C12C", VA = "0x166C12C", Slot = "7")]
		public void OnEvent(GUIEvent evt)
		{
		}

		[Token(Token = "0x6005663")]
		[Address(RVA = "0x166C1C4", Offset = "0x166C1C4", VA = "0x166C1C4")]
		private void Show()
		{
		}

		[Token(Token = "0x6005664")]
		[Address(RVA = "0x166BCF4", Offset = "0x166BCF4", VA = "0x166BCF4")]
		private void Hide()
		{
		}

		[Token(Token = "0x6005665")]
		[Address(RVA = "0x166C4A0", Offset = "0x166C4A0", VA = "0x166C4A0")]
		private void Disable()
		{
		}

		[Token(Token = "0x6005666")]
		[Address(RVA = "0x166C5C8", Offset = "0x166C5C8", VA = "0x166C5C8")]
		public SaveGUI()
		{
		}
	}
}
