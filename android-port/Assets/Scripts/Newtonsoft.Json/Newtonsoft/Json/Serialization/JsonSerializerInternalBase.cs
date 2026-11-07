using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183CA8", Offset = "0x183CA8")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183CA8", Offset = "0x183CA8")]
	internal abstract class JsonSerializerInternalBase
	{
		[Token(Token = "0x20000B4")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183CE8", Offset = "0x183CE8")]
		private class ReferenceEqualsEqualityComparer : IEqualityComparer<object>
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x23393E0", Offset = "0x23393E0", VA = "0x23393E0", Slot = "4")]
			private bool System_002ECollections_002EGeneric_002EIEqualityComparer_003CSystem_002EObject_003E_002EEquals(object x, object y)
			{
				return default;
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x23393EC", Offset = "0x23393EC", VA = "0x23393EC", Slot = "5")]
			private int System_002ECollections_002EGeneric_002EIEqualityComparer_003CSystem_002EObject_003E_002EGetHashCode(object obj)
			{
				return default;
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x23393F8", Offset = "0x23393F8", VA = "0x23393F8")]
			public ReferenceEqualsEqualityComparer()
			{
			}
		}

		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187C30", Offset = "0x187C30")]
		private ErrorContext _currentErrorContext;

		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187C44", Offset = "0x187C44")]
		private BidirectionalDictionary<string, object> _mappings;

		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x20")]
		internal readonly JsonSerializer Serializer;

		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187CBC", Offset = "0x187CBC")]
		internal readonly ITraceWriter TraceWriter;

		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187CD0", Offset = "0x187CD0")]
		protected JsonSerializerProxy InternalSerializer;

		[Token(Token = "0x170000D8")]
		internal BidirectionalDictionary<string, object> DefaultReferenceMappings
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x22F531C", Offset = "0x22F531C", VA = "0x22F531C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x22F5290", Offset = "0x22F5290", VA = "0x22F5290")]
		protected JsonSerializerInternalBase(JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x22F5420", Offset = "0x22F5420", VA = "0x22F5420")]
		protected NullValueHandling ResolvedNullValueHandling([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D234", Offset = "0x18D234")] JsonObjectContract containerContract, JsonProperty property)
		{
			return default;
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x22F54B0", Offset = "0x22F54B0", VA = "0x22F54B0")]
		private ErrorContext GetErrorContext([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D248", Offset = "0x18D248")] object currentObject, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D25C", Offset = "0x18D25C")] object member, string path, Exception error)
		{
			return null;
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x22F55B4", Offset = "0x22F55B4", VA = "0x22F55B4")]
		protected void ClearErrorContext()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x22F5618", Offset = "0x22F5618", VA = "0x22F5618")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A04C", Offset = "0x18A04C")]
		protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D270", Offset = "0x18D270")] string path, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D284", Offset = "0x18D284")] Exception ex)
		{
			return default;
		}
	}
}
