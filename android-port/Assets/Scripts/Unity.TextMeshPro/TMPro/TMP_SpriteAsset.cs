using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.TextCore;

namespace TMPro
{
	[Token(Token = "0x2000054")]
	public class TMP_SpriteAsset : TMP_Asset
	{
		[Serializable]
		[Token(Token = "0x2000055")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B920C", Offset = "0x1B920C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40002E4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40002E5")]
			[FieldOffset(Offset = "0x8")]
			public static Func<TMP_SpriteGlyph, uint> _003C_003E9__40_0;

			[Token(Token = "0x40002E6")]
			[FieldOffset(Offset = "0x10")]
			public static Func<TMP_SpriteCharacter, uint> _003C_003E9__41_0;

			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x2AE01A0", Offset = "0x2AE01A0", VA = "0x2AE01A0")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x2AE01A8", Offset = "0x2AE01A8", VA = "0x2AE01A8")]
			internal uint _003CSortGlyphTable_003Eb__40_0(TMP_SpriteGlyph item)
			{
				return default;
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x2AE01C4", Offset = "0x2AE01C4", VA = "0x2AE01C4")]
			internal uint _003CSortCharacterTable_003Eb__41_0(TMP_SpriteCharacter c)
			{
				return default;
			}
		}

		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x30")]
		internal Dictionary<int, int> m_NameLookup;

		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x38")]
		internal Dictionary<uint, int> m_GlyphIndexLookup;

		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string m_Version;

		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		internal FaceInfo m_FaceInfo;

		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0xA8")]
		public Texture spriteSheet;

		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private List<TMP_SpriteCharacter> m_SpriteCharacterTable;

		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0xB8")]
		internal Dictionary<uint, TMP_SpriteCharacter> m_SpriteCharacterLookup;

		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private List<TMP_SpriteGlyph> m_SpriteGlyphTable;

		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0xC8")]
		internal Dictionary<uint, TMP_SpriteGlyph> m_SpriteGlyphLookup;

		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0xD0")]
		public List<TMP_Sprite> spriteInfoList;

		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		public List<TMP_SpriteAsset> fallbackSpriteAssets;

		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0xE0")]
		internal bool m_IsSpriteAssetLookupTablesDirty;

		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x0")]
		private static HashSet<int> k_searchedSpriteAssets;

		[Token(Token = "0x170000B3")]
		public string version
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x2A9CB14", Offset = "0x2A9CB14", VA = "0x2A9CB14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x2A9CB1C", Offset = "0x2A9CB1C", VA = "0x2A9CB1C")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public FaceInfo faceInfo
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x2A9CB24", Offset = "0x2A9CB24", VA = "0x2A9CB24")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x2A9CB4C", Offset = "0x2A9CB4C", VA = "0x2A9CB4C")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public List<TMP_SpriteCharacter> spriteCharacterTable
		{
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x2A9CB74", Offset = "0x2A9CB74", VA = "0x2A9CB74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x2A9D0F4", Offset = "0x2A9D0F4", VA = "0x2A9D0F4")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x2A9D0FC", Offset = "0x2A9D0FC", VA = "0x2A9D0FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x2A9D12C", Offset = "0x2A9D12C", VA = "0x2A9D12C")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public List<TMP_SpriteGlyph> spriteGlyphTable
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x2A9D134", Offset = "0x2A9D134", VA = "0x2A9D134")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x2A9D13C", Offset = "0x2A9D13C", VA = "0x2A9D13C")]
			internal set
			{
			}
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x2A9D144", Offset = "0x2A9D144", VA = "0x2A9D144")]
		private void Awake()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x2A9D6EC", Offset = "0x2A9D6EC", VA = "0x2A9D6EC")]
		private Material GetDefaultSpriteMaterial()
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x2A9CBA4", Offset = "0x2A9CBA4", VA = "0x2A9CBA4")]
		public void UpdateLookupTables()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x2A9D7E0", Offset = "0x2A9D7E0", VA = "0x2A9D7E0")]
		public int GetSpriteIndexFromHashcode(int hashCode)
		{
			return default;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x2A9D874", Offset = "0x2A9D874", VA = "0x2A9D874")]
		public int GetSpriteIndexFromUnicode(uint unicode)
		{
			return default;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2A9D914", Offset = "0x2A9D914", VA = "0x2A9D914")]
		public int GetSpriteIndexFromName(string name)
		{
			return default;
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x2A9DA08", Offset = "0x2A9DA08", VA = "0x2A9DA08")]
		public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			return null;
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x2A9DC48", Offset = "0x2A9DC48", VA = "0x2A9DC48")]
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			return null;
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x2A9DDF4", Offset = "0x2A9DDF4", VA = "0x2A9DDF4")]
		private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2A9DEB4", Offset = "0x2A9DEB4", VA = "0x2A9DEB4")]
		public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex)
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2A9E24C", Offset = "0x2A9E24C", VA = "0x2A9E24C")]
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex)
		{
			return null;
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2A9E3F8", Offset = "0x2A9E3F8", VA = "0x2A9E3F8")]
		private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex)
		{
			return null;
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x2A9E50C", Offset = "0x2A9E50C", VA = "0x2A9E50C")]
		public void SortGlyphTable()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2A9E68C", Offset = "0x2A9E68C", VA = "0x2A9E68C")]
		internal void SortCharacterTable()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2A9E810", Offset = "0x2A9E810", VA = "0x2A9E810")]
		internal void SortGlyphAndCharacterTables()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2A9D1EC", Offset = "0x2A9D1EC", VA = "0x2A9D1EC")]
		private void UpgradeSpriteAsset()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2A9E8F8", Offset = "0x2A9E8F8", VA = "0x2A9E8F8")]
		public TMP_SpriteAsset()
		{
		}
	}
}
