using System;
using System.Collections.Generic;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner
{
	public sealed class GuiController : MonoBehaviour, IRequireEvents<GUIEvent>, IRequireEvents, IRequireEvents<GameStateEvent>
	{
		[SerializeField]
		private GuiGroup[] m_GuiGroups;

		private static List<int> m_ActiveGroupIndices;

		private static bool s_HasFocus;

		private static bool s_IsInModals;

		private static Type s_CurrentModalType;

		private static bool s_IsDraggingGui;

		private bool m_Initialized;

		public static bool HasFocus => false;

		public static bool IsInModals => false;

		public void Init(Camera camera)
		{
		}

		private void Update()
		{
		}

		public void OnEvent(GameStateEvent evt)
		{
		}

		public void OnEvent(GUIEvent evt)
		{
		}

		private void UpdateGuiGroups()
		{
		}
	}
}
