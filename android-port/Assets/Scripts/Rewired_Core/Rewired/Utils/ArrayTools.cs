using Il2CppDummyDll;
using Rewired.Utils.Interfaces;

namespace Rewired.Utils
{
	[Token(Token = "0x2000337")]
	public static class ArrayTools
	{
		[Token(Token = "0x60018A5")]
		public static T[] DeepClone<T>(T[] array) where T : class, IDeepCloneable
		{
			return null;
		}

		[Token(Token = "0x60018A6")]
		public static T[] ShallowCopy<T>(T[] array)
		{
			return null;
		}

		[Token(Token = "0x60018A7")]
		public static bool Contains<T>(T[] array, T item)
		{
			return default;
		}

		[Token(Token = "0x60018A8")]
		public static void Expand<T>(ref T[] array, int length)
		{
		}

		[Token(Token = "0x60018A9")]
		[Address(RVA = "0x234B918", Offset = "0x234B918", VA = "0x234B918")]
		public static int IndexOf(int[] array, int value)
		{
			return default;
		}

		[Token(Token = "0x60018AA")]
		public static void Fill<T>(T[] array, T value)
		{
		}

		[Token(Token = "0x60018AB")]
		public static void Populate<T>(T[] array, int startIndex, int length) where T : class, new()
		{
		}

		[Token(Token = "0x60018AC")]
		public static void Populate<T>(T[] array) where T : class, new()
		{
		}

		[Token(Token = "0x60018AD")]
		public static bool IsNullOrEmpty<T>(T[] array)
		{
			return default;
		}
	}
}
