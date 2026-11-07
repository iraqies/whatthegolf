using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	internal sealed class InputSystem : BaseSystem
	{
		private static CursorData s_CursorData;

		private static KeyCode[] s_KeyCodes;

		private Camera m_Camera;

		public static CursorData CursorData => default;

		private Camera camera => null;

		[RuntimeInitializeOnLoadMethod]
		private static void InitOnLoad()
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
	}
}
