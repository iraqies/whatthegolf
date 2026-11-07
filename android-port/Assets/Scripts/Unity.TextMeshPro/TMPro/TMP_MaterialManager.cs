using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	[Token(Token = "0x2000043")]
	public static class TMP_MaterialManager
	{
		[Token(Token = "0x2000044")]
		private class FallbackMaterial
		{
			[Token(Token = "0x40001B5")]
			[FieldOffset(Offset = "0x10")]
			public long fallbackID;

			[Token(Token = "0x40001B6")]
			[FieldOffset(Offset = "0x18")]
			public Material sourceMaterial;

			[Token(Token = "0x40001B7")]
			[FieldOffset(Offset = "0x20")]
			internal int sourceMaterialCRC;

			[Token(Token = "0x40001B8")]
			[FieldOffset(Offset = "0x28")]
			public Material fallbackMaterial;

			[Token(Token = "0x40001B9")]
			[FieldOffset(Offset = "0x30")]
			public int count;

			[Token(Token = "0x6000239")]
			[Address(RVA = "0x2ADF82C", Offset = "0x2ADF82C", VA = "0x2ADF82C")]
			public FallbackMaterial()
			{
			}
		}

		[Token(Token = "0x2000045")]
		private class MaskingMaterial
		{
			[Token(Token = "0x40001BA")]
			[FieldOffset(Offset = "0x10")]
			public Material stencilMaterial;

			[Token(Token = "0x40001BB")]
			[FieldOffset(Offset = "0x18")]
			public int count;
		}

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x0")]
		private static List<MaskingMaterial> m_materialList;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<long, FallbackMaterial> m_fallbackMaterials;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<int, long> m_fallbackMaterialLookup;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x18")]
		private static List<FallbackMaterial> m_fallbackCleanupList;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x20")]
		private static bool isFallbackListDirty;

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2A988CC", Offset = "0x2A988CC", VA = "0x2A988CC")]
		static TMP_MaterialManager()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2A98A98", Offset = "0x2A98A98", VA = "0x2A98A98")]
		private static void OnPreRender()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2A98D7C", Offset = "0x2A98D7C", VA = "0x2A98D7C")]
		public static void ReleaseStencilMaterial(Material stencilMaterial)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x2A99014", Offset = "0x2A99014", VA = "0x2A99014")]
		public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial)
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x2A99240", Offset = "0x2A99240", VA = "0x2A99240")]
		internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex)
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x2A997D0", Offset = "0x2A997D0", VA = "0x2A997D0")]
		public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial)
		{
			return null;
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2A99C3C", Offset = "0x2A99C3C", VA = "0x2A99C3C")]
		public static void AddFallbackMaterialReference(Material targetMaterial)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2A98B28", Offset = "0x2A98B28", VA = "0x2A98B28")]
		public static void CleanupFallbackMaterials()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2A99DA0", Offset = "0x2A99DA0", VA = "0x2A99DA0")]
		public static void ReleaseFallbackMaterial(Material fallbackMaterial)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x2A99548", Offset = "0x2A99548", VA = "0x2A99548")]
		public static void CopyMaterialPresetProperties(Material source, Material destination)
		{
		}
	}
}
