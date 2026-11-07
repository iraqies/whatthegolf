using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x200128C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x48844", Offset = "0x48844")]
	public sealed class MenuGUI : BaseGUI, IRequireEvents<GameStateEvent>, IRequireEvents
	{
		[Token(Token = "0x200128D")]
		public enum MenuState
		{
			[Token(Token = "0x40063CF")]
			Home = 0,
			[Token(Token = "0x40063D0")]
			Profile = 1,
			[Token(Token = "0x40063D1")]
			Search = 2,
			[Token(Token = "0x40063D2")]
			LevelInfoPlay = 3,
			[Token(Token = "0x40063D3")]
			LevelInfoEdit = 4
		}

		[Token(Token = "0x200128E")]
		public enum MenuGroupLayoutType
		{
			[Token(Token = "0x40063D5")]
			Grid = 0,
			[Token(Token = "0x40063D6")]
			Row = 1
		}

		[Token(Token = "0x200128F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x488AC", Offset = "0x488AC")]
		private sealed class _003C_003Ec__DisplayClass41_0
		{
			[Token(Token = "0x40063D7")]
			[FieldOffset(Offset = "0x10")]
			public MenuGroupGUI groupGUI;

			[Token(Token = "0x60055EB")]
			[Address(RVA = "0x17F6E18", Offset = "0x17F6E18", VA = "0x17F6E18")]
			public _003C_003Ec__DisplayClass41_0()
			{
			}

			[Token(Token = "0x60055EC")]
			[Address(RVA = "0x17F6E20", Offset = "0x17F6E20", VA = "0x17F6E20")]
			internal void _003CPopulateGroupGui_003Eb__0(bool e)
			{
			}
		}

		[Token(Token = "0x40063B8")]
		[FieldOffset(Offset = "0x0")]
		private static MenuGUI s_Instance;

		[Token(Token = "0x40063B9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TMP_InputField m_SearchField;

		[Token(Token = "0x40063BA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject m_SearchBar;

		[Token(Token = "0x40063BB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button m_BackButton;

		[Token(Token = "0x40063BC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button m_ProfileButton;

		[Token(Token = "0x40063BD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject[] m_CenterObjects;

		[Token(Token = "0x40063BE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TMP_Text m_ProfileHeaderText;

		[Token(Token = "0x40063BF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform m_ContentContainer;

		[Token(Token = "0x40063C0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject scrollviewContainer;

		[Token(Token = "0x40063C1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private MenuLevelInfoGUI LevelInfoGUI;

		[Token(Token = "0x40063C2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Scrollbar m_Scrollbar;

		[Token(Token = "0x40063C3")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private MenuGroupGUI[] m_GroupPrefabs;

		[Token(Token = "0x40063C4")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private MenuGUIData m_MenuGUIData;

		[Token(Token = "0x40063C5")]
		private const int kRecentlyDays = 7;

		[Token(Token = "0x40063C6")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_Initialized;

		[Token(Token = "0x40063C7")]
		[FieldOffset(Offset = "0xA4")]
		private MenuState m_State;

		[Token(Token = "0x40063C8")]
		[FieldOffset(Offset = "0xA8")]
		private string m_SearchString;

		[Token(Token = "0x40063C9")]
		[FieldOffset(Offset = "0xB0")]
		private Stack<MenuStateCache> m_BackStack;

		[Token(Token = "0x40063CA")]
		[FieldOffset(Offset = "0xB8")]
		private List<MenuGroupGUI> m_Groups;

		[Token(Token = "0x40063CB")]
		[FieldOffset(Offset = "0xC0")]
		private SerializableLevelData selectedLevel;

		[Token(Token = "0x40063CC")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<MenuState, int> centerObjectLookup;

		[Token(Token = "0x40063CD")]
		[FieldOffset(Offset = "0xC8")]
		private Regex levelUrlRegex;

		[Token(Token = "0x170009CC")]
		public static MenuGUI Instance
		{
			[Token(Token = "0x60055CE")]
			[Address(RVA = "0x1562668", Offset = "0x1562668", VA = "0x1562668")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009CD")]
		public override bool isActiveOnOpen
		{
			[Token(Token = "0x60055D0")]
			[Address(RVA = "0x1562924", Offset = "0x1562924", VA = "0x1562924", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170009CE")]
		public override bool hasFocus
		{
			[Token(Token = "0x60055D1")]
			[Address(RVA = "0x156292C", Offset = "0x156292C", VA = "0x156292C", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60055CF")]
		[Address(RVA = "0x15627A4", Offset = "0x15627A4", VA = "0x15627A4")]
		public MenuGUI()
		{
		}

		[Token(Token = "0x60055D2")]
		[Address(RVA = "0x1562934", Offset = "0x1562934", VA = "0x1562934", Slot = "6")]
		public override void Init()
		{
		}

		[Token(Token = "0x60055D3")]
		[Address(RVA = "0x156378C", Offset = "0x156378C", VA = "0x156378C", Slot = "7")]
		public void OnEvent(GameStateEvent evt)
		{
		}

		[Token(Token = "0x60055D4")]
		[Address(RVA = "0x1563800", Offset = "0x1563800", VA = "0x1563800")]
		private void SetMenuState(MenuState state, bool isBack = false)
		{
		}

		[Token(Token = "0x60055D5")]
		[Address(RVA = "0x1562984", Offset = "0x1562984", VA = "0x1562984")]
		private void RecreateGroups()
		{
		}

		[Token(Token = "0x60055D6")]
		[Address(RVA = "0x1563C9C", Offset = "0x1563C9C", VA = "0x1563C9C")]
		private void ResetSearch()
		{
		}

		[Token(Token = "0x60055D7")]
		[Address(RVA = "0x1563D08", Offset = "0x1563D08", VA = "0x1563D08")]
		private void SetBackButtonActive(bool value)
		{
		}

		[Token(Token = "0x60055D8")]
		[Address(RVA = "0x1563D44", Offset = "0x1563D44", VA = "0x1563D44")]
		private void SetProfileButtonActive(bool value)
		{
		}

		[Token(Token = "0x60055D9")]
		[Address(RVA = "0x1563DF0", Offset = "0x1563DF0", VA = "0x1563DF0")]
		private MenuGroupGUI CreateGroup(MenuGroupLayoutType layoutType, MenuGroupType groupType, Color labelColor, Sprite labelSprite, string labelText, Sprite actionButtonIcon, string moreSearchString, Action<SerializableLevelData> mainAction, Action<SerializableLevelData> viewAction, bool includeNewLevel = false)
		{
			return null;
		}

		[Token(Token = "0x60055DA")]
		[Address(RVA = "0x1564678", Offset = "0x1564678", VA = "0x1564678")]
		public void LayoutUpdate()
		{
		}

		[Token(Token = "0x60055DB")]
		[Address(RVA = "0x15641D8", Offset = "0x15641D8", VA = "0x15641D8")]
		private void GetSearchResults(MenuGroupGUI groupGUI, string searchString)
		{
		}

		[Token(Token = "0x60055DC")]
		[Address(RVA = "0x1564010", Offset = "0x1564010", VA = "0x1564010")]
		private void PopulateGroupGui(MenuGroupGUI groupGUI, string query, bool hasNewLevel = false)
		{
		}

		[Token(Token = "0x60055DD")]
		[Address(RVA = "0x1563D80", Offset = "0x1563D80", VA = "0x1563D80")]
		private static string ApplySearchSyntax(string searchString)
		{
			return null;
		}

		[Token(Token = "0x60055DE")]
		[Address(RVA = "0x156413C", Offset = "0x156413C", VA = "0x156413C")]
		private static string RemoveSearchSyntax(string searchString)
		{
			return null;
		}

		[Token(Token = "0x60055DF")]
		[Address(RVA = "0x156479C", Offset = "0x156479C", VA = "0x156479C")]
		public void OnClickHome()
		{
		}

		[Token(Token = "0x60055E0")]
		[Address(RVA = "0x1564800", Offset = "0x1564800", VA = "0x1564800")]
		public void OnClickBack()
		{
		}

		[Token(Token = "0x60055E1")]
		[Address(RVA = "0x15648BC", Offset = "0x15648BC", VA = "0x15648BC")]
		public void OnClickProfile()
		{
		}

		[Token(Token = "0x60055E2")]
		[Address(RVA = "0x15648C8", Offset = "0x15648C8", VA = "0x15648C8")]
		public void OnClickSearch()
		{
		}

		[Token(Token = "0x60055E3")]
		[Address(RVA = "0x15648E4", Offset = "0x15648E4", VA = "0x15648E4")]
		public void RunSearch(string searchString)
		{
		}

		[Token(Token = "0x60055E4")]
		[Address(RVA = "0x15649CC", Offset = "0x15649CC", VA = "0x15649CC")]
		private void SetAndStretchToParentSize(RectTransform rect, RectTransform parent)
		{
		}

		[Token(Token = "0x60055E5")]
		[Address(RVA = "0x1564A8C", Offset = "0x1564A8C", VA = "0x1564A8C")]
		public void PlayLevel(SerializableLevelData serializableLevelData)
		{
		}

		[Token(Token = "0x60055E6")]
		[Address(RVA = "0x1564B0C", Offset = "0x1564B0C", VA = "0x1564B0C")]
		public void EditLevel(SerializableLevelData serializableLevelData)
		{
		}

		[Token(Token = "0x60055E7")]
		[Address(RVA = "0x1564B9C", Offset = "0x1564B9C", VA = "0x1564B9C")]
		public void ShowLevelInfoPlay(SerializableLevelData serializableLevelData)
		{
		}

		[Token(Token = "0x60055E8")]
		[Address(RVA = "0x1564BAC", Offset = "0x1564BAC", VA = "0x1564BAC")]
		public void ShowLevelInfoEdit(SerializableLevelData serializableLevelData)
		{
		}

		[Token(Token = "0x60055E9")]
		[Address(RVA = "0x1564BBC", Offset = "0x1564BBC", VA = "0x1564BBC")]
		public void OnClickCloneLevel()
		{
		}
	}
}
