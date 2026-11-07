using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Events
{
	public struct KeyCodeArgs
	{
		public KeyCode key;

		public KeyCodeArgs(KeyCode key)
		{
			this.key = KeyCode.None;
		}
	}
}
