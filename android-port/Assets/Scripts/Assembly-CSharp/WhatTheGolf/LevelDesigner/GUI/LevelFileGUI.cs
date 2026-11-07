using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class LevelFileGUI : MonoBehaviour
	{
		private SerializableLevelData levelData;

		[SerializeField]
		private LevelCoverButtonGUI levelCoverButtonGUI;

		[SerializeField]
		private Button viewButton;

		[SerializeField]
		private TextMeshProUGUI levelNameRenderer;

		[SerializeField]
		private string defaultText;

		[CompilerGenerated]
		private Action<SerializableLevelData> m_OnActionSelected;

		[CompilerGenerated]
		private Action<SerializableLevelData> m_OnViewSelected;

		private bool subscribed;

		public event Action<SerializableLevelData> OnActionSelected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<SerializableLevelData> OnViewSelected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Init(SerializableLevelData levelData, Sprite actionButtonIcon, ButtonStateColors overrideHoverColors = null)
		{
		}

		private void CoverButton_OnSelected(SerializableLevelData levelData)
		{
		}

		private void ViewButton_OnSelected()
		{
		}
	}
}
