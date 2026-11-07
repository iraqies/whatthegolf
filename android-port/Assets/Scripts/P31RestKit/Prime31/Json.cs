using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace Prime31
{
	[Token(Token = "0x2000009")]
	public class Json
	{
		[Token(Token = "0x200000A")]
		internal class ObjectDecoder
		{
			[Token(Token = "0x200000B")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x190508", Offset = "0x190508")]
			private sealed class _003C_003Ec__DisplayClass4_0
			{
				[Token(Token = "0x400001F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public FieldInfo theInfo;

				[Token(Token = "0x4000020")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Type theFieldType;

				[Token(Token = "0x6000048")]
				[Address(RVA = "0x23468AC", Offset = "0x23468AC", VA = "0x23468AC")]
				public _003C_003Ec__DisplayClass4_0()
				{
				}

				[Token(Token = "0x6000049")]
				[Address(RVA = "0x2348368", Offset = "0x2348368", VA = "0x2348368")]
				internal void _003CgetMembersWithSetters_003Eb__0(object ownerObject, object val)
				{
				}
			}

			[Token(Token = "0x200000C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x190518", Offset = "0x190518")]
			private sealed class _003C_003Ec__DisplayClass4_1
			{
				[Token(Token = "0x4000021")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public PropertyInfo theInfo;

				[Token(Token = "0x4000022")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Type thePropertyType;

				[Token(Token = "0x600004A")]
				[Address(RVA = "0x23468B4", Offset = "0x23468B4", VA = "0x23468B4")]
				public _003C_003Ec__DisplayClass4_1()
				{
				}

				[Token(Token = "0x600004B")]
				[Address(RVA = "0x234840C", Offset = "0x234840C", VA = "0x234840C")]
				internal void _003CgetMembersWithSetters_003Eb__1(object ownerObject, object val)
				{
				}
			}

			[Token(Token = "0x400001E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Dictionary<string, Action<object, object>> _memberInfo;

			[Token(Token = "0x6000042")]
			public static object decode<T>(string json, [Optional] string rootElement) where T : new()
			{
				return null;
			}

			[Token(Token = "0x6000043")]
			private object decode<T>(object decodedJsonObject, [Optional] string rootElement) where T : new()
			{
				return null;
			}

			[Token(Token = "0x6000044")]
			[Address(RVA = "0x23464A0", Offset = "0x23464A0", VA = "0x23464A0")]
			private Dictionary<string, Action<object, object>> getMemberInfoForObject(object obj)
			{
				return null;
			}

			[Token(Token = "0x6000045")]
			[Address(RVA = "0x23464D4", Offset = "0x23464D4", VA = "0x23464D4")]
			private static Dictionary<string, Action<object, object>> getMembersWithSetters(object obj)
			{
				return null;
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0x23468BC", Offset = "0x23468BC", VA = "0x23468BC")]
			public object createAndPopulateObjectFromDictionary(Type objectType, Dictionary<string, object> dict)
			{
				return null;
			}

			[Token(Token = "0x6000047")]
			[Address(RVA = "0x2346C2C", Offset = "0x2346C2C", VA = "0x2346C2C")]
			public ObjectDecoder()
			{
			}
		}

		[Token(Token = "0x200000D")]
		internal class Deserializer
		{
			[Token(Token = "0x200000E")]
			private enum JsonToken
			{
				[Token(Token = "0x4000025")]
				None = 0,
				[Token(Token = "0x4000026")]
				CurlyOpen = 1,
				[Token(Token = "0x4000027")]
				CurlyClose = 2,
				[Token(Token = "0x4000028")]
				SquaredOpen = 3,
				[Token(Token = "0x4000029")]
				SquaredClose = 4,
				[Token(Token = "0x400002A")]
				Colon = 5,
				[Token(Token = "0x400002B")]
				Comma = 6,
				[Token(Token = "0x400002C")]
				String = 7,
				[Token(Token = "0x400002D")]
				Number = 8,
				[Token(Token = "0x400002E")]
				True = 9,
				[Token(Token = "0x400002F")]
				False = 10,
				[Token(Token = "0x4000030")]
				Null = 11
			}

			[Token(Token = "0x4000023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private char[] charArray;

			[Token(Token = "0x600004C")]
			[Address(RVA = "0x233C464", Offset = "0x233C464", VA = "0x233C464")]
			public static object deserialize(string json)
			{
				return null;
			}

			[Token(Token = "0x600004D")]
			[Address(RVA = "0x23454A0", Offset = "0x23454A0", VA = "0x23454A0")]
			private Deserializer(string json)
			{
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0x23454E0", Offset = "0x23454E0", VA = "0x23454E0")]
			private object deserialize()
			{
				return null;
			}

			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2345508", Offset = "0x2345508", VA = "0x2345508")]
			protected object parseValue(char[] json, ref int index)
			{
				return null;
			}

			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2345D9C", Offset = "0x2345D9C", VA = "0x2345D9C")]
			private IDictionary parseObject(char[] json, ref int index)
			{
				return null;
			}

			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2345F60", Offset = "0x2345F60", VA = "0x2345F60")]
			private IList parseArray(char[] json, ref int index)
			{
				return null;
			}

			[Token(Token = "0x6000052")]
			[Address(RVA = "0x234574C", Offset = "0x234574C", VA = "0x234574C")]
			private string parseString(char[] json, ref int index)
			{
				return null;
			}

			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2345BA8", Offset = "0x2345BA8", VA = "0x2345BA8")]
			private object parseNumber(char[] json, ref int index)
			{
				return null;
			}

			[Token(Token = "0x6000054")]
			[Address(RVA = "0x23463EC", Offset = "0x23463EC", VA = "0x23463EC")]
			private int getLastIndexOfNumber(char[] json, int index)
			{
				return default;
			}

			[Token(Token = "0x6000055")]
			[Address(RVA = "0x2346338", Offset = "0x2346338", VA = "0x2346338")]
			private void eatWhitespace(char[] json, ref int index)
			{
			}

			[Token(Token = "0x6000056")]
			[Address(RVA = "0x2345728", Offset = "0x2345728", VA = "0x2345728")]
			private JsonToken lookAhead(char[] json, int index)
			{
				return default;
			}

			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2346084", Offset = "0x2346084", VA = "0x2346084")]
			private JsonToken nextToken(char[] json, ref int index)
			{
				return default;
			}
		}

		[Token(Token = "0x200000F")]
		internal class Serializer
		{
			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringBuilder _builder;

			[Token(Token = "0x6000058")]
			[Address(RVA = "0x2346C34", Offset = "0x2346C34", VA = "0x2346C34")]
			private Serializer()
			{
			}

			[Token(Token = "0x6000059")]
			[Address(RVA = "0x233C6B4", Offset = "0x233C6B4", VA = "0x233C6B4")]
			public static string serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x600005A")]
			[Address(RVA = "0x2346CA4", Offset = "0x2346CA4", VA = "0x2346CA4")]
			private void serializeObject(object value)
			{
			}

			[Token(Token = "0x600005B")]
			[Address(RVA = "0x234747C", Offset = "0x234747C", VA = "0x234747C")]
			private void serializeIList(IList anArray)
			{
			}

			[Token(Token = "0x600005C")]
			[Address(RVA = "0x2347930", Offset = "0x2347930", VA = "0x2347930")]
			private void serializeIDictionary(IDictionary dict)
			{
			}

			[Token(Token = "0x600005D")]
			[Address(RVA = "0x2347680", Offset = "0x2347680", VA = "0x2347680")]
			private void serializeDictionary(Dictionary<string, object> dict)
			{
			}

			[Token(Token = "0x600005E")]
			[Address(RVA = "0x2347108", Offset = "0x2347108", VA = "0x2347108")]
			private void serializeString(string str)
			{
			}

			[Token(Token = "0x600005F")]
			[Address(RVA = "0x2347E08", Offset = "0x2347E08", VA = "0x2347E08")]
			private void serializeClass(object value)
			{
			}
		}

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool useSimpleJson;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x233C238", Offset = "0x233C238", VA = "0x233C238")]
		public static object decode(string json)
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		public static T decode<T>(string json, [Optional] string rootElement) where T : new()
		{
			return (T)null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x233C578", Offset = "0x233C578", VA = "0x233C578")]
		public static string encode(object obj)
		{
			return null;
		}
	}
}
