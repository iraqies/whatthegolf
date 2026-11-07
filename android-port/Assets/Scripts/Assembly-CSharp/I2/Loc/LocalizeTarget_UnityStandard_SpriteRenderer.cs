using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2001317")]
	public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<SpriteRenderer>
	{
		[Token(Token = "0x600590D")]
		[Address(RVA = "0x1549C70", Offset = "0x1549C70", VA = "0x1549C70")]
		static LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}

		[Token(Token = "0x600590E")]
		[Address(RVA = "0x1549C74", Offset = "0x1549C74", VA = "0x1549C74")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x72024", Offset = "0x72024")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x600590F")]
		[Address(RVA = "0x1549D44", Offset = "0x1549D44", VA = "0x1549D44", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005910")]
		[Address(RVA = "0x1549D4C", Offset = "0x1549D4C", VA = "0x1549D4C", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005911")]
		[Address(RVA = "0x1549D54", Offset = "0x1549D54", VA = "0x1549D54", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x6005912")]
		[Address(RVA = "0x1549D5C", Offset = "0x1549D5C", VA = "0x1549D5C", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x6005913")]
		[Address(RVA = "0x1549D64", Offset = "0x1549D64", VA = "0x1549D64", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x6005914")]
		[Address(RVA = "0x1549D6C", Offset = "0x1549D6C", VA = "0x1549D6C", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6005915")]
		[Address(RVA = "0x1549E50", Offset = "0x1549E50", VA = "0x1549E50", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6005916")]
		[Address(RVA = "0x1549F60", Offset = "0x1549F60", VA = "0x1549F60")]
		public LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}
	}
}
