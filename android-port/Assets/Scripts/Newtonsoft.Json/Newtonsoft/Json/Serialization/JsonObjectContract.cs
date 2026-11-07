using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183B5C", Offset = "0x183B5C")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183B5C", Offset = "0x183B5C")]
	public class JsonObjectContract : JsonContainerContract
	{
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1876C4", Offset = "0x1876C4")]
		private MemberSerialization MemberSerialization__BackingField;

		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1876D4", Offset = "0x1876D4")]
		private MissingMemberHandling? MissingMemberHandling__BackingField;

		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1876E4", Offset = "0x1876E4")]
		private Required? ItemRequired__BackingField;

		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1876F4", Offset = "0x1876F4")]
		private NullValueHandling? ItemNullValueHandling__BackingField;

		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187704", Offset = "0x187704")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187704", Offset = "0x187704")]
		private readonly JsonPropertyCollection Properties__BackingField;

		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187740", Offset = "0x187740")]
		private ExtensionDataSetter ExtensionDataSetter__BackingField;

		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187750", Offset = "0x187750")]
		private ExtensionDataGetter ExtensionDataGetter__BackingField;

		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187760", Offset = "0x187760")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187760", Offset = "0x187760")]
		private Func<string, string> ExtensionDataNameResolver__BackingField;

		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0xF8")]
		internal bool ExtensionDataIsJToken;

		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0xF9")]
		private bool? _hasRequiredOrDefaultValueProperties;

		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1877E8", Offset = "0x1877E8")]
		private ObjectConstructor<object> _overrideCreator;

		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187858", Offset = "0x187858")]
		private ObjectConstructor<object> _parameterizedCreator;

		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x110")]
		private JsonPropertyCollection _creatorParameters;

		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x118")]
		private Type _extensionDataValueType;

		[Token(Token = "0x170000AD")]
		public MemberSerialization MemberSerialization
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x22E9FF8", Offset = "0x22E9FF8", VA = "0x22E9FF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189BAC", Offset = "0x189BAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x22EA000", Offset = "0x22EA000", VA = "0x22EA000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189BBC", Offset = "0x189BBC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public MissingMemberHandling? MissingMemberHandling
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x22EA008", Offset = "0x22EA008", VA = "0x22EA008")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189BCC", Offset = "0x189BCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x22EA010", Offset = "0x22EA010", VA = "0x22EA010")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189BDC", Offset = "0x189BDC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public Required? ItemRequired
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x22EA018", Offset = "0x22EA018", VA = "0x22EA018")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189BEC", Offset = "0x189BEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x22EA020", Offset = "0x22EA020", VA = "0x22EA020")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189BFC", Offset = "0x189BFC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public NullValueHandling? ItemNullValueHandling
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x22EA028", Offset = "0x22EA028", VA = "0x22EA028")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189C0C", Offset = "0x189C0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x22EA030", Offset = "0x22EA030", VA = "0x22EA030")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189C1C", Offset = "0x189C1C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F354", Offset = "0x18F354")]
		public JsonPropertyCollection Properties
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x22EA038", Offset = "0x22EA038", VA = "0x22EA038")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189C2C", Offset = "0x189C2C")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189C2C", Offset = "0x189C2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F368", Offset = "0x18F368")]
		public JsonPropertyCollection CreatorParameters
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x22EA040", Offset = "0x22EA040", VA = "0x22EA040")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189C68", Offset = "0x189C68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F37C", Offset = "0x18F37C")]
		public ObjectConstructor<object> OverrideCreator
		{
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x22EA220", Offset = "0x22EA220", VA = "0x22EA220")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x22EA228", Offset = "0x22EA228", VA = "0x22EA228")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CF70", Offset = "0x18CF70")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F3EC", Offset = "0x18F3EC")]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x22EA230", Offset = "0x22EA230", VA = "0x22EA230")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x22EA238", Offset = "0x22EA238", VA = "0x22EA238")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CFE0", Offset = "0x18CFE0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public ExtensionDataSetter ExtensionDataSetter
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x22EA240", Offset = "0x22EA240", VA = "0x22EA240")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189C7C", Offset = "0x189C7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x22EA248", Offset = "0x22EA248", VA = "0x22EA248")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189C8C", Offset = "0x189C8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public ExtensionDataGetter ExtensionDataGetter
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x22EA250", Offset = "0x22EA250", VA = "0x22EA250")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189C9C", Offset = "0x189C9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x22EA258", Offset = "0x22EA258", VA = "0x22EA258")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189CAC", Offset = "0x189CAC")]
			set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public Type ExtensionDataValueType
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x22EA260", Offset = "0x22EA260", VA = "0x22EA260")]
			set
			{
			}
		}

		[Token(Token = "0x170000B8")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F45C", Offset = "0x18F45C")]
		public Func<string, string> ExtensionDataNameResolver
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x22EA358", Offset = "0x22EA358", VA = "0x22EA358")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189CBC", Offset = "0x189CBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x22EA360", Offset = "0x22EA360", VA = "0x22EA360")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189CCC", Offset = "0x189CCC")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18D050", Offset = "0x18D050")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		internal bool HasRequiredOrDefaultValueProperties
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x22EA368", Offset = "0x22EA368", VA = "0x22EA368")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x22EA7E0", Offset = "0x22EA7E0", VA = "0x22EA7E0")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189CDC", Offset = "0x189CDC")]
		public JsonObjectContract(Type underlyingType)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x22EA864", Offset = "0x22EA864", VA = "0x22EA864")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189CF0", Offset = "0x189CF0")]
		internal object GetUninitializedObject()
		{
			return null;
		}
	}
}
