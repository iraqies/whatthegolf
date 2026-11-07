using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x200130A")]
	public abstract class ILocalizeTargetDescriptor
	{
		[Token(Token = "0x400666C")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400666D")]
		[FieldOffset(Offset = "0x18")]
		public int Priority;

		[Token(Token = "0x60058A8")]
		public abstract bool CanLocalize(Localize cmp);

		[Token(Token = "0x60058A9")]
		public abstract ILocalizeTarget CreateTarget(Localize cmp);

		[Token(Token = "0x60058AA")]
		public abstract Type GetTargetType();

		[Token(Token = "0x60058AB")]
		[Address(RVA = "0x14E15DC", Offset = "0x14E15DC", VA = "0x14E15DC")]
		protected ILocalizeTargetDescriptor()
		{
		}
	}
}
