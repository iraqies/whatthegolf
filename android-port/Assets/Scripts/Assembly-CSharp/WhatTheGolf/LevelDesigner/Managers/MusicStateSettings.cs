using System;

namespace WhatTheGolf.LevelDesigner.Managers
{
	[Serializable]
	public struct MusicStateSettings
	{
		public LevelMusicSettings musicData;

		public float rtpcInEditMode;

		public float rtpcInPlaymode;

		public int transitionTimeToPlaymode;

		public int transitionTimeToEditmode;
	}
}
