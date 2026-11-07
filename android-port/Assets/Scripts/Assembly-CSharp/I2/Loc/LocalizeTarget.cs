using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2001309")]
	public abstract class LocalizeTarget<T> : ILocalizeTarget where T : Object
	{
		[Token(Token = "0x400666B")]
		[FieldOffset(Offset = "0x0")]
		public T mTarget;

		[Token(Token = "0x60058A6")]
		public override bool IsValid(Localize cmp)
		{
			return default;
		}

		[Token(Token = "0x60058A7")]
		protected LocalizeTarget()
		{
		}
	}
}
