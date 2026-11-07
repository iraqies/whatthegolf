using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public sealed class MenuGUI : BaseGUI, IRequireEvents<GameStateEvent>, IRequireEvents
	{
		public enum MenuState
		{
			Home = 0,
			Profile = 1,
			Search = 2,
			LevelInfoPlay = 3,
			LevelInfoEdit = 4
		}

		public enum MenuGroupLayoutType
		{
			Grid = 0,
			Row = 1
		}

		private static MenuGUI s_Instance;

		[SerializeField]
		private TMP_InputField m_SearchField;

		[SerializeField]
		private GameObject m_SearchBar;

		[SerializeField]
		private Button m_BackButton;

		[SerializeField]
		private Button m_ProfileButton;

		[SerializeField]
		private GameObject[] m_CenterObjects;

		[SerializeField]
		private TMP_Text m_ProfileHeaderText;

		[SerializeField]
		private RectTransform m_ContentContainer;

		[SerializeField]
		private GameObject scrollviewContainer;

		[SerializeField]
		private MenuLevelInfoGUI LevelInfoGUI;

		[SerializeField]
		private Scrollbar m_Scrollbar;

		[SerializeField]
		private MenuGroupGUI[] m_GroupPrefabs;

		[SerializeField]
		private MenuGUIData m_MenuGUIData;

		private const int kRecentlyDays = 7;

		private bool m_Initialized;

		private MenuState m_State;

		private string m_SearchString;

		private Stack<MenuStateCache> m_BackStack;

		private List<MenuGroupGUI> m_Groups;

		private SerializableLevelData selectedLevel;

		private static Dictionary<MenuState, int> centerObjectLookup;

		private Regex levelUrlRegex;

		public static MenuGUI Instance => null;

		public override bool isActiveOnOpen => false;

		public override bool hasFocus => false;

		public override void Init()
		{
		}

		public void OnEvent(GameStateEvent evt)
		{
		}

		private void SetMenuState(MenuState state, bool isBack = false)
		{
		}

		private void RecreateGroups()
		{
		}

		private void ResetSearch()
		{
		}

		private void SetBackButtonActive(bool value)
		{
		}

		private void SetProfileButtonActive(bool value)
		{
		}

		private MenuGroupGUI CreateGroup(MenuGroupLayoutType layoutType, MenuGroupType groupType, Color labelColor, Sprite labelSprite, string labelText, Sprite actionButtonIcon, string moreSearchString, Action<SerializableLevelData> mainAction, Action<SerializableLevelData> viewAction, bool includeNewLevel = false)
		{
			return null;
		}

		public void LayoutUpdate()
		{
		}

		private void GetSearchResults(MenuGroupGUI groupGUI, string searchString)
		{
		}

		private void PopulateGroupGui(MenuGroupGUI groupGUI, string query, bool hasNewLevel = false)
		{
		}

		private static string ApplySearchSyntax(string searchString)
		{
			return null;
		}

		private static string RemoveSearchSyntax(string searchString)
		{
			return null;
		}

		public void OnClickHome()
		{
		}

		public void OnClickBack()
		{
		}

		public void OnClickProfile()
		{
		}

		public void OnClickSearch()
		{
		}

		public void RunSearch(string searchString)
		{
		}

		private void SetAndStretchToParentSize(RectTransform rect, RectTransform parent)
		{
		}

		public void PlayLevel(SerializableLevelData serializableLevelData)
		{
		}

		public void EditLevel(SerializableLevelData serializableLevelData)
		{
		}

		public void ShowLevelInfoPlay(SerializableLevelData serializableLevelData)
		{
		}

		public void ShowLevelInfoEdit(SerializableLevelData serializableLevelData)
		{
		}

		public void OnClickCloneLevel()
		{
		}
	}
}
