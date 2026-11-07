using System;

namespace Kilt.Reflection
{
	internal static class ReflectionExtension
	{
		public static bool IsEnum(this Type type)
		{
			return false;
		}

		public static bool IsAbstract(this Type type)
		{
			return false;
		}
	}
}
