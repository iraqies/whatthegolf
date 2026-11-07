using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	public sealed class MenuGUIData : ScriptableObject
	{
		[SerializeField]
		private Sprite m_CrownIcon;

		[SerializeField]
		private Sprite m_SearchIcon;

		[SerializeField]
		private Sprite m_PlayLevelIcon;

		[SerializeField]
		private Sprite m_EditLevelIcon;

		[SerializeField]
		private Color m_DefaultLabelColor;

		[SerializeField]
		private Color m_DarkLabelColor;

		[SerializeField]
		private Color m_SearchLabelColor;

		[SerializeField]
		private Color m_FavoruiteLabelColor;

		public Sprite crownIcon => null;

		public Sprite searchIcon => null;

		public Sprite playLevelIcon => null;

		public Sprite editLevelIcon => null;

		public Color defaultLabelColor => default;

		public Color darkLabelColor => default;

		public Color searchLabelColor => default;

		public Color favouriteLabelColor => default;
	}
}
