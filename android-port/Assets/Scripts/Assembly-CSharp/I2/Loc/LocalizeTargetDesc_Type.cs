using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x200130C")]
	public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G> where T : Object where G : LocalizeTarget<T>
	{
		[Token(Token = "0x60058AF")]
		public override bool CanLocalize(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60058B0")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x60058B1")]
		public LocalizeTargetDesc_Type()
		{
		}
	}
}
