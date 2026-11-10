using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace MegacoolThirdParty_MiniJSON
{
	public static class Json
	{
		private sealed class Parser : IDisposable
		{
			private enum TOKEN
			{
				NONE = 0,
				CURLY_OPEN = 1,
				CURLY_CLOSE = 2,
				SQUARED_OPEN = 3,
				SQUARED_CLOSE = 4,
				COLON = 5,
				COMMA = 6,
				STRING = 7,
				NUMBER = 8,
				TRUE = 9,
				FALSE = 10,
				NULL = 11
			}

			private const string WORD_BREAK = "{}[],:\"";

			private StringReader json;

			private char PeekChar
			{
				get
				{
					int peek = json.Peek();
					return peek == -1 ? '\0' : Convert.ToChar(peek);
				}
			}

			private char NextChar
			{
				get
				{
					int r = json.Read();
					return r == -1 ? '\0' : Convert.ToChar(r);
				}
			}

			private string NextWord
			{
				get
				{
					StringBuilder sb = new StringBuilder();
					while (!IsWordBreak(PeekChar))
					{
						sb.Append(NextChar);
						if (json.Peek() == -1)
							break;
					}
					return sb.ToString();
				}
			}

			private TOKEN NextToken
			{
				get
				{
					EatWhitespace();
					if (json.Peek() == -1)
						return TOKEN.NONE;
					switch (PeekChar)
					{
						case '{':
							return TOKEN.CURLY_OPEN;
						case '}':
							json.Read();
							return TOKEN.CURLY_CLOSE;
						case '[':
							return TOKEN.SQUARED_OPEN;
						case ']':
							json.Read();
							return TOKEN.SQUARED_CLOSE;
						case ',':
							json.Read();
							return TOKEN.COMMA;
						case '"':
							return TOKEN.STRING;
						case ':':
							return TOKEN.COLON;
						case '0':
						case '1':
						case '2':
						case '3':
						case '4':
						case '5':
						case '6':
						case '7':
						case '8':
						case '9':
						case '-':
							return TOKEN.NUMBER;
					}
					switch (NextWord)
					{
						case "false":
							return TOKEN.FALSE;
						case "true":
							return TOKEN.TRUE;
						case "null":
							return TOKEN.NULL;
						default:
							return TOKEN.NONE;
					}
				}
			}

			public static bool IsWordBreak(char c)
			{
				return char.IsWhiteSpace(c) || WORD_BREAK.IndexOf(c) != -1;
			}

			private Parser(string jsonString)
			{
				json = new StringReader(jsonString ?? string.Empty);
			}

			public static object Parse(string jsonString)
			{
				if (string.IsNullOrEmpty(jsonString))
					return null;
				using (Parser instance = new Parser(jsonString))
				{
					return instance.ParseValue();
				}
			}

			public void Dispose()
			{
				if (json != null)
				{
					json.Dispose();
					json = null;
				}
			}

			private Dictionary<string, object> ParseObject()
			{
				Dictionary<string, object> table = new Dictionary<string, object>();
				json.Read();
				while (true)
				{
					switch (NextToken)
					{
						case TOKEN.NONE:
							return null;
						case TOKEN.COMMA:
							continue;
						case TOKEN.CURLY_CLOSE:
							return table;
						default:
						{
							string name = ParseString();
							if (name == null)
								return null;
							if (NextToken != TOKEN.COLON)
								return null;
							json.Read();
							table[name] = ParseValue();
							break;
						}
					}
				}
			}

			private List<object> ParseArray()
			{
				List<object> array = new List<object>();
				json.Read();
				bool parsing = true;
				while (parsing)
				{
					TOKEN nextToken = NextToken;
					switch (nextToken)
					{
						case TOKEN.NONE:
							return null;
						case TOKEN.COMMA:
							continue;
						case TOKEN.SQUARED_CLOSE:
							parsing = false;
							break;
						default:
						{
							object value = ParseByToken(nextToken);
							array.Add(value);
							break;
						}
					}
				}
				return array;
			}

			private object ParseValue()
			{
				TOKEN nextToken = NextToken;
				return ParseByToken(nextToken);
			}

			private object ParseByToken(TOKEN token)
			{
				switch (token)
				{
					case TOKEN.STRING:
						return ParseString();
					case TOKEN.NUMBER:
						return ParseNumber();
					case TOKEN.CURLY_OPEN:
						return ParseObject();
					case TOKEN.SQUARED_OPEN:
						return ParseArray();
					case TOKEN.TRUE:
						return true;
					case TOKEN.FALSE:
						return false;
					case TOKEN.NULL:
						return null;
					default:
						return null;
				}
			}

			private string ParseString()
			{
				StringBuilder s = new StringBuilder();
				json.Read();
				bool parsing = true;
				while (parsing)
				{
					if (json.Peek() == -1)
					{
						parsing = false;
						break;
					}
					char c = NextChar;
					switch (c)
					{
						case '"':
							parsing = false;
							break;
						case '\\':
							if (json.Peek() == -1)
							{
								parsing = false;
								break;
							}
							c = NextChar;
							switch (c)
							{
								case '"':
								case '\\':
								case '/':
									s.Append(c);
									break;
								case 'b':
									s.Append('\b');
									break;
								case 'f':
									s.Append('\f');
									break;
								case 'n':
									s.Append('\n');
									break;
								case 'r':
									s.Append('\r');
									break;
								case 't':
									s.Append('\t');
									break;
								case 'u':
								{
									char[] hex = new char[4];
									for (int i = 0; i < 4; i++)
										hex[i] = NextChar;
									s.Append((char)Convert.ToInt32(new string(hex), 16));
									break;
								}
							}
							break;
						default:
							s.Append(c);
							break;
					}
				}
				return s.ToString();
			}

			private object ParseNumber()
			{
				string number = NextWord;
				if (number.IndexOf('.') == -1 && number.IndexOf('e') == -1 && number.IndexOf('E') == -1)
				{
					if (long.TryParse(number, NumberStyles.Any, CultureInfo.InvariantCulture, out long parsedInt))
						return parsedInt;
				}
				if (double.TryParse(number, NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedDouble))
					return parsedDouble;
				return 0L;
			}

			private void EatWhitespace()
			{
				while (char.IsWhiteSpace(PeekChar))
				{
					json.Read();
					if (json.Peek() == -1)
						break;
				}
			}
		}

		private sealed class Serializer
		{
			private StringBuilder builder;

			private Serializer()
			{
				builder = new StringBuilder();
			}

			public static string Serialize(object obj)
			{
				Serializer instance = new Serializer();
				instance.SerializeValue(obj);
				return instance.builder.ToString();
			}

			private void SerializeValue(object value)
			{
				IList asList;
				IDictionary asDict;
				string asStr;
				if (value == null)
				{
					builder.Append("null");
				}
				else if ((asStr = value as string) != null)
				{
					SerializeString(asStr);
				}
				else if (value is bool b)
				{
					builder.Append(b ? "true" : "false");
				}
				else if ((asDict = value as IDictionary) != null)
				{
					SerializeObject(asDict);
				}
				else if ((asList = value as IList) != null)
				{
					SerializeArray(asList);
				}
				else if (value is char c)
				{
					SerializeString(new string(c, 1));
				}
				else
				{
					SerializeOther(value);
				}
			}

			private void SerializeObject(IDictionary obj)
			{
				bool first = true;
				builder.Append('{');
				foreach (object e in obj.Keys)
				{
					if (e == null)
						continue;
					if (!first)
						builder.Append(',');
					SerializeString(e.ToString());
					builder.Append(':');
					SerializeValue(obj[e]);
					first = false;
				}
				builder.Append('}');
			}

			private void SerializeArray(IList anArray)
			{
				builder.Append('[');
				bool first = true;
				foreach (object obj in anArray)
				{
					if (!first)
						builder.Append(',');
					SerializeValue(obj);
					first = false;
				}
				builder.Append(']');
			}

			private void SerializeString(string str)
			{
				builder.Append('\"');
				char[] charArray = str.ToCharArray();
				for (int i = 0; i < charArray.Length; i++)
				{
					char c = charArray[i];
					switch (c)
					{
						case '"':
							builder.Append("\\\"");
							break;
						case '\\':
							builder.Append("\\\\");
							break;
						case '\b':
							builder.Append("\\b");
							break;
						case '\f':
							builder.Append("\\f");
							break;
						case '\n':
							builder.Append("\\n");
							break;
						case '\r':
							builder.Append("\\r");
							break;
						case '\t':
							builder.Append("\\t");
							break;
						default:
						{
							int codepoint = Convert.ToInt32(c);
							if (codepoint >= 32 && codepoint <= 126)
							{
								builder.Append(c);
							}
							else
							{
								builder.Append("\\u");
								builder.Append(codepoint.ToString("x4"));
							}
							break;
						}
					}
				}
				builder.Append('\"');
			}

			private void SerializeOther(object value)
			{
				if (value is float f)
				{
					builder.Append(f.ToString("R", CultureInfo.InvariantCulture));
				}
				else if (value is int || value is uint || value is long || value is sbyte || value is byte || value is short || value is ushort || value is ulong)
				{
					builder.Append(Convert.ToString(value, CultureInfo.InvariantCulture));
				}
				else if (value is double || value is decimal)
				{
					builder.Append(Convert.ToDouble(value).ToString("R", CultureInfo.InvariantCulture));
				}
				else
				{
					SerializeString(value.ToString());
				}
			}
		}

		public static object Deserialize(string json)
		{
			if (json == null)
				return null;
			return Parser.Parse(json);
		}

		public static string Serialize(object obj)
		{
			return Serializer.Serialize(obj);
		}
	}
}
