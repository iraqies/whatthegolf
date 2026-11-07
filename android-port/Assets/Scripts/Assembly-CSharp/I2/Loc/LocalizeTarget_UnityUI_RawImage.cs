using Il2CppDummyDll;
using UnityEngine.UI;

namespace I2.Loc
{
	[Token(Token = "0x200131A")]
	public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<RawImage>
	{
		[Token(Token = "0x600592B")]
		[Address(RVA = "0x154A96C", Offset = "0x154A96C", VA = "0x154A96C")]
		static LocalizeTarget_UnityUI_RawImage()
		{
		}

		[Token(Token = "0x600592C")]
		[Address(RVA = "0x154A970", Offset = "0x154A970", VA = "0x154A970")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x72060", Offset = "0x72060")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x600592D")]
		[Address(RVA = "0x154AA40", Offset = "0x154AA40", VA = "0x154AA40", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x600592E")]
		[Address(RVA = "0x154AA48", Offset = "0x154AA48", VA = "0x154AA48", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x600592F")]
		[Address(RVA = "0x154AA50", Offset = "0x154AA50", VA = "0x154AA50", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x6005930")]
		[Address(RVA = "0x154AA58", Offset = "0x154AA58", VA = "0x154AA58", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x6005931")]
		[Address(RVA = "0x154AA60", Offset = "0x154AA60", VA = "0x154AA60", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x6005932")]
		[Address(RVA = "0x154AA68", Offset = "0x154AA68", VA = "0x154AA68", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6005933")]
		[Address(RVA = "0x154AB50", Offset = "0x154AB50", VA = "0x154AB50", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6005934")]
		[Address(RVA = "0x154AC4C", Offset = "0x154AC4C", VA = "0x154AC4C")]
		public LocalizeTarget_UnityUI_RawImage()
		{
		}
	}
}
