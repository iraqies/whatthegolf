using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183CFC", Offset = "0x183CFC")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183CFC", Offset = "0x183CFC")]
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase
	{
		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183D3C", Offset = "0x183D3C")]
		internal enum PropertyPresence
		{
			[Token(Token = "0x40002C2")]
			None = 0,
			[Token(Token = "0x40002C3")]
			Null = 1,
			[Token(Token = "0x40002C4")]
			Value = 2
		}

		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183D50", Offset = "0x183D50")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183D50", Offset = "0x183D50")]
		internal class CreatorPropertyContext
		{
			[Token(Token = "0x40002C5")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187CE4", Offset = "0x187CE4")]
			public readonly string Name;

			[Token(Token = "0x40002C6")]
			[FieldOffset(Offset = "0x18")]
			public JsonProperty Property;

			[Token(Token = "0x40002C7")]
			[FieldOffset(Offset = "0x20")]
			public JsonProperty ConstructorProperty;

			[Token(Token = "0x40002C8")]
			[FieldOffset(Offset = "0x28")]
			public PropertyPresence? Presence;

			[Token(Token = "0x40002C9")]
			[FieldOffset(Offset = "0x30")]
			public object Value;

			[Token(Token = "0x40002CA")]
			[FieldOffset(Offset = "0x38")]
			public bool Used;

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x23394D4", Offset = "0x23394D4", VA = "0x23394D4")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A18C", Offset = "0x18A18C")]
			public CreatorPropertyContext(string name)
			{
			}
		}

		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x183D90", Offset = "0x183D90")]
		private sealed class _003C_003Ec__DisplayClass38_0
		{
			[Token(Token = "0x40002CB")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187CF8", Offset = "0x187CF8")]
			public JsonProperty property;

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x23394A8", Offset = "0x23394A8", VA = "0x23394A8")]
			public _003C_003Ec__DisplayClass38_0()
			{
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x23394B0", Offset = "0x23394B0", VA = "0x23394B0")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A1A0", Offset = "0x18A1A0")]
			internal bool _003CCreateObjectUsingCreatorWithParameters_003Eb__1(CreatorPropertyContext p)
			{
				return default;
			}
		}

		[Serializable]
		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x183DA0", Offset = "0x183DA0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40002CC")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187D0C", Offset = "0x187D0C")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40002CD")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187D20", Offset = "0x187D20")]
			public static Func<JsonProperty, string> _003C_003E9__38_0;

			[Token(Token = "0x40002CE")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187D34", Offset = "0x187D34")]
			public static Func<JsonProperty, string> _003C_003E9__38_2;

			[Token(Token = "0x40002CF")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187DA8", Offset = "0x187DA8")]
			public static Func<JsonProperty, JsonProperty> _003C_003E9__42_0;

			[Token(Token = "0x40002D0")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187DBC", Offset = "0x187DBC")]
			public static Func<JsonProperty, PropertyPresence> _003C_003E9__42_1;

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x2339460", Offset = "0x2339460", VA = "0x2339460")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x2339468", Offset = "0x2339468", VA = "0x2339468")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A1B4", Offset = "0x18A1B4")]
			internal string _003CCreateObjectUsingCreatorWithParameters_003Eb__38_0(JsonProperty p)
			{
				return null;
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x2339480", Offset = "0x2339480", VA = "0x2339480")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A1C8", Offset = "0x18A1C8")]
			internal string _003CCreateObjectUsingCreatorWithParameters_003Eb__38_2(JsonProperty p)
			{
				return null;
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x2339498", Offset = "0x2339498", VA = "0x2339498")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A1DC", Offset = "0x18A1DC")]
			internal JsonProperty _003CPopulateObject_003Eb__42_0(JsonProperty m)
			{
				return null;
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x23394A0", Offset = "0x23394A0", VA = "0x23394A0")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A1F0", Offset = "0x18A1F0")]
			internal PropertyPresence _003CPopulateObject_003Eb__42_1(JsonProperty m)
			{
				return default;
			}
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x22F360C", Offset = "0x22F360C", VA = "0x22F360C")]
		public JsonSerializerInternalReader(JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x22F3698", Offset = "0x22F3698", VA = "0x22F3698")]
		public void Populate(JsonReader reader, object target)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x22F7A28", Offset = "0x22F7A28", VA = "0x22F7A28")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A060", Offset = "0x18A060")]
		private JsonContract GetContractSafe(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x22F7AC0", Offset = "0x22F7AC0", VA = "0x22F7AC0")]
		private JsonContract GetContract(Type type)
		{
			return null;
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x22F4294", Offset = "0x22F4294", VA = "0x22F4294")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A074", Offset = "0x18A074")]
		public object Deserialize([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D298", Offset = "0x18D298")] JsonReader reader, Type objectType, bool checkAdditionalContent)
		{
			return null;
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x22F875C", Offset = "0x22F875C", VA = "0x22F875C")]
		private JsonSerializerProxy GetInternalSerializer()
		{
			return null;
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x22F87C8", Offset = "0x22F87C8", VA = "0x22F87C8")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A088", Offset = "0x18A088")]
		private JToken CreateJToken([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D2AC", Offset = "0x18D2AC")] JsonReader reader, JsonContract contract)
		{
			return null;
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x22F8C24", Offset = "0x22F8C24", VA = "0x22F8C24")]
		private JToken CreateJObject(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x22F80C8", Offset = "0x22F80C8", VA = "0x22F80C8")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A09C", Offset = "0x18A09C")]
		private object CreateValueInternal([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D2C0", Offset = "0x18D2C0")] JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			return null;
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x22FAD60", Offset = "0x22FAD60", VA = "0x22FAD60")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A0B0", Offset = "0x18A0B0")]
		private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D2D4", Offset = "0x18D2D4")] string s)
		{
			return default;
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x22FAEB8", Offset = "0x22FAEB8", VA = "0x22FAEB8")]
		internal string GetExpectedDescription(JsonContract contract)
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x22F7B8C", Offset = "0x22F7B8C", VA = "0x22F7B8C")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A0C4", Offset = "0x18A0C4")]
		private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return null;
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x22F913C", Offset = "0x22F913C", VA = "0x22F913C")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A0D8", Offset = "0x18A0D8")]
		private object CreateObject([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D2E8", Offset = "0x18D2E8")] JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue)
		{
			return null;
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x22FAFD8", Offset = "0x22FAFD8", VA = "0x22FAFD8")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A0EC", Offset = "0x18A0EC")]
		private bool ReadMetadataPropertiesToken([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D2FC", Offset = "0x18D2FC")] JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id)
		{
			return default;
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x22FBA1C", Offset = "0x22FBA1C", VA = "0x22FBA1C")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A100", Offset = "0x18A100")]
		private bool ReadMetadataProperties([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D310", Offset = "0x18D310")] JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id)
		{
			return default;
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x22FD8B8", Offset = "0x22FD8B8", VA = "0x22FD8B8")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A114", Offset = "0x18A114")]
		private void ResolveTypeName([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D324", Offset = "0x18D324")] JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D338", Offset = "0x18D338")] string qualifiedTypeName)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x22FDFA4", Offset = "0x22FDFA4", VA = "0x22FDFA4")]
		private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract)
		{
			return null;
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x22F9EE0", Offset = "0x22F9EE0", VA = "0x22F9EE0")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A128", Offset = "0x18A128")]
		private object CreateList([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D34C", Offset = "0x18D34C")] JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id)
		{
			return null;
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x22FC064", Offset = "0x22FC064", VA = "0x22FC064")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A13C", Offset = "0x18A13C")]
		private bool HasNoDefinedType(JsonContract contract)
		{
			return default;
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x22FA6C8", Offset = "0x22FA6C8", VA = "0x22FA6C8")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A150", Offset = "0x18A150")]
		private object EnsureType([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D360", Offset = "0x18D360")] JsonReader reader, object value, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D374", Offset = "0x18D374")] CultureInfo culture, JsonContract contract, Type targetType)
		{
			return null;
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x22FED28", Offset = "0x22FED28", VA = "0x22FED28")]
		private bool SetPropertyValue(JsonProperty property, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D388", Offset = "0x18D388")] JsonConverter propertyConverter, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D39C", Offset = "0x18D39C")] JsonContainerContract containerContract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D3B0", Offset = "0x18D3B0")] JsonProperty containerProperty, JsonReader reader, object target)
		{
			return default;
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x22FF1EC", Offset = "0x22FF1EC", VA = "0x22FF1EC")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A164", Offset = "0x18A164")]
		private bool CalculatePropertyDetails([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D3C4", Offset = "0x18D3C4")] JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D3D8", Offset = "0x18D3D8")] JsonReader reader, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D3EC", Offset = "0x18D3EC")] object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue, out bool ignoredValue)
		{
			return default;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x22FF9DC", Offset = "0x22FF9DC", VA = "0x22FF9DC")]
		private void AddReference(JsonReader reader, string id, object value)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x22FF9D0", Offset = "0x22FF9D0", VA = "0x22FF9D0")]
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return default;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x22FF874", Offset = "0x22FF874", VA = "0x22FF874")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A178", Offset = "0x18A178")]
		private bool ShouldSetPropertyValue([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D400", Offset = "0x18D400")] JsonProperty property, JsonObjectContract contract, object value)
		{
			return default;
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x22FE178", Offset = "0x22FE178", VA = "0x22FE178")]
		private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator)
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x22FC4D8", Offset = "0x22FC4D8", VA = "0x22FC4D8")]
		private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator)
		{
			return null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x22FFE5C", Offset = "0x22FFE5C", VA = "0x22FFE5C")]
		private void OnDeserializing(JsonReader reader, JsonContract contract, object value)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x23000B4", Offset = "0x23000B4", VA = "0x23000B4")]
		private void OnDeserialized(JsonReader reader, JsonContract contract, object value)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x22F60F4", Offset = "0x22F60F4", VA = "0x22F60F4")]
		private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D414", Offset = "0x18D414")] JsonProperty containerProperty, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D428", Offset = "0x18D428")] string id)
		{
			return null;
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x22FE540", Offset = "0x22FE540", VA = "0x22FE540")]
		private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D43C", Offset = "0x18D43C")] JsonProperty containerProperty, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D450", Offset = "0x18D450")] string id)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x230030C", Offset = "0x230030C", VA = "0x230030C")]
		private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D464", Offset = "0x18D464")] object currentObject, string message)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x22F5A40", Offset = "0x22F5A40", VA = "0x22F5A40")]
		private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D478", Offset = "0x18D478")] JsonProperty containerProperty, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D48C", Offset = "0x18D48C")] string id)
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x22FD114", Offset = "0x22FD114", VA = "0x22FD114")]
		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D4A0", Offset = "0x18D4A0")] JsonProperty member, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D4B4", Offset = "0x18D4B4")] string id)
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x2300508", Offset = "0x2300508", VA = "0x2300508")]
		internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D4C8", Offset = "0x18D4C8")] JsonProperty member)
		{
			return null;
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x22FC7F8", Offset = "0x22FC7F8", VA = "0x22FC7F8")]
		private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D4DC", Offset = "0x18D4DC")] JsonProperty member, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D4F0", Offset = "0x18D4F0")] string id)
		{
			return null;
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x23006D4", Offset = "0x23006D4", VA = "0x23006D4")]
		private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D504", Offset = "0x18D504")] JsonProperty containerProperty, ObjectConstructor<object> creator, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D518", Offset = "0x18D518")] string id)
		{
			return null;
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x22F7C08", Offset = "0x22F7C08", VA = "0x22F7C08")]
		private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D52C", Offset = "0x18D52C")] object existingValue)
		{
			return null;
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x2302580", Offset = "0x2302580", VA = "0x2302580")]
		private List<CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D540", Offset = "0x18D540")] JsonProperty containerProperty, JsonReader reader, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x22FC184", Offset = "0x22FC184", VA = "0x22FC184")]
		public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D554", Offset = "0x18D554")] JsonProperty containerMember, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D568", Offset = "0x18D568")] JsonProperty containerProperty, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D57C", Offset = "0x18D57C")] string id, out bool createdFromNonDefaultCreator)
		{
			return null;
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x22F6D60", Offset = "0x22F6D60", VA = "0x22F6D60")]
		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D590", Offset = "0x18D590")] JsonProperty member, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D5A4", Offset = "0x18D5A4")] string id)
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x23035D4", Offset = "0x23035D4", VA = "0x23035D4")]
		private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target)
		{
			return default;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x22F8FA4", Offset = "0x22F8FA4", VA = "0x22F8FA4")]
		private bool CheckPropertyName(JsonReader reader, string memberName)
		{
			return default;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x23033C8", Offset = "0x23033C8", VA = "0x23033C8")]
		private void SetExtensionData(JsonObjectContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D5B8", Offset = "0x18D5B8")] JsonProperty member, JsonReader reader, string memberName, object o)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x23032EC", Offset = "0x23032EC", VA = "0x23032EC")]
		private object ReadExtensionDataValue(JsonObjectContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D5CC", Offset = "0x18D5CC")] JsonProperty member, JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x2302DE4", Offset = "0x2302DE4", VA = "0x2302DE4")]
		private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, PropertyPresence presence, bool setDefaultValue)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x2303870", Offset = "0x2303870", VA = "0x2303870")]
		private void SetPropertyPresence(JsonReader reader, JsonProperty property, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D5E0", Offset = "0x18D5E0")] Dictionary<JsonProperty, PropertyPresence> requiredProperties)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x22F8624", Offset = "0x22F8624", VA = "0x22F8624")]
		private void HandleError(JsonReader reader, bool readPastError, int initialDepth)
		{
		}
	}
}
