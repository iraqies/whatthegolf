using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;

namespace Newtonsoft.Json.Utilities
{
	internal static class ConvertUtils
	{
		internal enum ConvertResult
		{
			Success = 0,
			CannotConvertNull = 1,
			NotInstantiableType = 2,
			NoValidConversion = 3
		}

		private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap;

		private static readonly TypeInformation[] PrimitiveTypeCodes;

		private static readonly ThreadSafeStore<StructMultiKey<Type, Type>, Func<object, object>> CastConverters;

		public static PrimitiveTypeCode GetTypeCode(Type t)
		{
			return PrimitiveTypeCode.Empty;
		}

		public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum)
		{
			isEnum = default;
			return PrimitiveTypeCode.Empty;
		}

		public static TypeInformation GetTypeInformation(IConvertible convertable)
		{
			return null;
		}

		public static bool IsConvertible(Type t)
		{
			return false;
		}

		public static TimeSpan ParseTimeSpan(string input)
		{
			return default;
		}

		private static Func<object, object> CreateCastConverter(StructMultiKey<Type, Type> t)
		{
			return null;
		}

		internal static BigInteger ToBigInteger(object value)
		{
			return default;
		}

		public static object FromBigInteger(BigInteger i, Type targetType)
		{
			return null;
		}

		private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value)
		{
			value = null;
			return false;
		}

		private static ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value)
		{
			value = null;
			return ConvertResult.Success;
		}

		public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType)
		{
			return null;
		}

		private static object EnsureTypeAssignable(object value, Type initialType, Type targetType)
		{
			return null;
		}

		public static bool VersionTryParse(string input, out Version result)
		{
			result = null;
			return false;
		}

		public static bool IsInteger(object value)
		{
			return false;
		}

		public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value)
		{
			value = default;
			return ParseResult.None;
		}

		public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value)
		{
			value = default;
			return ParseResult.None;
		}

		public static ParseResult DecimalTryParse(char[] chars, int start, int length, out decimal value)
		{
			value = 0m;
			return ParseResult.None;
		}

		public static bool TryConvertGuid(string s, out Guid g)
		{
			g = default;
			return false;
		}

		public static bool TryHexTextToInt(char[] text, int start, int end, out int value)
		{
			value = default;
			return false;
		}
	}
}
