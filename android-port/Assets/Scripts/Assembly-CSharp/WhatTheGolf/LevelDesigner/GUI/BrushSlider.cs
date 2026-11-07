using System;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class BrushSlider : Slider
	{
		public Action<BaseEventData> onSliderSelected { get; set; }

		public bool IsDragging { get; private set; }

		public override void OnSelect(BaseEventData eventData)
		{
		}

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		public override void OnPointerUp(PointerEventData eventData)
		{
		}
	}
}
