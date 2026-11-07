using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace I2.Loc
{
	[Token(Token = "0x200131B")]
	public class LocalizeTarget_UnityUI_Text : LocalizeTarget<Text>
	{
		[Token(Token = "0x400667E")]
		[FieldOffset(Offset = "0x20")]
		private TextAnchor mAlignment_RTL;

		[Token(Token = "0x400667F")]
		[FieldOffset(Offset = "0x24")]
		private TextAnchor mAlignment_LTR;

		[Token(Token = "0x4006680")]
		[FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x4006681")]
		[FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x6005935")]
		[Address(RVA = "0x154ACA4", Offset = "0x154ACA4", VA = "0x154ACA4")]
		static LocalizeTarget_UnityUI_Text()
		{
		}

		[Token(Token = "0x6005936")]
		[Address(RVA = "0x154ACA8", Offset = "0x154ACA8", VA = "0x154ACA8")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x72074", Offset = "0x72074")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6005937")]
		[Address(RVA = "0x154AD78", Offset = "0x154AD78", VA = "0x154AD78", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005938")]
		[Address(RVA = "0x154AD80", Offset = "0x154AD80", VA = "0x154AD80", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005939")]
		[Address(RVA = "0x154AD88", Offset = "0x154AD88", VA = "0x154AD88", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x600593A")]
		[Address(RVA = "0x154AD90", Offset = "0x154AD90", VA = "0x154AD90", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x600593B")]
		[Address(RVA = "0x154AD98", Offset = "0x154AD98", VA = "0x154AD98", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x600593C")]
		[Address(RVA = "0x154ADA0", Offset = "0x154ADA0", VA = "0x154ADA0", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x600593D")]
		[Address(RVA = "0x154AEE0", Offset = "0x154AEE0", VA = "0x154AEE0", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x600593E")]
		[Address(RVA = "0x154B1D4", Offset = "0x154B1D4", VA = "0x154B1D4")]
		private void InitAlignment(bool isRTL, TextAnchor alignment, out TextAnchor alignLTR, out TextAnchor alignRTL)
		{
		}

		[Token(Token = "0x600593F")]
		[Address(RVA = "0x154B304", Offset = "0x154B304", VA = "0x154B304")]
		public LocalizeTarget_UnityUI_Text()
		{
		}
	}
}
