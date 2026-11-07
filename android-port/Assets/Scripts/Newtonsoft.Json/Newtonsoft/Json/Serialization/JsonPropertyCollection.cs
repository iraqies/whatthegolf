using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183C1C", Offset = "0x183C1C")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183C1C", Offset = "0x183C1C")]
	public class JsonPropertyCollection : KeyedCollection<string, JsonProperty>
	{
		[Token(Token = "0x40002BA")]
		[FieldOffset(Offset = "0x38")]
		private readonly Type _type;

		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<JsonProperty> _list;

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x22EA0B4", Offset = "0x22EA0B4", VA = "0x22EA0B4")]
		public JsonPropertyCollection(Type type)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x22EBDD0", Offset = "0x22EBDD0", VA = "0x22EBDD0", Slot = "39")]
		protected override string GetKeyForItem(JsonProperty item)
		{
			return null;
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x22EBDE8", Offset = "0x22EBDE8", VA = "0x22EBDE8")]
		public void AddProperty(JsonProperty property)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x22EC10C", Offset = "0x22EC10C", VA = "0x22EC10C")]
		public JsonProperty GetClosestMatchProperty(string propertyName)
		{
			return null;
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x22EC2F4", Offset = "0x22EC2F4", VA = "0x22EC2F4")]
		private bool TryGetValue(string key, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D220", Offset = "0x18D220")] out JsonProperty item)
		{
			return default;
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x22EC150", Offset = "0x22EC150", VA = "0x22EC150")]
		public JsonProperty GetProperty(string propertyName, StringComparison comparisonType)
		{
			return null;
		}
	}
}
