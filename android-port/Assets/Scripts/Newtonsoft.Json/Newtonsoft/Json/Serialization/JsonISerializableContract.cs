using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000AD")]
	public class JsonISerializableContract : JsonContainerContract
	{
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187644", Offset = "0x187644")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187644", Offset = "0x187644")]
		private ObjectConstructor<object> ISerializableCreator__BackingField;

		[Token(Token = "0x170000AC")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F2E4", Offset = "0x18F2E4")]
		public ObjectConstructor<object> ISerializableCreator
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x22E9F68", Offset = "0x22E9F68", VA = "0x22E9F68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189B64", Offset = "0x189B64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x22E9F70", Offset = "0x22E9F70", VA = "0x22E9F70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189B74", Offset = "0x189B74")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CF00", Offset = "0x18CF00")]
			set
			{
			}
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x22E9F78", Offset = "0x22E9F78", VA = "0x22E9F78")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189B84", Offset = "0x189B84")]
		public JsonISerializableContract(Type underlyingType)
		{
		}
	}
}
