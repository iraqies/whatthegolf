using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182C30", Offset = "0x182C30")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182C30", Offset = "0x182C30")]
	internal static class CollectionUtils
	{
		[Token(Token = "0x200003D")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182C80", Offset = "0x182C80")]
		private static class EmptyArrayContainer<T>
		{
			[Token(Token = "0x4000149")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18567C", Offset = "0x18567C")]
			public static readonly T[] Empty;
		}

		[Token(Token = "0x60001C6")]
		public static bool IsNullOrEmpty<T>(ICollection<T> collection)
		{
			return default;
		}

		[Token(Token = "0x60001C7")]
		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x22AE0AC", Offset = "0x22AE0AC", VA = "0x22AE0AC")]
		public static bool IsDictionaryType(Type type)
		{
			return default;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x22AE294", Offset = "0x22AE294", VA = "0x22AE294")]
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType)
		{
			return null;
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x22AE3C4", Offset = "0x22AE3C4", VA = "0x22AE3C4")]
		public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType)
		{
			return null;
		}

		[Token(Token = "0x60001CB")]
		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
		{
			return default;
		}

		[Token(Token = "0x60001CC")]
		public static bool Contains<T>(this List<T> list, T value, IEqualityComparer comparer)
		{
			return default;
		}

		[Token(Token = "0x60001CD")]
		public static int IndexOfReference<T>(this List<T> list, T item)
		{
			return default;
		}

		[Token(Token = "0x60001CE")]
		public static void FastReverse<T>(this List<T> list)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x22AE744", Offset = "0x22AE744", VA = "0x22AE744")]
		private static IList<int> GetDimensions(IList values, int dimensionsCount)
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x22AEA5C", Offset = "0x22AEA5C", VA = "0x22AEA5C")]
		private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x22AED28", Offset = "0x22AED28", VA = "0x22AED28")]
		private static object JaggedArrayGetValue(IList values, int[] indices)
		{
			return null;
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x22AEEF4", Offset = "0x22AEEF4", VA = "0x22AEEF4")]
		public static Array ToMultidimensionalArray(IList values, Type type, int rank)
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		public static T[] ArrayEmpty<T>()
		{
			return null;
		}
	}
}
