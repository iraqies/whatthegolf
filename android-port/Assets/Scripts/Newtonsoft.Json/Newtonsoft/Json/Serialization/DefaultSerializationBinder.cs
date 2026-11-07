using System;
using System.Reflection;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183884", Offset = "0x183884")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183884", Offset = "0x183884")]
	public class DefaultSerializationBinder : SerializationBinder, ISerializationBinder
	{
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly DefaultSerializationBinder Instance;

		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186B2C", Offset = "0x186B2C")]
		private readonly ThreadSafeStore<StructMultiKey<string, string>, Type> _typeCache;

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x22C2078", Offset = "0x22C2078", VA = "0x22C2078")]
		public DefaultSerializationBinder()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x22C2168", Offset = "0x22C2168", VA = "0x22C2168")]
		private Type GetTypeFromTypeNameKey([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CA40", Offset = "0x18CA40")] StructMultiKey<string, string> typeNameKey)
		{
			return null;
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x22C260C", Offset = "0x22C260C", VA = "0x22C260C")]
		private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly)
		{
			return null;
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x22C28C4", Offset = "0x22C28C4", VA = "0x22C28C4")]
		private Type GetTypeByName([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CAB8", Offset = "0x18CAB8")] StructMultiKey<string, string> typeNameKey)
		{
			return null;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x22C2930", Offset = "0x22C2930", VA = "0x22C2930", Slot = "5")]
		public override Type BindToType([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CB30", Offset = "0x18CB30")] string assemblyName, string typeName)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x22C29F4", Offset = "0x22C29F4", VA = "0x22C29F4", Slot = "4")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1896EC", Offset = "0x1896EC")]
		public override void BindToName([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CB44", Offset = "0x18CB44")] Type serializedType, out string assemblyName, out string typeName)
		{
		}
	}
}
