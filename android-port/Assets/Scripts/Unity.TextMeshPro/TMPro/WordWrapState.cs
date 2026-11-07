using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Token(Token = "0x2000081")]
	public struct WordWrapState
	{
		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x0")]
		public int previous_WordBreak;

		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x4")]
		public int total_CharacterCount;

		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0x8")]
		public int visible_CharacterCount;

		[Token(Token = "0x40004E2")]
		[FieldOffset(Offset = "0xC")]
		public int visible_SpriteCount;

		[Token(Token = "0x40004E3")]
		[FieldOffset(Offset = "0x10")]
		public int visible_LinkCount;

		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0x14")]
		public int firstCharacterIndex;

		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x18")]
		public int firstVisibleCharacterIndex;

		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x1C")]
		public int lastCharacterIndex;

		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0x20")]
		public int lastVisibleCharIndex;

		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0x24")]
		public int lineNumber;

		[Token(Token = "0x40004E9")]
		[FieldOffset(Offset = "0x28")]
		public float maxCapHeight;

		[Token(Token = "0x40004EA")]
		[FieldOffset(Offset = "0x2C")]
		public float maxAscender;

		[Token(Token = "0x40004EB")]
		[FieldOffset(Offset = "0x30")]
		public float maxDescender;

		[Token(Token = "0x40004EC")]
		[FieldOffset(Offset = "0x34")]
		public float startOfLineAscender;

		[Token(Token = "0x40004ED")]
		[FieldOffset(Offset = "0x38")]
		public float maxLineAscender;

		[Token(Token = "0x40004EE")]
		[FieldOffset(Offset = "0x3C")]
		public float maxLineDescender;

		[Token(Token = "0x40004EF")]
		[FieldOffset(Offset = "0x40")]
		public float pageAscender;

		[Token(Token = "0x40004F0")]
		[FieldOffset(Offset = "0x44")]
		public HorizontalAlignmentOptions horizontalAlignment;

		[Token(Token = "0x40004F1")]
		[FieldOffset(Offset = "0x48")]
		public float marginLeft;

		[Token(Token = "0x40004F2")]
		[FieldOffset(Offset = "0x4C")]
		public float marginRight;

		[Token(Token = "0x40004F3")]
		[FieldOffset(Offset = "0x50")]
		public float xAdvance;

		[Token(Token = "0x40004F4")]
		[FieldOffset(Offset = "0x54")]
		public float preferredWidth;

		[Token(Token = "0x40004F5")]
		[FieldOffset(Offset = "0x58")]
		public float preferredHeight;

		[Token(Token = "0x40004F6")]
		[FieldOffset(Offset = "0x5C")]
		public float previousLineScale;

		[Token(Token = "0x40004F7")]
		[FieldOffset(Offset = "0x60")]
		public int wordCount;

		[Token(Token = "0x40004F8")]
		[FieldOffset(Offset = "0x64")]
		public FontStyles fontStyle;

		[Token(Token = "0x40004F9")]
		[FieldOffset(Offset = "0x68")]
		public int italicAngle;

		[Token(Token = "0x40004FA")]
		[FieldOffset(Offset = "0x6C")]
		public float fontScaleMultiplier;

		[Token(Token = "0x40004FB")]
		[FieldOffset(Offset = "0x70")]
		public float currentFontSize;

		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0x74")]
		public float baselineOffset;

		[Token(Token = "0x40004FD")]
		[FieldOffset(Offset = "0x78")]
		public float lineOffset;

		[Token(Token = "0x40004FE")]
		[FieldOffset(Offset = "0x7C")]
		public bool isDrivenLineSpacing;

		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0x80")]
		public float glyphHorizontalAdvanceAdjustment;

		[Token(Token = "0x4000500")]
		[FieldOffset(Offset = "0x84")]
		public float cSpace;

		[Token(Token = "0x4000501")]
		[FieldOffset(Offset = "0x88")]
		public float mSpace;

		[Token(Token = "0x4000502")]
		[FieldOffset(Offset = "0x90")]
		public TMP_TextInfo textInfo;

		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x98")]
		public TMP_LineInfo lineInfo;

		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0xF4")]
		public Color32 vertexColor;

		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0xF8")]
		public Color32 underlineColor;

		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0xFC")]
		public Color32 strikethroughColor;

		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x100")]
		public Color32 highlightColor;

		[Token(Token = "0x4000508")]
		[FieldOffset(Offset = "0x104")]
		public TMP_FontStyleStack basicStyleStack;

		[Token(Token = "0x4000509")]
		[FieldOffset(Offset = "0x110")]
		public TMP_TextProcessingStack<int> italicAngleStack;

		[Token(Token = "0x400050A")]
		[FieldOffset(Offset = "0x130")]
		public TMP_TextProcessingStack<Color32> colorStack;

		[Token(Token = "0x400050B")]
		[FieldOffset(Offset = "0x150")]
		public TMP_TextProcessingStack<Color32> underlineColorStack;

		[Token(Token = "0x400050C")]
		[FieldOffset(Offset = "0x170")]
		public TMP_TextProcessingStack<Color32> strikethroughColorStack;

		[Token(Token = "0x400050D")]
		[FieldOffset(Offset = "0x190")]
		public TMP_TextProcessingStack<Color32> highlightColorStack;

		[Token(Token = "0x400050E")]
		[FieldOffset(Offset = "0x1B0")]
		public TMP_TextProcessingStack<HighlightState> highlightStateStack;

		[Token(Token = "0x400050F")]
		[FieldOffset(Offset = "0x1E0")]
		public TMP_TextProcessingStack<TMP_ColorGradient> colorGradientStack;

		[Token(Token = "0x4000510")]
		[FieldOffset(Offset = "0x208")]
		public TMP_TextProcessingStack<float> sizeStack;

		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0x228")]
		public TMP_TextProcessingStack<float> indentStack;

		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0x248")]
		public TMP_TextProcessingStack<FontWeight> fontWeightStack;

		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0x268")]
		public TMP_TextProcessingStack<int> styleStack;

		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0x288")]
		public TMP_TextProcessingStack<float> baselineStack;

		[Token(Token = "0x4000515")]
		[FieldOffset(Offset = "0x2A8")]
		public TMP_TextProcessingStack<int> actionStack;

		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x2C8")]
		public TMP_TextProcessingStack<MaterialReference> materialReferenceStack;

		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x320")]
		public TMP_TextProcessingStack<HorizontalAlignmentOptions> lineJustificationStack;

		[Token(Token = "0x4000518")]
		[FieldOffset(Offset = "0x340")]
		public int spriteAnimationID;

		[Token(Token = "0x4000519")]
		[FieldOffset(Offset = "0x348")]
		public TMP_FontAsset currentFontAsset;

		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x350")]
		public TMP_SpriteAsset currentSpriteAsset;

		[Token(Token = "0x400051B")]
		[FieldOffset(Offset = "0x358")]
		public Material currentMaterial;

		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x360")]
		public int currentMaterialIndex;

		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x364")]
		public Extents meshExtents;

		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x374")]
		public bool tagNoParsing;

		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0x375")]
		public bool isNonBreakingSpace;
	}
}
