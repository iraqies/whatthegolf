using System.Collections.Generic;
using UnityEngine;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner
{
	internal sealed class UndoSystem : BaseSystem, IRequireEvents<GUIEvent>, IRequireEvents, IRequireEvents<InputEvent>
	{
		private static Stack<LevelContentData> m_UndoStack;

		private static Stack<LevelContentData> m_RedoStack;

		public static bool HasUndo => false;

		public static bool HasRedo => false;

		[RuntimeInitializeOnLoadMethod]
		private static void InitOnLoad()
		{
		}

		public static void RegisterUndo(bool clearRedoStack = true)
		{
		}

		public static void ClearStacks()
		{
		}

		public override void Init()
		{
		}

		public override void Update()
		{
		}

		public override void Dispose()
		{
		}

		private static void PerformUndo()
		{
		}

		private static void PerformRedo()
		{
		}

		public void OnEvent(GUIEvent evt)
		{
		}

		public void OnEvent(InputEvent evt)
		{
		}
	}
}
