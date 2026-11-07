using System;

namespace Kilt.Extensions
{
	public static class EnumExtension
	{
		private static T SetFlags<T>(this T value, T flags, bool on) where T : struct, IConvertible
		{
			return default;
		}

		public static bool CheckIfIsEnum<T>(bool withFlags) where T : struct, IConvertible
		{
			return false;
		}

		public static bool ContainsFlag<T>(this T value, T flag) where T : struct, IConvertible
		{
			return false;
		}

		public static T SetFlags<T>(this T value, T flags) where T : struct, IConvertible
		{
			return default;
		}

		public static T ClearFlags<T>(this T value, T flags) where T : struct, IConvertible
		{
			return default;
		}
	}
}
