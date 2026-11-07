using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182D14", Offset = "0x182D14")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182D14", Offset = "0x182D14")]
	internal static class ConvertUtils
	{
		[Token(Token = "0x2000044")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182D54", Offset = "0x182D54")]
		internal enum ConvertResult
		{
			[Token(Token = "0x4000180")]
			Success = 0,
			[Token(Token = "0x4000181")]
			CannotConvertNull = 1,
			[Token(Token = "0x4000182")]
			NotInstantiableType = 2,
			[Token(Token = "0x4000183")]
			NoValidConversion = 3
		}

		[Token(Token = "0x2000045")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x182D68", Offset = "0x182D68")]
		private sealed class _003C_003Ec__DisplayClass8_0
		{
			[Token(Token = "0x4000184")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185734", Offset = "0x185734")]
			public MethodCall<object, object> call;

			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x23363C0", Offset = "0x23363C0", VA = "0x23363C0")]
			public _003C_003Ec__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x23363C8", Offset = "0x23363C8", VA = "0x23363C8")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188D70", Offset = "0x188D70")]
			internal object _003CCreateCastConverter_003Eb__0(object o)
			{
				return null;
			}
		}

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly TypeInformation[] PrimitiveTypeCodes;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1856B0", Offset = "0x1856B0")]
		private static readonly ThreadSafeStore<StructMultiKey<Type, Type>, Func<object, object>> CastConverters;

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x22AF134", Offset = "0x22AF134", VA = "0x22AF134")]
		public static PrimitiveTypeCode GetTypeCode(Type t)
		{
			return default;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x22AF1C0", Offset = "0x22AF1C0", VA = "0x22AF1C0")]
		public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum)
		{
			return default;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x22AF518", Offset = "0x22AF518", VA = "0x22AF518")]
		public static TypeInformation GetTypeInformation(IConvertible convertable)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x22AF630", Offset = "0x22AF630", VA = "0x22AF630")]
		public static bool IsConvertible(Type t)
		{
			return default;
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x22AF6D8", Offset = "0x22AF6D8", VA = "0x22AF6D8")]
		public static TimeSpan ParseTimeSpan(string input)
		{
			return default;
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x22AF780", Offset = "0x22AF780", VA = "0x22AF780")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188D5C", Offset = "0x188D5C")]
		private static Func<object, object> CreateCastConverter([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B558", Offset = "0x18B558")] StructMultiKey<Type, Type> t)
		{
			return null;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x22AF9EC", Offset = "0x22AF9EC", VA = "0x22AF9EC")]
		internal static BigInteger ToBigInteger(object value)
		{
			return default;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x22AFE00", Offset = "0x22AFE00", VA = "0x22AFE00")]
		public static object FromBigInteger(BigInteger i, Type targetType)
		{
			return null;
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x22B0384", Offset = "0x22B0384", VA = "0x22B0384")]
		private static bool TryConvert([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B5D0", Offset = "0x18B5D0")] object initialValue, CultureInfo culture, Type targetType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B5E4", Offset = "0x18B5E4")] out object value)
		{
			return default;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x22B049C", Offset = "0x22B049C", VA = "0x22B049C")]
		private static ConvertResult TryConvertInternal([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B5F8", Offset = "0x18B5F8")] object initialValue, CultureInfo culture, Type targetType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B60C", Offset = "0x18B60C")] out object value)
		{
			return default;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x22B142C", Offset = "0x22B142C", VA = "0x22B142C")]
		public static object ConvertOrCast([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B620", Offset = "0x18B620")] object initialValue, CultureInfo culture, Type targetType)
		{
			return null;
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x22B1174", Offset = "0x22B1174", VA = "0x22B1174")]
		private static object EnsureTypeAssignable([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B634", Offset = "0x18B634")] object value, Type initialType, Type targetType)
		{
			return null;
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x22B10E8", Offset = "0x22B10E8", VA = "0x22B10E8")]
		public static bool VersionTryParse(string input, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B648", Offset = "0x18B648")] out Version result)
		{
			return default;
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x22B1000", Offset = "0x22B1000", VA = "0x22B1000")]
		public static bool IsInteger(object value)
		{
			return default;
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x22B15F0", Offset = "0x22B15F0", VA = "0x22B15F0")]
		public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value)
		{
			return default;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x22B1770", Offset = "0x22B1770", VA = "0x22B1770")]
		public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value)
		{
			return default;
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x22B18D4", Offset = "0x22B18D4", VA = "0x22B18D4")]
		public static ParseResult DecimalTryParse(char[] chars, int start, int length, out decimal value)
		{
			return default;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x22B2294", Offset = "0x22B2294", VA = "0x22B2294")]
		public static bool TryConvertGuid(string s, out Guid g)
		{
			return default;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x22B2330", Offset = "0x22B2330", VA = "0x22B2330")]
		public static bool TryHexTextToInt(char[] text, int start, int end, out int value)
		{
			return default;
		}
	}
}
