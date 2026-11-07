using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x2001295")]
	public class FileGUI : BaseGUI, IRequireEvents<GUIEvent>, IRequireEvents
	{
		[Token(Token = "0x40063FE")]
		[FieldOffset(Offset = "0x40")]
		private SerializableLevelData[] levelDatas;

		[Token(Token = "0x40063FF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private LevelFileGUI levelFileGUIPrefab;

		[Token(Token = "0x4006400")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private LayoutGroup contentLayoutGroup;

		[Token(Token = "0x4006401")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ScrollRect scroll;

		[Token(Token = "0x4006402")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Sprite newLevelActionIcon;

		[Token(Token = "0x4006403")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Sprite editLevelActionIcon;

		[Token(Token = "0x4006404")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button closeButton;

		[Token(Token = "0x4006405")]
		[FieldOffset(Offset = "0x78")]
		private List<LevelFileGUI> levelFileGUIButtons;

		[Token(Token = "0x4006406")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private LevelFileGUI newLevelFileGUI;

		[Token(Token = "0x4006407")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ButtonStateColors currentLevelHoverColors;

		[Token(Token = "0x4006408")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ButtonStateColors defaultHoverColors;

		[Token(Token = "0x4006409")]
		[FieldOffset(Offset = "0x98")]
		private bool m_IsVisible;

		[Token(Token = "0x400640A")]
		[FieldOffset(Offset = "0xA0")]
		private SerializableLevelData cachedLevel;

		[Token(Token = "0x170009D0")]
		public override bool isActiveOnOpen
		{
			[Token(Token = "0x6005601")]
			[Address(RVA = "0x1461510", Offset = "0x1461510", VA = "0x1461510", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005602")]
		[Address(RVA = "0x1461518", Offset = "0x1461518", VA = "0x1461518", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005603")]
		[Address(RVA = "0x14616AC", Offset = "0x14616AC", VA = "0x14616AC")]
		private void CloseButton_OnSelected()
		{
		}

		[Token(Token = "0x6005604")]
		[Address(RVA = "0x1461780", Offset = "0x1461780", VA = "0x1461780")]
		private void LevelFileGUI_OnViewSelected(SerializableLevelData levelData)
		{
		}

		[Token(Token = "0x6005605")]
		[Address(RVA = "0x14618A4", Offset = "0x14618A4", VA = "0x14618A4")]
		private void LevelFileGUI_OnActionSelected(SerializableLevelData levelData)
		{
		}

		[Token(Token = "0x6005606")]
		[Address(RVA = "0x14619C0", Offset = "0x14619C0", VA = "0x14619C0")]
		private void LoadCachedLevel()
		{
		}

		[Token(Token = "0x6005607")]
		[Address(RVA = "0x1461ADC", Offset = "0x1461ADC", VA = "0x1461ADC", Slot = "7")]
		public void OnEvent(GUIEvent evt)
		{
		}

		[Token(Token = "0x6005608")]
		[Address(RVA = "0x1461B74", Offset = "0x1461B74", VA = "0x1461B74")]
		private void Show()
		{
		}

		[Token(Token = "0x6005609")]
		[Address(RVA = "0x14616B0", Offset = "0x14616B0", VA = "0x14616B0")]
		private void Hide()
		{
		}

		[Token(Token = "0x600560A")]
		[Address(RVA = "0x1461FEC", Offset = "0x1461FEC", VA = "0x1461FEC")]
		private void ClearAndDisable()
		{
		}

		[Token(Token = "0x600560B")]
		[Address(RVA = "0x146228C", Offset = "0x146228C", VA = "0x146228C")]
		public FileGUI()
		{
		}
	}
}
