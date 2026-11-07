using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x2000FBE")]
	public class ReferenceElement
	{
		[Token(Token = "0x40053D0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x549B4", Offset = "0x549B4")]
		private Ref ObjectRef__BackingField;

		[Token(Token = "0x40053D1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x549C4", Offset = "0x549C4")]
		private ReferenceName Name__BackingField;

		[Token(Token = "0x17000789")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x737CC", Offset = "0x737CC")]
		public Ref ObjectRef
		{
			[Token(Token = "0x60047EA")]
			[Address(RVA = "0x16468B4", Offset = "0x16468B4", VA = "0x16468B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EDB4", Offset = "0x6EDB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700078A")]
		[Attribute(Name = "JsonPropertyAttribute", RVA = "0x73804", Offset = "0x73804")]
		public ReferenceName Name
		{
			[Token(Token = "0x60047EB")]
			[Address(RVA = "0x16468BC", Offset = "0x16468BC", VA = "0x16468BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EDC4", Offset = "0x6EDC4")]
			get
			{
				return default;
			}
		}
	}
}
