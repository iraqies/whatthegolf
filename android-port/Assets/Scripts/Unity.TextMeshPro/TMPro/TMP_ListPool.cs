using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TMPro
{
	[Token(Token = "0x2000041")]
	internal static class TMP_ListPool<T>
	{
		[Serializable]
		[Token(Token = "0x2000042")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B9174", Offset = "0x1B9174")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40001AF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x600022D")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600022E")]
			internal void _003C_002Ecctor_003Eb__3_0(List<T> l)
			{
			}
		}

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly TMP_ObjectPool<List<T>> s_ListPool;

		[Token(Token = "0x6000229")]
		public static List<T> Get()
		{
			return null;
		}

		[Token(Token = "0x600022A")]
		public static void Release(List<T> toRelease)
		{
		}
	}
}
