using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x2000FB8")]
	public class FluffyProperty
	{
		[Token(Token = "0x40053C3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x548E4", Offset = "0x548E4")]
		private PurpleName Name__BackingField;

		[Token(Token = "0x40053C4")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x548F4", Offset = "0x548F4")]
		private TypeEnum Type__BackingField;

		[Token(Token = "0x40053C5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x54904", Offset = "0x54904")]
		private string Value__BackingField;

		[Token(Token = "0x17000781")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x735FC", Offset = "0x735FC")]
		public PurpleName Name
		{
			[Token(Token = "0x60047E2")]
			[Address(RVA = "0x146D078", Offset = "0x146D078", VA = "0x146D078")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED34", Offset = "0x6ED34")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000782")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x73634", Offset = "0x73634")]
		public string Value
		{
			[Token(Token = "0x60047E3")]
			[Address(RVA = "0x146D080", Offset = "0x146D080", VA = "0x146D080")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED44", Offset = "0x6ED44")]
			get
			{
				return null;
			}
		}
	}
}
