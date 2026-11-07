using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Prime31
{
	public class Json
	{
		internal class ObjectDecoder
		{
			private Dictionary<string, Action<object, object>> _memberInfo;

			public static object decode<T>(string json, string rootElement = null) where T : new()
			{
				return null;
			}

			private object decode<T>(object decodedJsonObject, string rootElement = null) where T : new()
			{
				return null;
			}

			private Dictionary<string, Action<object, object>> getMemberInfoForObject(object obj)
			{
				return null;
			}

			private static Dictionary<string, Action<object, object>> getMembersWithSetters(object obj)
			{
				return null;
			}

			public object createAndPopulateObjectFromDictionary(Type objectType, Dictionary<string, object> dict)
			{
				return null;
			}
		}

		internal class Deserializer
		{
			private enum JsonToken
			{
				None = 0,
				CurlyOpen = 1,
				CurlyClose = 2,
				SquaredOpen = 3,
				SquaredClose = 4,
				Colon = 5,
				Comma = 6,
				String = 7,
				Number = 8,
				True = 9,
				False = 10,
				Null = 11
			}

			private char[] charArray;

			public static object deserialize(string json)
			{
				return null;
			}

			private Deserializer(string json)
			{
			}

			private object deserialize()
			{
				return null;
			}

			protected object parseValue(char[] json, ref int index)
			{
				return null;
			}

			private IDictionary parseObject(char[] json, ref int index)
			{
				return null;
			}

			private IList parseArray(char[] json, ref int index)
			{
				return null;
			}

			private string parseString(char[] json, ref int index)
			{
				return null;
			}

			private object parseNumber(char[] json, ref int index)
			{
				return null;
			}

			private int getLastIndexOfNumber(char[] json, int index)
			{
				return 0;
			}

			private void eatWhitespace(char[] json, ref int index)
			{
			}

			private JsonToken lookAhead(char[] json, int index)
			{
				return JsonToken.None;
			}

			private JsonToken nextToken(char[] json, ref int index)
			{
				return JsonToken.None;
			}
		}

		internal class Serializer
		{
			private StringBuilder _builder;

			private Serializer()
			{
			}

			public static string serialize(object obj)
			{
				return null;
			}

			private void serializeObject(object value)
			{
			}

			private void serializeIList(IList anArray)
			{
			}

			private void serializeIDictionary(IDictionary dict)
			{
			}

			private void serializeDictionary(Dictionary<string, object> dict)
			{
			}

			private void serializeString(string str)
			{
			}

			private void serializeClass(object value)
			{
			}
		}

		public static bool useSimpleJson;

		public static object decode(string json)
		{
			return null;
		}

		public static T decode<T>(string json, string rootElement = null) where T : new()
		{
			return default;
		}

		public static string encode(object obj)
		{
			return null;
		}
	}
}
