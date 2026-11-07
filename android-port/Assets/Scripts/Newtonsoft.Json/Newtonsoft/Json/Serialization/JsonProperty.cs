using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183BDC", Offset = "0x183BDC")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183BDC", Offset = "0x183BDC")]
	public class JsonProperty
	{
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x10")]
		internal Required? _required;

		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x18")]
		internal bool _hasExplicitDefaultValue;

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x20")]
		private object _defaultValue;

		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x28")]
		private bool _hasGeneratedDefaultValue;

		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x30")]
		private string _propertyName;

		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x38")]
		internal bool _skipPropertyNameEscape;

		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x40")]
		private Type _propertyType;

		[Token(Token = "0x40002A1")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1878D8", Offset = "0x1878D8")]
		private JsonContract PropertyContract__BackingField;

		[Token(Token = "0x40002A2")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1878E8", Offset = "0x1878E8")]
		private Type DeclaringType__BackingField;

		[Token(Token = "0x40002A3")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1878F8", Offset = "0x1878F8")]
		private int? Order__BackingField;

		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187908", Offset = "0x187908")]
		private string UnderlyingName__BackingField;

		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187918", Offset = "0x187918")]
		private IValueProvider ValueProvider__BackingField;

		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187928", Offset = "0x187928")]
		private IAttributeProvider AttributeProvider__BackingField;

		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187938", Offset = "0x187938")]
		private JsonConverter Converter__BackingField;

		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187948", Offset = "0x187948")]
		private bool Ignored__BackingField;

		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x81")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187958", Offset = "0x187958")]
		private bool Readable__BackingField;

		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x82")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187968", Offset = "0x187968")]
		private bool Writable__BackingField;

		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x83")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187978", Offset = "0x187978")]
		private bool HasMemberAttribute__BackingField;

		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187988", Offset = "0x187988")]
		private bool? IsReference__BackingField;

		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187998", Offset = "0x187998")]
		private NullValueHandling? NullValueHandling__BackingField;

		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1879A8", Offset = "0x1879A8")]
		private DefaultValueHandling? DefaultValueHandling__BackingField;

		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1879B8", Offset = "0x1879B8")]
		private ReferenceLoopHandling? ReferenceLoopHandling__BackingField;

		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1879C8", Offset = "0x1879C8")]
		private ObjectCreationHandling? ObjectCreationHandling__BackingField;

		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1879D8", Offset = "0x1879D8")]
		private TypeNameHandling? TypeNameHandling__BackingField;

		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1879E8", Offset = "0x1879E8")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1879E8", Offset = "0x1879E8")]
		private Predicate<object> ShouldSerialize__BackingField;

		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187A68", Offset = "0x187A68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187A68", Offset = "0x187A68")]
		private Predicate<object> ShouldDeserialize__BackingField;

		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187AE8", Offset = "0x187AE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187AE8", Offset = "0x187AE8")]
		private Predicate<object> GetIsSpecified__BackingField;

		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187B68", Offset = "0x187B68")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187B68", Offset = "0x187B68")]
		private Action<object, object> SetIsSpecified__BackingField;

		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187BF0", Offset = "0x187BF0")]
		private JsonConverter ItemConverter__BackingField;

		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187C00", Offset = "0x187C00")]
		private bool? ItemIsReference__BackingField;

		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187C10", Offset = "0x187C10")]
		private TypeNameHandling? ItemTypeNameHandling__BackingField;

		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187C20", Offset = "0x187C20")]
		private ReferenceLoopHandling? ItemReferenceLoopHandling__BackingField;

		[Token(Token = "0x170000BB")]
		internal JsonContract PropertyContract
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x22EB87C", Offset = "0x22EB87C", VA = "0x22EB87C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189D24", Offset = "0x189D24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x22EB884", Offset = "0x22EB884", VA = "0x22EB884")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189D34", Offset = "0x189D34")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public string PropertyName
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x22EB88C", Offset = "0x22EB88C", VA = "0x22EB88C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x22EB894", Offset = "0x22EB894", VA = "0x22EB894")]
			set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public Type DeclaringType
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x22EB920", Offset = "0x22EB920", VA = "0x22EB920")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189D44", Offset = "0x189D44")]
			get
			{
				return null;
			}
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x22EB928", Offset = "0x22EB928", VA = "0x22EB928")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189D54", Offset = "0x189D54")]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public int? Order
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x22EB930", Offset = "0x22EB930", VA = "0x22EB930")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189D64", Offset = "0x189D64")]
			get
			{
				return null;
			}
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x22EB938", Offset = "0x22EB938", VA = "0x22EB938")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189D74", Offset = "0x189D74")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public string UnderlyingName
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x22EB940", Offset = "0x22EB940", VA = "0x22EB940")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189D84", Offset = "0x189D84")]
			get
			{
				return null;
			}
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x22EB948", Offset = "0x22EB948", VA = "0x22EB948")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189D94", Offset = "0x189D94")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public IValueProvider ValueProvider
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x22EB950", Offset = "0x22EB950", VA = "0x22EB950")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189DA4", Offset = "0x189DA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x22EB958", Offset = "0x22EB958", VA = "0x22EB958")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189DB4", Offset = "0x189DB4")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public IAttributeProvider AttributeProvider
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x22EB960", Offset = "0x22EB960", VA = "0x22EB960")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189DC4", Offset = "0x189DC4")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public Type PropertyType
		{
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x22EB968", Offset = "0x22EB968", VA = "0x22EB968")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x22EB970", Offset = "0x22EB970", VA = "0x22EB970")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public JsonConverter Converter
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x22EBA00", Offset = "0x22EBA00", VA = "0x22EBA00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189DD4", Offset = "0x189DD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x22EBA08", Offset = "0x22EBA08", VA = "0x22EBA08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189DE4", Offset = "0x189DE4")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public bool Ignored
		{
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x22EBA10", Offset = "0x22EBA10", VA = "0x22EBA10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189DF4", Offset = "0x189DF4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x22EBA18", Offset = "0x22EBA18", VA = "0x22EBA18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189E04", Offset = "0x189E04")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public bool Readable
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x22EBA20", Offset = "0x22EBA20", VA = "0x22EBA20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189E14", Offset = "0x189E14")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x22EBA28", Offset = "0x22EBA28", VA = "0x22EBA28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189E24", Offset = "0x189E24")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public bool Writable
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x22EBA30", Offset = "0x22EBA30", VA = "0x22EBA30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189E34", Offset = "0x189E34")]
			get
			{
				return default;
			}
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x22EBA38", Offset = "0x22EBA38", VA = "0x22EBA38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189E44", Offset = "0x189E44")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public bool HasMemberAttribute
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x22EBA40", Offset = "0x22EBA40", VA = "0x22EBA40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189E54", Offset = "0x189E54")]
			get
			{
				return default;
			}
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x22EBA48", Offset = "0x22EBA48", VA = "0x22EBA48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189E64", Offset = "0x189E64")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public object DefaultValue
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x22EBA50", Offset = "0x22EBA50", VA = "0x22EBA50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x22EBA6C", Offset = "0x22EBA6C", VA = "0x22EBA6C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public Required Required
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x22EA7A0", Offset = "0x22EA7A0", VA = "0x22EA7A0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000CA")]
		public bool? IsReference
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x22EBB6C", Offset = "0x22EBB6C", VA = "0x22EBB6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189E74", Offset = "0x189E74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x22EBB74", Offset = "0x22EBB74", VA = "0x22EBB74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189E84", Offset = "0x189E84")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public NullValueHandling? NullValueHandling
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x22EBB7C", Offset = "0x22EBB7C", VA = "0x22EBB7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189E94", Offset = "0x189E94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x22EBB84", Offset = "0x22EBB84", VA = "0x22EBB84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189EA4", Offset = "0x189EA4")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public DefaultValueHandling? DefaultValueHandling
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x22EBB8C", Offset = "0x22EBB8C", VA = "0x22EBB8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189EB4", Offset = "0x189EB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x22EBB94", Offset = "0x22EBB94", VA = "0x22EBB94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189EC4", Offset = "0x189EC4")]
			set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public ReferenceLoopHandling? ReferenceLoopHandling
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x22EBB9C", Offset = "0x22EBB9C", VA = "0x22EBB9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189ED4", Offset = "0x189ED4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x22EBBA4", Offset = "0x22EBBA4", VA = "0x22EBBA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189EE4", Offset = "0x189EE4")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public ObjectCreationHandling? ObjectCreationHandling
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x22EBBAC", Offset = "0x22EBBAC", VA = "0x22EBBAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189EF4", Offset = "0x189EF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x22EBBB4", Offset = "0x22EBBB4", VA = "0x22EBBB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189F04", Offset = "0x189F04")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public TypeNameHandling? TypeNameHandling
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x22EBBBC", Offset = "0x22EBBBC", VA = "0x22EBBBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189F14", Offset = "0x189F14")]
			get
			{
				return null;
			}
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x22EBBC4", Offset = "0x22EBBC4", VA = "0x22EBBC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189F24", Offset = "0x189F24")]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F4D4", Offset = "0x18F4D4")]
		public Predicate<object> ShouldSerialize
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x22EBBCC", Offset = "0x22EBBCC", VA = "0x22EBBCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189F34", Offset = "0x189F34")]
			get
			{
				return null;
			}
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x22EBBD4", Offset = "0x22EBBD4", VA = "0x22EBBD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189F44", Offset = "0x189F44")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D0C8", Offset = "0x18D0C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F544", Offset = "0x18F544")]
		public Predicate<object> ShouldDeserialize
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x22EBBDC", Offset = "0x22EBBDC", VA = "0x22EBBDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189F54", Offset = "0x189F54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D2")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F5B4", Offset = "0x18F5B4")]
		public Predicate<object> GetIsSpecified
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x22EBBE4", Offset = "0x22EBBE4", VA = "0x22EBBE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189F64", Offset = "0x189F64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x22EBBEC", Offset = "0x22EBBEC", VA = "0x22EBBEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189F74", Offset = "0x189F74")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D138", Offset = "0x18D138")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F624", Offset = "0x18F624")]
		public Action<object, object> SetIsSpecified
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x22EBBF4", Offset = "0x22EBBF4", VA = "0x22EBBF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189F84", Offset = "0x189F84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x22EBBFC", Offset = "0x22EBBFC", VA = "0x22EBBFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189F94", Offset = "0x189F94")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D1A8", Offset = "0x18D1A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public JsonConverter ItemConverter
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x22EBC5C", Offset = "0x22EBC5C", VA = "0x22EBC5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189FB8", Offset = "0x189FB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x22EBC64", Offset = "0x22EBC64", VA = "0x22EBC64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189FC8", Offset = "0x189FC8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public bool? ItemIsReference
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x22EBC6C", Offset = "0x22EBC6C", VA = "0x22EBC6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189FD8", Offset = "0x189FD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x22EBC74", Offset = "0x22EBC74", VA = "0x22EBC74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189FE8", Offset = "0x189FE8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public TypeNameHandling? ItemTypeNameHandling
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x22EBC7C", Offset = "0x22EBC7C", VA = "0x22EBC7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189FF8", Offset = "0x189FF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x22EBC84", Offset = "0x22EBC84", VA = "0x22EBC84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18A008", Offset = "0x18A008")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public ReferenceLoopHandling? ItemReferenceLoopHandling
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x22EBC8C", Offset = "0x22EBC8C", VA = "0x22EBC8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18A018", Offset = "0x18A018")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x22EBC94", Offset = "0x22EBC94", VA = "0x22EBC94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18A028", Offset = "0x18A028")]
			set
			{
			}
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x22EBA7C", Offset = "0x22EBA7C", VA = "0x22EBA7C")]
		internal object GetResolvedDefaultValue()
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x22EBC04", Offset = "0x22EBC04", VA = "0x22EBC04", Slot = "3")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189FA4", Offset = "0x189FA4")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x22EBC9C", Offset = "0x22EBC9C", VA = "0x22EBC9C")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A038", Offset = "0x18A038")]
		internal void WritePropertyName(JsonWriter writer)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x22EBCF8", Offset = "0x22EBCF8", VA = "0x22EBCF8")]
		public JsonProperty()
		{
		}
	}
}
