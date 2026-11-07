using System;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	[Serializable]
	public class TMP_GlyphPairAdjustmentRecord
	{
		[SerializeField]
		internal TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord;

		[SerializeField]
		internal TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord;

		[SerializeField]
		internal FontFeatureLookupFlags m_FeatureLookupFlags;

		public TMP_GlyphAdjustmentRecord firstAdjustmentRecord => default;

		public TMP_GlyphAdjustmentRecord secondAdjustmentRecord => default;

		public TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord)
		{
		}

		internal TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord)
		{
		}
	}
}
