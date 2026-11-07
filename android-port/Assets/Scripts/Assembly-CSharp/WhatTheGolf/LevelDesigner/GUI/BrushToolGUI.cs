using System;
using System.Runtime.CompilerServices;
using Triband.GolfTerrainTool;
using UnityEngine;
using UnityEngine.EventSystems;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class BrushToolGUI : MonoBehaviour
	{
		[SerializeField]
		private PersistentButton m_Button;

		[SerializeField]
		private BrushSlider m_Slider;

		[SerializeField]
		private RectTransform m_CircleContainer;

		[CompilerGenerated]
		private Action m_OnBrushSelectedOrChanged;

		private const float kMinBrushSize = 2f;

		private const float kMaxBrushSize = 10f;

		private const float kMinCircleScale = 0.5f;

		private const float kMaxCircleScale = 1f;

		public Brush Brush { get; private set; }

		public BrushSlider BrushSlider => null;

		public event Action OnBrushSelectedOrChanged
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

		private void Awake()
		{
		}

		private void ResetSlider()
		{
		}

		private void OnSliderSelected(BaseEventData obj)
		{
		}

		private void OnButtonClick(PersistentButton _button)
		{
		}

		private void OnSliderChanged(float t)
		{
		}

		private void SendSetBrushEvent()
		{
		}
	}
}
