using Il2CppDummyDll;
using UnityEngine.UI;

namespace I2.Loc
{
	[Token(Token = "0x2001319")]
	public class LocalizeTarget_UnityUI_Image : LocalizeTarget<Image>
	{
		[Token(Token = "0x6005921")]
		[Address(RVA = "0x154A4F0", Offset = "0x154A4F0", VA = "0x154A4F0")]
		static LocalizeTarget_UnityUI_Image()
		{
		}

		[Token(Token = "0x6005922")]
		[Address(RVA = "0x154A4F4", Offset = "0x154A4F4", VA = "0x154A4F4")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x7204C", Offset = "0x7204C")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6005923")]
		[Address(RVA = "0x154A5C4", Offset = "0x154A5C4", VA = "0x154A5C4", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x6005924")]
		[Address(RVA = "0x154A5CC", Offset = "0x154A5CC", VA = "0x154A5CC", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x6005925")]
		[Address(RVA = "0x154A5D4", Offset = "0x154A5D4", VA = "0x154A5D4", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x6005926")]
		[Address(RVA = "0x154A5DC", Offset = "0x154A5DC", VA = "0x154A5DC", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005927")]
		[Address(RVA = "0x154A670", Offset = "0x154A670", VA = "0x154A670", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005928")]
		[Address(RVA = "0x154A678", Offset = "0x154A678", VA = "0x154A678", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6005929")]
		[Address(RVA = "0x154A818", Offset = "0x154A818", VA = "0x154A818", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x600592A")]
		[Address(RVA = "0x154A914", Offset = "0x154A914", VA = "0x154A914")]
		public LocalizeTarget_UnityUI_Image()
		{
		}
	}
}
