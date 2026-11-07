using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x200130D")]
	public class LocalizeTarget_TextMeshPro_Label : LocalizeTarget<TextMeshPro>
	{
		[Token(Token = "0x400666E")]
		[FieldOffset(Offset = "0x20")]
		private TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x400666F")]
		[FieldOffset(Offset = "0x24")]
		private TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x4006670")]
		[FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x4006671")]
		[FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x60058B2")]
		[Address(RVA = "0x1546C30", Offset = "0x1546C30", VA = "0x1546C30")]
		static LocalizeTarget_TextMeshPro_Label()
		{
		}

		[Token(Token = "0x60058B3")]
		[Address(RVA = "0x1546C34", Offset = "0x1546C34", VA = "0x1546C34")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x71F88", Offset = "0x71F88")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60058B4")]
		[Address(RVA = "0x1546D04", Offset = "0x1546D04", VA = "0x1546D04", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60058B5")]
		[Address(RVA = "0x1546D0C", Offset = "0x1546D0C", VA = "0x1546D0C", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60058B6")]
		[Address(RVA = "0x1546D14", Offset = "0x1546D14", VA = "0x1546D14", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x60058B7")]
		[Address(RVA = "0x1546D1C", Offset = "0x1546D1C", VA = "0x1546D1C", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60058B8")]
		[Address(RVA = "0x1546D24", Offset = "0x1546D24", VA = "0x1546D24", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60058B9")]
		[Address(RVA = "0x1546D2C", Offset = "0x1546D2C", VA = "0x1546D2C", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60058BA")]
		[Address(RVA = "0x1546E64", Offset = "0x1546E64", VA = "0x1546E64", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60058BB")]
		[Address(RVA = "0x15474EC", Offset = "0x15474EC", VA = "0x15474EC")]
		internal static TMP_FontAsset GetTMPFontFromMaterial(Localize cmp, string matName)
		{
			return null;
		}

		[Token(Token = "0x60058BC")]
		[Address(RVA = "0x154779C", Offset = "0x154779C", VA = "0x154779C")]
		internal static void InitAlignment_TMPro(bool isRTL, TextAlignmentOptions alignment, out TextAlignmentOptions alignLTR, out TextAlignmentOptions alignRTL)
		{
		}

		[Token(Token = "0x60058BD")]
		[Address(RVA = "0x15473D8", Offset = "0x15473D8", VA = "0x15473D8")]
		internal static void SetFont(TMP_Text label, TMP_FontAsset newFont)
		{
		}

		[Token(Token = "0x60058BE")]
		[Address(RVA = "0x1547670", Offset = "0x1547670", VA = "0x1547670")]
		internal static void SetMaterial(TMP_Text label, Material newMat)
		{
		}

		[Token(Token = "0x60058BF")]
		[Address(RVA = "0x15479A8", Offset = "0x15479A8", VA = "0x15479A8")]
		public LocalizeTarget_TextMeshPro_Label()
		{
		}
	}
}
