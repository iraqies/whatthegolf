using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2001316")]
	public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x6005901")]
		[Address(RVA = "0x15496C0", Offset = "0x15496C0", VA = "0x15496C0")]
		static LocalizeTarget_UnityStandard_Prefab()
		{
		}

		[Token(Token = "0x6005902")]
		[Address(RVA = "0x15496C4", Offset = "0x15496C4", VA = "0x15496C4")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x72010", Offset = "0x72010")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6005903")]
		[Address(RVA = "0x15497A8", Offset = "0x15497A8", VA = "0x15497A8", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005904")]
		[Address(RVA = "0x15497B0", Offset = "0x15497B0", VA = "0x15497B0", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005905")]
		[Address(RVA = "0x15497B8", Offset = "0x15497B8", VA = "0x15497B8", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x6005906")]
		[Address(RVA = "0x15497C0", Offset = "0x15497C0", VA = "0x15497C0", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default;
		}

		[Token(Token = "0x6005907")]
		[Address(RVA = "0x15497C8", Offset = "0x15497C8", VA = "0x15497C8", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x6005908")]
		[Address(RVA = "0x15497D0", Offset = "0x15497D0", VA = "0x15497D0", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default;
		}

		[Token(Token = "0x6005909")]
		[Address(RVA = "0x15497D8", Offset = "0x15497D8", VA = "0x15497D8", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x600590A")]
		[Address(RVA = "0x1549814", Offset = "0x1549814", VA = "0x1549814", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x600590B")]
		[Address(RVA = "0x1549A50", Offset = "0x1549A50", VA = "0x1549A50")]
		private Transform InstantiateNewPrefab(Localize cmp, string mainTranslation)
		{
			return null;
		}

		[Token(Token = "0x600590C")]
		[Address(RVA = "0x1549C18", Offset = "0x1549C18", VA = "0x1549C18")]
		public LocalizeTarget_UnityStandard_Prefab()
		{
		}
	}
}
