using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000E2")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1845D4", Offset = "0x1845D4")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1845D4", Offset = "0x1845D4")]
	public class BinaryConverter : JsonConverter
	{
		[Token(Token = "0x400033F")]
		private const string BinaryTypeName = "System.Data.Linq.Binary";

		[Token(Token = "0x4000340")]
		private const string BinaryToArrayName = "ToArray";

		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1883A0", Offset = "0x1883A0")]
		private static ReflectionObject _reflectionObject;

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x22AC46C", Offset = "0x22AC46C", VA = "0x22AC46C", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E140", Offset = "0x18E140")] object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x22AC4D0", Offset = "0x22AC4D0", VA = "0x22AC4D0")]
		private byte[] GetByteArray(object value)
		{
			return null;
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x22AC6F0", Offset = "0x22AC6F0", VA = "0x22AC6F0")]
		private static void EnsureReflectionObject(Type t)
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x22AC8B4", Offset = "0x22AC8B4", VA = "0x22AC8B4", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E154", Offset = "0x18E154")] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x22ACD68", Offset = "0x22ACD68", VA = "0x22ACD68")]
		private byte[] ReadByteArray(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x22ACFF4", Offset = "0x22ACFF4", VA = "0x22ACFF4", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default;
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x22AD13C", Offset = "0x22AD13C", VA = "0x22AD13C")]
		public BinaryConverter()
		{
		}
	}
}
