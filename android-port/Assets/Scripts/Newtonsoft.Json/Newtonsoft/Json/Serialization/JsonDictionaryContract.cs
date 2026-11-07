using System;
using System.Collections;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183A9C", Offset = "0x183A9C")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183A9C", Offset = "0x183A9C")]
	public class JsonDictionaryContract : JsonContainerContract
	{
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18728C", Offset = "0x18728C")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18728C", Offset = "0x18728C")]
		private Func<string, string> DictionaryKeyResolver__BackingField;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187314", Offset = "0x187314")]
		private readonly Type DictionaryKeyType__BackingField;

		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187324", Offset = "0x187324")]
		private readonly Type DictionaryValueType__BackingField;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187334", Offset = "0x187334")]
		private JsonContract KeyContract__BackingField;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0xE0")]
		private readonly Type _genericCollectionDefinitionType;

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0xE8")]
		private Type _genericWrapperType;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187344", Offset = "0x187344")]
		private ObjectConstructor<object> _genericWrapperCreator;

		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1873B4", Offset = "0x1873B4")]
		private Func<object> _genericTemporaryDictionaryCreator;

		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187424", Offset = "0x187424")]
		private readonly bool ShouldCreateWrapper__BackingField;

		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x108")]
		private readonly ConstructorInfo _parameterizedConstructor;

		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187434", Offset = "0x187434")]
		private ObjectConstructor<object> _overrideCreator;

		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1874A4", Offset = "0x1874A4")]
		private ObjectConstructor<object> _parameterizedCreator;

		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x187514", Offset = "0x187514")]
		private bool HasParameterizedCreator__BackingField;

		[Token(Token = "0x170000A1")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F114", Offset = "0x18F114")]
		public Func<string, string> DictionaryKeyResolver
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x22E8024", Offset = "0x22E8024", VA = "0x22E8024")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189A68", Offset = "0x189A68")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x22E802C", Offset = "0x22E802C", VA = "0x22E802C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189A78", Offset = "0x189A78")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CD64", Offset = "0x18CD64")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public Type DictionaryKeyType
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x22E8034", Offset = "0x22E8034", VA = "0x22E8034")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189A88", Offset = "0x189A88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		public Type DictionaryValueType
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x22E803C", Offset = "0x22E803C", VA = "0x22E803C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189A98", Offset = "0x189A98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		internal JsonContract KeyContract
		{
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x22E8044", Offset = "0x22E8044", VA = "0x22E8044")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189AA8", Offset = "0x189AA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x22E804C", Offset = "0x22E804C", VA = "0x22E804C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189AB8", Offset = "0x189AB8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		internal bool ShouldCreateWrapper
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x22E8054", Offset = "0x22E8054", VA = "0x22E8054")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189AC8", Offset = "0x189AC8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000A6")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F18C", Offset = "0x18F18C")]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x22E805C", Offset = "0x22E805C", VA = "0x22E805C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F1FC", Offset = "0x18F1FC")]
		public ObjectConstructor<object> OverrideCreator
		{
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x22E8134", Offset = "0x22E8134", VA = "0x22E8134")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x22E813C", Offset = "0x22E813C", VA = "0x22E813C")]
			[param: AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CDDC", Offset = "0x18CDDC")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public bool HasParameterizedCreator
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x22E8144", Offset = "0x22E8144", VA = "0x22E8144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189AD8", Offset = "0x189AD8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x22E814C", Offset = "0x22E814C", VA = "0x22E814C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189AE8", Offset = "0x189AE8")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		internal bool HasParameterizedCreatorInternal
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x22E8154", Offset = "0x22E8154", VA = "0x22E8154")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x22E81E8", Offset = "0x22E81E8", VA = "0x22E81E8")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189AF8", Offset = "0x189AF8")]
		public JsonDictionaryContract(Type underlyingType)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x22E8D3C", Offset = "0x22E8D3C", VA = "0x22E8D3C")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189B0C", Offset = "0x189B0C")]
		internal IWrappedDictionary CreateWrapper(object dictionary)
		{
			return null;
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x22E8FF0", Offset = "0x22E8FF0", VA = "0x22E8FF0")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x189B20", Offset = "0x189B20")]
		internal IDictionary CreateTemporaryDictionary()
		{
			return null;
		}
	}
}
