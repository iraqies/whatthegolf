using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000F1")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x184894", Offset = "0x184894")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x184894", Offset = "0x184894")]
	public class KeyValuePairConverter : JsonConverter
	{
		[Token(Token = "0x4000359")]
		private const string KeyName = "Key";

		[Token(Token = "0x400035A")]
		private const string ValueName = "Value";

		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType;

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x231A078", Offset = "0x231A078", VA = "0x231A078")]
		private static ReflectionObject InitializeReflectionObject(Type t)
		{
			return null;
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x231ACA8", Offset = "0x231ACA8", VA = "0x231ACA8", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E2A8", Offset = "0x18E2A8")] object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x231B004", Offset = "0x231B004", VA = "0x231B004", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E2BC", Offset = "0x18E2BC")] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x231B5F8", Offset = "0x231B5F8", VA = "0x231B5F8", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default;
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x231B730", Offset = "0x231B730", VA = "0x231B730")]
		public KeyValuePairConverter()
		{
		}
	}
}
