using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182CD4", Offset = "0x182CD4")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182CD4", Offset = "0x182CD4")]
	internal class TypeInformation
	{
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185690", Offset = "0x185690")]
		private readonly Type Type__BackingField;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1856A0", Offset = "0x1856A0")]
		private readonly PrimitiveTypeCode TypeCode__BackingField;

		[Token(Token = "0x17000059")]
		public Type Type
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x232776C", Offset = "0x232776C", VA = "0x232776C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188D3C", Offset = "0x188D3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public PrimitiveTypeCode TypeCode
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x2327774", Offset = "0x2327774", VA = "0x2327774")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188D4C", Offset = "0x188D4C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x232777C", Offset = "0x232777C", VA = "0x232777C")]
		public TypeInformation(Type type, PrimitiveTypeCode typeCode)
		{
		}
	}
}
