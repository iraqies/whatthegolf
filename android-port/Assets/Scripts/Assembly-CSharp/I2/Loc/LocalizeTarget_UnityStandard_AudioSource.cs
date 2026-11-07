using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x200130F")]
	public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<AudioSource>
	{
		[Token(Token = "0x60058CA")]
		[Address(RVA = "0x1548228", Offset = "0x1548228", VA = "0x1548228")]
		static LocalizeTarget_UnityStandard_AudioSource()
		{
		}

		[Token(Token = "0x60058CB")]
		[Address(RVA = "0x154822C", Offset = "0x154822C", VA = "0x154822C")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x71FB0", Offset = "0x71FB0")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60058CC")]
		[Address(RVA = "0x15482FC", Offset = "0x15482FC", VA = "0x15482FC", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60058CD")]
		[Address(RVA = "0x1548304", Offset = "0x1548304", VA = "0x1548304", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60058CE")]
		[Address(RVA = "0x154830C", Offset = "0x154830C", VA = "0x154830C", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x60058CF")]
		[Address(RVA = "0x1548314", Offset = "0x1548314", VA = "0x1548314", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60058D0")]
		[Address(RVA = "0x154831C", Offset = "0x154831C", VA = "0x154831C", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x60058D1")]
		[Address(RVA = "0x1548324", Offset = "0x1548324", VA = "0x1548324", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60058D2")]
		[Address(RVA = "0x1548404", Offset = "0x1548404", VA = "0x1548404", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60058D3")]
		[Address(RVA = "0x15485A0", Offset = "0x15485A0", VA = "0x15485A0")]
		public LocalizeTarget_UnityStandard_AudioSource()
		{
		}
	}
}
