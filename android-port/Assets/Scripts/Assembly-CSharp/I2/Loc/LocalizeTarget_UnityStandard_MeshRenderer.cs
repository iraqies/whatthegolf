using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2001314")]
	public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<MeshRenderer>
	{
		[Token(Token = "0x60058F5")]
		[Address(RVA = "0x154917C", Offset = "0x154917C", VA = "0x154917C")]
		static LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}

		[Token(Token = "0x60058F6")]
		[Address(RVA = "0x1549180", Offset = "0x1549180", VA = "0x1549180")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x71FFC", Offset = "0x71FFC")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60058F7")]
		[Address(RVA = "0x1549250", Offset = "0x1549250", VA = "0x1549250", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60058F8")]
		[Address(RVA = "0x1549258", Offset = "0x1549258", VA = "0x1549258", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60058F9")]
		[Address(RVA = "0x1549260", Offset = "0x1549260", VA = "0x1549260", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x60058FA")]
		[Address(RVA = "0x1549268", Offset = "0x1549268", VA = "0x1549268", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60058FB")]
		[Address(RVA = "0x1549270", Offset = "0x1549270", VA = "0x1549270", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60058FC")]
		[Address(RVA = "0x1549278", Offset = "0x1549278", VA = "0x1549278", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60058FD")]
		[Address(RVA = "0x154947C", Offset = "0x154947C", VA = "0x154947C", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60058FE")]
		[Address(RVA = "0x1549668", Offset = "0x1549668", VA = "0x1549668")]
		public LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}
	}
}
