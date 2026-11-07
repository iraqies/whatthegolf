using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182894", Offset = "0x182894")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182894", Offset = "0x182894")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x182894", Offset = "0x182894")]
	public sealed class JsonPropertyAttribute : Attribute
	{
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x10")]
		internal NullValueHandling? _nullValueHandling;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x18")]
		internal DefaultValueHandling? _defaultValueHandling;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x20")]
		internal ReferenceLoopHandling? _referenceLoopHandling;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x28")]
		internal ObjectCreationHandling? _objectCreationHandling;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x30")]
		internal TypeNameHandling? _typeNameHandling;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x38")]
		internal bool? _isReference;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x3C")]
		internal int? _order;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x44")]
		internal Required? _required;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x4C")]
		internal bool? _itemIsReference;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x50")]
		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x58")]
		internal TypeNameHandling? _itemTypeNameHandling;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1850FC", Offset = "0x1850FC")]
		private Type ItemConverterType__BackingField;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18510C", Offset = "0x18510C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18510C", Offset = "0x18510C")]
		private object[] ItemConverterParameters__BackingField;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18518C", Offset = "0x18518C")]
		private Type NamingStrategyType__BackingField;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18519C", Offset = "0x18519C")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18519C", Offset = "0x18519C")]
		private object[] NamingStrategyParameters__BackingField;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18521C", Offset = "0x18521C")]
		private string PropertyName__BackingField;

		[Token(Token = "0x17000010")]
		public Type ItemConverterType
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x22EBD00", Offset = "0x22EBD00", VA = "0x22EBD00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1887CC", Offset = "0x1887CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E908", Offset = "0x18E908")]
		public object[] ItemConverterParameters
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x22EBD08", Offset = "0x22EBD08", VA = "0x22EBD08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1887DC", Offset = "0x1887DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public Type NamingStrategyType
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x22EBD10", Offset = "0x22EBD10", VA = "0x22EBD10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1887EC", Offset = "0x1887EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E978", Offset = "0x18E978")]
		public object[] NamingStrategyParameters
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x22EBD18", Offset = "0x22EBD18", VA = "0x22EBD18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1887FC", Offset = "0x1887FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public NullValueHandling NullValueHandling
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x22EBD20", Offset = "0x22EBD20", VA = "0x22EBD20")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public string PropertyName
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x22EBD94", Offset = "0x22EBD94", VA = "0x22EBD94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18880C", Offset = "0x18880C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x22EBD9C", Offset = "0x22EBD9C", VA = "0x22EBD9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18881C", Offset = "0x18881C")]
			set
			{
			}
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x22EBDA4", Offset = "0x22EBDA4", VA = "0x22EBDA4")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18882C", Offset = "0x18882C")]
		public JsonPropertyAttribute(string propertyName)
		{
		}
	}
}
