using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class MenuLevelInfoGUI : MonoBehaviour
	{
		[SerializeField]
		private LevelCoverButtonGUI levelCover;

		[SerializeField]
		private TextMeshProUGUI levelTitle;

		[SerializeField]
		private TextMeshProUGUI levelDescription;

		[SerializeField]
		private TextMeshProUGUI sharingLink;

		[SerializeField]
		private Button cloneLevelButton;

		[SerializeField]
		private Button copyLevelLinkButton;

		[SerializeField]
		private GameObject sharingLinkContainer;

		private SerializableLevelData levelData;

		private Action<SerializableLevelData> action;

		private bool subscribed;

		public void Init(SerializableLevelData levelData, Action<SerializableLevelData> action, Sprite actionIcon)
		{
		}

		private void LevelCover_OnSelected(SerializableLevelData levelData)
		{
		}

		private void CloneLevel()
		{
		}

		private void CopyLevelLink()
		{
		}
	}
}
