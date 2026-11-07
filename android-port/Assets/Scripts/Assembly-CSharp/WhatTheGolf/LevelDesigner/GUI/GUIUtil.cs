using System.Collections.Generic;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.GUI
{
	public static class GUIUtil
	{
		public static Dictionary<ButtonGroupType, List<PersistentButton>> panelButtons;

		[RuntimeInitializeOnLoadMethod]
		private static void Init()
		{
		}

		public static void RegisterButton(PersistentButton _button)
		{
		}

		public static void UnregisterButton(PersistentButton _button)
		{
		}

		public static void OnPersistentButtonClicked(PersistentButton _button)
		{
		}

		public static void DeselectGroup(ButtonGroupType groupType)
		{
		}
	}
}
