using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000064")]
	public static class StencilMaterial
	{
		[Token(Token = "0x2000065")]
		private class MatEntry
		{
			[Token(Token = "0x400020F")]
			[FieldOffset(Offset = "0x10")]
			public Material baseMat;

			[Token(Token = "0x4000210")]
			[FieldOffset(Offset = "0x18")]
			public Material customMat;

			[Token(Token = "0x4000211")]
			[FieldOffset(Offset = "0x20")]
			public int count;

			[Token(Token = "0x4000212")]
			[FieldOffset(Offset = "0x24")]
			public int stencilId;

			[Token(Token = "0x4000213")]
			[FieldOffset(Offset = "0x28")]
			public StencilOp operation;

			[Token(Token = "0x4000214")]
			[FieldOffset(Offset = "0x2C")]
			public CompareFunction compareFunction;

			[Token(Token = "0x4000215")]
			[FieldOffset(Offset = "0x30")]
			public int readMask;

			[Token(Token = "0x4000216")]
			[FieldOffset(Offset = "0x34")]
			public int writeMask;

			[Token(Token = "0x4000217")]
			[FieldOffset(Offset = "0x38")]
			public bool useAlphaClip;

			[Token(Token = "0x4000218")]
			[FieldOffset(Offset = "0x3C")]
			public ColorWriteMask colorMask;

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x2C48C14", Offset = "0x2C48C14", VA = "0x2C48C14")]
			public MatEntry()
			{
			}
		}

		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x0")]
		private static List<MatEntry> m_List;

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x2C3E774", Offset = "0x2C3E774", VA = "0x2C3E774")]
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask)
		{
			return null;
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x2C3F200", Offset = "0x2C3F200", VA = "0x2C3F200")]
		private static void LogWarningWhenNotInBatchmode(string warning, Object context)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x2C3E844", Offset = "0x2C3E844", VA = "0x2C3E844")]
		public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask)
		{
			return null;
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x2C3F290", Offset = "0x2C3F290", VA = "0x2C3F290")]
		public static void Remove(Material customMat)
		{
		}
	}
}
