using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Token(Token = "0x2000008")]
	public struct MaterialReference
	{
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x0")]
		public int index;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x8")]
		public TMP_FontAsset fontAsset;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x10")]
		public TMP_SpriteAsset spriteAsset;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x18")]
		public Material material;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x20")]
		public bool isDefaultMaterial;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x21")]
		public bool isFallbackMaterial;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x28")]
		public Material fallbackMaterial;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x30")]
		public float padding;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x34")]
		public int referenceCount;

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2A7AA0C", Offset = "0x2A7AA0C", VA = "0x2A7AA0C")]
		public MaterialReference(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding)
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2A7AA94", Offset = "0x2A7AA94", VA = "0x2A7AA94")]
		public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
		{
			return default;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2A7AC74", Offset = "0x2A7AC74", VA = "0x2A7AC74")]
		public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
		{
			return default;
		}
	}
}
