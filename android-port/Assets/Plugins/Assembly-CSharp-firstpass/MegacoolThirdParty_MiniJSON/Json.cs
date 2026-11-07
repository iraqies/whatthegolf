using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace MegacoolThirdParty_MiniJSON
{
	[Token(Token = "0x2000286")]
	public static class Json
	{
		[Token(Token = "0x2000287")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x2000288")]
			private enum TOKEN
			{
				[Token(Token = "0x40010F7")]
				NONE = 0,
				[Token(Token = "0x40010F8")]
				CURLY_OPEN = 1,
				[Token(Token = "0x40010F9")]
				CURLY_CLOSE = 2,
				[Token(Token = "0x40010FA")]
				SQUARED_OPEN = 3,
				[Token(Token = "0x40010FB")]
				SQUARED_CLOSE = 4,
				[Token(Token = "0x40010FC")]
				COLON = 5,
				[Token(Token = "0x40010FD")]
				COMMA = 6,
				[Token(Token = "0x40010FE")]
				STRING = 7,
				[Token(Token = "0x40010FF")]
				NUMBER = 8,
				[Token(Token = "0x4001100")]
				TRUE = 9,
				[Token(Token = "0x4001101")]
				FALSE = 10,
				[Token(Token = "0x4001102")]
				NULL = 11
			}

			[Token(Token = "0x40010F5")]
			[FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x170001FB")]
			private char PeekChar
			{
				[Token(Token = "0x60010B9")]
				[Address(RVA = "0x134D694", Offset = "0x134D694", VA = "0x134D694")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170001FC")]
			private char NextChar
			{
				[Token(Token = "0x60010BA")]
				[Address(RVA = "0x134D380", Offset = "0x134D380", VA = "0x134D380")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x170001FD")]
			private string NextWord
			{
				[Token(Token = "0x60010BB")]
				[Address(RVA = "0x134D404", Offset = "0x134D404", VA = "0x134D404")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001FE")]
			private TOKEN NextToken
			{
				[Token(Token = "0x60010BC")]
				[Address(RVA = "0x134C9C8", Offset = "0x134C9C8", VA = "0x134C9C8")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x60010AE")]
			[Address(RVA = "0x134C544", Offset = "0x134C544", VA = "0x134C544")]
			public static bool IsWordBreak(char c)
			{
				return default;
			}

			[Token(Token = "0x60010AF")]
			[Address(RVA = "0x134C5F4", Offset = "0x134C5F4", VA = "0x134C5F4")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x60010B0")]
			[Address(RVA = "0x134C66C", Offset = "0x134C66C", VA = "0x134C66C")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x60010B1")]
			[Address(RVA = "0x134C86C", Offset = "0x134C86C", VA = "0x134C86C", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60010B2")]
			[Address(RVA = "0x134C8A0", Offset = "0x134C8A0", VA = "0x134C8A0")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x60010B3")]
			[Address(RVA = "0x134D020", Offset = "0x134D020", VA = "0x134D020")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x60010B4")]
			[Address(RVA = "0x134C844", Offset = "0x134C844", VA = "0x134C844")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x60010B5")]
			[Address(RVA = "0x134D108", Offset = "0x134D108", VA = "0x134D108")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x60010B6")]
			[Address(RVA = "0x134CC20", Offset = "0x134CC20", VA = "0x134CC20")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x60010B7")]
			[Address(RVA = "0x134D24C", Offset = "0x134D24C", VA = "0x134D24C")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x60010B8")]
			[Address(RVA = "0x134D57C", Offset = "0x134D57C", VA = "0x134D57C")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x2000289")]
		private sealed class Serializer
		{
			[Token(Token = "0x4001103")]
			[FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x60010BD")]
			[Address(RVA = "0x134D718", Offset = "0x134D718", VA = "0x134D718")]
			private Serializer()
			{
			}

			[Token(Token = "0x60010BE")]
			[Address(RVA = "0x134D788", Offset = "0x134D788", VA = "0x134D788")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x60010BF")]
			[Address(RVA = "0x134D850", Offset = "0x134D850", VA = "0x134D850")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x60010C0")]
			[Address(RVA = "0x134E094", Offset = "0x134E094", VA = "0x134E094")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x60010C1")]
			[Address(RVA = "0x134DD5C", Offset = "0x134DD5C", VA = "0x134DD5C")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x60010C2")]
			[Address(RVA = "0x134DA58", Offset = "0x134DA58", VA = "0x134DA58")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x60010C3")]
			[Address(RVA = "0x134E514", Offset = "0x134E514", VA = "0x134E514")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x60010AC")]
		[Address(RVA = "0x13A7CFC", Offset = "0x13A7CFC", VA = "0x13A7CFC")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x60010AD")]
		[Address(RVA = "0x13A7D0C", Offset = "0x13A7D0C", VA = "0x13A7D0C")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
