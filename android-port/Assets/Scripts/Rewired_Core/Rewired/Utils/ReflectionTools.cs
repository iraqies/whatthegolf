using System;
using System.Collections.Generic;
using System.Reflection;

namespace Rewired.Utils
{
	public static class ReflectionTools
	{
		[Flags]
		public enum BindingFlags
		{
			IgnoreCase = 1,
			DeclaredOnly = 2,
			Instance = 4,
			Static = 8,
			Public = 0x10,
			NonPublic = 0x20,
			FlattenHierarchy = 0x40
		}

		public static bool IsValueType(Type type)
		{
			return false;
		}

		public static bool IsEnum(Type type)
		{
			return false;
		}

		public static Type GetUnderlyingEnumType(Type enumType)
		{
			return null;
		}

		public static bool IsArray(Type type)
		{
			return false;
		}

		public static bool DoesTypeImplement(Type type, Type baseOrInterfaceType)
		{
			return false;
		}

		public static bool IsGenericType(Type type)
		{
			return false;
		}

		public static Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		public static IEnumerable<FieldInfo> GetFields(Type type, BindingFlags bindingFlags)
		{
			return null;
		}

		public static IEnumerable<PropertyInfo> GetProperties(Type type, BindingFlags bindingFlags)
		{
			return null;
		}

		public static bool IsDefined(Type type, Type attributeType, bool inherit)
		{
			return false;
		}

		public static T GetAttribute<T>(Type type, bool inherit) where T : Attribute
		{
			return null;
		}

		internal static bool IsAssemblyLoaded(string assemblyName, bool useShortName, bool ignoreCase)
		{
			return false;
		}

		internal static Type GetTypeInAssembly(string classPath, string assemblyName, bool ignoreCase = false)
		{
			return null;
		}

		public static MethodInfo GetMethodInfo(Delegate @delegate)
		{
			return null;
		}
	}
}
