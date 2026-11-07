using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2001318")]
	public class LocalizeTarget_UnityStandard_TextMesh : LocalizeTarget<TextMesh>
	{
		[Token(Token = "0x400667A")]
		[FieldOffset(Offset = "0x20")]
		private TextAlignment mAlignment_RTL;

		[Token(Token = "0x400667B")]
		[FieldOffset(Offset = "0x24")]
		private TextAlignment mAlignment_LTR;

		[Token(Token = "0x400667C")]
		[FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x400667D")]
		[FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x6005917")]
		[Address(RVA = "0x1549FB8", Offset = "0x1549FB8", VA = "0x1549FB8")]
		static LocalizeTarget_UnityStandard_TextMesh()
		{
		}

		[Token(Token = "0x6005918")]
		[Address(RVA = "0x1549FBC", Offset = "0x1549FBC", VA = "0x1549FBC")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x72038", Offset = "0x72038")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6005919")]
		[Address(RVA = "0x154A08C", Offset = "0x154A08C", VA = "0x154A08C", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x600591A")]
		[Address(RVA = "0x154A094", Offset = "0x154A094", VA = "0x154A094", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x600591B")]
		[Address(RVA = "0x154A09C", Offset = "0x154A09C", VA = "0x154A09C", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x600591C")]
		[Address(RVA = "0x154A0A4", Offset = "0x154A0A4", VA = "0x154A0A4", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x600591D")]
		[Address(RVA = "0x154A0AC", Offset = "0x154A0AC", VA = "0x154A0AC", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x600591E")]
		[Address(RVA = "0x154A0B4", Offset = "0x154A0B4", VA = "0x154A0B4", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x600591F")]
		[Address(RVA = "0x154A1E4", Offset = "0x154A1E4", VA = "0x154A1E4", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6005920")]
		[Address(RVA = "0x154A488", Offset = "0x154A488", VA = "0x154A488")]
		public LocalizeTarget_UnityStandard_TextMesh()
		{
		}
	}
}
