using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1829FC", Offset = "0x1829FC")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1829FC", Offset = "0x1829FC")]
	public class JsonSerializer
	{
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x10")]
		internal TypeNameHandling _typeNameHandling;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x14")]
		internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x18")]
		internal PreserveReferencesHandling _preserveReferencesHandling;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x1C")]
		internal ReferenceLoopHandling _referenceLoopHandling;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x20")]
		internal MissingMemberHandling _missingMemberHandling;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x24")]
		internal ObjectCreationHandling _objectCreationHandling;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x28")]
		internal NullValueHandling _nullValueHandling;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x2C")]
		internal DefaultValueHandling _defaultValueHandling;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x30")]
		internal ConstructorHandling _constructorHandling;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x34")]
		internal MetadataPropertyHandling _metadataPropertyHandling;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185304", Offset = "0x185304")]
		internal JsonConverterCollection _converters;

		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x40")]
		internal IContractResolver _contractResolver;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185318", Offset = "0x185318")]
		internal ITraceWriter _traceWriter;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18532C", Offset = "0x18532C")]
		internal IEqualityComparer _equalityComparer;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x58")]
		internal ISerializationBinder _serializationBinder;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x60")]
		internal StreamingContext _context;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185340", Offset = "0x185340")]
		private IReferenceResolver _referenceResolver;

		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x78")]
		private Formatting? _formatting;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x80")]
		private DateFormatHandling? _dateFormatHandling;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x88")]
		private DateTimeZoneHandling? _dateTimeZoneHandling;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x90")]
		private DateParseHandling? _dateParseHandling;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x98")]
		private FloatFormatHandling? _floatFormatHandling;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0xA0")]
		private FloatParseHandling? _floatParseHandling;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0xA8")]
		private StringEscapeHandling? _stringEscapeHandling;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0xB0")]
		private CultureInfo _culture;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0xB8")]
		private int? _maxDepth;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0xC0")]
		private bool _maxDepthSet;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0xC1")]
		private bool? _checkAdditionalContent;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185354", Offset = "0x185354")]
		private string _dateFormatString;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0xD0")]
		private bool _dateFormatStringSet;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185368", Offset = "0x185368")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185368", Offset = "0x185368")]
		private EventHandler<ErrorEventArgs> m_Error;

		[Token(Token = "0x17000024")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18EA10", Offset = "0x18EA10")]
		public virtual IReferenceResolver ReferenceResolver
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x22F1CF8", Offset = "0x22F1CF8", VA = "0x22F1CF8", Slot = "6")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188908", Offset = "0x188908")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public virtual ISerializationBinder SerializationBinder
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x22F1D6C", Offset = "0x22F1D6C", VA = "0x22F1D6C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18EA24", Offset = "0x18EA24")]
		public virtual ITraceWriter TraceWriter
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x22F1DE0", Offset = "0x22F1DE0", VA = "0x22F1DE0", Slot = "8")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18891C", Offset = "0x18891C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x22F1DE8", Offset = "0x22F1DE8", VA = "0x22F1DE8", Slot = "9")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188930", Offset = "0x188930")]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18EA38", Offset = "0x18EA38")]
		public virtual IEqualityComparer EqualityComparer
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x22F1DF0", Offset = "0x22F1DF0", VA = "0x22F1DF0", Slot = "10")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188944", Offset = "0x188944")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public virtual TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x22F1DF8", Offset = "0x22F1DF8", VA = "0x22F1DF8", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x22F1E5C", Offset = "0x22F1E5C", VA = "0x22F1E5C", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public virtual PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x22F1EC0", Offset = "0x22F1EC0", VA = "0x22F1EC0", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public virtual ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x22F1F24", Offset = "0x22F1F24", VA = "0x22F1F24", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public virtual MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x22F1F88", Offset = "0x22F1F88", VA = "0x22F1F88", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public virtual NullValueHandling NullValueHandling
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x22F1FEC", Offset = "0x22F1FEC", VA = "0x22F1FEC", Slot = "16")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x22F1FF4", Offset = "0x22F1FF4", VA = "0x22F1FF4", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public virtual DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x22F2058", Offset = "0x22F2058", VA = "0x22F2058", Slot = "18")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public virtual ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x22F20BC", Offset = "0x22F20BC", VA = "0x22F20BC", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public virtual ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x22F2120", Offset = "0x22F2120", VA = "0x22F2120", Slot = "20")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public virtual MetadataPropertyHandling MetadataPropertyHandling
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x22F2184", Offset = "0x22F2184", VA = "0x22F2184", Slot = "21")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x22F218C", Offset = "0x22F218C", VA = "0x22F218C", Slot = "22")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public virtual JsonConverterCollection Converters
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x22F21F0", Offset = "0x22F21F0", VA = "0x22F21F0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public virtual IContractResolver ContractResolver
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x22F2258", Offset = "0x22F2258", VA = "0x22F2258", Slot = "24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x22F2260", Offset = "0x22F2260", VA = "0x22F2260", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public virtual StreamingContext Context
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x22F232C", Offset = "0x22F232C", VA = "0x22F232C", Slot = "26")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x22F2338", Offset = "0x22F2338", VA = "0x22F2338", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public virtual bool CheckAdditionalContent
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x22F2340", Offset = "0x22F2340", VA = "0x22F2340", Slot = "28")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x14000001")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E640", Offset = "0x18E640")]
		public virtual event EventHandler<ErrorEventArgs> Error
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x22F1BB0", Offset = "0x22F1BB0", VA = "0x22F1BB0", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1888E8", Offset = "0x1888E8")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B304", Offset = "0x18B304")]
			add
			{
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x22F1C54", Offset = "0x22F1C54", VA = "0x22F1C54", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1888F8", Offset = "0x1888F8")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B374", Offset = "0x18B374")]
			remove
			{
			}
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x22F2380", Offset = "0x22F2380", VA = "0x22F2380")]
		public JsonSerializer()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x22F24D0", Offset = "0x22F24D0", VA = "0x22F24D0")]
		public static JsonSerializer Create()
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x22F2524", Offset = "0x22F2524", VA = "0x22F2524")]
		public static JsonSerializer Create([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B3E4", Offset = "0x18B3E4")] JsonSerializerSettings settings)
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x22F2C7C", Offset = "0x22F2C7C", VA = "0x22F2C7C")]
		public static JsonSerializer CreateDefault()
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x22F2594", Offset = "0x22F2594", VA = "0x22F2594")]
		private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x22F2D98", Offset = "0x22F2D98", VA = "0x22F2D98")]
		[DebuggerStepThrough]
		public void Populate(JsonReader reader, object target)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x22F2DA8", Offset = "0x22F2DA8", VA = "0x22F2DA8", Slot = "29")]
		internal virtual void PopulateInternal(JsonReader reader, object target)
		{
		}

		[Token(Token = "0x60000B5")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188968", Offset = "0x188968")]
		[DebuggerStepThrough]
		public T Deserialize<T>([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B3F8", Offset = "0x18B3F8")] JsonReader reader)
		{
			return (T)null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x22F3F94", Offset = "0x22F3F94", VA = "0x22F3F94")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1889A4", Offset = "0x1889A4")]
		[DebuggerStepThrough]
		public object Deserialize([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B40C", Offset = "0x18B40C")] JsonReader reader, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x22F3FA4", Offset = "0x22F3FA4", VA = "0x22F3FA4", Slot = "30")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1889E0", Offset = "0x1889E0")]
		internal virtual object DeserializeInternal([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B420", Offset = "0x18B420")] JsonReader reader, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x22F308C", Offset = "0x22F308C", VA = "0x22F308C")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1889F4", Offset = "0x1889F4")]
		private void SetupReader([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B434", Offset = "0x18B434")] JsonReader reader, out CultureInfo previousCulture, out DateTimeZoneHandling? previousDateTimeZoneHandling, out DateParseHandling? previousDateParseHandling, out FloatParseHandling? previousFloatParseHandling, out int? previousMaxDepth, out string previousDateFormatString)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x22F3CD4", Offset = "0x22F3CD4", VA = "0x22F3CD4")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188A08", Offset = "0x188A08")]
		private void ResetReader([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B448", Offset = "0x18B448")] JsonReader reader, CultureInfo previousCulture, DateTimeZoneHandling? previousDateTimeZoneHandling, DateParseHandling? previousDateParseHandling, FloatParseHandling? previousFloatParseHandling, int? previousMaxDepth, string previousDateFormatString)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x22F4688", Offset = "0x22F4688", VA = "0x22F4688")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188A1C", Offset = "0x188A1C")]
		public void Serialize([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B45C", Offset = "0x18B45C")] JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x22F4698", Offset = "0x22F4698", VA = "0x22F4698")]
		public void Serialize(JsonWriter jsonWriter, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B470", Offset = "0x18B470")] object value)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x22F3578", Offset = "0x22F3578", VA = "0x22F3578")]
		private TraceJsonReader CreateTraceJsonReader(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x22F46AC", Offset = "0x22F46AC", VA = "0x22F46AC", Slot = "31")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188A30", Offset = "0x188A30")]
		internal virtual void SerializeInternal([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B484", Offset = "0x18B484")] JsonWriter jsonWriter, object value, Type objectType)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x22F502C", Offset = "0x22F502C", VA = "0x22F502C")]
		internal IReferenceResolver GetReferenceResolver()
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x22F5094", Offset = "0x22F5094", VA = "0x22F5094")]
		internal JsonConverter GetMatchingConverter(Type type)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x22F509C", Offset = "0x22F509C", VA = "0x22F509C")]
		internal static JsonConverter GetMatchingConverter([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B498", Offset = "0x18B498")] IList<JsonConverter> converters, Type objectType)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x22F521C", Offset = "0x22F521C", VA = "0x22F521C")]
		internal void OnError(ErrorEventArgs e)
		{
		}
	}
}
