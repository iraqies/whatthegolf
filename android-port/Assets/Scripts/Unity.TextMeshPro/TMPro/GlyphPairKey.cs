namespace TMPro
{
	public struct GlyphPairKey
	{
		public uint firstGlyphIndex;

		public uint secondGlyphIndex;

		public uint key;

		internal GlyphPairKey(TMP_GlyphPairAdjustmentRecord record)
		{
			firstGlyphIndex = 0u;
			secondGlyphIndex = 0u;
			key = 0u;
		}
	}
}
