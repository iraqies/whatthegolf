using System;
using System.Collections.Generic;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class GUIElementTabContent : ScriptableObject
	{
		public GUIElementType type;

		[NonSerialized]
		private List<ElementDefinition> elements;

		public Sprite icon;

		public string title;

		public void SetContent(List<ElementDefinition> content)
		{
		}

		public List<ElementDefinition> GetContent()
		{
			return null;
		}
	}
}
