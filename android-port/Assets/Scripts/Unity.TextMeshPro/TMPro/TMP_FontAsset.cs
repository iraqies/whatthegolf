using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x200001F")]
	public class TMP_FontAsset : TMP_Asset
	{
		[Serializable]
		[Token(Token = "0x2000020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B9124", Offset = "0x1B9124")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40000C7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40000C8")]
			[FieldOffset(Offset = "0x8")]
			public static Func<TMP_Character, uint> _003C_003E9__124_0;

			[Token(Token = "0x40000C9")]
			[FieldOffset(Offset = "0x10")]
			public static Func<Glyph, uint> _003C_003E9__125_0;

			[Token(Token = "0x6000104")]
			[Address(RVA = "0x2ADEBB0", Offset = "0x2ADEBB0", VA = "0x2ADEBB0")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000105")]
			[Address(RVA = "0x2ADEBB8", Offset = "0x2ADEBB8", VA = "0x2ADEBB8")]
			internal uint _003CSortCharacterTable_003Eb__124_0(TMP_Character c)
			{
				return default;
			}

			[Token(Token = "0x6000106")]
			[Address(RVA = "0x2ADEBD0", Offset = "0x2ADEBD0", VA = "0x2ADEBD0")]
			internal uint _003CSortGlyphTable_003Eb__125_0(Glyph c)
			{
				return default;
			}
		}

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string m_Version;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		internal string m_SourceFontFileGUID;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Font m_SourceFontFile;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AtlasPopulationMode m_AtlasPopulationMode;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		internal FaceInfo m_FaceInfo;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		internal List<Glyph> m_GlyphTable;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0xB8")]
		internal Dictionary<uint, Glyph> m_GlyphLookupDictionary;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		internal List<TMP_Character> m_CharacterTable;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0xC8")]
		internal Dictionary<uint, TMP_Character> m_CharacterLookupDictionary;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0xD0")]
		internal Texture2D m_AtlasTexture;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		internal Texture2D[] m_AtlasTextures;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		internal int m_AtlasTextureIndex;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private bool m_IsMultiAtlasTexturesEnabled;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0xE5")]
		[SerializeField]
		private bool m_ClearDynamicDataOnBuild;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private List<GlyphRect> m_UsedGlyphRects;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private List<GlyphRect> m_FreeGlyphRects;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private FaceInfo_Legacy m_fontInfo;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		public Texture2D atlas;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		internal int m_AtlasWidth;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x10C")]
		[SerializeField]
		internal int m_AtlasHeight;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		internal int m_AtlasPadding;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x114")]
		[SerializeField]
		internal GlyphRenderMode m_AtlasRenderMode;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		internal List<TMP_Glyph> m_glyphInfoList;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B97A0", Offset = "0x1B97A0")]
		internal KerningTable m_KerningTable;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		internal TMP_FontFeatureTable m_FontFeatureTable;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private List<TMP_FontAsset> fallbackFontAssets;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		internal List<TMP_FontAsset> m_FallbackFontAssetTable;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		internal FontAssetCreationSettings m_CreationSettings;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private TMP_FontWeightPair[] m_FontWeightTable;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private TMP_FontWeightPair[] fontWeights;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x1A8")]
		public float normalStyle;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x1AC")]
		public float normalSpacingOffset;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x1B0")]
		public float boldStyle;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x1B4")]
		public float boldSpacing;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x1B8")]
		public byte italicStyle;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x1B9")]
		public byte tabSize;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x1BA")]
		internal bool IsFontAssetLookupTablesDirty;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker k_ReadFontAssetDefinitionMarker;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker k_AddSynthesizedCharactersMarker;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker k_TryAddCharacterMarker;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker k_TryAddCharactersMarker;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x20")]
		private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x28")]
		private static ProfilerMarker k_ClearFontAssetDataMarker;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x30")]
		private static ProfilerMarker k_UpdateFontAssetDataMarker;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x38")]
		private static string s_DefaultMaterialSuffix;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x1C0")]
		internal HashSet<int> FallbackSearchQueryLookup;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x40")]
		private static HashSet<int> k_SearchedFontAssetLookup;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x48")]
		private static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x50")]
		private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x58")]
		private static List<TMP_FontAsset> k_FontAssets_AtlasTexturesUpdateQueue;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x60")]
		private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x1C8")]
		private List<Glyph> m_GlyphsToRender;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x1D0")]
		private List<Glyph> m_GlyphsRendered;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x1D8")]
		private List<uint> m_GlyphIndexList;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x1E0")]
		private List<uint> m_GlyphIndexListNewlyAdded;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x1E8")]
		internal List<uint> m_GlyphsToAdd;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x1F0")]
		internal HashSet<uint> m_GlyphsToAddLookup;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x1F8")]
		internal List<TMP_Character> m_CharactersToAdd;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x200")]
		internal HashSet<uint> m_CharactersToAddLookup;

		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x208")]
		internal List<uint> s_MissingCharacterList;

		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x210")]
		internal HashSet<uint> m_MissingUnicodesFromFontFile;

		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x68")]
		internal static uint[] k_GlyphIndexArray;

		[Token(Token = "0x17000024")]
		public string version
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x2A80DE4", Offset = "0x2A80DE4", VA = "0x2A80DE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x2A80DEC", Offset = "0x2A80DEC", VA = "0x2A80DEC")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public Font sourceFontFile
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x2A80DF4", Offset = "0x2A80DF4", VA = "0x2A80DF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x2A80DFC", Offset = "0x2A80DFC", VA = "0x2A80DFC")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public AtlasPopulationMode atlasPopulationMode
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x2A80E04", Offset = "0x2A80E04", VA = "0x2A80E04")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x2A80E0C", Offset = "0x2A80E0C", VA = "0x2A80E0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public FaceInfo faceInfo
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x2A80E14", Offset = "0x2A80E14", VA = "0x2A80E14")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x2A80E30", Offset = "0x2A80E30", VA = "0x2A80E30")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public List<Glyph> glyphTable
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x2A80E4C", Offset = "0x2A80E4C", VA = "0x2A80E4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x2A80E54", Offset = "0x2A80E54", VA = "0x2A80E54")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public Dictionary<uint, Glyph> glyphLookupTable
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x2A80E5C", Offset = "0x2A80E5C", VA = "0x2A80E5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public List<TMP_Character> characterTable
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x2A81118", Offset = "0x2A81118", VA = "0x2A81118")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x2A81120", Offset = "0x2A81120", VA = "0x2A81120")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public Dictionary<uint, TMP_Character> characterLookupTable
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x2A81128", Offset = "0x2A81128", VA = "0x2A81128")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public Texture2D atlasTexture
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x2A81158", Offset = "0x2A81158", VA = "0x2A81158")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public Texture2D[] atlasTextures
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x2A81208", Offset = "0x2A81208", VA = "0x2A81208")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x2A81210", Offset = "0x2A81210", VA = "0x2A81210")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public int atlasTextureCount
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x2A81218", Offset = "0x2A81218", VA = "0x2A81218")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002F")]
		public bool isMultiAtlasTexturesEnabled
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x2A81224", Offset = "0x2A81224", VA = "0x2A81224")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x2A8122C", Offset = "0x2A8122C", VA = "0x2A8122C")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		internal bool clearDynamicDataOnBuild
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x2A81234", Offset = "0x2A81234", VA = "0x2A81234")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x2A8123C", Offset = "0x2A8123C", VA = "0x2A8123C")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		internal List<GlyphRect> usedGlyphRects
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x2A81244", Offset = "0x2A81244", VA = "0x2A81244")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x2A8124C", Offset = "0x2A8124C", VA = "0x2A8124C")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		internal List<GlyphRect> freeGlyphRects
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x2A81254", Offset = "0x2A81254", VA = "0x2A81254")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x2A8125C", Offset = "0x2A8125C", VA = "0x2A8125C")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1BA9A8", Offset = "0x1BA9A8")]
		public FaceInfo_Legacy fontInfo
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x2A81264", Offset = "0x2A81264", VA = "0x2A81264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public int atlasWidth
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x2A8126C", Offset = "0x2A8126C", VA = "0x2A8126C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x2A81274", Offset = "0x2A81274", VA = "0x2A81274")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public int atlasHeight
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x2A8127C", Offset = "0x2A8127C", VA = "0x2A8127C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x2A81284", Offset = "0x2A81284", VA = "0x2A81284")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public int atlasPadding
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x2A8128C", Offset = "0x2A8128C", VA = "0x2A8128C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x2A81294", Offset = "0x2A81294", VA = "0x2A81294")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public GlyphRenderMode atlasRenderMode
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x2A8129C", Offset = "0x2A8129C", VA = "0x2A8129C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x2A812A4", Offset = "0x2A812A4", VA = "0x2A812A4")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public TMP_FontFeatureTable fontFeatureTable
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x2A812AC", Offset = "0x2A812AC", VA = "0x2A812AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x2A812B4", Offset = "0x2A812B4", VA = "0x2A812B4")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public List<TMP_FontAsset> fallbackFontAssetTable
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x2A812BC", Offset = "0x2A812BC", VA = "0x2A812BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x2A812C4", Offset = "0x2A812C4", VA = "0x2A812C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public FontAssetCreationSettings creationSettings
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x2A812CC", Offset = "0x2A812CC", VA = "0x2A812CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x2A812F0", Offset = "0x2A812F0", VA = "0x2A812F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public TMP_FontWeightPair[] fontWeightTable
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x2A81314", Offset = "0x2A81314", VA = "0x2A81314")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x2A8131C", Offset = "0x2A8131C", VA = "0x2A8131C")]
			internal set
			{
			}
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2A81324", Offset = "0x2A81324", VA = "0x2A81324")]
		public static TMP_FontAsset CreateFontAsset(Font font)
		{
			return null;
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2A813C4", Offset = "0x2A813C4", VA = "0x2A813C4")]
		public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2A818C4", Offset = "0x2A818C4", VA = "0x2A818C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2A80E8C", Offset = "0x2A80E8C", VA = "0x2A80E8C")]
		public void ReadFontAssetDefinition()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2A824F8", Offset = "0x2A824F8", VA = "0x2A824F8")]
		internal void InitializeDictionaryLookupTables()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2A8282C", Offset = "0x2A8282C", VA = "0x2A8282C")]
		internal void InitializeGlyphLookupDictionary()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2A82A8C", Offset = "0x2A82A8C", VA = "0x2A82A8C")]
		internal void InitializeCharacterLookupDictionary()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2A82CB8", Offset = "0x2A82CB8", VA = "0x2A82CB8")]
		internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2A82524", Offset = "0x2A82524", VA = "0x2A82524")]
		internal void AddSynthesizedCharactersAndFaceMetrics()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2A8316C", Offset = "0x2A8316C", VA = "0x2A8316C")]
		private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2A833C4", Offset = "0x2A833C4", VA = "0x2A833C4")]
		internal void AddCharacterToLookupCache(uint unicode, TMP_Character character)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2A83480", Offset = "0x2A83480", VA = "0x2A83480")]
		internal void SortCharacterTable()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2A83604", Offset = "0x2A83604", VA = "0x2A83604")]
		internal void SortGlyphTable()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2A83788", Offset = "0x2A83788", VA = "0x2A83788")]
		internal void SortFontFeatureTable()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2A83A10", Offset = "0x2A83A10", VA = "0x2A83A10")]
		internal void SortAllTables()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2A83A44", Offset = "0x2A83A44", VA = "0x2A83A44")]
		public bool HasCharacter(int character)
		{
			return default;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2A83AB4", Offset = "0x2A83AB4", VA = "0x2A83AB4")]
		public bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			return default;
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2A84908", Offset = "0x2A84908", VA = "0x2A84908")]
		private bool HasCharacter_Internal(uint character, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			return default;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2A84B58", Offset = "0x2A84B58", VA = "0x2A84B58")]
		public bool HasCharacters(string text, out List<char> missingCharacters)
		{
			return default;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2A84CC4", Offset = "0x2A84CC4", VA = "0x2A84CC4")]
		public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false)
		{
			return default;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2A85318", Offset = "0x2A85318", VA = "0x2A85318")]
		public bool HasCharacters(string text)
		{
			return default;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2A853DC", Offset = "0x2A853DC", VA = "0x2A853DC")]
		public static string GetCharacters(TMP_FontAsset fontAsset)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2A854CC", Offset = "0x2A854CC", VA = "0x2A854CC")]
		public static int[] GetCharactersArray(TMP_FontAsset fontAsset)
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2A855C4", Offset = "0x2A855C4", VA = "0x2A855C4")]
		internal uint GetGlyphIndex(uint unicode)
		{
			return default;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2A856EC", Offset = "0x2A856EC", VA = "0x2A856EC")]
		internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2A85800", Offset = "0x2A85800", VA = "0x2A85800")]
		internal static void UpdateFontFeaturesForFontAssetsInQueue()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2A85C78", Offset = "0x2A85C78", VA = "0x2A85C78")]
		internal static void RegisterFontAssetForAtlasTextureUpdate(TMP_FontAsset fontAsset)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2A85D8C", Offset = "0x2A85D8C", VA = "0x2A85D8C")]
		internal static void UpdateAtlasTexturesForFontAssetsInQueue()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2A85F0C", Offset = "0x2A85F0C", VA = "0x2A85F0C")]
		public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = false)
		{
			return default;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2A85F34", Offset = "0x2A85F34", VA = "0x2A85F34")]
		public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = false)
		{
			return default;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2A86C80", Offset = "0x2A86C80", VA = "0x2A86C80")]
		public bool TryAddCharacters(string characters, bool includeFontFeatures = false)
		{
			return default;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2A86CA8", Offset = "0x2A86CA8", VA = "0x2A86CA8")]
		public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false)
		{
			return default;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2A8402C", Offset = "0x2A8402C", VA = "0x2A8402C")]
		internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character)
		{
			return default;
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2A8786C", Offset = "0x2A8786C", VA = "0x2A8786C")]
		internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character)
		{
			return default;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2A85F08", Offset = "0x2A85F08", VA = "0x2A85F08")]
		internal void TryAddGlyphsToAtlasTextures()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2A86924", Offset = "0x2A86924", VA = "0x2A86924")]
		private bool TryAddGlyphsToNewAtlasTexture()
		{
			return default;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2A8764C", Offset = "0x2A8764C", VA = "0x2A8764C")]
		private void SetupNewAtlasTexture()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2A87D1C", Offset = "0x2A87D1C", VA = "0x2A87D1C")]
		internal void UpdateAtlasTexture()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2A85980", Offset = "0x2A85980", VA = "0x2A85980")]
		internal void UpdateGlyphAdjustmentRecords()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2A880C0", Offset = "0x2A880C0", VA = "0x2A880C0")]
		internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2A88384", Offset = "0x2A88384", VA = "0x2A88384")]
		internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2A88388", Offset = "0x2A88388", VA = "0x2A88388")]
		internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes)
		{
		}

		[Token(Token = "0x60000F9")]
		private void CopyListDataToArray<T>(List<T> srcList, ref T[] dstArray)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2A8838C", Offset = "0x2A8838C", VA = "0x2A8838C")]
		public void ClearFontAssetData(bool setAtlasSizeToZero = false)
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2A8890C", Offset = "0x2A8890C", VA = "0x2A8890C")]
		internal void ClearFontAssetDataInternal()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2A88934", Offset = "0x2A88934", VA = "0x2A88934")]
		internal void UpdateFontAssetData()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2A883C0", Offset = "0x2A883C0", VA = "0x2A883C0")]
		internal void ClearFontAssetTables()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2A8852C", Offset = "0x2A8852C", VA = "0x2A8852C")]
		internal void ClearAtlasTextures(bool setAtlasSizeToZero = false)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2A8196C", Offset = "0x2A8196C", VA = "0x2A8196C")]
		internal void UpgradeFontAsset()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2A82E8C", Offset = "0x2A82E8C", VA = "0x2A82E8C")]
		private void UpgradeGlyphAdjustmentTableToFontFeatureTable()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2A88ADC", Offset = "0x2A88ADC", VA = "0x2A88ADC")]
		public TMP_FontAsset()
		{
		}
	}
}
