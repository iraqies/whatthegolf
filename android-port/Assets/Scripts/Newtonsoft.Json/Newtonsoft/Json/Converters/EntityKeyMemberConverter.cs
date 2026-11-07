using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000ED")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x184794", Offset = "0x184794")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x184794", Offset = "0x184794")]
	public class EntityKeyMemberConverter : JsonConverter
	{
		[Token(Token = "0x4000350")]
		private const string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";

		[Token(Token = "0x4000351")]
		private const string KeyPropertyName = "Key";

		[Token(Token = "0x4000352")]
		private const string TypePropertyName = "Type";

		[Token(Token = "0x4000353")]
		private const string ValuePropertyName = "Value";

		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1883DC", Offset = "0x1883DC")]
		private static ReflectionObject _reflectionObject;

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x22C4A14", Offset = "0x22C4A14", VA = "0x22C4A14", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E208", Offset = "0x18E208")] object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x22C4F0C", Offset = "0x22C4F0C", VA = "0x22C4F0C")]
		private static void ReadAndAssertProperty(JsonReader reader, string propertyName)
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x22C5024", Offset = "0x22C5024", VA = "0x22C5024", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E21C", Offset = "0x18E21C")] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x22C4DD4", Offset = "0x22C4DD4", VA = "0x22C4DD4")]
		private static void EnsureReflectionObject(Type objectType)
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x22C5330", Offset = "0x22C5330", VA = "0x22C5330", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default;
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x22C1758", Offset = "0x22C1758", VA = "0x22C1758")]
		public EntityKeyMemberConverter()
		{
		}
	}
}
