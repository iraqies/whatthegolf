using UnityEngine;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class LayerToolGUI : MonoBehaviour
	{
		[SerializeField]
		private LayerIconGUI[] m_LayerIcons;

		[SerializeField]
		private Slider m_Slider;

		private void Awake()
		{
		}

		private void OnSliderChanged(float f)
		{
		}

		private void SetLayerGraphics(int layer)
		{
		}
	}
}
