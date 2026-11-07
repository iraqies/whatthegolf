using System;
using Il2CppDummyDll;

namespace Prime31
{
	[Token(Token = "0x2000004")]
	public static class ActionExtensions
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x233AD8C", Offset = "0x233AD8C", VA = "0x233AD8C")]
		private static void invoke(Delegate listener, object[] args)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x233AEC8", Offset = "0x233AEC8", VA = "0x233AEC8")]
		public static void fire(this Action handler)
		{
		}

		[Token(Token = "0x6000006")]
		public static void fire<T>(this Action<T> handler, T param)
		{
		}
	}
}
