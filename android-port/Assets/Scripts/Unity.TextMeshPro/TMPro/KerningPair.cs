using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public class KerningPair
	{
		[SerializeField]
		private uint m_FirstGlyph;

		[SerializeField]
		private GlyphValueRecord_Legacy m_FirstGlyphAdjustments;

		[SerializeField]
		private uint m_SecondGlyph;

		[SerializeField]
		private GlyphValueRecord_Legacy m_SecondGlyphAdjustments;

		public float xOffset;

		internal static KerningPair empty;

		[SerializeField]
		private bool m_IgnoreSpacingAdjustments;

		public uint firstGlyph => 0u;

		public GlyphValueRecord_Legacy firstGlyphAdjustments => default;

		public uint secondGlyph => 0u;

		public GlyphValueRecord_Legacy secondGlyphAdjustments => default;

		public KerningPair()
		{
		}

		public KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments)
		{
		}
	}
}
