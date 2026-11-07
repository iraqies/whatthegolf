using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	public static class TMP_MaterialManager
	{
		private class FallbackMaterial
		{
			public long fallbackID;

			public Material sourceMaterial;

			internal int sourceMaterialCRC;

			public Material fallbackMaterial;

			public int count;
		}

		private class MaskingMaterial
		{
			public Material stencilMaterial;

			public int count;
		}

		private static List<MaskingMaterial> m_materialList;

		private static Dictionary<long, FallbackMaterial> m_fallbackMaterials;

		private static Dictionary<int, long> m_fallbackMaterialLookup;

		private static List<FallbackMaterial> m_fallbackCleanupList;

		private static bool isFallbackListDirty;

		static TMP_MaterialManager()
		{
		}

		private static void OnPreRender()
		{
		}

		public static void ReleaseStencilMaterial(Material stencilMaterial)
		{
		}

		public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial)
		{
			return null;
		}

		internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex)
		{
			return null;
		}

		public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial)
		{
			return null;
		}

		public static void AddFallbackMaterialReference(Material targetMaterial)
		{
		}

		public static void CleanupFallbackMaterials()
		{
		}

		public static void ReleaseFallbackMaterial(Material fallbackMaterial)
		{
		}

		public static void CopyMaterialPresetProperties(Material source, Material destination)
		{
		}
	}
}
