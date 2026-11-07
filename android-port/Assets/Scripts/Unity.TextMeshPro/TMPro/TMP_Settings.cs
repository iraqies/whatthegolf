using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x200004E")]
	public class TMP_Settings : ScriptableObject
	{
		[Token(Token = "0x200004F")]
		public class LineBreakingTable
		{
			[Token(Token = "0x400027A")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<int, char> leadingCharacters;

			[Token(Token = "0x400027B")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<int, char> followingCharacters;

			[Token(Token = "0x600027D")]
			[Address(RVA = "0x2ADF834", Offset = "0x2ADF834", VA = "0x2ADF834")]
			public LineBreakingTable()
			{
			}
		}

		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x0")]
		private static TMP_Settings s_Instance;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_enableWordWrapping;

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_enableKerning;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x1A")]
		[SerializeField]
		private bool m_enableExtraPadding;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x1B")]
		[SerializeField]
		private bool m_enableTintAllSprites;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_enableParseEscapeCharacters;

		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x1D")]
		[SerializeField]
		private bool m_EnableRaycastTarget;

		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x1E")]
		[SerializeField]
		private bool m_GetFontFeaturesAtRuntime;

		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_missingGlyphCharacter;

		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_warningsDisabled;

		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TMP_FontAsset m_defaultFontAsset;

		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string m_defaultFontAssetPath;

		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_defaultFontSize;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_defaultAutoSizeMinRatio;

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_defaultAutoSizeMaxRatio;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Vector2 m_defaultTextMeshProTextContainerSize;

		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Vector2 m_defaultTextMeshProUITextContainerSize;

		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private bool m_autoSizeTextContainer;

		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x55")]
		[SerializeField]
		private bool m_IsTextObjectScaleStatic;

		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<TMP_FontAsset> m_fallbackFontAssets;

		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_matchMaterialPreset;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TMP_SpriteAsset m_defaultSpriteAsset;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string m_defaultSpriteAssetPath;

		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool m_enableEmojiSupport;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private uint m_MissingCharacterSpriteUnicode;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string m_defaultColorGradientPresetsPath;

		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TMP_StyleSheet m_defaultStyleSheet;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string m_StyleSheetsResourcePath;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TextAsset m_leadingCharacters;

		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TextAsset m_followingCharacters;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private LineBreakingTable m_linebreakingRules;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool m_UseModernHangulLineBreakingRules;

		[Token(Token = "0x1700008E")]
		public static string version
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x2A9BC54", Offset = "0x2A9BC54", VA = "0x2A9BC54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		public static bool enableWordWrapping
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x2A9BC98", Offset = "0x2A9BC98", VA = "0x2A9BC98")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000090")]
		public static bool enableKerning
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x2A9BDA0", Offset = "0x2A9BDA0", VA = "0x2A9BDA0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000091")]
		public static bool enableExtraPadding
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x2A9BDC0", Offset = "0x2A9BDC0", VA = "0x2A9BDC0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000092")]
		public static bool enableTintAllSprites
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x2A9BDE0", Offset = "0x2A9BDE0", VA = "0x2A9BDE0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000093")]
		public static bool enableParseEscapeCharacters
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x2A9BE00", Offset = "0x2A9BE00", VA = "0x2A9BE00")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000094")]
		public static bool enableRaycastTarget
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x2A9BE20", Offset = "0x2A9BE20", VA = "0x2A9BE20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000095")]
		public static bool getFontFeaturesAtRuntime
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x2A9BE40", Offset = "0x2A9BE40", VA = "0x2A9BE40")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000096")]
		public static int missingGlyphCharacter
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x2A9BE60", Offset = "0x2A9BE60", VA = "0x2A9BE60")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x2A9BE80", Offset = "0x2A9BE80", VA = "0x2A9BE80")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public static bool warningsDisabled
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x2A9BEAC", Offset = "0x2A9BEAC", VA = "0x2A9BEAC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000098")]
		public static TMP_FontAsset defaultFontAsset
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x2A9BECC", Offset = "0x2A9BECC", VA = "0x2A9BECC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public static string defaultFontAssetPath
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x2A9BEEC", Offset = "0x2A9BEEC", VA = "0x2A9BEEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		public static float defaultFontSize
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x2A9BF0C", Offset = "0x2A9BF0C", VA = "0x2A9BF0C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700009B")]
		public static float defaultTextAutoSizingMinRatio
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x2A9BF2C", Offset = "0x2A9BF2C", VA = "0x2A9BF2C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700009C")]
		public static float defaultTextAutoSizingMaxRatio
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x2A9BF4C", Offset = "0x2A9BF4C", VA = "0x2A9BF4C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700009D")]
		public static Vector2 defaultTextMeshProTextContainerSize
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x2A9BF6C", Offset = "0x2A9BF6C", VA = "0x2A9BF6C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700009E")]
		public static Vector2 defaultTextMeshProUITextContainerSize
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x2A9BF8C", Offset = "0x2A9BF8C", VA = "0x2A9BF8C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700009F")]
		public static bool autoSizeTextContainer
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x2A9BFAC", Offset = "0x2A9BFAC", VA = "0x2A9BFAC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000A0")]
		public static bool isTextObjectScaleStatic
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x2A9BFCC", Offset = "0x2A9BFCC", VA = "0x2A9BFCC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x2A9BFEC", Offset = "0x2A9BFEC", VA = "0x2A9BFEC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public static List<TMP_FontAsset> fallbackFontAssets
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x2A9C018", Offset = "0x2A9C018", VA = "0x2A9C018")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		public static bool matchMaterialPreset
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x2A9C038", Offset = "0x2A9C038", VA = "0x2A9C038")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000A3")]
		public static TMP_SpriteAsset defaultSpriteAsset
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x2A9C058", Offset = "0x2A9C058", VA = "0x2A9C058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		public static string defaultSpriteAssetPath
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x2A9C078", Offset = "0x2A9C078", VA = "0x2A9C078")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public static bool enableEmojiSupport
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x2A9C098", Offset = "0x2A9C098", VA = "0x2A9C098")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x2A9C0B8", Offset = "0x2A9C0B8", VA = "0x2A9C0B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public static uint missingCharacterSpriteUnicode
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x2A9C0E4", Offset = "0x2A9C0E4", VA = "0x2A9C0E4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x2A9C104", Offset = "0x2A9C104", VA = "0x2A9C104")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public static string defaultColorGradientPresetsPath
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x2A9C130", Offset = "0x2A9C130", VA = "0x2A9C130")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		public static TMP_StyleSheet defaultStyleSheet
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x2A9C150", Offset = "0x2A9C150", VA = "0x2A9C150")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A9")]
		public static string styleSheetsResourcePath
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x2A9C170", Offset = "0x2A9C170", VA = "0x2A9C170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		public static TextAsset leadingCharacters
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x2A9C190", Offset = "0x2A9C190", VA = "0x2A9C190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		public static TextAsset followingCharacters
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x2A9C1B0", Offset = "0x2A9C1B0", VA = "0x2A9C1B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		public static LineBreakingTable linebreakingRules
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x2A9C1D0", Offset = "0x2A9C1D0", VA = "0x2A9C1D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		public static bool useModernHangulLineBreakingRules
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x2A9C324", Offset = "0x2A9C324", VA = "0x2A9C324")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x2A9C344", Offset = "0x2A9C344", VA = "0x2A9C344")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public static TMP_Settings instance
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x2A9BCB8", Offset = "0x2A9BCB8", VA = "0x2A9BCB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x2A9C370", Offset = "0x2A9C370", VA = "0x2A9C370")]
		public static TMP_Settings LoadDefaultSettings()
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x2A9C488", Offset = "0x2A9C488", VA = "0x2A9C488")]
		public static TMP_Settings GetSettings()
		{
			return null;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x2A9C510", Offset = "0x2A9C510", VA = "0x2A9C510")]
		public static TMP_FontAsset GetFontAsset()
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x2A9C5A0", Offset = "0x2A9C5A0", VA = "0x2A9C5A0")]
		public static TMP_SpriteAsset GetSpriteAsset()
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x2A9C630", Offset = "0x2A9C630", VA = "0x2A9C630")]
		public static TMP_StyleSheet GetStyleSheet()
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x2A9C204", Offset = "0x2A9C204", VA = "0x2A9C204")]
		public static void LoadLinebreakingRules()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x2A9C6C0", Offset = "0x2A9C6C0", VA = "0x2A9C6C0")]
		private static Dictionary<int, char> GetCharacters(TextAsset file)
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2A9C7EC", Offset = "0x2A9C7EC", VA = "0x2A9C7EC")]
		public TMP_Settings()
		{
		}
	}
}
