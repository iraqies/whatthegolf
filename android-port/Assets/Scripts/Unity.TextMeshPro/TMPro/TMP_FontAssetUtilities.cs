using System.Collections.Generic;
using Il2CppDummyDll;

namespace TMPro
{
	[Token(Token = "0x2000028")]
	public class TMP_FontAssetUtilities
	{
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly TMP_FontAssetUtilities s_Instance;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x8")]
		private static HashSet<int> k_SearchedAssets;

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2A89100", Offset = "0x2A89100", VA = "0x2A89100")]
		static TMP_FontAssetUtilities()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2A89168", Offset = "0x2A89168", VA = "0x2A89168")]
		public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2A892DC", Offset = "0x2A892DC", VA = "0x2A892DC")]
		private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2A896D4", Offset = "0x2A896D4", VA = "0x2A896D4")]
		public static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			return null;
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2A89960", Offset = "0x2A89960", VA = "0x2A89960")]
		public static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks)
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2A89CB4", Offset = "0x2A89CB4", VA = "0x2A89CB4")]
		private static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks)
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2A89160", Offset = "0x2A89160", VA = "0x2A89160")]
		public TMP_FontAssetUtilities()
		{
		}
	}
}
