using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x200002E")]
	public class TMP_GlyphPairAdjustmentRecord
	{
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		internal TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		internal TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		internal FontFeatureLookupFlags m_FeatureLookupFlags;

		[Token(Token = "0x17000046")]
		public TMP_GlyphAdjustmentRecord firstAdjustmentRecord
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x2A8A264", Offset = "0x2A8A264", VA = "0x2A8A264")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000047")]
		public TMP_GlyphAdjustmentRecord secondAdjustmentRecord
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x2A8A278", Offset = "0x2A8A278", VA = "0x2A8A278")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2A88A88", Offset = "0x2A88A88", VA = "0x2A88A88")]
		public TMP_GlyphPairAdjustmentRecord(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2A87F7C", Offset = "0x2A87F7C", VA = "0x2A87F7C")]
		internal TMP_GlyphPairAdjustmentRecord(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord)
		{
		}
	}
}
