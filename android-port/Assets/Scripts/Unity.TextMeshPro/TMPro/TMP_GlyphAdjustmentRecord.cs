using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x200002D")]
	public struct TMP_GlyphAdjustmentRecord
	{
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		internal uint m_GlyphIndex;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		internal TMP_GlyphValueRecord m_GlyphValueRecord;

		[Token(Token = "0x17000045")]
		public uint glyphIndex
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x2A8A150", Offset = "0x2A8A150", VA = "0x2A8A150")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2A88A78", Offset = "0x2A88A78", VA = "0x2A88A78")]
		public TMP_GlyphAdjustmentRecord(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2A8A158", Offset = "0x2A8A158", VA = "0x2A8A158")]
		internal TMP_GlyphAdjustmentRecord(GlyphAdjustmentRecord adjustmentRecord)
		{
		}
	}
}
