using Il2CppDummyDll;
using TMPro;

namespace I2.Loc
{
	[Token(Token = "0x200130E")]
	public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TextMeshProUGUI>
	{
		[Token(Token = "0x4006672")]
		[FieldOffset(Offset = "0x20")]
		public TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x4006673")]
		[FieldOffset(Offset = "0x24")]
		public TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x4006674")]
		[FieldOffset(Offset = "0x28")]
		public bool mAlignmentWasRTL;

		[Token(Token = "0x4006675")]
		[FieldOffset(Offset = "0x29")]
		public bool mInitializeAlignment;

		[Token(Token = "0x60058C0")]
		[Address(RVA = "0x1547A14", Offset = "0x1547A14", VA = "0x1547A14")]
		static LocalizeTarget_TextMeshPro_UGUI()
		{
		}

		[Token(Token = "0x60058C1")]
		[Address(RVA = "0x1547A18", Offset = "0x1547A18", VA = "0x1547A18")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x71F9C", Offset = "0x71F9C")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60058C2")]
		[Address(RVA = "0x1547AE8", Offset = "0x1547AE8", VA = "0x1547AE8", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60058C3")]
		[Address(RVA = "0x1547AF0", Offset = "0x1547AF0", VA = "0x1547AF0", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60058C4")]
		[Address(RVA = "0x1547AF8", Offset = "0x1547AF8", VA = "0x1547AF8", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x60058C5")]
		[Address(RVA = "0x1547B00", Offset = "0x1547B00", VA = "0x1547B00", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60058C6")]
		[Address(RVA = "0x1547B08", Offset = "0x1547B08", VA = "0x1547B08", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60058C7")]
		[Address(RVA = "0x1547B10", Offset = "0x1547B10", VA = "0x1547B10", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60058C8")]
		[Address(RVA = "0x1547C48", Offset = "0x1547C48", VA = "0x1547C48", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60058C9")]
		[Address(RVA = "0x15481BC", Offset = "0x15481BC", VA = "0x15481BC")]
		public LocalizeTarget_TextMeshPro_UGUI()
		{
		}
	}
}
