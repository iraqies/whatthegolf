using System;
using System.IO;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183258", Offset = "0x183258")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183258", Offset = "0x183258")]
	internal static class JavaScriptUtils
	{
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly bool[] SingleQuoteCharEscapeFlags;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly bool[] DoubleQuoteCharEscapeFlags;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly bool[] HtmlCharEscapeFlags;

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x22E32C0", Offset = "0x22E32C0", VA = "0x22E32C0")]
		static JavaScriptUtils()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x22E3DA8", Offset = "0x22E3DA8", VA = "0x22E3DA8")]
		public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar)
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x22E3E74", Offset = "0x22E3E74", VA = "0x22E3E74")]
		public static bool ShouldEscapeJavaScriptString([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18BF20", Offset = "0x18BF20")] string s, bool[] charEscapeFlags)
		{
			return default;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x22E3F10", Offset = "0x22E3F10", VA = "0x22E3F10")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189024", Offset = "0x189024")]
		public static void WriteEscapedJavaScriptString([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18BF34", Offset = "0x18BF34")] TextWriter writer, string s, char delimiter, bool appendDelimiters, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18BF48", Offset = "0x18BF48")] bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x22E45F4", Offset = "0x22E45F4", VA = "0x22E45F4")]
		public static string ToEscapedJavaScriptString([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18BF5C", Offset = "0x18BF5C")] string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling)
		{
			return null;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x22E4528", Offset = "0x22E4528", VA = "0x22E4528")]
		private static int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling)
		{
			return default;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x22E2E94", Offset = "0x22E2E94", VA = "0x22E2E94")]
		public static bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18BF70", Offset = "0x18BF70")] out string errorMessage)
		{
			return default;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x22E480C", Offset = "0x22E480C", VA = "0x22E480C")]
		private static bool TryGetDateConstructorValue(JsonReader reader, out long? integer, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18BF84", Offset = "0x18BF84")] out string errorMessage)
		{
			return default;
		}
	}
}
