using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x200130B")]
	public abstract class LocalizeTargetDesc<T> : ILocalizeTargetDescriptor where T : ILocalizeTarget
	{
		[Token(Token = "0x60058AC")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x60058AD")]
		public override Type GetTargetType()
		{
			return null;
		}

		[Token(Token = "0x60058AE")]
		protected LocalizeTargetDesc()
		{
		}
	}
}
