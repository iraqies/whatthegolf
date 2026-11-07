using UnityEngine;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class LayerIconGUI : MonoBehaviour
	{
		[SerializeField]
		private Color m_ActiveColor;

		[SerializeField]
		private Color m_InactiveColor;

		[SerializeField]
		private SVGImage m_OuterImage;

		[SerializeField]
		private SVGImage m_InnerImage;

		public void SetColor(bool active)
		{
		}
	}
}
