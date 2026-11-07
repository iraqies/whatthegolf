using System;
using Il2CppDummyDll;

namespace Rewired.Utils.Classes.Utility
{
	[Token(Token = "0x2000360")]
	internal struct SetAndRestoreVar<T> : IDisposable
	{
		[Token(Token = "0x400116F")]
		[FieldOffset(Offset = "0x0")]
		private readonly Action<T> oTYaMbEJOHgWFriwyKVuQJmGgRLMA;

		[Token(Token = "0x4001170")]
		[FieldOffset(Offset = "0x0")]
		private readonly T aeBVIwKfLInMbZLMxxXPuWvxrCrQ;

		[Token(Token = "0x60019D5")]
		public SetAndRestoreVar(T P_0, T P_1, Action<T> P_2)
		{
		}

		[Token(Token = "0x60019D6")]
		public void Dispose()
		{
		}
	}
}
