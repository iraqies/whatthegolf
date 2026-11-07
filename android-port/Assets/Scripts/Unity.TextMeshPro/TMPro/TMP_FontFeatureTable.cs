using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000029")]
	public class TMP_FontFeatureTable
	{
		[Serializable]
		[Token(Token = "0x200002A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B9134", Offset = "0x1B9134")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000101")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000102")]
			[FieldOffset(Offset = "0x8")]
			public static Func<TMP_GlyphPairAdjustmentRecord, uint> _003C_003E9__6_0;

			[Token(Token = "0x4000103")]
			[FieldOffset(Offset = "0x10")]
			public static Func<TMP_GlyphPairAdjustmentRecord, uint> _003C_003E9__6_1;

			[Token(Token = "0x600011C")]
			[Address(RVA = "0x2ADEC4C", Offset = "0x2ADEC4C", VA = "0x2ADEC4C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600011D")]
			[Address(RVA = "0x2ADEC54", Offset = "0x2ADEC54", VA = "0x2ADEC54")]
			internal uint _003CSortGlyphPairAdjustmentRecords_003Eb__6_0(TMP_GlyphPairAdjustmentRecord s)
			{
				return default;
			}

			[Token(Token = "0x600011E")]
			[Address(RVA = "0x2ADEC6C", Offset = "0x2ADEC6C", VA = "0x2ADEC6C")]
			internal uint _003CSortGlyphPairAdjustmentRecords_003Eb__6_1(TMP_GlyphPairAdjustmentRecord s)
			{
				return default;
			}
		}

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x18")]
		internal Dictionary<uint, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary;

		[Token(Token = "0x17000040")]
		public List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x2A89EC0", Offset = "0x2A89EC0", VA = "0x2A89EC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2A87EB0", Offset = "0x2A87EB0", VA = "0x2A87EB0")]
		public TMP_FontFeatureTable()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2A837A0", Offset = "0x2A837A0", VA = "0x2A837A0")]
		public void SortGlyphPairAdjustmentRecords()
		{
		}
	}
}
