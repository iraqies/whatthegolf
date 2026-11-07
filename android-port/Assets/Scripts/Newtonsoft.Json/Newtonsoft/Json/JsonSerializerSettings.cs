using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182A3C", Offset = "0x182A3C")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182A3C", Offset = "0x182A3C")]
	public class JsonSerializerSettings
	{
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly StreamingContext DefaultContext;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1853E8", Offset = "0x1853E8")]
		internal static readonly CultureInfo DefaultCulture;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x10")]
		internal Formatting? _formatting;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x18")]
		internal DateFormatHandling? _dateFormatHandling;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x20")]
		internal DateTimeZoneHandling? _dateTimeZoneHandling;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x28")]
		internal DateParseHandling? _dateParseHandling;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x30")]
		internal FloatFormatHandling? _floatFormatHandling;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x38")]
		internal FloatParseHandling? _floatParseHandling;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x40")]
		internal StringEscapeHandling? _stringEscapeHandling;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x48")]
		internal CultureInfo _culture;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x50")]
		internal bool? _checkAdditionalContent;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x54")]
		internal int? _maxDepth;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x5C")]
		internal bool _maxDepthSet;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x60")]
		internal string _dateFormatString;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x68")]
		internal bool _dateFormatStringSet;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x6C")]
		internal TypeNameAssemblyFormatHandling? _typeNameAssemblyFormatHandling;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x74")]
		internal DefaultValueHandling? _defaultValueHandling;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x7C")]
		internal PreserveReferencesHandling? _preserveReferencesHandling;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x84")]
		internal NullValueHandling? _nullValueHandling;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x8C")]
		internal ObjectCreationHandling? _objectCreationHandling;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x94")]
		internal MissingMemberHandling? _missingMemberHandling;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x9C")]
		internal ReferenceLoopHandling? _referenceLoopHandling;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0xA8")]
		internal StreamingContext? _context;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0xC0")]
		internal ConstructorHandling? _constructorHandling;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0xC8")]
		internal TypeNameHandling? _typeNameHandling;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0xD0")]
		internal MetadataPropertyHandling? _metadataPropertyHandling;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1853FC", Offset = "0x1853FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1853FC", Offset = "0x1853FC")]
		private IList<JsonConverter> Converters__BackingField;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185438", Offset = "0x185438")]
		private IContractResolver ContractResolver__BackingField;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185448", Offset = "0x185448")]
		private IEqualityComparer EqualityComparer__BackingField;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185458", Offset = "0x185458")]
		private Func<IReferenceResolver> ReferenceResolverProvider__BackingField;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185468", Offset = "0x185468")]
		private ITraceWriter TraceWriter__BackingField;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185478", Offset = "0x185478")]
		private ISerializationBinder SerializationBinder__BackingField;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185488", Offset = "0x185488")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185488", Offset = "0x185488")]
		private EventHandler<ErrorEventArgs> Error__BackingField;

		[Token(Token = "0x17000036")]
		public ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x230AAFC", Offset = "0x230AAFC", VA = "0x230AAFC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000037")]
		public MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x230AB3C", Offset = "0x230AB3C", VA = "0x230AB3C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000038")]
		public ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x230AB7C", Offset = "0x230AB7C", VA = "0x230AB7C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000039")]
		public NullValueHandling NullValueHandling
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x230ABBC", Offset = "0x230ABBC", VA = "0x230ABBC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003A")]
		public DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x230ABFC", Offset = "0x230ABFC", VA = "0x230ABFC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003B")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18EA4C", Offset = "0x18EA4C")]
		public IList<JsonConverter> Converters
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x230AC3C", Offset = "0x230AC3C", VA = "0x230AC3C")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188A44", Offset = "0x188A44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188A44", Offset = "0x188A44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public PreserveReferencesHandling PreserveReferencesHandling
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x230AC44", Offset = "0x230AC44", VA = "0x230AC44")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003D")]
		public TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x230AC84", Offset = "0x230AC84", VA = "0x230AC84")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003E")]
		public MetadataPropertyHandling MetadataPropertyHandling
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x230ACC4", Offset = "0x230ACC4", VA = "0x230ACC4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003F")]
		public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x230AD04", Offset = "0x230AD04", VA = "0x230AD04")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000040")]
		public ConstructorHandling ConstructorHandling
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x230AD44", Offset = "0x230AD44", VA = "0x230AD44")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000041")]
		public IContractResolver ContractResolver
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x230AD84", Offset = "0x230AD84", VA = "0x230AD84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188A80", Offset = "0x188A80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public IEqualityComparer EqualityComparer
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x230AD8C", Offset = "0x230AD8C", VA = "0x230AD8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188A90", Offset = "0x188A90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public Func<IReferenceResolver> ReferenceResolverProvider
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x230AD94", Offset = "0x230AD94", VA = "0x230AD94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188AA0", Offset = "0x188AA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public ITraceWriter TraceWriter
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x230AD9C", Offset = "0x230AD9C", VA = "0x230AD9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188AB0", Offset = "0x188AB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public ISerializationBinder SerializationBinder
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x230ADA4", Offset = "0x230ADA4", VA = "0x230ADA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188AC0", Offset = "0x188AC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18EA60", Offset = "0x18EA60")]
		public EventHandler<ErrorEventArgs> Error
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x230ADAC", Offset = "0x230ADAC", VA = "0x230ADAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188AD0", Offset = "0x188AD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public StreamingContext Context
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x230ADB4", Offset = "0x230ADB4", VA = "0x230ADB4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x230AE50", Offset = "0x230AE50", VA = "0x230AE50")]
		static JsonSerializerSettings()
		{
		}
	}
}
