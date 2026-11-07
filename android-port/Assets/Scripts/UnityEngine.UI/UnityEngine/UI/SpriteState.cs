using System;

namespace UnityEngine.UI
{
	[Serializable]
	public struct SpriteState : IEquatable<SpriteState>
	{
		[SerializeField]
		private Sprite m_HighlightedSprite;

		[SerializeField]
		private Sprite m_PressedSprite;

		[SerializeField]
		private Sprite m_SelectedSprite;

		[SerializeField]
		private Sprite m_DisabledSprite;

		public Sprite highlightedSprite => null;

		public Sprite pressedSprite => null;

		public Sprite selectedSprite => null;

		public Sprite disabledSprite => null;

		public bool Equals(SpriteState other)
		{
			return false;
		}
	}
}
