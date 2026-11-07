using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Token(Token = "0x2000002")]
	internal static class ArrayUtility
	{
		[Serializable]
		[Token(Token = "0x2000003")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B593C", Offset = "0x1B593C")]
		private sealed class _003C_003Ec__23<T>
		{
			[Token(Token = "0x4000001")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec__23<T> _003C_003E9;

			[Token(Token = "0x4000002")]
			[FieldOffset(Offset = "0x0")]
			public static Func<T, string> _003C_003E9__23_0;

			[Token(Token = "0x6000006")]
			public _003C_003Ec__23()
			{
			}

			[Token(Token = "0x6000007")]
			internal string _003CToString_003Eb__23_0(T x)
			{
				return null;
			}
		}

		[Token(Token = "0x6000001")]
		public static T[] Add<T>(this T[] arr, T val)
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		public static T[] RemoveAt<T>(this T[] arr, int index)
		{
			return null;
		}

		[Token(Token = "0x6000003")]
		public static T[] Fill<T>(T val, int length)
		{
			return null;
		}

		[Token(Token = "0x6000004")]
		public static string ToString<T>(this IEnumerable<T> arr, string separator = ", ")
		{
			return null;
		}
	}
}
