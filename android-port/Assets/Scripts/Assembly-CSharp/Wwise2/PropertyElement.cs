using Il2CppDummyDll;

namespace Wwise2
{
	[Token(Token = "0x2001014")]
	public class PropertyElement
	{
		[Token(Token = "0x40054C8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x551C4", Offset = "0x551C4")]
		private Name Name__BackingField;

		[Token(Token = "0x40054C9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x551D4", Offset = "0x551D4")]
		private long Value__BackingField;

		[Token(Token = "0x1700078F")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x7392C", Offset = "0x7392C")]
		public Name Name
		{
			[Token(Token = "0x60047F0")]
			[Address(RVA = "0x16287EC", Offset = "0x16287EC", VA = "0x16287EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EE14", Offset = "0x6EE14")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000790")]
		[Attribute(Name = "JsonConverterAttribute", RVA = "0x73964", Offset = "0x73964")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x73964", Offset = "0x73964")]
		public long Value
		{
			[Token(Token = "0x60047F1")]
			[Address(RVA = "0x16287F4", Offset = "0x16287F4", VA = "0x16287F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EE24", Offset = "0x6EE24")]
			get
			{
				return default;
			}
		}
	}
}
