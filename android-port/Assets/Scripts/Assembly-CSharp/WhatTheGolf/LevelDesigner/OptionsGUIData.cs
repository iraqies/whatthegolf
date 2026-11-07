using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	public sealed class OptionsGUIData : ScriptableObject
	{
		[SerializeField]
		private Sprite m_PlayIcon;

		[SerializeField]
		private Sprite m_PauseIcon;

		public Sprite playIcon => null;

		public Sprite pauseIcon => null;
	}
}
