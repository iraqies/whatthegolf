using System;

namespace Prime31.Reflection
{
	public class ReflectionUtils
	{
		public static bool isTypeGenericeCollectionInterface(Type type)
		{
			return false;
		}

		public static bool isTypeDictionary(Type type)
		{
			return false;
		}

		public static bool isNullableType(Type type)
		{
			return false;
		}

		public static object toNullableType(object obj, Type nullableType)
		{
			return null;
		}
	}
}
