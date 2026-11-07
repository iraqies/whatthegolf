using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2001311")]
	public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x60058D6")]
		[Address(RVA = "0x15485F8", Offset = "0x15485F8", VA = "0x15485F8")]
		static LocalizeTarget_UnityStandard_Child()
		{
		}

		[Token(Token = "0x60058D7")]
		[Address(RVA = "0x15485FC", Offset = "0x15485FC", VA = "0x15485FC")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x71FC4", Offset = "0x71FC4")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60058D8")]
		[Address(RVA = "0x15486E0", Offset = "0x15486E0", VA = "0x15486E0", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60058D9")]
		[Address(RVA = "0x1548718", Offset = "0x1548718", VA = "0x1548718", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60058DA")]
		[Address(RVA = "0x1548720", Offset = "0x1548720", VA = "0x1548720", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60058DB")]
		[Address(RVA = "0x1548728", Offset = "0x1548728", VA = "0x1548728", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x60058DC")]
		[Address(RVA = "0x1548730", Offset = "0x1548730", VA = "0x1548730", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60058DD")]
		[Address(RVA = "0x1548738", Offset = "0x1548738", VA = "0x1548738", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60058DE")]
		[Address(RVA = "0x1548740", Offset = "0x1548740", VA = "0x1548740", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60058DF")]
		[Address(RVA = "0x154877C", Offset = "0x154877C", VA = "0x154877C", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60058E0")]
		[Address(RVA = "0x15488CC", Offset = "0x15488CC", VA = "0x15488CC")]
		public LocalizeTarget_UnityStandard_Child()
		{
		}
	}
}
