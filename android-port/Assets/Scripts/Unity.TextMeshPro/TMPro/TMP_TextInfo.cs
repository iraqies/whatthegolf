using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000070")]
	public class TMP_TextInfo
	{
		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0x0")]
		internal static Vector2 k_InfinityVectorPositive;

		[Token(Token = "0x400047B")]
		[FieldOffset(Offset = "0x8")]
		internal static Vector2 k_InfinityVectorNegative;

		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x10")]
		public TMP_Text textComponent;

		[Token(Token = "0x400047D")]
		[FieldOffset(Offset = "0x18")]
		public int characterCount;

		[Token(Token = "0x400047E")]
		[FieldOffset(Offset = "0x1C")]
		public int spriteCount;

		[Token(Token = "0x400047F")]
		[FieldOffset(Offset = "0x20")]
		public int spaceCount;

		[Token(Token = "0x4000480")]
		[FieldOffset(Offset = "0x24")]
		public int wordCount;

		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x28")]
		public int linkCount;

		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x2C")]
		public int lineCount;

		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x30")]
		public int pageCount;

		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x34")]
		public int materialCount;

		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x38")]
		public TMP_CharacterInfo[] characterInfo;

		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x40")]
		public TMP_WordInfo[] wordInfo;

		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x48")]
		public TMP_LinkInfo[] linkInfo;

		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x50")]
		public TMP_LineInfo[] lineInfo;

		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0x58")]
		public TMP_PageInfo[] pageInfo;

		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x60")]
		public TMP_MeshInfo[] meshInfo;

		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x68")]
		private TMP_MeshInfo[] m_CachedMeshInfo;

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x2AB9298", Offset = "0x2AB9298", VA = "0x2AB9298")]
		public TMP_TextInfo()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x2AB93C4", Offset = "0x2AB93C4", VA = "0x2AB93C4")]
		internal TMP_TextInfo(int characterCount)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x2AB94FC", Offset = "0x2AB94FC", VA = "0x2AB94FC")]
		public TMP_TextInfo(TMP_Text textComponent)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x2AB967C", Offset = "0x2AB967C", VA = "0x2AB967C")]
		public void Clear()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x2AB96DC", Offset = "0x2AB96DC", VA = "0x2AB96DC")]
		public void ClearMeshInfo(bool updateMesh)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x2AB975C", Offset = "0x2AB975C", VA = "0x2AB975C")]
		public void ResetVertexLayout(bool isVolumetric)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x2AB97E0", Offset = "0x2AB97E0", VA = "0x2AB97E0")]
		public void ClearLineInfo()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x2AB9950", Offset = "0x2AB9950", VA = "0x2AB9950")]
		internal void ClearPageInfo()
		{
		}

		[Token(Token = "0x600045E")]
		public static void Resize<T>(ref T[] array, int size)
		{
		}

		[Token(Token = "0x600045F")]
		public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated)
		{
		}
	}
}
