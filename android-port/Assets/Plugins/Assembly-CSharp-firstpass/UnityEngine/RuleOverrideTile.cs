using System;
using System.Collections.Generic;
using UnityEngine.Tilemaps;

namespace UnityEngine
{
	[Serializable]
	public class RuleOverrideTile : RuleTile
	{
		[Serializable]
		public class TileSpritePair
		{
			public Sprite m_OriginalSprite;

			public Sprite m_OverrideSprite;
		}

		[Serializable]
		public class OverrideTilingRule
		{
			public bool m_Enabled;

			public TilingRule m_TilingRule;
		}

		public RuleTile m_Tile;

		public bool m_Advanced;

		public List<TileSpritePair> m_Sprites;

		public List<OverrideTilingRule> m_OverrideTilingRules;

		public OverrideTilingRule m_OverrideDefault;

		// C# has no syntax for parameterized property 'Item'.
		public Sprite get_Item(Sprite originalSprite)
		{
			return null;
		}

		public void set_Item(Sprite originalSprite, Sprite value)
		{
		}

		// C# has no syntax for parameterized property 'Item'.
		public TilingRule get_Item(TilingRule originalRule)
		{
			return null;
		}

		public void set_Item(TilingRule originalRule, TilingRule value)
		{
		}

		public TilingRule m_OriginalDefault => null;

		public override bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go)
		{
			return false;
		}

		public void ApplyOverrides(IList<KeyValuePair<Sprite, Sprite>> overrides)
		{
		}

		public void GetOverrides(List<KeyValuePair<Sprite, Sprite>> overrides)
		{
		}

		public void ApplyOverrides(IList<KeyValuePair<TilingRule, TilingRule>> overrides)
		{
		}

		public void GetOverrides(List<KeyValuePair<TilingRule, TilingRule>> overrides)
		{
		}

		public void Override()
		{
		}

		public TilingRule CloneTilingRule(TilingRule from)
		{
			return null;
		}

		public void CopyTilingRule(TilingRule from, TilingRule to, bool copyRule)
		{
		}
	}
}
