using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x2000022")]
	public static class EasyDecalManager
	{
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x0")]
		private static List<CombinedDecalsGroup> combinedSceneDecals;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x8")]
		private static IDictionary<Material, IList<EasyDecal>> materialGroupedDecals;

		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x10")]
		private static IDictionary<DecalTextureAtlas, IList<EasyDecal>> atlasGroupedDecals;

		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x18")]
		private static DecalSet decalSet;

		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x20")]
		private static List<DecalBufferGroup> flagsBoundDecals;

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2C5D2D4", Offset = "0x2C5D2D4", VA = "0x2C5D2D4")]
		internal static List<DecalBufferGroup> GetDecalBufferGroups()
		{
			return null;
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x2C69C60", Offset = "0x2C69C60", VA = "0x2C69C60")]
		public static HashSet<EasyDecal> GetDeferredDecals(DeferredFlags flags)
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2C63E58", Offset = "0x2C63E58", VA = "0x2C63E58")]
		public static void Add(EasyDecal decal)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2C6427C", Offset = "0x2C6427C", VA = "0x2C6427C")]
		public static void Remove(EasyDecal decal)
		{
		}
	}
}
