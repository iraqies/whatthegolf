using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace PlayFab.Json
{
	[Token(Token = "0x20011A1")]
	public static class PlayFabSimpleJson
	{
		[Token(Token = "0x20011A2")]
		private enum TokenType : byte
		{
			[Token(Token = "0x4005F0F")]
			NONE = 0,
			[Token(Token = "0x4005F10")]
			CURLY_OPEN = 1,
			[Token(Token = "0x4005F11")]
			CURLY_CLOSE = 2,
			[Token(Token = "0x4005F12")]
			SQUARED_OPEN = 3,
			[Token(Token = "0x4005F13")]
			SQUARED_CLOSE = 4,
			[Token(Token = "0x4005F14")]
			COLON = 5,
			[Token(Token = "0x4005F15")]
			COMMA = 6,
			[Token(Token = "0x4005F16")]
			STRING = 7,
			[Token(Token = "0x4005F17")]
			NUMBER = 8,
			[Token(Token = "0x4005F18")]
			TRUE = 9,
			[Token(Token = "0x4005F19")]
			FALSE = 10,
			[Token(Token = "0x4005F1A")]
			NULL = 11
		}

		[Token(Token = "0x4005F07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] EscapeTable;

		[Token(Token = "0x4005F08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly char[] EscapeCharacters;

		[Token(Token = "0x4005F09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static readonly List<Type> NumberTypes;

		[Token(Token = "0x4005F0A")]
		[ThreadStatic]
		private static StringBuilder _serializeObjectBuilder;

		[Token(Token = "0x4005F0B")]
		[ThreadStatic]
		private static StringBuilder _parseStringBuilder;

		[Token(Token = "0x4005F0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IJsonSerializerStrategy _currentJsonSerializerStrategy;

		[Token(Token = "0x4005F0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static PocoJsonSerializerStrategy _pocoJsonSerializerStrategy;

		[Token(Token = "0x170008B1")]
		public static IJsonSerializerStrategy CurrentJsonSerializerStrategy
		{
			[Token(Token = "0x6005083")]
			[Address(RVA = "0x15F1518", Offset = "0x15F1518", VA = "0x15F1518")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008B2")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x73A28", Offset = "0x73A28")]
		public static PocoJsonSerializerStrategy PocoJsonSerializerStrategy
		{
			[Token(Token = "0x6005084")]
			[Address(RVA = "0x15F428C", Offset = "0x15F428C", VA = "0x15F428C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600506D")]
		[Address(RVA = "0x15F0A90", Offset = "0x15F0A90", VA = "0x15F0A90")]
		static PlayFabSimpleJson()
		{
		}

		[Token(Token = "0x600506E")]
		[Address(RVA = "0x15F0E98", Offset = "0x15F0E98", VA = "0x15F0E98")]
		public static object DeserializeObject(string json)
		{
			return null;
		}

		[Token(Token = "0x600506F")]
		[Address(RVA = "0x15F0FC0", Offset = "0x15F0FC0", VA = "0x15F0FC0")]
		public static bool TryDeserializeObject(string json, out object obj)
		{
			return default;
		}

		[Token(Token = "0x6005070")]
		[Address(RVA = "0x15F1328", Offset = "0x15F1328", VA = "0x15F1328")]
		public static object DeserializeObject(string json, Type type, [Optional] IJsonSerializerStrategy jsonSerializerStrategy)
		{
			return null;
		}

		[Token(Token = "0x6005071")]
		public static T DeserializeObject<T>(string json, [Optional] IJsonSerializerStrategy jsonSerializerStrategy)
		{
			return (T)null;
		}

		[Token(Token = "0x6005072")]
		[Address(RVA = "0x15F15AC", Offset = "0x15F15AC", VA = "0x15F15AC")]
		public static string SerializeObject(object json, [Optional] IJsonSerializerStrategy jsonSerializerStrategy)
		{
			return null;
		}

		[Token(Token = "0x6005073")]
		[Address(RVA = "0x15F1EAC", Offset = "0x15F1EAC", VA = "0x15F1EAC")]
		private static IDictionary<string, object> ParseObject(string json, ref int index, ref bool success)
		{
			return null;
		}

		[Token(Token = "0x6005074")]
		[Address(RVA = "0x15F2B38", Offset = "0x15F2B38", VA = "0x15F2B38")]
		private static JsonArray ParseArray(string json, ref int index, ref bool success)
		{
			return null;
		}

		[Token(Token = "0x6005075")]
		[Address(RVA = "0x15F1068", Offset = "0x15F1068", VA = "0x15F1068")]
		private static object ParseValue(string json, ref int index, ref bool success)
		{
			return null;
		}

		[Token(Token = "0x6005076")]
		[Address(RVA = "0x15F2518", Offset = "0x15F2518", VA = "0x15F2518")]
		private static string ParseString(string json, ref int index, ref bool success)
		{
			return null;
		}

		[Token(Token = "0x6005077")]
		[Address(RVA = "0x15F3128", Offset = "0x15F3128", VA = "0x15F3128")]
		private static string ConvertFromUtf32(int utf32)
		{
			return null;
		}

		[Token(Token = "0x6005078")]
		[Address(RVA = "0x15F2D40", Offset = "0x15F2D40", VA = "0x15F2D40")]
		private static object ParseNumber(string json, ref int index, ref bool success)
		{
			return null;
		}

		[Token(Token = "0x6005079")]
		[Address(RVA = "0x15F3294", Offset = "0x15F3294", VA = "0x15F3294")]
		private static int GetLastIndexOfNumber(string json, int index)
		{
			return default;
		}

		[Token(Token = "0x600507A")]
		[Address(RVA = "0x15F3080", Offset = "0x15F3080", VA = "0x15F3080")]
		private static void EatWhitespace(string json, ref int index)
		{
		}

		[Token(Token = "0x600507B")]
		[Address(RVA = "0x15F2488", Offset = "0x15F2488", VA = "0x15F2488")]
		private static TokenType LookAhead(string json, int index)
		{
			return default;
		}

		[Token(Token = "0x600507C")]
		[Address(RVA = "0x15F2174", Offset = "0x15F2174", VA = "0x15F2174")]
		private static TokenType NextToken(string json, ref int index)
		{
			return default;
		}

		[Token(Token = "0x600507D")]
		[Address(RVA = "0x15F1748", Offset = "0x15F1748", VA = "0x15F1748")]
		private static bool SerializeValue(IJsonSerializerStrategy jsonSerializerStrategy, object value, StringBuilder builder)
		{
			return default;
		}

		[Token(Token = "0x600507E")]
		[Address(RVA = "0x15F3594", Offset = "0x15F3594", VA = "0x15F3594")]
		private static bool SerializeObject(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable keys, IEnumerable values, StringBuilder builder)
		{
			return default;
		}

		[Token(Token = "0x600507F")]
		[Address(RVA = "0x15F3A4C", Offset = "0x15F3A4C", VA = "0x15F3A4C")]
		private static bool SerializeArray(IJsonSerializerStrategy jsonSerializerStrategy, IEnumerable anArray, StringBuilder builder)
		{
			return default;
		}

		[Token(Token = "0x6005080")]
		[Address(RVA = "0x15F3338", Offset = "0x15F3338", VA = "0x15F3338")]
		private static bool SerializeString(string aString, StringBuilder builder)
		{
			return default;
		}

		[Token(Token = "0x6005081")]
		[Address(RVA = "0x15F3FC0", Offset = "0x15F3FC0", VA = "0x15F3FC0")]
		private static bool SerializeNumber(object number, StringBuilder builder)
		{
			return default;
		}

		[Token(Token = "0x6005082")]
		[Address(RVA = "0x15F3E1C", Offset = "0x15F3E1C", VA = "0x15F3E1C")]
		private static bool IsNumeric(object value)
		{
			return default;
		}
	}
}
