using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace ZXing
{
	[Token(Token = "0x200000E")]
	internal static class IDictionaryExtensions
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2EBF0C4", Offset = "0x2EBF0C4", VA = "0x2EBF0C4")]
		public static bool IsBooleanFlagSet(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType)
		{
			return default;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2EBF0CC", Offset = "0x2EBF0CC", VA = "0x2EBF0CC")]
		public static bool IsBooleanFlagSet(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType, bool defaultIfNotContained)
		{
			return default;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2EBF2D0", Offset = "0x2EBF2D0", VA = "0x2EBF2D0")]
		public static int GetIntValue(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType, int defaultIfNotContained)
		{
			return default;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2EBF4D4", Offset = "0x2EBF4D4", VA = "0x2EBF4D4")]
		public static float GetFloatValue(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType, float defaultIfNotContained)
		{
			return default;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2EBF6E0", Offset = "0x2EBF6E0", VA = "0x2EBF6E0")]
		public static int GetEnumValue(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType, Type enumType, int defaultIfNotContained)
		{
			return default;
		}

		[Token(Token = "0x6000061")]
		public static TEnum GetEnumValue<TEnum>(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType, TEnum defaultIfNotContained)
		{
			return (TEnum)null;
		}

		[Token(Token = "0x6000062")]
		public static T GetValue<T>(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		public static T GetValue<T>(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType, T defaultIfNotContained) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2EBF908", Offset = "0x2EBF908", VA = "0x2EBF908")]
		public static Encoding GetEncoding(IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2EBFAA8", Offset = "0x2EBFAA8", VA = "0x2EBFAA8")]
		public static Encoding GetEncoding(IDictionary<EncodeHintType, object> hints, Encoding defaultIfNotContained)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2EBF914", Offset = "0x2EBF914", VA = "0x2EBF914")]
		public static Encoding GetEncoding(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType, Encoding defaultIfNotContained)
		{
			return null;
		}
	}
}
