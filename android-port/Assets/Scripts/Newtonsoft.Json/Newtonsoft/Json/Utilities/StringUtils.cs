using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18360C", Offset = "0x18360C")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18360C", Offset = "0x18360C")]
	internal static class StringUtils
	{
		[Token(Token = "0x2000081")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18365C", Offset = "0x18365C")]
		private enum SeparatedCaseState
		{
			[Token(Token = "0x4000206")]
			Start = 0,
			[Token(Token = "0x4000207")]
			Lower = 1,
			[Token(Token = "0x4000208")]
			Upper = 2,
			[Token(Token = "0x4000209")]
			NewWord = 3
		}

		[Token(Token = "0x2000082")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x183670", Offset = "0x183670")]
		private sealed class _003C_003Ec__DisplayClass14_0<TSource>
		{
			[Token(Token = "0x400020A")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1863F8", Offset = "0x1863F8")]
			public Func<TSource, string> valueSelector;

			[Token(Token = "0x400020B")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18646C", Offset = "0x18646C")]
			public string testValue;

			[Token(Token = "0x600033F")]
			public _003C_003Ec__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000340")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1893DC", Offset = "0x1893DC")]
			internal bool _003CForgivingCaseSensitiveFind_003Eb__0(TSource s)
			{
				return default;
			}

			[Token(Token = "0x6000341")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1893F0", Offset = "0x1893F0")]
			internal bool _003CForgivingCaseSensitiveFind_003Eb__1(TSource s)
			{
				return default;
			}
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x23237E4", Offset = "0x23237E4", VA = "0x23237E4")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18930C", Offset = "0x18930C")]
		public static bool IsNullOrEmpty(string value)
		{
			return default;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x23231E4", Offset = "0x23231E4", VA = "0x23231E4")]
		public static string FormatWith(this string format, IFormatProvider provider, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C58C", Offset = "0x18C58C")] object arg0)
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x23237EC", Offset = "0x23237EC", VA = "0x23237EC")]
		public static string FormatWith(this string format, IFormatProvider provider, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C5A0", Offset = "0x18C5A0")] object arg0, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C5B4", Offset = "0x18C5B4")] object arg1)
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x2323CE8", Offset = "0x2323CE8", VA = "0x2323CE8")]
		public static string FormatWith(this string format, IFormatProvider provider, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C5C8", Offset = "0x18C5C8")] object arg0, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C5DC", Offset = "0x18C5DC")] object arg1, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C5F0", Offset = "0x18C5F0")] object arg2)
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x2323E04", Offset = "0x2323E04", VA = "0x2323E04")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189350", Offset = "0x189350")]
		public static string FormatWith([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C604", Offset = "0x18C604")] this string format, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C618", Offset = "0x18C618")] IFormatProvider provider, object arg0, object arg1, object arg2, object arg3)
		{
			return null;
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x2323C44", Offset = "0x2323C44", VA = "0x2323C44")]
		private static string FormatWith(this string format, IFormatProvider provider, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18C62C", Offset = "0x18C62C")] params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x2323F4C", Offset = "0x2323F4C", VA = "0x2323F4C")]
		public static StringWriter CreateStringWriter(int capacity)
		{
			return null;
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x232401C", Offset = "0x232401C", VA = "0x232401C")]
		public static void ToCharAsUnicode(char c, char[] buffer)
		{
		}

		[Token(Token = "0x6000334")]
		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
		{
			return (TSource)null;
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x23240E0", Offset = "0x23240E0", VA = "0x23240E0")]
		public static string ToCamelCase(string s)
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x2324320", Offset = "0x2324320", VA = "0x2324320")]
		private static char ToLower(char c)
		{
			return default;
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x23243C8", Offset = "0x23243C8", VA = "0x23243C8")]
		public static string ToSnakeCase(string s)
		{
			return null;
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x23246E0", Offset = "0x23246E0", VA = "0x23246E0")]
		public static string ToKebabCase(string s)
		{
			return null;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x23243D0", Offset = "0x23243D0", VA = "0x23243D0")]
		private static string ToSeparatedCase(string s, char separator)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x23246E8", Offset = "0x23246E8", VA = "0x23246E8")]
		public static bool IsHighSurrogate(char c)
		{
			return default;
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x2324764", Offset = "0x2324764", VA = "0x2324764")]
		public static bool IsLowSurrogate(char c)
		{
			return default;
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x23247E0", Offset = "0x23247E0", VA = "0x23247E0")]
		public static bool StartsWith(this string source, char value)
		{
			return default;
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x232482C", Offset = "0x232482C", VA = "0x232482C")]
		public static bool EndsWith(this string source, char value)
		{
			return default;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x2324874", Offset = "0x2324874", VA = "0x2324874")]
		public static string Trim(this string s, int start, int length)
		{
			return null;
		}
	}
}
