using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class LevelCoverButtonGUI : MonoBehaviour
	{
		private SerializableLevelData levelData;

		[SerializeField]
		private MultiGraphicButton button;

		[SerializeField]
		private RawImage thumbnailRenderer;

		[SerializeField]
		private SVGImage actionIconRenderer;

		[SerializeField]
		private GameObject ballIconRendererContainer;

		[SerializeField]
		private SVGImage ballIconRenderer;

		[SerializeField]
		private ButtonStateColors thumbnailHoverColors;

		[SerializeField]
		private GameObject publishedLabel;

		[CompilerGenerated]
		private Action<SerializableLevelData> m_OnSelected;

		private bool subscribed;

		public event Action<SerializableLevelData> OnSelected
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

		public void Init(Sprite actionIcon = null, ButtonStateColors overrideHoverColors = null)
		{
		}

		public void Init(SerializableLevelData levelData, Sprite actionIcon = null, ButtonStateColors overrideHoverColors = null, bool showPublishedStatus = false)
		{
		}

		public void Init(SerializableLevelData levelData, Sprite actionIcon, Texture levelThumbnail, ButtonStateColors overrideHoverColors = null, bool showPublishedStatus = false)
		{
		}

		public void SetButtonInteractable(bool interactable)
		{
		}

		private void Button_OnSelected()
		{
		}
	}
}
