using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	public static class EasyDecalManager
	{
		private static List<CombinedDecalsGroup> combinedSceneDecals;

		private static IDictionary<Material, IList<EasyDecal>> materialGroupedDecals;

		private static IDictionary<DecalTextureAtlas, IList<EasyDecal>> atlasGroupedDecals;

		private static DecalSet decalSet;

		private static List<DecalBufferGroup> flagsBoundDecals;

		internal static List<DecalBufferGroup> GetDecalBufferGroups()
		{
			return null;
		}

		public static HashSet<EasyDecal> GetDeferredDecals(DeferredFlags flags)
		{
			return null;
		}

		public static void Add(EasyDecal decal)
		{
		}

		public static void Remove(EasyDecal decal)
		{
		}
	}
}
