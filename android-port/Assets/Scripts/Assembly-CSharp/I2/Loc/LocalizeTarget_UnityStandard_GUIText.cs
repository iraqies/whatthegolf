using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace I2.Loc
{
	[Token(Token = "0x2001312")]
	public class LocalizeTarget_UnityStandard_GUIText : LocalizeTarget<Text>
	{
		[Token(Token = "0x4006676")]
		[FieldOffset(Offset = "0x20")]
		private TextAnchor mAlignment_RTL;

		[Token(Token = "0x4006677")]
		[FieldOffset(Offset = "0x24")]
		private TextAnchor mAlignment_LTR;

		[Token(Token = "0x4006678")]
		[FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x4006679")]
		[FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x60058E1")]
		[Address(RVA = "0x1548924", Offset = "0x1548924", VA = "0x1548924")]
		static LocalizeTarget_UnityStandard_GUIText()
		{
		}

		[Token(Token = "0x60058E2")]
		[Address(RVA = "0x1548928", Offset = "0x1548928", VA = "0x1548928")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x71FD8", Offset = "0x71FD8")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60058E3")]
		[Address(RVA = "0x15489F8", Offset = "0x15489F8", VA = "0x15489F8", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60058E4")]
		[Address(RVA = "0x1548A00", Offset = "0x1548A00", VA = "0x1548A00", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60058E5")]
		[Address(RVA = "0x1548A08", Offset = "0x1548A08", VA = "0x1548A08", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x60058E6")]
		[Address(RVA = "0x1548A10", Offset = "0x1548A10", VA = "0x1548A10", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60058E7")]
		[Address(RVA = "0x1548A18", Offset = "0x1548A18", VA = "0x1548A18", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60058E8")]
		[Address(RVA = "0x1548A20", Offset = "0x1548A20", VA = "0x1548A20", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60058E9")]
		[Address(RVA = "0x1548B58", Offset = "0x1548B58", VA = "0x1548B58", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60058EA")]
		[Address(RVA = "0x1548DE8", Offset = "0x1548DE8", VA = "0x1548DE8")]
		public LocalizeTarget_UnityStandard_GUIText()
		{
		}
	}
}
