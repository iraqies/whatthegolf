using System;
using Il2CppDummyDll;

namespace Kilt.Extensions
{
	[Token(Token = "0x2000091")]
	public static class EnumExtension
	{
		[Token(Token = "0x60002B0")]
		private static T SetFlags<T>(this T value, T flags, bool on) where T : struct, IConvertible
		{
			return (T)null;
		}

		[Token(Token = "0x60002B1")]
		public static bool CheckIfIsEnum<T>(bool withFlags) where T : struct, IConvertible
		{
			return default;
		}

		[Token(Token = "0x60002B2")]
		public static bool ContainsFlag<T>(this T value, T flag) where T : struct, IConvertible
		{
			return default;
		}

		[Token(Token = "0x60002B3")]
		public static T SetFlags<T>(this T value, T flags) where T : struct, IConvertible
		{
			return (T)null;
		}

		[Token(Token = "0x60002B4")]
		public static T ClearFlags<T>(this T value, T flags) where T : struct, IConvertible
		{
			return (T)null;
		}
	}
}
