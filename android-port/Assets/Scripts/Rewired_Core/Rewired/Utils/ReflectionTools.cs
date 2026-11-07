using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace Rewired.Utils
{
	[Token(Token = "0x200033F")]
	public static class ReflectionTools
	{
		[Token(Token = "0x2000340")]
		[Flags]
		public enum BindingFlags
		{
			[Token(Token = "0x4001098")]
			IgnoreCase = 1,
			[Token(Token = "0x4001099")]
			DeclaredOnly = 2,
			[Token(Token = "0x400109A")]
			Instance = 4,
			[Token(Token = "0x400109B")]
			Static = 8,
			[Token(Token = "0x400109C")]
			Public = 0x10,
			[Token(Token = "0x400109D")]
			NonPublic = 0x20,
			[Token(Token = "0x400109E")]
			FlattenHierarchy = 0x40
		}

		[Token(Token = "0x60018F2")]
		[Address(RVA = "0x24088B0", Offset = "0x24088B0", VA = "0x24088B0")]
		public static bool IsValueType(Type type)
		{
			return default;
		}

		[Token(Token = "0x60018F3")]
		[Address(RVA = "0x24088C8", Offset = "0x24088C8", VA = "0x24088C8")]
		public static bool IsEnum(Type type)
		{
			return default;
		}

		[Token(Token = "0x60018F4")]
		[Address(RVA = "0x24088E0", Offset = "0x24088E0", VA = "0x24088E0")]
		public static Type GetUnderlyingEnumType(Type enumType)
		{
			return null;
		}

		[Token(Token = "0x60018F5")]
		[Address(RVA = "0x2408970", Offset = "0x2408970", VA = "0x2408970")]
		public static bool IsArray(Type type)
		{
			return default;
		}

		[Token(Token = "0x60018F6")]
		[Address(RVA = "0x2408988", Offset = "0x2408988", VA = "0x2408988")]
		public static bool DoesTypeImplement(Type type, Type baseOrInterfaceType)
		{
			return default;
		}

		[Token(Token = "0x60018F7")]
		[Address(RVA = "0x24089B4", Offset = "0x24089B4", VA = "0x24089B4")]
		public static bool IsGenericType(Type type)
		{
			return default;
		}

		[Token(Token = "0x60018F8")]
		[Address(RVA = "0x24089CC", Offset = "0x24089CC", VA = "0x24089CC")]
		public static Type[] GetGenericArguments(Type type)
		{
			return null;
		}

		[Token(Token = "0x60018F9")]
		[Address(RVA = "0x24089E4", Offset = "0x24089E4", VA = "0x24089E4")]
		public static IEnumerable<FieldInfo> GetFields(Type type, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x60018FA")]
		[Address(RVA = "0x24089FC", Offset = "0x24089FC", VA = "0x24089FC")]
		public static IEnumerable<PropertyInfo> GetProperties(Type type, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x60018FB")]
		[Address(RVA = "0x2408A14", Offset = "0x2408A14", VA = "0x2408A14")]
		public static bool IsDefined(Type type, Type attributeType, bool inherit)
		{
			return default;
		}

		[Token(Token = "0x60018FC")]
		public static T GetAttribute<T>(Type type, bool inherit) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x60018FD")]
		[Address(RVA = "0x2408A34", Offset = "0x2408A34", VA = "0x2408A34")]
		internal static bool IsAssemblyLoaded(string assemblyName, bool useShortName, bool ignoreCase)
		{
			return default;
		}

		[Token(Token = "0x60018FE")]
		[Address(RVA = "0x2408BA4", Offset = "0x2408BA4", VA = "0x2408BA4")]
		internal static Type GetTypeInAssembly(string classPath, string assemblyName, bool ignoreCase = false)
		{
			return null;
		}

		[Token(Token = "0x60018FF")]
		[Address(RVA = "0x2408CA4", Offset = "0x2408CA4", VA = "0x2408CA4")]
		public static MethodInfo GetMethodInfo(Delegate @delegate)
		{
			return null;
		}
	}
}
