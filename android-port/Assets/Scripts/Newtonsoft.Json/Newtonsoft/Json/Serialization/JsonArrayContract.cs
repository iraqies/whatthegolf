using System;
using System.Collections;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1839BC", Offset = "0x1839BC")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1839BC", Offset = "0x1839BC")]
	public class JsonArrayContract : JsonContainerContract
	{
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186CAC", Offset = "0x186CAC")]
		private readonly Type CollectionItemType__BackingField;

		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186CBC", Offset = "0x186CBC")]
		private readonly bool IsMultidimensionalArray__BackingField;

		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0xD0")]
		private readonly Type _genericCollectionDefinitionType;

		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0xD8")]
		private Type _genericWrapperType;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186CCC", Offset = "0x186CCC")]
		private ObjectConstructor<object> _genericWrapperCreator;

		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186D3C", Offset = "0x186D3C")]
		private Func<object> _genericTemporaryCollectionCreator;

		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186DAC", Offset = "0x186DAC")]
		private readonly bool IsArray__BackingField;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0xF1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186DBC", Offset = "0x186DBC")]
		private readonly bool ShouldCreateWrapper__BackingField;

		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0xF2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186DCC", Offset = "0x186DCC")]
		private bool CanDeserialize__BackingField;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0xF8")]
		private readonly ConstructorInfo _parameterizedConstructor;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186DDC", Offset = "0x186DDC")]
		private ObjectConstructor<object> _parameterizedCreator;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186E4C", Offset = "0x186E4C")]
		private ObjectConstructor<object> _overrideCreator;

		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186EBC", Offset = "0x186EBC")]
		private bool HasParameterizedCreator__BackingField;

		[Token(Token = "0x17000086")]
		public Type CollectionItemType
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x22E49D4", Offset = "0x22E49D4", VA = "0x22E49D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189754", Offset = "0x189754")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public bool IsMultidimensionalArray
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x22E49DC", Offset = "0x22E49DC", VA = "0x22E49DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189764", Offset = "0x189764")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000088")]
		internal bool IsArray
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x22E49E4", Offset = "0x22E49E4", VA = "0x22E49E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189774", Offset = "0x189774")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000089")]
		internal bool ShouldCreateWrapper
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x22E49EC", Offset = "0x22E49EC", VA = "0x22E49EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189784", Offset = "0x189784")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008A")]
		internal bool CanDeserialize
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x22E49F4", Offset = "0x22E49F4", VA = "0x22E49F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189794", Offset = "0x189794")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x22E49FC", Offset = "0x22E49FC", VA = "0x22E49FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1897A4", Offset = "0x1897A4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18EF9C", Offset = "0x18EF9C")]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x22E4A04", Offset = "0x22E4A04", VA = "0x22E4A04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F00C", Offset = "0x18F00C")]
		public ObjectConstructor<object> OverrideCreator
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x22E4ADC", Offset = "0x22E4ADC", VA = "0x22E4ADC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x22E4AE4", Offset = "0x22E4AE4", VA = "0x22E4AE4")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CBE4", Offset = "0x18CBE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public bool HasParameterizedCreator
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x22E4AF4", Offset = "0x22E4AF4", VA = "0x22E4AF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1897B4", Offset = "0x1897B4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x22E4AFC", Offset = "0x22E4AFC", VA = "0x22E4AFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1897C4", Offset = "0x1897C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		internal bool HasParameterizedCreatorInternal
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x22E4B04", Offset = "0x22E4B04", VA = "0x22E4B04")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x22E4B98", Offset = "0x22E4B98", VA = "0x22E4B98")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1897D4", Offset = "0x1897D4")]
		public JsonArrayContract(Type underlyingType)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x22E5ED0", Offset = "0x22E5ED0", VA = "0x22E5ED0")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1897E8", Offset = "0x1897E8")]
		internal IWrappedCollection CreateWrapper(object list)
		{
			return null;
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x22E62E4", Offset = "0x22E62E4", VA = "0x22E62E4")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1897FC", Offset = "0x1897FC")]
		internal IList CreateTemporaryCollection()
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x22E5D44", Offset = "0x22E5D44", VA = "0x22E5D44")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189810", Offset = "0x189810")]
		private void StoreFSharpListCreatorIfNecessary(Type underlyingType)
		{
		}
	}
}
