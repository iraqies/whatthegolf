using System;
using System.Collections;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183DF0", Offset = "0x183DF0")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183DF0", Offset = "0x183DF0")]
	internal class JsonSerializerProxy : JsonSerializer
	{
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187DE4", Offset = "0x187DE4")]
		private readonly JsonSerializerInternalReader _serializerReader;

		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187DF8", Offset = "0x187DF8")]
		private readonly JsonSerializerInternalWriter _serializerWriter;

		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0xF0")]
		private readonly JsonSerializer _serializer;

		[Token(Token = "0x170000D9")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F69C", Offset = "0x18F69C")]
		public override IReferenceResolver ReferenceResolver
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x230A630", Offset = "0x230A630", VA = "0x230A630", Slot = "6")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A2B8", Offset = "0x18A2B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F6B0", Offset = "0x18F6B0")]
		public override ITraceWriter TraceWriter
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x230A650", Offset = "0x230A650", VA = "0x230A650", Slot = "8")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A2CC", Offset = "0x18A2CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x230A670", Offset = "0x230A670", VA = "0x230A670", Slot = "9")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A2E0", Offset = "0x18A2E0")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F6C4", Offset = "0x18F6C4")]
		public override IEqualityComparer EqualityComparer
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x230A690", Offset = "0x230A690", VA = "0x230A690", Slot = "10")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A2F4", Offset = "0x18A2F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public override JsonConverterCollection Converters
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x230A6B0", Offset = "0x230A6B0", VA = "0x230A6B0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		public override DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x230A6D4", Offset = "0x230A6D4", VA = "0x230A6D4", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public override IContractResolver ContractResolver
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x230A6F8", Offset = "0x230A6F8", VA = "0x230A6F8", Slot = "24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x230A71C", Offset = "0x230A71C", VA = "0x230A71C", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public override MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0x230A740", Offset = "0x230A740", VA = "0x230A740", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public override NullValueHandling NullValueHandling
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x230A764", Offset = "0x230A764", VA = "0x230A764", Slot = "16")]
			get
			{
				return default;
			}
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x230A788", Offset = "0x230A788", VA = "0x230A788", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public override ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x230A7AC", Offset = "0x230A7AC", VA = "0x230A7AC", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public override ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x230A7D0", Offset = "0x230A7D0", VA = "0x230A7D0", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public override PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x230A7F4", Offset = "0x230A7F4", VA = "0x230A7F4", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public override TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x230A818", Offset = "0x230A818", VA = "0x230A818", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public override MetadataPropertyHandling MetadataPropertyHandling
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0x230A838", Offset = "0x230A838", VA = "0x230A838", Slot = "21")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x230A85C", Offset = "0x230A85C", VA = "0x230A85C", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x230A880", Offset = "0x230A880", VA = "0x230A880", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public override ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x230A8A0", Offset = "0x230A8A0", VA = "0x230A8A0", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public override ISerializationBinder SerializationBinder
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x230A8C4", Offset = "0x230A8C4", VA = "0x230A8C4", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public override StreamingContext Context
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x230A8E4", Offset = "0x230A8E4", VA = "0x230A8E4", Slot = "26")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x230A908", Offset = "0x230A908", VA = "0x230A908", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public override bool CheckAdditionalContent
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x230A92C", Offset = "0x230A92C", VA = "0x230A92C", Slot = "28")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000002")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E6B0", Offset = "0x18E6B0")]
		public override event EventHandler<ErrorEventArgs> Error
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x230A5F0", Offset = "0x230A5F0", VA = "0x230A5F0", Slot = "4")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D984", Offset = "0x18D984")]
			add
			{
			}
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x230A610", Offset = "0x230A610", VA = "0x230A610", Slot = "5")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D9F4", Offset = "0x18D9F4")]
			remove
			{
			}
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x230A950", Offset = "0x230A950", VA = "0x230A950")]
		internal JsonSerializerInternalBase GetInternalSerializer()
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x230A968", Offset = "0x230A968", VA = "0x230A968")]
		public JsonSerializerProxy(JsonSerializerInternalReader serializerReader)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x230A9E8", Offset = "0x230A9E8", VA = "0x230A9E8")]
		public JsonSerializerProxy(JsonSerializerInternalWriter serializerWriter)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x230AA68", Offset = "0x230AA68", VA = "0x230AA68", Slot = "30")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A308", Offset = "0x18A308")]
		internal override object DeserializeInternal([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DA64", Offset = "0x18DA64")] JsonReader reader, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x230AA9C", Offset = "0x230AA9C", VA = "0x230AA9C", Slot = "29")]
		internal override void PopulateInternal(JsonReader reader, object target)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x230AACC", Offset = "0x230AACC", VA = "0x230AACC", Slot = "31")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A31C", Offset = "0x18A31C")]
		internal override void SerializeInternal([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18DA78", Offset = "0x18DA78")] JsonWriter jsonWriter, object value, Type rootType)
		{
		}
	}
}
