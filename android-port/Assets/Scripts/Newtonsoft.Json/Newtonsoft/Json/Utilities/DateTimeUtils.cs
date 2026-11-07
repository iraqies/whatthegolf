using System;
using System.Globalization;
using System.IO;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182DB8", Offset = "0x182DB8")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182DB8", Offset = "0x182DB8")]
	internal static class DateTimeUtils
	{
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly long InitialJavaScriptDateTicks;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] DaysToMonth365;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[] DaysToMonth366;

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x22B5F34", Offset = "0x22B5F34", VA = "0x22B5F34")]
		static DateTimeUtils()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x22B602C", Offset = "0x22B602C", VA = "0x22B602C")]
		public static TimeSpan GetUtcOffset(this DateTime d)
		{
			return default;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x22B6060", Offset = "0x22B6060", VA = "0x22B6060")]
		public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind)
		{
			return default;
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x22B6108", Offset = "0x22B6108", VA = "0x22B6108")]
		internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone)
		{
			return default;
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x22B625C", Offset = "0x22B625C", VA = "0x22B625C")]
		private static DateTime SwitchToLocalTime(DateTime value)
		{
			return default;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x22B62FC", Offset = "0x22B62FC", VA = "0x22B62FC")]
		private static DateTime SwitchToUtcTime(DateTime value)
		{
			return default;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x22B639C", Offset = "0x22B639C", VA = "0x22B639C")]
		private static long ToUniversalTicks(DateTime dateTime)
		{
			return default;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x22B6450", Offset = "0x22B6450", VA = "0x22B6450")]
		private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset)
		{
			return default;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x22B6578", Offset = "0x22B6578", VA = "0x22B6578")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset)
		{
			return default;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x22B66FC", Offset = "0x22B66FC", VA = "0x22B66FC")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime)
		{
			return default;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x22B6778", Offset = "0x22B6778", VA = "0x22B6778")]
		internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc)
		{
			return default;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x22B666C", Offset = "0x22B666C", VA = "0x22B666C")]
		private static long UniversalTicksToJavaScriptTicks(long universalTicks)
		{
			return default;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x22B6890", Offset = "0x22B6890", VA = "0x22B6890")]
		internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks)
		{
			return default;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x22B6928", Offset = "0x22B6928", VA = "0x22B6928")]
		internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
		{
			return default;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x22B6E0C", Offset = "0x22B6E0C", VA = "0x22B6E0C")]
		internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt)
		{
			return default;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x22B6D88", Offset = "0x22B6D88", VA = "0x22B6D88")]
		private static DateTime CreateDateTime(DateTimeParser dateTimeParser)
		{
			return default;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x22B702C", Offset = "0x22B702C", VA = "0x22B702C")]
		internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B65C", Offset = "0x18B65C")] string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			return default;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x22B75A4", Offset = "0x22B75A4", VA = "0x22B75A4")]
		internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B670", Offset = "0x18B670")] string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			return default;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x22B78A8", Offset = "0x22B78A8", VA = "0x22B78A8")]
		internal static bool TryParseDateTimeOffset(StringReference s, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B684", Offset = "0x18B684")] string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			return default;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x22B7E00", Offset = "0x22B7E00", VA = "0x22B7E00")]
		internal static bool TryParseDateTimeOffset(string s, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B698", Offset = "0x18B698")] string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			return default;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x22B8170", Offset = "0x22B8170", VA = "0x22B8170")]
		private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind)
		{
			return default;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x22B7290", Offset = "0x22B7290", VA = "0x22B7290")]
		private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt)
		{
			return default;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x22B7488", Offset = "0x22B7488", VA = "0x22B7488")]
		private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt)
		{
			return default;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x22B7B5C", Offset = "0x22B7B5C", VA = "0x22B7B5C")]
		private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt)
		{
			return default;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x22B7D2C", Offset = "0x22B7D2C", VA = "0x22B7D2C")]
		private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt)
		{
			return default;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x22B8310", Offset = "0x22B8310", VA = "0x22B8310")]
		private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset)
		{
			return default;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x22B84B0", Offset = "0x22B84B0", VA = "0x22B84B0")]
		internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B6AC", Offset = "0x18B6AC")] string formatString, CultureInfo culture)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x22B85F8", Offset = "0x22B85F8", VA = "0x22B85F8")]
		internal static int WriteDateTimeString(char[] chars, int start, DateTime value, TimeSpan? offset, DateTimeKind kind, DateFormatHandling format)
		{
			return default;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x22B8B9C", Offset = "0x22B8B9C", VA = "0x22B8B9C")]
		internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt)
		{
			return default;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x22B91F8", Offset = "0x22B91F8", VA = "0x22B91F8")]
		private static void CopyIntToCharArray(char[] chars, int start, int value, int digits)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x22B898C", Offset = "0x22B898C", VA = "0x22B898C")]
		internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format)
		{
			return default;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x22B9270", Offset = "0x22B9270", VA = "0x22B9270")]
		internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B6C0", Offset = "0x18B6C0")] string formatString, CultureInfo culture)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x22B8FBC", Offset = "0x22B8FBC", VA = "0x22B8FBC")]
		private static void GetDateValues(DateTime td, out int year, out int month, out int day)
		{
		}
	}
}
