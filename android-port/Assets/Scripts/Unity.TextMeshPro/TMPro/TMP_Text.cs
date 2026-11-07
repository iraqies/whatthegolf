using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	[Token(Token = "0x2000066")]
	public abstract class TMP_Text : MaskableGraphic
	{
		[Token(Token = "0x2000067")]
		protected struct CharacterSubstitution
		{
			[Token(Token = "0x4000456")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			[Token(Token = "0x4000457")]
			[FieldOffset(Offset = "0x4")]
			public uint unicode;

			[Token(Token = "0x600043D")]
			[Address(RVA = "0x2AE0248", Offset = "0x2AE0248", VA = "0x2AE0248")]
			public CharacterSubstitution(int index, uint unicode)
			{
			}
		}

		[Token(Token = "0x2000068")]
		internal enum TextInputSources
		{
			[Token(Token = "0x4000459")]
			TextInputBox = 0,
			[Token(Token = "0x400045A")]
			SetText = 1,
			[Token(Token = "0x400045B")]
			SetTextArray = 2,
			[Token(Token = "0x400045C")]
			TextString = 3
		}

		[Token(Token = "0x2000069")]
		internal struct UnicodeChar
		{
			[Token(Token = "0x400045D")]
			[FieldOffset(Offset = "0x0")]
			public int unicode;

			[Token(Token = "0x400045E")]
			[FieldOffset(Offset = "0x4")]
			public int stringIndex;

			[Token(Token = "0x400045F")]
			[FieldOffset(Offset = "0x8")]
			public int length;
		}

		[Token(Token = "0x200006A")]
		protected struct SpecialCharacter
		{
			[Token(Token = "0x4000460")]
			[FieldOffset(Offset = "0x0")]
			public TMP_Character character;

			[Token(Token = "0x4000461")]
			[FieldOffset(Offset = "0x8")]
			public TMP_FontAsset fontAsset;

			[Token(Token = "0x4000462")]
			[FieldOffset(Offset = "0x10")]
			public Material material;

			[Token(Token = "0x4000463")]
			[FieldOffset(Offset = "0x18")]
			public int materialIndex;

			[Token(Token = "0x600043E")]
			[Address(RVA = "0x2AE0250", Offset = "0x2AE0250", VA = "0x2AE0250")]
			public SpecialCharacter(TMP_Character character, int materialIndex)
			{
			}
		}

		[Token(Token = "0x200006B")]
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1B931C", Offset = "0x1B931C")]
		private struct TextBackingContainer
		{
			[Token(Token = "0x4000464")]
			[FieldOffset(Offset = "0x0")]
			private uint[] m_Array;

			[Token(Token = "0x4000465")]
			[FieldOffset(Offset = "0x8")]
			private int m_Count;

			[Token(Token = "0x17000131")]
			public int Capacity
			{
				[Token(Token = "0x600043F")]
				[Address(RVA = "0x2AE0350", Offset = "0x2AE0350", VA = "0x2AE0350")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000132")]
			public int Count
			{
				[Token(Token = "0x6000440")]
				[Address(RVA = "0x2AE036C", Offset = "0x2AE036C", VA = "0x2AE036C")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000441")]
				[Address(RVA = "0x2AE0374", Offset = "0x2AE0374", VA = "0x2AE0374")]
				set
				{
				}
			}

			// C# has no syntax for parameterized property 'Item'.
			// Its 'property:' attributes below are ignored by the compiler (CS0657).
			[property: Token(Token = "0x17000133")]
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x2AE037C", Offset = "0x2AE037C", VA = "0x2AE037C")]
			public uint get_Item(int index)
			{
				return default;
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x2AE03B8", Offset = "0x2AE03B8", VA = "0x2AE03B8")]
			public void set_Item(int index, uint value)
			{
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x2AE04D8", Offset = "0x2AE04D8", VA = "0x2AE04D8")]
			public TextBackingContainer(int size)
			{
			}

			[Token(Token = "0x6000445")]
			[Address(RVA = "0x2AE0470", Offset = "0x2AE0470", VA = "0x2AE0470")]
			public void Resize(int size)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200006C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B9354", Offset = "0x1B9354")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000466")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000467")]
			[FieldOffset(Offset = "0x8")]
			public static Action<TMP_TextInfo> _003C_003E9__622_0;

			[Token(Token = "0x6000447")]
			[Address(RVA = "0x2AE023C", Offset = "0x2AE023C", VA = "0x2AE023C")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x2AE0244", Offset = "0x2AE0244", VA = "0x2AE0244")]
			internal void _003C_002Ector_003Eb__622_0(TMP_TextInfo _003Cp0_003E)
			{
			}
		}

		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		protected string m_text;

		[Token(Token = "0x4000372")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_IsTextBackingStringDirty;

		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		protected ITextPreprocessor m_TextPreprocessor;

		[Token(Token = "0x4000374")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		protected bool m_isRightToLeft;

		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		protected TMP_FontAsset m_fontAsset;

		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0xF8")]
		protected TMP_FontAsset m_currentFontAsset;

		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x100")]
		protected bool m_isSDFShader;

		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		protected Material m_sharedMaterial;

		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x110")]
		protected Material m_currentMaterial;

		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0x0")]
		protected static MaterialReference[] m_materialReferences;

		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0x8")]
		protected static Dictionary<int, int> m_materialReferenceIndexLookup;

		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0x10")]
		protected static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack;

		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0x118")]
		protected int m_currentMaterialIndex;

		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		protected Material[] m_fontSharedMaterials;

		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		protected Material m_fontMaterial;

		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		protected Material[] m_fontMaterials;

		[Token(Token = "0x4000381")]
		[FieldOffset(Offset = "0x138")]
		protected bool m_isMaterialDirty;

		[Token(Token = "0x4000382")]
		[FieldOffset(Offset = "0x13C")]
		[SerializeField]
		protected Color32 m_fontColor32;

		[Token(Token = "0x4000383")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		protected Color m_fontColor;

		[Token(Token = "0x4000384")]
		[FieldOffset(Offset = "0x68")]
		protected static Color32 s_colorWhite;

		[Token(Token = "0x4000385")]
		[FieldOffset(Offset = "0x150")]
		protected Color32 m_underlineColor;

		[Token(Token = "0x4000386")]
		[FieldOffset(Offset = "0x154")]
		protected Color32 m_strikethroughColor;

		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		protected bool m_enableVertexGradient;

		[Token(Token = "0x4000388")]
		[FieldOffset(Offset = "0x15C")]
		[SerializeField]
		protected ColorMode m_colorMode;

		[Token(Token = "0x4000389")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		protected VertexGradient m_fontColorGradient;

		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		protected TMP_ColorGradient m_fontColorGradientPreset;

		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		protected TMP_SpriteAsset m_spriteAsset;

		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		protected bool m_tintAllSprites;

		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x1B1")]
		protected bool m_tintSprite;

		[Token(Token = "0x400038E")]
		[FieldOffset(Offset = "0x1B4")]
		protected Color32 m_spriteColor;

		[Token(Token = "0x400038F")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		protected TMP_StyleSheet m_StyleSheet;

		[Token(Token = "0x4000390")]
		[FieldOffset(Offset = "0x1C0")]
		internal TMP_Style m_TextStyle;

		[Token(Token = "0x4000391")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		protected int m_TextStyleHashCode;

		[Token(Token = "0x4000392")]
		[FieldOffset(Offset = "0x1CC")]
		[SerializeField]
		protected bool m_overrideHtmlColors;

		[Token(Token = "0x4000393")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		protected Color32 m_faceColor;

		[Token(Token = "0x4000394")]
		[FieldOffset(Offset = "0x1D4")]
		protected Color32 m_outlineColor;

		[Token(Token = "0x4000395")]
		[FieldOffset(Offset = "0x1D8")]
		protected float m_outlineWidth;

		[Token(Token = "0x4000396")]
		[FieldOffset(Offset = "0x1DC")]
		[SerializeField]
		protected float m_fontSize;

		[Token(Token = "0x4000397")]
		[FieldOffset(Offset = "0x1E0")]
		protected float m_currentFontSize;

		[Token(Token = "0x4000398")]
		[FieldOffset(Offset = "0x1E4")]
		[SerializeField]
		protected float m_fontSizeBase;

		[Token(Token = "0x4000399")]
		[FieldOffset(Offset = "0x1E8")]
		protected TMP_TextProcessingStack<float> m_sizeStack;

		[Token(Token = "0x400039A")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		protected FontWeight m_fontWeight;

		[Token(Token = "0x400039B")]
		[FieldOffset(Offset = "0x20C")]
		protected FontWeight m_FontWeightInternal;

		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x210")]
		protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack;

		[Token(Token = "0x400039D")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		protected bool m_enableAutoSizing;

		[Token(Token = "0x400039E")]
		[FieldOffset(Offset = "0x234")]
		protected float m_maxFontSize;

		[Token(Token = "0x400039F")]
		[FieldOffset(Offset = "0x238")]
		protected float m_minFontSize;

		[Token(Token = "0x40003A0")]
		[FieldOffset(Offset = "0x23C")]
		protected int m_AutoSizeIterationCount;

		[Token(Token = "0x40003A1")]
		[FieldOffset(Offset = "0x240")]
		protected int m_AutoSizeMaxIterationCount;

		[Token(Token = "0x40003A2")]
		[FieldOffset(Offset = "0x244")]
		protected bool m_IsAutoSizePointSizeSet;

		[Token(Token = "0x40003A3")]
		[FieldOffset(Offset = "0x248")]
		[SerializeField]
		protected float m_fontSizeMin;

		[Token(Token = "0x40003A4")]
		[FieldOffset(Offset = "0x24C")]
		[SerializeField]
		protected float m_fontSizeMax;

		[Token(Token = "0x40003A5")]
		[FieldOffset(Offset = "0x250")]
		[SerializeField]
		protected FontStyles m_fontStyle;

		[Token(Token = "0x40003A6")]
		[FieldOffset(Offset = "0x254")]
		protected FontStyles m_FontStyleInternal;

		[Token(Token = "0x40003A7")]
		[FieldOffset(Offset = "0x258")]
		protected TMP_FontStyleStack m_fontStyleStack;

		[Token(Token = "0x40003A8")]
		[FieldOffset(Offset = "0x262")]
		protected bool m_isUsingBold;

		[Token(Token = "0x40003A9")]
		[FieldOffset(Offset = "0x264")]
		[SerializeField]
		protected HorizontalAlignmentOptions m_HorizontalAlignment;

		[Token(Token = "0x40003AA")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		protected VerticalAlignmentOptions m_VerticalAlignment;

		[Token(Token = "0x40003AB")]
		[FieldOffset(Offset = "0x26C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1BA2BC", Offset = "0x1BA2BC")]
		[SerializeField]
		protected TextAlignmentOptions m_textAlignment;

		[Token(Token = "0x40003AC")]
		[FieldOffset(Offset = "0x270")]
		protected HorizontalAlignmentOptions m_lineJustification;

		[Token(Token = "0x40003AD")]
		[FieldOffset(Offset = "0x278")]
		protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack;

		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x298")]
		protected Vector3[] m_textContainerLocalCorners;

		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x2A0")]
		[SerializeField]
		protected float m_characterSpacing;

		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x2A4")]
		protected float m_cSpacing;

		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x2A8")]
		protected float m_monoSpacing;

		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0x2AC")]
		[SerializeField]
		protected float m_wordSpacing;

		[Token(Token = "0x40003B3")]
		[FieldOffset(Offset = "0x2B0")]
		[SerializeField]
		protected float m_lineSpacing;

		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0x2B4")]
		protected float m_lineSpacingDelta;

		[Token(Token = "0x40003B5")]
		[FieldOffset(Offset = "0x2B8")]
		protected float m_lineHeight;

		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0x2BC")]
		protected bool m_IsDrivenLineSpacing;

		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0x2C0")]
		[SerializeField]
		protected float m_lineSpacingMax;

		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0x2C4")]
		[SerializeField]
		protected float m_paragraphSpacing;

		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0x2C8")]
		[SerializeField]
		protected float m_charWidthMaxAdj;

		[Token(Token = "0x40003BA")]
		[FieldOffset(Offset = "0x2CC")]
		protected float m_charWidthAdjDelta;

		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x2D0")]
		[SerializeField]
		protected bool m_enableWordWrapping;

		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0x2D1")]
		protected bool m_isCharacterWrappingEnabled;

		[Token(Token = "0x40003BD")]
		[FieldOffset(Offset = "0x2D2")]
		protected bool m_isNonBreakingSpace;

		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0x2D3")]
		protected bool m_isIgnoringAlignment;

		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0x2D4")]
		[SerializeField]
		protected float m_wordWrappingRatios;

		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x2D8")]
		[SerializeField]
		protected TextOverflowModes m_overflowMode;

		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x2DC")]
		protected int m_firstOverflowCharacterIndex;

		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x2E0")]
		[SerializeField]
		protected TMP_Text m_linkedTextComponent;

		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x2E8")]
		[SerializeField]
		internal TMP_Text parentLinkedComponent;

		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x2F0")]
		protected bool m_isTextTruncated;

		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x2F1")]
		[SerializeField]
		protected bool m_enableKerning;

		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x2F4")]
		protected float m_GlyphHorizontalAdvanceAdjustment;

		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x2F8")]
		[SerializeField]
		protected bool m_enableExtraPadding;

		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x2F9")]
		[SerializeField]
		protected bool checkPaddingRequired;

		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x2FA")]
		[SerializeField]
		protected bool m_isRichText;

		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x2FB")]
		[SerializeField]
		protected bool m_parseCtrlCharacters;

		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x2FC")]
		protected bool m_isOverlay;

		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x2FD")]
		[SerializeField]
		protected bool m_isOrthographic;

		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x2FE")]
		[SerializeField]
		protected bool m_isCullingEnabled;

		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x2FF")]
		protected bool m_isMaskingEnabled;

		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x300")]
		protected bool isMaskUpdateRequired;

		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x301")]
		protected bool m_ignoreCulling;

		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x304")]
		[SerializeField]
		protected TextureMappingOptions m_horizontalMapping;

		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x308")]
		[SerializeField]
		protected TextureMappingOptions m_verticalMapping;

		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x30C")]
		[SerializeField]
		protected float m_uvLineOffset;

		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x310")]
		protected TextRenderFlags m_renderMode;

		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0x314")]
		[SerializeField]
		protected VertexSortingOrder m_geometrySortingOrder;

		[Token(Token = "0x40003D6")]
		[FieldOffset(Offset = "0x318")]
		[SerializeField]
		protected bool m_IsTextObjectScaleStatic;

		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x319")]
		[SerializeField]
		protected bool m_VertexBufferAutoSizeReduction;

		[Token(Token = "0x40003D8")]
		[FieldOffset(Offset = "0x31C")]
		protected int m_firstVisibleCharacter;

		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0x320")]
		protected int m_maxVisibleCharacters;

		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x324")]
		protected int m_maxVisibleWords;

		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x328")]
		protected int m_maxVisibleLines;

		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x32C")]
		[SerializeField]
		protected bool m_useMaxVisibleDescender;

		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x330")]
		[SerializeField]
		protected int m_pageToDisplay;

		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x334")]
		protected bool m_isNewPage;

		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x338")]
		[SerializeField]
		protected Vector4 m_margin;

		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0x348")]
		protected float m_marginLeft;

		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x34C")]
		protected float m_marginRight;

		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x350")]
		protected float m_marginWidth;

		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x354")]
		protected float m_marginHeight;

		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x358")]
		protected float m_width;

		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x360")]
		protected TMP_TextInfo m_textInfo;

		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x368")]
		protected bool m_havePropertiesChanged;

		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x369")]
		[SerializeField]
		protected bool m_isUsingLegacyAnimationComponent;

		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x370")]
		protected Transform m_transform;

		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x378")]
		protected RectTransform m_rectTransform;

		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x380")]
		protected Vector2 m_PreviousRectTransformSize;

		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0x388")]
		protected Vector2 m_PreviousPivotPosition;

		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0x390")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA4C8", Offset = "0x1BA4C8")]
		private bool autoSizeTextContainer__BackingField;

		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0x391")]
		protected bool m_autoSizeTextContainer;

		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0x398")]
		protected Mesh m_mesh;

		[Token(Token = "0x40003EF")]
		[FieldOffset(Offset = "0x3A0")]
		[SerializeField]
		protected bool m_isVolumetricText;

		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA4E8", Offset = "0x1BA4E8")]
		private static Func<int, string, TMP_FontAsset> m_OnFontAssetRequest;

		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA4F8", Offset = "0x1BA4F8")]
		private static Func<int, string, TMP_SpriteAsset> m_OnSpriteAssetRequest;

		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0x3A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA508", Offset = "0x1BA508")]
		private Action<TMP_TextInfo> m_OnPreRenderText;

		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x3B0")]
		protected TMP_SpriteAnimator m_spriteAnimator;

		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x3B8")]
		protected float m_flexibleHeight;

		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x3BC")]
		protected float m_flexibleWidth;

		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0x3C0")]
		protected float m_minWidth;

		[Token(Token = "0x40003F7")]
		[FieldOffset(Offset = "0x3C4")]
		protected float m_minHeight;

		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x3C8")]
		protected float m_maxWidth;

		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x3CC")]
		protected float m_maxHeight;

		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x3D0")]
		protected LayoutElement m_LayoutElement;

		[Token(Token = "0x40003FB")]
		[FieldOffset(Offset = "0x3D8")]
		protected float m_preferredWidth;

		[Token(Token = "0x40003FC")]
		[FieldOffset(Offset = "0x3DC")]
		protected float m_renderedWidth;

		[Token(Token = "0x40003FD")]
		[FieldOffset(Offset = "0x3E0")]
		protected bool m_isPreferredWidthDirty;

		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x3E4")]
		protected float m_preferredHeight;

		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x3E8")]
		protected float m_renderedHeight;

		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x3EC")]
		protected bool m_isPreferredHeightDirty;

		[Token(Token = "0x4000401")]
		[FieldOffset(Offset = "0x3ED")]
		protected bool m_isCalculatingPreferredValues;

		[Token(Token = "0x4000402")]
		[FieldOffset(Offset = "0x3F0")]
		protected int m_layoutPriority;

		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x3F4")]
		protected bool m_isLayoutDirty;

		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x3F5")]
		protected bool m_isAwake;

		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x3F6")]
		internal bool m_isWaitingOnResourceLoad;

		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x3F8")]
		internal TextInputSources m_inputSource;

		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0x3FC")]
		protected float m_fontScaleMultiplier;

		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x80")]
		private static char[] m_htmlTag;

		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x88")]
		private static RichTextTagAttribute[] m_xmlAttribute;

		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x90")]
		private static float[] m_attributeParameterValues;

		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x400")]
		protected float tag_LineIndent;

		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x404")]
		protected float tag_Indent;

		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x408")]
		protected TMP_TextProcessingStack<float> m_indentStack;

		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x428")]
		protected bool tag_NoParsing;

		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x429")]
		protected bool m_isParsingText;

		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x42C")]
		protected Matrix4x4 m_FXMatrix;

		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x46C")]
		protected bool m_isFXMatrixSet;

		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x470")]
		internal UnicodeChar[] m_TextProcessingArray;

		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x478")]
		internal int m_InternalTextProcessingArraySize;

		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x480")]
		private TMP_CharacterInfo[] m_internalCharacterInfo;

		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x488")]
		protected int m_totalCharacterCount;

		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x98")]
		protected static WordWrapState m_SavedWordWrapState;

		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x410")]
		protected static WordWrapState m_SavedLineState;

		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x788")]
		protected static WordWrapState m_SavedEllipsisState;

		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0xB00")]
		protected static WordWrapState m_SavedLastValidState;

		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0xE78")]
		protected static WordWrapState m_SavedSoftLineBreakState;

		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x11F0")]
		internal static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack;

		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0x48C")]
		protected int m_characterCount;

		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0x490")]
		protected int m_firstCharacterOfLine;

		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x494")]
		protected int m_firstVisibleCharacterOfLine;

		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x498")]
		protected int m_lastCharacterOfLine;

		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x49C")]
		protected int m_lastVisibleCharacterOfLine;

		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x4A0")]
		protected int m_lineNumber;

		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x4A4")]
		protected int m_lineVisibleCharacterCount;

		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x4A8")]
		protected int m_pageNumber;

		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x4AC")]
		protected float m_PageAscender;

		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x4B0")]
		protected float m_maxTextAscender;

		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x4B4")]
		protected float m_maxCapHeight;

		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x4B8")]
		protected float m_ElementAscender;

		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x4BC")]
		protected float m_ElementDescender;

		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x4C0")]
		protected float m_maxLineAscender;

		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x4C4")]
		protected float m_maxLineDescender;

		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x4C8")]
		protected float m_startOfLineAscender;

		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x4CC")]
		protected float m_startOfLineDescender;

		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x4D0")]
		protected float m_lineOffset;

		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x4D4")]
		protected Extents m_meshExtents;

		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x4E4")]
		protected Color32 m_htmlColor;

		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x4E8")]
		protected TMP_TextProcessingStack<Color32> m_colorStack;

		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x508")]
		protected TMP_TextProcessingStack<Color32> m_underlineColorStack;

		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x528")]
		protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack;

		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x548")]
		protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack;

		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x578")]
		protected TMP_ColorGradient m_colorGradientPreset;

		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x580")]
		protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack;

		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x5A8")]
		protected bool m_colorGradientPresetIsTinted;

		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x5AC")]
		protected float m_tabSpacing;

		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x5B0")]
		protected float m_spacing;

		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x5B8")]
		protected TMP_TextProcessingStack<int>[] m_TextStyleStacks;

		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x5C0")]
		protected int m_TextStyleStackDepth;

		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x5C8")]
		protected TMP_TextProcessingStack<int> m_ItalicAngleStack;

		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x5E8")]
		protected int m_ItalicAngle;

		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x5F0")]
		protected TMP_TextProcessingStack<int> m_actionStack;

		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x610")]
		protected float m_padding;

		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x614")]
		protected float m_baselineOffset;

		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x618")]
		protected TMP_TextProcessingStack<float> m_baselineOffsetStack;

		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x638")]
		protected float m_xAdvance;

		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x63C")]
		protected TMP_TextElementType m_textElementType;

		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x640")]
		protected TMP_TextElement m_cached_TextElement;

		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x648")]
		protected SpecialCharacter m_Ellipsis;

		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x668")]
		protected SpecialCharacter m_Underline;

		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x688")]
		protected TMP_SpriteAsset m_defaultSpriteAsset;

		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x690")]
		protected TMP_SpriteAsset m_currentSpriteAsset;

		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x698")]
		protected int m_spriteCount;

		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x69C")]
		protected int m_spriteIndex;

		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x6A0")]
		protected int m_spriteAnimationID;

		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x1588")]
		private static ProfilerMarker k_ParseTextMarker;

		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x1590")]
		private static ProfilerMarker k_InsertNewLineMarker;

		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x6A4")]
		protected bool m_ignoreActiveState;

		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x6A8")]
		private TextBackingContainer m_TextBackingArray;

		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x6B8")]
		private readonly decimal[] k_Power;

		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x1598")]
		protected static Vector2 k_LargePositiveVector2;

		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x15A0")]
		protected static Vector2 k_LargeNegativeVector2;

		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x15A8")]
		protected static float k_LargePositiveFloat;

		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x15AC")]
		protected static float k_LargeNegativeFloat;

		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x15B0")]
		protected static int k_LargePositiveInt;

		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x15B4")]
		protected static int k_LargeNegativeInt;

		[Token(Token = "0x170000D7")]
		public virtual string text
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x2AA2218", Offset = "0x2AA2218", VA = "0x2AA2218", Slot = "61")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x2AA230C", Offset = "0x2AA230C", VA = "0x2AA230C", Slot = "62")]
			set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public ITextPreprocessor textPreprocessor
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x2AA23B4", Offset = "0x2AA23B4", VA = "0x2AA23B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x2AA23BC", Offset = "0x2AA23BC", VA = "0x2AA23BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public bool isRightToLeftText
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x2AA23C4", Offset = "0x2AA23C4", VA = "0x2AA23C4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x2AA23CC", Offset = "0x2AA23CC", VA = "0x2AA23CC")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public TMP_FontAsset font
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x2AA2424", Offset = "0x2AA2424", VA = "0x2AA2424")]
			get
			{
				return null;
			}
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x2AA242C", Offset = "0x2AA242C", VA = "0x2AA242C")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public virtual Material fontSharedMaterial
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x2AA2508", Offset = "0x2AA2508", VA = "0x2AA2508", Slot = "63")]
			get
			{
				return null;
			}
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x2AA2510", Offset = "0x2AA2510", VA = "0x2AA2510", Slot = "64")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public virtual Material[] fontSharedMaterials
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x2AA25EC", Offset = "0x2AA25EC", VA = "0x2AA25EC", Slot = "65")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x2AA25FC", Offset = "0x2AA25FC", VA = "0x2AA25FC", Slot = "66")]
			set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public Material fontMaterial
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x2AA2654", Offset = "0x2AA2654", VA = "0x2AA2654")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x2AA2668", Offset = "0x2AA2668", VA = "0x2AA2668")]
			set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public virtual Material[] fontMaterials
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x2AA2778", Offset = "0x2AA2778", VA = "0x2AA2778", Slot = "67")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x2AA278C", Offset = "0x2AA278C", VA = "0x2AA278C", Slot = "68")]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public override Color color
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x2AA27E4", Offset = "0x2AA27E4", VA = "0x2AA27E4", Slot = "22")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x2AA27F8", Offset = "0x2AA27F8", VA = "0x2AA27F8", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public float alpha
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x2AA289C", Offset = "0x2AA289C", VA = "0x2AA289C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x2AA28A4", Offset = "0x2AA28A4", VA = "0x2AA28A4")]
			set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public bool enableVertexGradient
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x2AA28D0", Offset = "0x2AA28D0", VA = "0x2AA28D0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x2AA28D8", Offset = "0x2AA28D8", VA = "0x2AA28D8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public VertexGradient colorGradient
		{
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x2AA2904", Offset = "0x2AA2904", VA = "0x2AA2904")]
			get
			{
				return default;
			}
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x2AA2918", Offset = "0x2AA2918", VA = "0x2AA2918")]
			set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public TMP_ColorGradient colorGradientPreset
		{
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x2AA2940", Offset = "0x2AA2940", VA = "0x2AA2940")]
			get
			{
				return null;
			}
			[Token(Token = "0x600032E")]
			[Address(RVA = "0x2AA2948", Offset = "0x2AA2948", VA = "0x2AA2948")]
			set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public TMP_SpriteAsset spriteAsset
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0x2AA2964", Offset = "0x2AA2964", VA = "0x2AA2964")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x2AA296C", Offset = "0x2AA296C", VA = "0x2AA296C")]
			set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public bool tintAllSprites
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x2AA29B4", Offset = "0x2AA29B4", VA = "0x2AA29B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x2AA29BC", Offset = "0x2AA29BC", VA = "0x2AA29BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public TMP_StyleSheet styleSheet
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x2AA29E8", Offset = "0x2AA29E8", VA = "0x2AA29E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x2AA29F0", Offset = "0x2AA29F0", VA = "0x2AA29F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public TMP_Style textStyle
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0x2AA2A38", Offset = "0x2AA2A38", VA = "0x2AA2A38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000336")]
			[Address(RVA = "0x2AA2C38", Offset = "0x2AA2C38", VA = "0x2AA2C38")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public bool overrideColorTags
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0x2AA2C90", Offset = "0x2AA2C90", VA = "0x2AA2C90")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x2AA2C98", Offset = "0x2AA2C98", VA = "0x2AA2C98")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public Color32 faceColor
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x2AA2CC4", Offset = "0x2AA2CC4", VA = "0x2AA2CC4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x2AA2DB4", Offset = "0x2AA2DB4", VA = "0x2AA2DB4")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public Color32 outlineColor
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x2AA2E4C", Offset = "0x2AA2E4C", VA = "0x2AA2E4C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x2AA2F3C", Offset = "0x2AA2F3C", VA = "0x2AA2F3C")]
			set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public float outlineWidth
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x2AA2FC0", Offset = "0x2AA2FC0", VA = "0x2AA2FC0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x2AA30A8", Offset = "0x2AA30A8", VA = "0x2AA30A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public float fontSize
		{
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x2AA310C", Offset = "0x2AA310C", VA = "0x2AA310C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x2AA3114", Offset = "0x2AA3114", VA = "0x2AA3114")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public FontWeight fontWeight
		{
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x2AA3178", Offset = "0x2AA3178", VA = "0x2AA3178")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x2AA3180", Offset = "0x2AA3180", VA = "0x2AA3180")]
			set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public float pixelsPerUnit
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x2AA31D8", Offset = "0x2AA31D8", VA = "0x2AA31D8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000EF")]
		public bool enableAutoSizing
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x2AA338C", Offset = "0x2AA338C", VA = "0x2AA338C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x2AA3394", Offset = "0x2AA3394", VA = "0x2AA3394")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public float fontSizeMin
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x2AA33E4", Offset = "0x2AA33E4", VA = "0x2AA33E4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x2AA33EC", Offset = "0x2AA33EC", VA = "0x2AA33EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public float fontSizeMax
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x2AA343C", Offset = "0x2AA343C", VA = "0x2AA343C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x2AA3444", Offset = "0x2AA3444", VA = "0x2AA3444")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public FontStyles fontStyle
		{
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x2AA3494", Offset = "0x2AA3494", VA = "0x2AA3494")]
			get
			{
				return default;
			}
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x2AA349C", Offset = "0x2AA349C", VA = "0x2AA349C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public bool isUsingBold
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x2AA34F4", Offset = "0x2AA34F4", VA = "0x2AA34F4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F4")]
		public HorizontalAlignmentOptions horizontalAlignment
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x2AA34FC", Offset = "0x2AA34FC", VA = "0x2AA34FC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x2AA3504", Offset = "0x2AA3504", VA = "0x2AA3504")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public VerticalAlignmentOptions verticalAlignment
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x2AA3530", Offset = "0x2AA3530", VA = "0x2AA3530")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x2AA3538", Offset = "0x2AA3538", VA = "0x2AA3538")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public TextAlignmentOptions alignment
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x2AA3564", Offset = "0x2AA3564", VA = "0x2AA3564")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x2AA3574", Offset = "0x2AA3574", VA = "0x2AA3574")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public float characterSpacing
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x2AA35B8", Offset = "0x2AA35B8", VA = "0x2AA35B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x2AA35C0", Offset = "0x2AA35C0", VA = "0x2AA35C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public float wordSpacing
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x2AA3618", Offset = "0x2AA3618", VA = "0x2AA3618")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x2AA3620", Offset = "0x2AA3620", VA = "0x2AA3620")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public float lineSpacing
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x2AA3678", Offset = "0x2AA3678", VA = "0x2AA3678")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x2AA3680", Offset = "0x2AA3680", VA = "0x2AA3680")]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public float lineSpacingAdjustment
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x2AA36D8", Offset = "0x2AA36D8", VA = "0x2AA36D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x2AA36E0", Offset = "0x2AA36E0", VA = "0x2AA36E0")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public float paragraphSpacing
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x2AA3738", Offset = "0x2AA3738", VA = "0x2AA3738")]
			get
			{
				return default;
			}
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x2AA3740", Offset = "0x2AA3740", VA = "0x2AA3740")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public float characterWidthAdjustment
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x2AA3798", Offset = "0x2AA3798", VA = "0x2AA3798")]
			get
			{
				return default;
			}
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x2AA37A0", Offset = "0x2AA37A0", VA = "0x2AA37A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public bool enableWordWrapping
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x2AA37F8", Offset = "0x2AA37F8", VA = "0x2AA37F8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x2AA3800", Offset = "0x2AA3800", VA = "0x2AA3800")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public float wordWrappingRatios
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x2AA3858", Offset = "0x2AA3858", VA = "0x2AA3858")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x2AA3860", Offset = "0x2AA3860", VA = "0x2AA3860")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public TextOverflowModes overflowMode
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x2AA38B8", Offset = "0x2AA38B8", VA = "0x2AA38B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x2AA38C0", Offset = "0x2AA38C0", VA = "0x2AA38C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public bool isTextOverflowing
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x2AA3918", Offset = "0x2AA3918", VA = "0x2AA3918")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000101")]
		public int firstOverflowCharacterIndex
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x2AA3928", Offset = "0x2AA3928", VA = "0x2AA3928")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000102")]
		public TMP_Text linkedTextComponent
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x2AA3930", Offset = "0x2AA3930", VA = "0x2AA3930")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x2AA3938", Offset = "0x2AA3938", VA = "0x2AA3938")]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public bool isTextTruncated
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x2AA3C58", Offset = "0x2AA3C58", VA = "0x2AA3C58")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000104")]
		public bool enableKerning
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x2AA3C60", Offset = "0x2AA3C60", VA = "0x2AA3C60")]
			get
			{
				return default;
			}
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x2AA3C68", Offset = "0x2AA3C68", VA = "0x2AA3C68")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public bool extraPadding
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x2AA3CC0", Offset = "0x2AA3CC0", VA = "0x2AA3CC0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x2AA3CC8", Offset = "0x2AA3CC8", VA = "0x2AA3CC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public bool richText
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x2AA3D20", Offset = "0x2AA3D20", VA = "0x2AA3D20")]
			get
			{
				return default;
			}
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x2AA3D28", Offset = "0x2AA3D28", VA = "0x2AA3D28")]
			set
			{
			}
		}

		[Token(Token = "0x17000107")]
		public bool parseCtrlCharacters
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x2AA3D80", Offset = "0x2AA3D80", VA = "0x2AA3D80")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x2AA3D88", Offset = "0x2AA3D88", VA = "0x2AA3D88")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public bool isOverlay
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x2AA3DE0", Offset = "0x2AA3DE0", VA = "0x2AA3DE0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x2AA3DE8", Offset = "0x2AA3DE8", VA = "0x2AA3DE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public bool isOrthographic
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x2AA3E40", Offset = "0x2AA3E40", VA = "0x2AA3E40")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x2AA3E48", Offset = "0x2AA3E48", VA = "0x2AA3E48")]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public bool enableCulling
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x2AA3E74", Offset = "0x2AA3E74", VA = "0x2AA3E74")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x2AA3E7C", Offset = "0x2AA3E7C", VA = "0x2AA3E7C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public bool ignoreVisibility
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x2AA3EC0", Offset = "0x2AA3EC0", VA = "0x2AA3EC0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x2AA3EC8", Offset = "0x2AA3EC8", VA = "0x2AA3EC8")]
			set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public TextureMappingOptions horizontalMapping
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x2AA3EE4", Offset = "0x2AA3EE4", VA = "0x2AA3EE4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x2AA3EEC", Offset = "0x2AA3EEC", VA = "0x2AA3EEC")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public TextureMappingOptions verticalMapping
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x2AA3F18", Offset = "0x2AA3F18", VA = "0x2AA3F18")]
			get
			{
				return default;
			}
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x2AA3F20", Offset = "0x2AA3F20", VA = "0x2AA3F20")]
			set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public float mappingUvLineOffset
		{
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x2AA3F4C", Offset = "0x2AA3F4C", VA = "0x2AA3F4C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x2AA3F54", Offset = "0x2AA3F54", VA = "0x2AA3F54")]
			set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		public TextRenderFlags renderMode
		{
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x2AA3F80", Offset = "0x2AA3F80", VA = "0x2AA3F80")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x2AA3F88", Offset = "0x2AA3F88", VA = "0x2AA3F88")]
			set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public VertexSortingOrder geometrySortingOrder
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x2AA3FA4", Offset = "0x2AA3FA4", VA = "0x2AA3FA4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x2AA3FAC", Offset = "0x2AA3FAC", VA = "0x2AA3FAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000111")]
		public bool isTextObjectScaleStatic
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x2AA3FC8", Offset = "0x2AA3FC8", VA = "0x2AA3FC8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x2AA3FD0", Offset = "0x2AA3FD0", VA = "0x2AA3FD0")]
			set
			{
			}
		}

		[Token(Token = "0x17000112")]
		public bool vertexBufferAutoSizeReduction
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x2AA4088", Offset = "0x2AA4088", VA = "0x2AA4088")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x2AA4090", Offset = "0x2AA4090", VA = "0x2AA4090")]
			set
			{
			}
		}

		[Token(Token = "0x17000113")]
		public int firstVisibleCharacter
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x2AA40AC", Offset = "0x2AA40AC", VA = "0x2AA40AC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x2AA40B4", Offset = "0x2AA40B4", VA = "0x2AA40B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public int maxVisibleCharacters
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x2AA40E0", Offset = "0x2AA40E0", VA = "0x2AA40E0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x2AA40E8", Offset = "0x2AA40E8", VA = "0x2AA40E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000115")]
		public int maxVisibleWords
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x2AA4114", Offset = "0x2AA4114", VA = "0x2AA4114")]
			get
			{
				return default;
			}
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x2AA411C", Offset = "0x2AA411C", VA = "0x2AA411C")]
			set
			{
			}
		}

		[Token(Token = "0x17000116")]
		public int maxVisibleLines
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x2AA4148", Offset = "0x2AA4148", VA = "0x2AA4148")]
			get
			{
				return default;
			}
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x2AA4150", Offset = "0x2AA4150", VA = "0x2AA4150")]
			set
			{
			}
		}

		[Token(Token = "0x17000117")]
		public bool useMaxVisibleDescender
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x2AA417C", Offset = "0x2AA417C", VA = "0x2AA417C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x2AA4184", Offset = "0x2AA4184", VA = "0x2AA4184")]
			set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public int pageToDisplay
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x2AA41B0", Offset = "0x2AA41B0", VA = "0x2AA41B0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x2AA41B8", Offset = "0x2AA41B8", VA = "0x2AA41B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000119")]
		public virtual Vector4 margin
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x2AA41E4", Offset = "0x2AA41E4", VA = "0x2AA41E4", Slot = "69")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x2AA41F8", Offset = "0x2AA41F8", VA = "0x2AA41F8", Slot = "70")]
			set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public TMP_TextInfo textInfo
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x2AA42A0", Offset = "0x2AA42A0", VA = "0x2AA42A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011B")]
		public bool havePropertiesChanged
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x2AA42A8", Offset = "0x2AA42A8", VA = "0x2AA42A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x2AA0450", Offset = "0x2AA0450", VA = "0x2AA0450")]
			set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public bool isUsingLegacyAnimationComponent
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x2AA42B0", Offset = "0x2AA42B0", VA = "0x2AA42B0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x2AA42B8", Offset = "0x2AA42B8", VA = "0x2AA42B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		public new Transform transform
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x2AA1510", Offset = "0x2AA1510", VA = "0x2AA1510")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011E")]
		public new RectTransform rectTransform
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x2AA15BC", Offset = "0x2AA15BC", VA = "0x2AA15BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011F")]
		public virtual bool autoSizeTextContainer
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x2AA42C0", Offset = "0x2AA42C0", VA = "0x2AA42C0", Slot = "71")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA7F8", Offset = "0x1BA7F8")]
			get
			{
				return default;
			}
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x2AA42C8", Offset = "0x2AA42C8", VA = "0x2AA42C8", Slot = "72")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA808", Offset = "0x1BA808")]
			set
			{
			}
		}

		[Token(Token = "0x17000120")]
		public virtual Mesh mesh
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x2AA42D0", Offset = "0x2AA42D0", VA = "0x2AA42D0", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000121")]
		public bool isVolumetricText
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x2AA42D8", Offset = "0x2AA42D8", VA = "0x2AA42D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x2AA42E0", Offset = "0x2AA42E0", VA = "0x2AA42E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000122")]
		public Bounds bounds
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x2AA4350", Offset = "0x2AA4350", VA = "0x2AA4350")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000123")]
		public Bounds textBounds
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x2AA4404", Offset = "0x2AA4404", VA = "0x2AA4404")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000124")]
		protected TMP_SpriteAnimator spriteAnimator
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x2AA4BB8", Offset = "0x2AA4BB8", VA = "0x2AA4BB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000125")]
		public float flexibleHeight
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x2AA4CCC", Offset = "0x2AA4CCC", VA = "0x2AA4CCC", Slot = "76")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000126")]
		public float flexibleWidth
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x2AA4CD4", Offset = "0x2AA4CD4", VA = "0x2AA4CD4", Slot = "77")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000127")]
		public float minWidth
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x2AA4CDC", Offset = "0x2AA4CDC", VA = "0x2AA4CDC", Slot = "78")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000128")]
		public float minHeight
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x2AA4CE4", Offset = "0x2AA4CE4", VA = "0x2AA4CE4", Slot = "79")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000129")]
		public float maxWidth
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x2AA4CEC", Offset = "0x2AA4CEC", VA = "0x2AA4CEC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700012A")]
		public float maxHeight
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x2AA4CF4", Offset = "0x2AA4CF4", VA = "0x2AA4CF4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700012B")]
		protected LayoutElement layoutElement
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x2AA4CFC", Offset = "0x2AA4CFC", VA = "0x2AA4CFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012C")]
		public virtual float preferredWidth
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x2AA4DA8", Offset = "0x2AA4DA8", VA = "0x2AA4DA8", Slot = "80")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700012D")]
		public virtual float preferredHeight
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x2AA4F24", Offset = "0x2AA4F24", VA = "0x2AA4F24", Slot = "81")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700012E")]
		public virtual float renderedWidth
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x2AA510C", Offset = "0x2AA510C", VA = "0x2AA510C", Slot = "82")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700012F")]
		public virtual float renderedHeight
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x2AA5164", Offset = "0x2AA5164", VA = "0x2AA5164", Slot = "83")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000130")]
		public int layoutPriority
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x2AA51C4", Offset = "0x2AA51C4", VA = "0x2AA51C4", Slot = "84")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000001")]
		public static event Func<int, string, TMP_FontAsset> OnFontAssetRequest
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x2AA4640", Offset = "0x2AA4640", VA = "0x2AA4640")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA818", Offset = "0x1BA818")]
			add
			{
			}
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x2AA474C", Offset = "0x2AA474C", VA = "0x2AA474C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA828", Offset = "0x1BA828")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public static event Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x2AA4858", Offset = "0x2AA4858", VA = "0x2AA4858")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA838", Offset = "0x1BA838")]
			add
			{
			}
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x2AA4964", Offset = "0x2AA4964", VA = "0x2AA4964")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA848", Offset = "0x1BA848")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public virtual event Action<TMP_TextInfo> OnPreRenderText
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x2AA4A70", Offset = "0x2AA4A70", VA = "0x2AA4A70", Slot = "74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA858", Offset = "0x1BA858")]
			add
			{
			}
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x2AA4B14", Offset = "0x2AA4B14", VA = "0x2AA4B14", Slot = "75")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA868", Offset = "0x1BA868")]
			remove
			{
			}
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x2AA51CC", Offset = "0x2AA51CC", VA = "0x2AA51CC", Slot = "85")]
		protected virtual void LoadFontAsset()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x2AA51D0", Offset = "0x2AA51D0", VA = "0x2AA51D0", Slot = "86")]
		protected virtual void SetSharedMaterial(Material mat)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x2AA51D4", Offset = "0x2AA51D4", VA = "0x2AA51D4", Slot = "87")]
		protected virtual Material GetMaterial(Material mat)
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x2AA51DC", Offset = "0x2AA51DC", VA = "0x2AA51DC", Slot = "88")]
		protected virtual Material[] GetSharedMaterials()
		{
			return null;
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x2AA51E4", Offset = "0x2AA51E4", VA = "0x2AA51E4", Slot = "89")]
		protected virtual void SetSharedMaterials(Material[] materials)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x2AA51E8", Offset = "0x2AA51E8", VA = "0x2AA51E8", Slot = "90")]
		protected virtual Material[] GetMaterials(Material[] mats)
		{
			return null;
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x2AA51F0", Offset = "0x2AA51F0", VA = "0x2AA51F0", Slot = "91")]
		protected virtual Material CreateMaterialInstance(Material source)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x2AA52BC", Offset = "0x2AA52BC", VA = "0x2AA52BC")]
		protected void SetVertexColorGradient(TMP_ColorGradient gradient)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x2AA5380", Offset = "0x2AA5380", VA = "0x2AA5380", Slot = "92")]
		protected virtual void SetFaceColor(Color32 color)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x2AA5384", Offset = "0x2AA5384", VA = "0x2AA5384", Slot = "93")]
		protected virtual void SetOutlineColor(Color32 color)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x2AA5388", Offset = "0x2AA5388", VA = "0x2AA5388", Slot = "94")]
		protected virtual void SetOutlineThickness(float thickness)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x2AA538C", Offset = "0x2AA538C", VA = "0x2AA538C", Slot = "95")]
		protected virtual void SetShaderDepth()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x2AA5390", Offset = "0x2AA5390", VA = "0x2AA5390", Slot = "96")]
		protected virtual void SetCulling()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x2AA5394", Offset = "0x2AA5394", VA = "0x2AA5394", Slot = "97")]
		internal virtual void UpdateCulling()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x2AA5398", Offset = "0x2AA5398", VA = "0x2AA5398", Slot = "98")]
		protected virtual float GetPaddingForMaterial()
		{
			return default;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x2AA54E0", Offset = "0x2AA54E0", VA = "0x2AA54E0", Slot = "99")]
		protected virtual float GetPaddingForMaterial(Material mat)
		{
			return default;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x2AA55F4", Offset = "0x2AA55F4", VA = "0x2AA55F4", Slot = "100")]
		protected virtual Vector3[] GetTextContainerLocalCorners()
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x2AA55FC", Offset = "0x2AA55FC", VA = "0x2AA55FC", Slot = "101")]
		public virtual void ForceMeshUpdate(bool ignoreActiveState = false, bool forceTextReparsing = false)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x2AA5600", Offset = "0x2AA5600", VA = "0x2AA5600", Slot = "102")]
		public virtual void UpdateGeometry(Mesh mesh, int index)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x2AA5604", Offset = "0x2AA5604", VA = "0x2AA5604", Slot = "103")]
		public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x2AA5608", Offset = "0x2AA5608", VA = "0x2AA5608", Slot = "104")]
		public virtual void UpdateVertexData()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x2AA560C", Offset = "0x2AA560C", VA = "0x2AA560C", Slot = "105")]
		public virtual void UpdateMeshPadding()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x2AA5610", Offset = "0x2AA5610", VA = "0x2AA5610", Slot = "46")]
		public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x2AA569C", Offset = "0x2AA569C", VA = "0x2AA569C", Slot = "48")]
		public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x2AA56F0", Offset = "0x2AA56F0", VA = "0x2AA56F0", Slot = "106")]
		protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x2AA56F4", Offset = "0x2AA56F4", VA = "0x2AA56F4", Slot = "107")]
		protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x2AA56F8", Offset = "0x2AA56F8", VA = "0x2AA56F8")]
		protected void ParseInputText()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x2AA5850", Offset = "0x2AA5850", VA = "0x2AA5850")]
		private void PopulateTextBackingArray(string sourceText)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x2AA62F8", Offset = "0x2AA62F8", VA = "0x2AA62F8")]
		private void PopulateTextBackingArray(string sourceText, int start, int length)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x2AA6414", Offset = "0x2AA6414", VA = "0x2AA6414")]
		private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x2AA6558", Offset = "0x2AA6558", VA = "0x2AA6558")]
		private void PopulateTextBackingArray(char[] sourceText, int start, int length)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x2AA586C", Offset = "0x2AA586C", VA = "0x2AA586C")]
		private void PopulateTextProcessingArray()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x2AA7A44", Offset = "0x2AA7A44", VA = "0x2AA7A44")]
		private void SetTextInternal(string sourceText)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x2AA7A94", Offset = "0x2AA7A94", VA = "0x2AA7A94")]
		public void SetText(string sourceText, bool syncTextInputBox = true)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x2AA7B14", Offset = "0x2AA7B14", VA = "0x2AA7B14")]
		public void SetText(string sourceText, float arg0)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x2AA7E80", Offset = "0x2AA7E80", VA = "0x2AA7E80")]
		public void SetText(string sourceText, float arg0, float arg1)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x2AA7E9C", Offset = "0x2AA7E9C", VA = "0x2AA7E9C")]
		public void SetText(string sourceText, float arg0, float arg1, float arg2)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x2AA7EB4", Offset = "0x2AA7EB4", VA = "0x2AA7EB4")]
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x2AA7EC8", Offset = "0x2AA7EC8", VA = "0x2AA7EC8")]
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x2AA7ED8", Offset = "0x2AA7ED8", VA = "0x2AA7ED8")]
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x2AA7EE4", Offset = "0x2AA7EE4", VA = "0x2AA7EE4")]
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x2AA7B34", Offset = "0x2AA7B34", VA = "0x2AA7B34")]
		public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x2AA81E8", Offset = "0x2AA81E8", VA = "0x2AA81E8")]
		public void SetText(StringBuilder sourceText)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x2AA8274", Offset = "0x2AA8274", VA = "0x2AA8274")]
		private void SetText(StringBuilder sourceText, int start, int length)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x2AA82D4", Offset = "0x2AA82D4", VA = "0x2AA82D4")]
		public void SetText(char[] sourceText)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x2AA83AC", Offset = "0x2AA83AC", VA = "0x2AA83AC")]
		public void SetText(char[] sourceText, int start, int length)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x2AA840C", Offset = "0x2AA840C", VA = "0x2AA840C")]
		public void SetCharArray(char[] sourceText)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x2AA834C", Offset = "0x2AA834C", VA = "0x2AA834C")]
		public void SetCharArray(char[] sourceText, int start, int length)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x2AA2A80", Offset = "0x2AA2A80", VA = "0x2AA2A80")]
		private TMP_Style GetStyle(int hashCode)
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x2AA6DA4", Offset = "0x2AA6DA4", VA = "0x2AA6DA4")]
		private bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex)
		{
			return default;
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x2AA88CC", Offset = "0x2AA88CC", VA = "0x2AA88CC")]
		private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref UnicodeChar[] charBuffer, ref int writeIndex)
		{
			return default;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x2AA720C", Offset = "0x2AA720C", VA = "0x2AA720C")]
		private void ReplaceClosingStyleTag(ref TextBackingContainer sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x2AA8D34", Offset = "0x2AA8D34", VA = "0x2AA8D34")]
		private void ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x2AA6694", Offset = "0x2AA6694", VA = "0x2AA6694")]
		private bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref UnicodeChar[] charBuffer, ref int writeIndex)
		{
			return default;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x2AA763C", Offset = "0x2AA763C", VA = "0x2AA763C")]
		private void InsertClosingStyleTag(ref UnicodeChar[] charBuffer, ref int writeIndex)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x2AA87A8", Offset = "0x2AA87A8", VA = "0x2AA87A8")]
		private int GetMarkupTagHashCode(int[] tagDefinition, int readIndex)
		{
			return default;
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x2AA6C94", Offset = "0x2AA6C94", VA = "0x2AA6C94")]
		private int GetMarkupTagHashCode(TextBackingContainer tagDefinition, int readIndex)
		{
			return default;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x2AA9164", Offset = "0x2AA9164", VA = "0x2AA9164")]
		private int GetStyleHashCode(ref int[] text, int index, out int closeIndex)
		{
			return default;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x2AA8484", Offset = "0x2AA8484", VA = "0x2AA8484")]
		private int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex)
		{
			return default;
		}

		[Token(Token = "0x60003F2")]
		private void ResizeInternalArray<T>(ref T[] array)
		{
		}

		[Token(Token = "0x60003F3")]
		private void ResizeInternalArray<T>(ref T[] array, int size)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x2AA7EEC", Offset = "0x2AA7EEC", VA = "0x2AA7EEC")]
		private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x2AA9250", Offset = "0x2AA9250", VA = "0x2AA9250")]
		private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x2AA2230", Offset = "0x2AA2230", VA = "0x2AA2230")]
		private string InternalTextBackingArrayToString()
		{
			return null;
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2AA9384", Offset = "0x2AA9384", VA = "0x2AA9384", Slot = "108")]
		internal virtual int SetArraySizes(UnicodeChar[] unicodeChars)
		{
			return default;
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x2AA938C", Offset = "0x2AA938C", VA = "0x2AA938C")]
		public Vector2 GetPreferredValues()
		{
			return default;
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2AA93DC", Offset = "0x2AA93DC", VA = "0x2AA93DC")]
		public Vector2 GetPreferredValues(float width, float height)
		{
			return default;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x2AA9618", Offset = "0x2AA9618", VA = "0x2AA9618")]
		public Vector2 GetPreferredValues(string text)
		{
			return default;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x2AA97D4", Offset = "0x2AA97D4", VA = "0x2AA97D4")]
		public Vector2 GetPreferredValues(string text, float width, float height)
		{
			return default;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x2AA4DCC", Offset = "0x2AA4DCC", VA = "0x2AA4DCC")]
		protected float GetPreferredWidth()
		{
			return default;
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x2AA9500", Offset = "0x2AA9500", VA = "0x2AA9500")]
		private float GetPreferredWidth(Vector2 margin)
		{
			return default;
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x2AA4F48", Offset = "0x2AA4F48", VA = "0x2AA4F48")]
		protected float GetPreferredHeight()
		{
			return default;
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x2AA9568", Offset = "0x2AA9568", VA = "0x2AA9568")]
		private float GetPreferredHeight(Vector2 margin)
		{
			return default;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x2AA9940", Offset = "0x2AA9940", VA = "0x2AA9940")]
		public Vector2 GetRenderedValues()
		{
			return default;
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x2AA996C", Offset = "0x2AA996C", VA = "0x2AA996C")]
		public Vector2 GetRenderedValues(bool onlyVisibleCharacters)
		{
			return default;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x2AA5138", Offset = "0x2AA5138", VA = "0x2AA5138")]
		private float GetRenderedWidth()
		{
			return default;
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x2AA9C14", Offset = "0x2AA9C14", VA = "0x2AA9C14")]
		protected float GetRenderedWidth(bool onlyVisibleCharacters)
		{
			return default;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x2AA5194", Offset = "0x2AA5194", VA = "0x2AA5194")]
		private float GetRenderedHeight()
		{
			return default;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x2AA9C40", Offset = "0x2AA9C40", VA = "0x2AA9C40")]
		protected float GetRenderedHeight(bool onlyVisibleCharacters)
		{
			return default;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x2AA9C70", Offset = "0x2AA9C70", VA = "0x2AA9C70", Slot = "109")]
		protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled)
		{
			return default;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x2AB3108", Offset = "0x2AB3108", VA = "0x2AB3108", Slot = "110")]
		protected virtual Bounds GetCompoundBounds()
		{
			return default;
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x2AB3114", Offset = "0x2AB3114", VA = "0x2AB3114", Slot = "111")]
		internal virtual Rect GetCanvasSpaceClippingRect()
		{
			return default;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x2AA441C", Offset = "0x2AA441C", VA = "0x2AA441C")]
		protected Bounds GetTextBounds()
		{
			return default;
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x2AA9998", Offset = "0x2AA9998", VA = "0x2AA9998")]
		protected Bounds GetTextBounds(bool onlyVisibleCharacters)
		{
			return default;
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x2AB311C", Offset = "0x2AB311C", VA = "0x2AB311C")]
		protected void AdjustLineOffset(int startIndex, int endIndex, float offset)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x2AB3218", Offset = "0x2AB3218", VA = "0x2AB3218")]
		protected void ResizeLineExtents(int size)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x2AB33D4", Offset = "0x2AB33D4", VA = "0x2AB33D4", Slot = "112")]
		public virtual TMP_TextInfo GetTextInfo(string text)
		{
			return null;
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x2AB33DC", Offset = "0x2AB33DC", VA = "0x2AB33DC", Slot = "113")]
		public virtual void ComputeMarginSize()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x2AB33E0", Offset = "0x2AB33E0", VA = "0x2AB33E0")]
		protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x2AB2E08", Offset = "0x2AB2E08", VA = "0x2AB2E08")]
		protected void SaveWordWrappingState(ref WordWrapState state, int index, int count)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x2AB2AD0", Offset = "0x2AB2AD0", VA = "0x2AB2AD0")]
		protected int RestoreWordWrappingState(ref WordWrapState state)
		{
			return default;
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x2AB3838", Offset = "0x2AB3838", VA = "0x2AB3838", Slot = "114")]
		protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x2AB42BC", Offset = "0x2AB42BC", VA = "0x2AB42BC", Slot = "115")]
		protected virtual void SaveSpriteVertexInfo(Color32 vertexColor)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x2AB495C", Offset = "0x2AB495C", VA = "0x2AB495C", Slot = "116")]
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x2AB4D20", Offset = "0x2AB4D20", VA = "0x2AB4D20", Slot = "117")]
		protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x2AB5300", Offset = "0x2AB5300", VA = "0x2AB5300", Slot = "118")]
		protected virtual void FillSpriteVertexBuffers(int i, int index_X4)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x2AB56C4", Offset = "0x2AB56C4", VA = "0x2AB56C4", Slot = "119")]
		protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x2AB63D0", Offset = "0x2AB63D0", VA = "0x2AB63D0", Slot = "120")]
		protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x2AB6804", Offset = "0x2AB6804", VA = "0x2AB6804")]
		protected void LoadDefaultSettings()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x2AB6ADC", Offset = "0x2AB6ADC", VA = "0x2AB6ADC")]
		protected void GetSpecialCharacters(TMP_FontAsset fontAsset)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x2AB6B08", Offset = "0x2AB6B08", VA = "0x2AB6B08")]
		protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x2AB6210", Offset = "0x2AB6210", VA = "0x2AB6210")]
		protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x2AB6DB0", Offset = "0x2AB6DB0", VA = "0x2AB6DB0")]
		protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x2AB6E24", Offset = "0x2AB6E24", VA = "0x2AB6E24")]
		protected TMP_FontAsset GetFontAssetForWeight(int fontWeight)
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x2AB6EC4", Offset = "0x2AB6EC4", VA = "0x2AB6EC4")]
		internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface)
		{
			return null;
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x2AB7350", Offset = "0x2AB7350", VA = "0x2AB7350", Slot = "121")]
		protected virtual void SetActiveSubMeshes(bool state)
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x2AB7354", Offset = "0x2AB7354", VA = "0x2AB7354", Slot = "122")]
		protected virtual void DestroySubMeshObjects()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x2AB7358", Offset = "0x2AB7358", VA = "0x2AB7358", Slot = "123")]
		public virtual void ClearMesh()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x2AB735C", Offset = "0x2AB735C", VA = "0x2AB735C", Slot = "124")]
		public virtual void ClearMesh(bool uploadGeometry)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x2AB7360", Offset = "0x2AB7360", VA = "0x2AB7360", Slot = "125")]
		public virtual string GetParsedText()
		{
			return null;
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x2AA3B5C", Offset = "0x2AA3B5C", VA = "0x2AA3B5C")]
		internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent)
		{
			return default;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x2AA3A30", Offset = "0x2AA3A30", VA = "0x2AA3A30")]
		internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x2AB6378", Offset = "0x2AB6378", VA = "0x2AB6378")]
		protected Vector2 PackUV(float x, float y, float scale)
		{
			return default;
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x2AB746C", Offset = "0x2AB746C", VA = "0x2AB746C")]
		protected float PackUV(float x, float y)
		{
			return default;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x2AB74C4", Offset = "0x2AB74C4", VA = "0x2AB74C4", Slot = "126")]
		internal virtual void InternalUpdate()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x2AB74C8", Offset = "0x2AB74C8", VA = "0x2AB74C8")]
		protected int HexToInt(char hex)
		{
			return default;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x2AB75E8", Offset = "0x2AB75E8", VA = "0x2AB75E8")]
		protected int GetUTF16(string text, int i)
		{
			return default;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x2AA85A0", Offset = "0x2AA85A0", VA = "0x2AA85A0")]
		protected int GetUTF16(int[] text, int i)
		{
			return default;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x2AB769C", Offset = "0x2AB769C", VA = "0x2AB769C")]
		internal int GetUTF16(uint[] text, int i)
		{
			return default;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x2AB7758", Offset = "0x2AB7758", VA = "0x2AB7758")]
		protected int GetUTF16(StringBuilder text, int i)
		{
			return default;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x2AA6AAC", Offset = "0x2AA6AAC", VA = "0x2AA6AAC")]
		private int GetUTF16(TextBackingContainer text, int i)
		{
			return default;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x2AB780C", Offset = "0x2AB780C", VA = "0x2AB780C")]
		protected int GetUTF32(string text, int i)
		{
			return default;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x2AA865C", Offset = "0x2AA865C", VA = "0x2AA865C")]
		protected int GetUTF32(int[] text, int i)
		{
			return default;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x2AB7950", Offset = "0x2AB7950", VA = "0x2AB7950")]
		internal int GetUTF32(uint[] text, int i)
		{
			return default;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x2AB7A9C", Offset = "0x2AB7A9C", VA = "0x2AB7A9C")]
		protected int GetUTF32(StringBuilder text, int i)
		{
			return default;
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x2AA6B58", Offset = "0x2AA6B58", VA = "0x2AA6B58")]
		private int GetUTF32(TextBackingContainer text, int i)
		{
			return default;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x2AB7BE0", Offset = "0x2AB7BE0", VA = "0x2AB7BE0")]
		protected Color32 HexCharsToColor(char[] hexChars, int tagCount)
		{
			return default;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x2AB8090", Offset = "0x2AB8090", VA = "0x2AB8090")]
		protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length)
		{
			return default;
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x2AB82F4", Offset = "0x2AB82F4", VA = "0x2AB82F4")]
		private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters)
		{
			return default;
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x2AB8550", Offset = "0x2AB8550", VA = "0x2AB8550")]
		protected float ConvertToFloat(char[] chars, int startIndex, int length)
		{
			return default;
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x2AB83B4", Offset = "0x2AB83B4", VA = "0x2AB83B4")]
		protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex)
		{
			return default;
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x2AAC114", Offset = "0x2AAC114", VA = "0x2AAC114")]
		internal bool ValidateHtmlTag(UnicodeChar[] chars, int startIndex, out int endIndex)
		{
			return default;
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x2AB8574", Offset = "0x2AB8574", VA = "0x2AB8574")]
		protected TMP_Text()
		{
		}
	}
}
