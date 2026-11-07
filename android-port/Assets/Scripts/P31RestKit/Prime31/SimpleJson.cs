using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Prime31
{
	public class SimpleJson
	{
		private static IJsonSerializerStrategy _currentJsonSerializerStrategy;

		private static PocoJsonSerializerStrategy _pocoJsonSerializerStrategy;

		public static IJsonSerializerStrategy currentJsonSerializerStrategy => null;

		public static PocoJsonSerializerStrategy pocoJsonSerializerStrategy => null;

		public static string encode(object obj)
		{
			return null;
		}

		public static bool tryDeserializeObject(string json, out object obj)
		{
			obj = null;
			return false;
		}

		public static object decode(string json)
		{
			return null;
		}

		public static T decode<T>(string json, string rootElement) where T : new()
		{
			return default;
		}

		private static object decode(string json, Type type, string rootElement = null)
		{
			return null;
		}

		protected static IDictionary<string, object> parseObject(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		protected static JsonArray parseArray(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		protected static object parseValue(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		protected static string parseString(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		protected static object parseNumber(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		protected static int getLastIndexOfNumber(char[] json, int index)
		{
			return 0;
		}

		protected static void eatWhitespace(char[] json, ref int index)
		{
		}

		protected static int lookAhead(char[] json, int index)
		{
			return 0;
		}

		protected static int nextToken(char[] json, ref int index)
		{
			return 0;
		}

		protected static bool serializeValue(IJsonSerializerStrategy jsonSerializerStrategy, object value, StringBuilder builder)
		{
			return false;
		}

		protected static bool serializeObject(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable keys, IEnumerable values, StringBuilder builder)
		{
			return false;
		}

		protected static bool serializeArray(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable anArray, StringBuilder builder)
		{
			return false;
		}

		protected static bool serializeString(string aString, StringBuilder builder)
		{
			return false;
		}

		protected static bool serializeNumber(object number, StringBuilder builder)
		{
			return false;
		}

		protected static bool isNumeric(object value)
		{
			return false;
		}
	}
}
