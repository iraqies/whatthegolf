using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1838C4", Offset = "0x1838C4")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1838C4", Offset = "0x1838C4")]
	public class ErrorContext
	{
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186BA8", Offset = "0x186BA8")]
		private bool Traced__BackingField;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186BB8", Offset = "0x186BB8")]
		private readonly Exception Error__BackingField;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186BC8", Offset = "0x186BC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186BC8", Offset = "0x186BC8")]
		private readonly object OriginalObject__BackingField;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186C04", Offset = "0x186C04")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186C04", Offset = "0x186C04")]
		private readonly object Member__BackingField;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186C40", Offset = "0x186C40")]
		private readonly string Path__BackingField;

		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186C50", Offset = "0x186C50")]
		private bool Handled__BackingField;

		[Token(Token = "0x17000082")]
		internal bool Traced
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x22C6D88", Offset = "0x22C6D88", VA = "0x22C6D88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189700", Offset = "0x189700")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x22C6D90", Offset = "0x22C6D90", VA = "0x22C6D90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189710", Offset = "0x189710")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public Exception Error
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x22C6D98", Offset = "0x22C6D98", VA = "0x22C6D98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189720", Offset = "0x189720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public bool Handled
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x22C6DA0", Offset = "0x22C6DA0", VA = "0x22C6DA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189730", Offset = "0x189730")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x22C6D3C", Offset = "0x22C6D3C", VA = "0x22C6D3C")]
		internal ErrorContext([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CB58", Offset = "0x18CB58")] object originalObject, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CB6C", Offset = "0x18CB6C")] object member, string path, Exception error)
		{
		}
	}
}
