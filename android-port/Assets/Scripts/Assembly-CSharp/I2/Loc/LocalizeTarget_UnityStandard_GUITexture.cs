using Il2CppDummyDll;
using UnityEngine.UI;

namespace I2.Loc
{
	[Token(Token = "0x2001313")]
	public class LocalizeTarget_UnityStandard_GUITexture : LocalizeTarget<Image>
	{
		[Token(Token = "0x60058EB")]
		[Address(RVA = "0x1548E54", Offset = "0x1548E54", VA = "0x1548E54")]
		static LocalizeTarget_UnityStandard_GUITexture()
		{
		}

		[Token(Token = "0x60058EC")]
		[Address(RVA = "0x1548E58", Offset = "0x1548E58", VA = "0x1548E58")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x71FEC", Offset = "0x71FEC")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60058ED")]
		[Address(RVA = "0x1548F28", Offset = "0x1548F28", VA = "0x1548F28", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60058EE")]
		[Address(RVA = "0x1548F30", Offset = "0x1548F30", VA = "0x1548F30", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60058EF")]
		[Address(RVA = "0x1548F38", Offset = "0x1548F38", VA = "0x1548F38", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x60058F0")]
		[Address(RVA = "0x1548F40", Offset = "0x1548F40", VA = "0x1548F40", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60058F1")]
		[Address(RVA = "0x1548F48", Offset = "0x1548F48", VA = "0x1548F48", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60058F2")]
		[Address(RVA = "0x1548F50", Offset = "0x1548F50", VA = "0x1548F50", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60058F3")]
		[Address(RVA = "0x1549028", Offset = "0x1549028", VA = "0x1549028", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60058F4")]
		[Address(RVA = "0x1549124", Offset = "0x1549124", VA = "0x1549124")]
		public LocalizeTarget_UnityStandard_GUITexture()
		{
		}
	}
}
