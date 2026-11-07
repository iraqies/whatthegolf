using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class MenuGroupGUI : MonoBehaviour
	{
		[SerializeField]
		private Image m_Label;

		[SerializeField]
		private SVGImage m_LabelIcon;

		[SerializeField]
		private TMP_Text m_LabelText;

		[SerializeField]
		private RectTransform m_Container;

		[SerializeField]
		private LayoutGroup m_LayoutGroup;

		[SerializeField]
		private Button m_MoreButton;

		[SerializeField]
		private GameObject m_FailureNotification;

		[SerializeField]
		private LevelFileGUI m_LevelFileGUI;

		[SerializeField]
		private LevelFileGUI m_NewLevelFileGUI;

		[SerializeField]
		private LevelFileGUI m_LoadingFileGUI;

		[SerializeField]
		private Sprite m_NewLevelActionIcon;

		private const float kLabelPaddingLeft = 64f;

		private const float kLabelPaddingRight = 32f;

		private MenuGUI m_Owner;

		private MenuGroupType m_GroupType;

		private List<LevelFileGUI> m_LevelGuis;

		private List<LevelFileGUI> m_LoadingGuis;

		private Sprite m_ActionButtonIcon;

		private string m_MoreSearchString;

		private bool m_RequiresLayoutUpdate;

		private Action<SerializableLevelData> mainAction;

		private Action<SerializableLevelData> viewAction;

		public MenuGroupType groupType => MenuGroupType.Local;

		public void Init(MenuGUI owner, MenuGroupType groupType, Color labelColor, Sprite labelSprite, string labelText, Sprite actionButtonIcon, string moreSearchString, Action<SerializableLevelData> mainAction, Action<SerializableLevelData> viewAction, bool includeNewLevel = false)
		{
		}

		public void Populate(bool isError, bool hasNewLevel)
		{
		}

		private void Instance_OnActionSelected(SerializableLevelData serializableLevelData)
		{
		}

		private void LevelFileGUI_OnViewSelected(SerializableLevelData serializableLevelData)
		{
		}

		private void Update()
		{
		}

		private void UpdateRowGroup()
		{
		}

		private void UpdateGridGroup()
		{
		}

		private int GetColumnCount()
		{
			return 0;
		}
	}
}
