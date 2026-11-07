using System;

namespace Newtonsoft.Json
{
	public static class JsonConvert
	{
		public static readonly string True;

		public static readonly string False;

		public static readonly string Null;

		public static readonly string Undefined;

		public static readonly string PositiveInfinity;

		public static readonly string NegativeInfinity;

		public static readonly string NaN;

		public static Func<JsonSerializerSettings> DefaultSettings { get; }

		public static string ToString(bool value)
		{
			return null;
		}

		public static string ToString(char value)
		{
			return null;
		}

		internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		private static string EnsureDecimalPlace(double value, string text)
		{
			return null;
		}

		private static string EnsureDecimalPlace(string text)
		{
			return null;
		}

		public static string ToString(decimal value)
		{
			return null;
		}

		public static string ToString(string value)
		{
			return null;
		}

		public static string ToString(string value, char delimiter)
		{
			return null;
		}

		public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling)
		{
			return null;
		}
	}
}
