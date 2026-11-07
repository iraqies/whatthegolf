using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000BA")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183DB0", Offset = "0x183DB0")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183DB0", Offset = "0x183DB0")]
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase
	{
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187DD0", Offset = "0x187DD0")]
		private Type _rootType;

		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x40")]
		private int _rootLevel;

		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<object> _serializeStack;

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x22F4C90", Offset = "0x22F4C90", VA = "0x22F4C90")]
		public JsonSerializerInternalWriter(JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x22F4D78", Offset = "0x22F4D78", VA = "0x22F4D78")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A204", Offset = "0x18A204")]
		public void Serialize([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D650", Offset = "0x18D650")] JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x23046C0", Offset = "0x23046C0", VA = "0x23046C0")]
		private JsonSerializerProxy GetInternalSerializer()
		{
			return null;
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x2303988", Offset = "0x2303988", VA = "0x2303988")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A218", Offset = "0x18A218")]
		private JsonContract GetContractSafe(object value)
		{
			return null;
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x230472C", Offset = "0x230472C", VA = "0x230472C")]
		private JsonContract GetContract(object value)
		{
			return null;
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x230480C", Offset = "0x230480C", VA = "0x230480C")]
		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D664", Offset = "0x18D664")] JsonProperty member, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D678", Offset = "0x18D678")] JsonContainerContract containerContract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D68C", Offset = "0x18D68C")] JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2303EA8", Offset = "0x2303EA8", VA = "0x2303EA8")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A22C", Offset = "0x18A22C")]
		private void SerializeValue([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D6A0", Offset = "0x18D6A0")] JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2307B38", Offset = "0x2307B38", VA = "0x2307B38")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A240", Offset = "0x18A240")]
		private bool? ResolveIsReference([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D6B4", Offset = "0x18D6B4")] JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x2303998", Offset = "0x2303998", VA = "0x2303998")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A254", Offset = "0x18A254")]
		private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty)
		{
			return default;
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x2307BF4", Offset = "0x2307BF4", VA = "0x2307BF4")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A268", Offset = "0x18A268")]
		private bool ShouldWriteProperty(object memberValue, JsonObjectContract containerContract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D6C8", Offset = "0x18D6C8")] JsonProperty property)
		{
			return default;
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x2307D34", Offset = "0x2307D34", VA = "0x2307D34")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A27C", Offset = "0x18A27C")]
		private bool CheckForCircularReference([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D6DC", Offset = "0x18D6DC")] JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return default;
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x2303C00", Offset = "0x2303C00", VA = "0x2303C00")]
		private void WriteReference(JsonWriter writer, object value)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x2308184", Offset = "0x2308184", VA = "0x2308184")]
		private string GetReference(JsonWriter writer, object value)
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x23083FC", Offset = "0x23083FC", VA = "0x23083FC")]
		internal static bool TryConvertToString(object value, Type type, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D6F0", Offset = "0x18D6F0")] out string s)
		{
			return default;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x230648C", Offset = "0x230648C", VA = "0x230648C")]
		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract)
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2308520", Offset = "0x2308520", VA = "0x2308520")]
		private void OnSerializing(JsonWriter writer, JsonContract contract, object value)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2308758", Offset = "0x2308758", VA = "0x2308758")]
		private void OnSerialized(JsonWriter writer, JsonContract contract, object value)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x23053F0", Offset = "0x23053F0", VA = "0x23053F0")]
		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D704", Offset = "0x18D704")] JsonProperty member, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D718", Offset = "0x18D718")] JsonContainerContract collectionContract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D72C", Offset = "0x18D72C")] JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2308B30", Offset = "0x2308B30", VA = "0x2308B30")]
		private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D740", Offset = "0x18D740")] JsonProperty member, JsonProperty property, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D754", Offset = "0x18D754")] out JsonContract memberContract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D768", Offset = "0x18D768")] out object memberValue)
		{
			return default;
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2308990", Offset = "0x2308990", VA = "0x2308990")]
		private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D77C", Offset = "0x18D77C")] JsonProperty member, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D790", Offset = "0x18D790")] JsonContainerContract collectionContract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D7A4", Offset = "0x18D7A4")] JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2309A84", Offset = "0x2309A84", VA = "0x2309A84")]
		private bool HasCreatorParameter([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D7B8", Offset = "0x18D7B8")] JsonContainerContract contract, JsonProperty property)
		{
			return default;
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2309BAC", Offset = "0x2309BAC", VA = "0x2309BAC")]
		private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2304BC0", Offset = "0x2304BC0", VA = "0x2304BC0")]
		private void WriteTypeProperty(JsonWriter writer, Type type)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x2307D28", Offset = "0x2307D28", VA = "0x2307D28")]
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return default;
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2307BE8", Offset = "0x2307BE8", VA = "0x2307BE8")]
		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag)
		{
			return default;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2309E1C", Offset = "0x2309E1C", VA = "0x2309E1C")]
		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag)
		{
			return default;
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2304E74", Offset = "0x2304E74", VA = "0x2304E74")]
		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D7CC", Offset = "0x18D7CC")] JsonContainerContract collectionContract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D7E0", Offset = "0x18D7E0")] JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2305B7C", Offset = "0x2305B7C", VA = "0x2305B7C")]
		private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D7F4", Offset = "0x18D7F4")] JsonProperty member, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D808", Offset = "0x18D808")] JsonContainerContract collectionContract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D81C", Offset = "0x18D81C")] JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x230629C", Offset = "0x230629C", VA = "0x230629C")]
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D830", Offset = "0x18D830")] JsonProperty member, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D844", Offset = "0x18D844")] JsonContainerContract collectionContract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D858", Offset = "0x18D858")] JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x230A16C", Offset = "0x230A16C", VA = "0x230A16C")]
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D86C", Offset = "0x18D86C")] JsonProperty member, int initialDepth, int[] indices)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2309E28", Offset = "0x2309E28", VA = "0x2309E28")]
		private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D880", Offset = "0x18D880")] JsonProperty member, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D894", Offset = "0x18D894")] JsonContainerContract containerContract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D8A8", Offset = "0x18D8A8")] JsonProperty containerProperty)
		{
			return default;
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x23076BC", Offset = "0x23076BC", VA = "0x23076BC")]
		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D8BC", Offset = "0x18D8BC")] JsonProperty member, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D8D0", Offset = "0x18D8D0")] JsonContainerContract collectionContract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D8E4", Offset = "0x18D8E4")] JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2306E28", Offset = "0x2306E28", VA = "0x2306E28")]
		private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D8F8", Offset = "0x18D8F8")] JsonProperty member, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D90C", Offset = "0x18D90C")] JsonContainerContract collectionContract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D920", Offset = "0x18D920")] JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x230A520", Offset = "0x230A520", VA = "0x230A520")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A290", Offset = "0x18A290")]
		private bool ShouldWriteDynamicProperty(object memberValue)
		{
			return default;
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2304990", Offset = "0x2304990", VA = "0x2304990")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A2A4", Offset = "0x18A2A4")]
		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D934", Offset = "0x18D934")] JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty)
		{
			return default;
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x2306518", Offset = "0x2306518", VA = "0x2306518")]
		private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D948", Offset = "0x18D948")] JsonProperty member, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D95C", Offset = "0x18D95C")] JsonContainerContract collectionContract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D970", Offset = "0x18D970")] JsonProperty containerProperty)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x2308FBC", Offset = "0x2308FBC", VA = "0x2308FBC")]
		private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape)
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x23045F8", Offset = "0x23045F8", VA = "0x23045F8")]
		private void HandleError(JsonWriter writer, int initialDepth)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2309554", Offset = "0x2309554", VA = "0x2309554")]
		private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target)
		{
			return default;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x23097EC", Offset = "0x23097EC", VA = "0x23097EC")]
		private bool IsSpecified(JsonWriter writer, JsonProperty property, object target)
		{
			return default;
		}
	}
}
