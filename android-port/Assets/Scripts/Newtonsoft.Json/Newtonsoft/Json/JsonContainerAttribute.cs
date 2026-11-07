using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182598", Offset = "0x182598")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x182598", Offset = "0x182598")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182598", Offset = "0x182598")]
	public abstract class JsonContainerAttribute : Attribute
	{
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x184EB8", Offset = "0x184EB8")]
		private Type ItemConverterType__BackingField;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x184EC8", Offset = "0x184EC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x184EC8", Offset = "0x184EC8")]
		private object[] ItemConverterParameters__BackingField;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x184F48", Offset = "0x184F48")]
		private NamingStrategy NamingStrategyInstance__BackingField;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x28")]
		internal bool? _isReference;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x2A")]
		internal bool? _itemIsReference;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x2C")]
		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x34")]
		internal TypeNameHandling? _itemTypeNameHandling;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x40")]
		private Type _namingStrategyType;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x184F58", Offset = "0x184F58")]
		private object[] _namingStrategyParameters;

		[Token(Token = "0x17000003")]
		public Type ItemConverterType
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x22E6588", Offset = "0x22E6588", VA = "0x22E6588")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188724", Offset = "0x188724")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E748", Offset = "0x18E748")]
		public object[] ItemConverterParameters
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x22E6590", Offset = "0x22E6590", VA = "0x22E6590")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188734", Offset = "0x188734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		public Type NamingStrategyType
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x22E6598", Offset = "0x22E6598", VA = "0x22E6598")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E7B8", Offset = "0x18E7B8")]
		public object[] NamingStrategyParameters
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x22E65A0", Offset = "0x22E65A0", VA = "0x22E65A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		internal NamingStrategy NamingStrategyInstance
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x22E65A8", Offset = "0x22E65A8", VA = "0x22E65A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188744", Offset = "0x188744")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x22E65B0", Offset = "0x22E65B0", VA = "0x22E65B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188754", Offset = "0x188754")]
			set
			{
			}
		}
	}
}
