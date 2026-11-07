using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2001308")]
	public abstract class ILocalizeTarget : ScriptableObject
	{
		[Token(Token = "0x600589D")]
		public abstract bool IsValid(Localize cmp);

		[Token(Token = "0x600589E")]
		public abstract void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm);

		[Token(Token = "0x600589F")]
		public abstract void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation);

		[Token(Token = "0x60058A0")]
		public abstract bool CanUseSecondaryTerm();

		[Token(Token = "0x60058A1")]
		public abstract bool AllowMainTermToBeRTL();

		[Token(Token = "0x60058A2")]
		public abstract bool AllowSecondTermToBeRTL();

		[Token(Token = "0x60058A3")]
		public abstract eTermType GetPrimaryTermType(Localize cmp);

		[Token(Token = "0x60058A4")]
		public abstract eTermType GetSecondaryTermType(Localize cmp);

		[Token(Token = "0x60058A5")]
		[Address(RVA = "0x14E15D4", Offset = "0x14E15D4", VA = "0x14E15D4")]
		protected ILocalizeTarget()
		{
		}
	}
}
