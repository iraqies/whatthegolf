using System;
using System.Collections.Generic;
using System.Text;

namespace ZXing
{
	internal static class IDictionaryExtensions
	{
		public static bool IsBooleanFlagSet(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType)
		{
			return false;
		}

		public static bool IsBooleanFlagSet(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType, bool defaultIfNotContained)
		{
			return false;
		}

		public static int GetIntValue(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType, int defaultIfNotContained)
		{
			return 0;
		}

		public static float GetFloatValue(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType, float defaultIfNotContained)
		{
			return 0f;
		}

		public static int GetEnumValue(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType, Type enumType, int defaultIfNotContained)
		{
			return 0;
		}

		public static TEnum GetEnumValue<TEnum>(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType, TEnum defaultIfNotContained)
		{
			return default;
		}

		public static T GetValue<T>(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType) where T : class
		{
			return null;
		}

		public static T GetValue<T>(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType, T defaultIfNotContained) where T : class
		{
			return null;
		}

		public static Encoding GetEncoding(IDictionary<EncodeHintType, object> hints)
		{
			return null;
		}

		public static Encoding GetEncoding(IDictionary<EncodeHintType, object> hints, Encoding defaultIfNotContained)
		{
			return null;
		}

		public static Encoding GetEncoding(IDictionary<EncodeHintType, object> hints, EncodeHintType encodeHintType, Encoding defaultIfNotContained)
		{
			return null;
		}
	}
}
