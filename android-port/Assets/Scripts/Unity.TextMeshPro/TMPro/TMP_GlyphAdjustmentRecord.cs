using System;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	[Serializable]
	public struct TMP_GlyphAdjustmentRecord
	{
		[SerializeField]
		internal uint m_GlyphIndex;

		[SerializeField]
		internal TMP_GlyphValueRecord m_GlyphValueRecord;

		public uint glyphIndex => 0u;

		public TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord)
		{
			m_GlyphIndex = 0u;
			m_GlyphValueRecord = default;
		}

		internal TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord)
		{
			m_GlyphIndex = 0u;
			m_GlyphValueRecord = default;
		}
	}
}
