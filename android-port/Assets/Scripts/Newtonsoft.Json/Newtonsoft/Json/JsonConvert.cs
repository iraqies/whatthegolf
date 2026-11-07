using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1825F4", Offset = "0x1825F4")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1825F4", Offset = "0x1825F4")]
	public static class JsonConvert
	{
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x184FC8", Offset = "0x184FC8")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x184FC8", Offset = "0x184FC8")]
		private static Func<JsonSerializerSettings> DefaultSettings__BackingField;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string True;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string False;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string Null;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string Undefined;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string PositiveInfinity;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string NegativeInfinity;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string NaN;

		[Token(Token = "0x17000008")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E828", Offset = "0x18E828")]
		public static Func<JsonSerializerSettings> DefaultSettings
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x22E7330", Offset = "0x22E7330", VA = "0x22E7330")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188764", Offset = "0x188764")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x22E7394", Offset = "0x22E7394", VA = "0x22E7394")]
		public static string ToString(bool value)
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x22E7430", Offset = "0x22E7430", VA = "0x22E7430")]
		public static string ToString(char value)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x22E75D4", Offset = "0x22E75D4", VA = "0x22E75D4")]
		internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x22E7818", Offset = "0x22E7818", VA = "0x22E7818")]
		private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x22E7978", Offset = "0x22E7978", VA = "0x22E7978")]
		internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x22E76E8", Offset = "0x22E76E8", VA = "0x22E76E8")]
		private static string EnsureDecimalPlace(double value, string text)
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x22E7A88", Offset = "0x22E7A88", VA = "0x22E7A88")]
		private static string EnsureDecimalPlace(string text)
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x22E7B08", Offset = "0x22E7B08", VA = "0x22E7B08")]
		public static string ToString(decimal value)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x22E74E8", Offset = "0x22E74E8", VA = "0x22E74E8")]
		public static string ToString([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B1C4", Offset = "0x18B1C4")] string value)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x22E7C18", Offset = "0x22E7C18", VA = "0x22E7C18")]
		public static string ToString([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B1D8", Offset = "0x18B1D8")] string value, char delimiter)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x22E7CA4", Offset = "0x22E7CA4", VA = "0x22E7CA4")]
		public static string ToString([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B1EC", Offset = "0x18B1EC")] string value, char delimiter, StringEscapeHandling stringEscapeHandling)
		{
			return null;
		}
	}
}
