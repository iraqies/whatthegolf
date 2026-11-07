using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace Prime31
{
	[Token(Token = "0x2000015")]
	public class SimpleJson
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IJsonSerializerStrategy _currentJsonSerializerStrategy;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static PocoJsonSerializerStrategy _pocoJsonSerializerStrategy;

		[Token(Token = "0x17000009")]
		public static IJsonSerializerStrategy currentJsonSerializerStrategy
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x23423AC", Offset = "0x23423AC", VA = "0x23423AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		public static PocoJsonSerializerStrategy pocoJsonSerializerStrategy
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x2344C74", Offset = "0x2344C74", VA = "0x2344C74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x233C77C", Offset = "0x233C77C", VA = "0x233C77C")]
		public static string encode(object obj)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2342998", Offset = "0x2342998", VA = "0x2342998")]
		public static bool tryDeserializeObject(string json, out object obj)
		{
			return default;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x233C354", Offset = "0x233C354", VA = "0x233C354")]
		public static object decode(string json)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		public static T decode<T>(string json, string rootElement) where T : new()
		{
			return (T)null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2342B6C", Offset = "0x2342B6C", VA = "0x2342B6C")]
		private static object decode(string json, Type type, [Optional] string rootElement)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2342E34", Offset = "0x2342E34", VA = "0x2342E34")]
		protected static IDictionary<string, object> parseObject(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2343720", Offset = "0x2343720", VA = "0x2343720")]
		protected static JsonArray parseArray(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x23429F0", Offset = "0x23429F0", VA = "0x23429F0")]
		protected static object parseValue(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x23432E8", Offset = "0x23432E8", VA = "0x23432E8")]
		protected static string parseString(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2343890", Offset = "0x2343890", VA = "0x2343890")]
		protected static object parseNumber(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2343C08", Offset = "0x2343C08", VA = "0x2343C08")]
		protected static int getLastIndexOfNumber(char[] json, int index)
		{
			return default;
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2343B54", Offset = "0x2343B54", VA = "0x2343B54")]
		protected static void eatWhitespace(char[] json, ref int index)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x23432C4", Offset = "0x23432C4", VA = "0x23432C4")]
		protected static int lookAhead(char[] json, int index)
		{
			return default;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2343010", Offset = "0x2343010", VA = "0x2343010")]
		protected static int nextToken(char[] json, ref int index)
		{
			return default;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x234246C", Offset = "0x234246C", VA = "0x234246C")]
		protected static bool serializeValue(IJsonSerializerStrategy jsonSerializerStrategy, object value, StringBuilder builder)
		{
			return default;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2343ED8", Offset = "0x2343ED8", VA = "0x2343ED8")]
		protected static bool serializeObject(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable keys, IEnumerable values, StringBuilder builder)
		{
			return default;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2344308", Offset = "0x2344308", VA = "0x2344308")]
		protected static bool serializeArray(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable anArray, StringBuilder builder)
		{
			return default;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2343CBC", Offset = "0x2343CBC", VA = "0x2343CBC")]
		protected static bool serializeString(string aString, StringBuilder builder)
		{
			return default;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2344854", Offset = "0x2344854", VA = "0x2344854")]
		protected static bool serializeNumber(object number, StringBuilder builder)
		{
			return default;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x23446B0", Offset = "0x23446B0", VA = "0x23446B0")]
		protected static bool isNumeric(object value)
		{
			return default;
		}
	}
}
