using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x2001291")]
	public class MenuGroupGUI : MonoBehaviour
	{
		[Token(Token = "0x40063DB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image m_Label;

		[Token(Token = "0x40063DC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SVGImage m_LabelIcon;

		[Token(Token = "0x40063DD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TMP_Text m_LabelText;

		[Token(Token = "0x40063DE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform m_Container;

		[Token(Token = "0x40063DF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LayoutGroup m_LayoutGroup;

		[Token(Token = "0x40063E0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button m_MoreButton;

		[Token(Token = "0x40063E1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject m_FailureNotification;

		[Token(Token = "0x40063E2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private LevelFileGUI m_LevelFileGUI;

		[Token(Token = "0x40063E3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private LevelFileGUI m_NewLevelFileGUI;

		[Token(Token = "0x40063E4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LevelFileGUI m_LoadingFileGUI;

		[Token(Token = "0x40063E5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Sprite m_NewLevelActionIcon;

		[Token(Token = "0x40063E6")]
		private const float kLabelPaddingLeft = 64f;

		[Token(Token = "0x40063E7")]
		private const float kLabelPaddingRight = 32f;

		[Token(Token = "0x40063E8")]
		[FieldOffset(Offset = "0x70")]
		private MenuGUI m_Owner;

		[Token(Token = "0x40063E9")]
		[FieldOffset(Offset = "0x78")]
		private MenuGroupType m_GroupType;

		[Token(Token = "0x40063EA")]
		[FieldOffset(Offset = "0x80")]
		private List<LevelFileGUI> m_LevelGuis;

		[Token(Token = "0x40063EB")]
		[FieldOffset(Offset = "0x88")]
		private List<LevelFileGUI> m_LoadingGuis;

		[Token(Token = "0x40063EC")]
		[FieldOffset(Offset = "0x90")]
		private Sprite m_ActionButtonIcon;

		[Token(Token = "0x40063ED")]
		[FieldOffset(Offset = "0x98")]
		private string m_MoreSearchString;

		[Token(Token = "0x40063EE")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_RequiresLayoutUpdate;

		[Token(Token = "0x40063EF")]
		[FieldOffset(Offset = "0xA8")]
		private Action<SerializableLevelData> mainAction;

		[Token(Token = "0x40063F0")]
		[FieldOffset(Offset = "0xB0")]
		private Action<SerializableLevelData> viewAction;

		[Token(Token = "0x170009CF")]
		public MenuGroupType groupType
		{
			[Token(Token = "0x60055ED")]
			[Address(RVA = "0x15650BC", Offset = "0x15650BC", VA = "0x15650BC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60055EE")]
		[Address(RVA = "0x15650C4", Offset = "0x15650C4", VA = "0x15650C4")]
		public void Init(MenuGUI owner, MenuGroupType groupType, Color labelColor, Sprite labelSprite, string labelText, Sprite actionButtonIcon, string moreSearchString, Action<SerializableLevelData> mainAction, Action<SerializableLevelData> viewAction, bool includeNewLevel = false)
		{
		}

		[Token(Token = "0x60055EF")]
		[Address(RVA = "0x15654BC", Offset = "0x15654BC", VA = "0x15654BC")]
		public void Populate(bool isError, bool hasNewLevel)
		{
		}

		[Token(Token = "0x60055F0")]
		[Address(RVA = "0x15659A4", Offset = "0x15659A4", VA = "0x15659A4")]
		private void Instance_OnActionSelected(SerializableLevelData serializableLevelData)
		{
		}

		[Token(Token = "0x60055F1")]
		[Address(RVA = "0x1565A14", Offset = "0x1565A14", VA = "0x1565A14")]
		private void LevelFileGUI_OnViewSelected(SerializableLevelData serializableLevelData)
		{
		}

		[Token(Token = "0x60055F2")]
		[Address(RVA = "0x1565A84", Offset = "0x1565A84", VA = "0x1565A84")]
		private void Update()
		{
		}

		[Token(Token = "0x60055F3")]
		[Address(RVA = "0x1565C5C", Offset = "0x1565C5C", VA = "0x1565C5C")]
		private void UpdateRowGroup()
		{
		}

		[Token(Token = "0x60055F4")]
		[Address(RVA = "0x1565AD8", Offset = "0x1565AD8", VA = "0x1565AD8")]
		private void UpdateGridGroup()
		{
		}

		[Token(Token = "0x60055F5")]
		[Address(RVA = "0x15654B4", Offset = "0x15654B4", VA = "0x15654B4")]
		private int GetColumnCount()
		{
			return default;
		}

		[Token(Token = "0x60055F6")]
		[Address(RVA = "0x1565D88", Offset = "0x1565D88", VA = "0x1565D88")]
		public MenuGroupGUI()
		{
		}

		[Token(Token = "0x60055F7")]
		[Address(RVA = "0x1565D90", Offset = "0x1565D90", VA = "0x1565D90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71920", Offset = "0x71920")]
		private void _003CPopulate_003Eb__25_0()
		{
		}
	}
}
