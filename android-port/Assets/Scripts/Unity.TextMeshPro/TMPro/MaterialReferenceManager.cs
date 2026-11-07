using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Token(Token = "0x2000007")]
	public class MaterialReferenceManager
	{
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x0")]
		private static MaterialReferenceManager s_Instance;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<int, Material> m_FontMaterialReferenceLookup;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup;

		[Token(Token = "0x17000001")]
		public static MaterialReferenceManager instance
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x2A7AE0C", Offset = "0x2A7AE0C", VA = "0x2A7AE0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2A7AFD8", Offset = "0x2A7AFD8", VA = "0x2A7AFD8")]
		public static void AddFontAsset(TMP_FontAsset fontAsset)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2A7B064", Offset = "0x2A7B064", VA = "0x2A7B064")]
		private void AddFontAssetInternal(TMP_FontAsset fontAsset)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2A7B138", Offset = "0x2A7B138", VA = "0x2A7B138")]
		public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2A7B1CC", Offset = "0x2A7B1CC", VA = "0x2A7B1CC")]
		private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2A7B2A4", Offset = "0x2A7B2A4", VA = "0x2A7B2A4")]
		public static void AddFontMaterial(int hashCode, Material material)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2A7B36C", Offset = "0x2A7B36C", VA = "0x2A7B36C")]
		private void AddFontMaterialInternal(int hashCode, Material material)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2A7B3D8", Offset = "0x2A7B3D8", VA = "0x2A7B3D8")]
		public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset)
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2A7B46C", Offset = "0x2A7B46C", VA = "0x2A7B46C")]
		private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2A7B514", Offset = "0x2A7B514", VA = "0x2A7B514")]
		public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset)
		{
			return default;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2A7B5E0", Offset = "0x2A7B5E0", VA = "0x2A7B5E0")]
		private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset)
		{
			return default;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2A7B650", Offset = "0x2A7B650", VA = "0x2A7B650")]
		public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset)
		{
			return default;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2A7B71C", Offset = "0x2A7B71C", VA = "0x2A7B71C")]
		private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset)
		{
			return default;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2A7B78C", Offset = "0x2A7B78C", VA = "0x2A7B78C")]
		public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset)
		{
			return default;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2A7B858", Offset = "0x2A7B858", VA = "0x2A7B858")]
		private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset)
		{
			return default;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2A7B8C8", Offset = "0x2A7B8C8", VA = "0x2A7B8C8")]
		public static bool TryGetMaterial(int hashCode, out Material material)
		{
			return default;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2A7B994", Offset = "0x2A7B994", VA = "0x2A7B994")]
		private bool TryGetMaterialInternal(int hashCode, out Material material)
		{
			return default;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2A7AE80", Offset = "0x2A7AE80", VA = "0x2A7AE80")]
		public MaterialReferenceManager()
		{
		}
	}
}
