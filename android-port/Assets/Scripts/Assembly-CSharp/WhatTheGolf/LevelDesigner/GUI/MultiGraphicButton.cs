using System;
using UnityEngine;
using UnityEngine.UI;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public class MultiGraphicButton : Button
	{
		[Serializable]
		private class GraphicToolButtonColorsPair
		{
			public Graphic graphic;

			public ButtonStateColors colors;
		}

		[SerializeField]
		private GraphicToolButtonColorsPair[] graphicsColorPairs;

		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}

		public void SetStateColor(ButtonStateColors colors, int index)
		{
		}
	}
}
