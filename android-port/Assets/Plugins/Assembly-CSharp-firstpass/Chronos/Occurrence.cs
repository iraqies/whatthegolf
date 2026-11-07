using Il2CppDummyDll;

namespace Chronos
{
	[Token(Token = "0x20002A0")]
	public abstract class Occurrence
	{
		[Token(Token = "0x4001134")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37334", Offset = "0x37334")]
		private float time__BackingField;

		[Token(Token = "0x4001135")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37344", Offset = "0x37344")]
		private bool repeatable__BackingField;

		[Token(Token = "0x1700021A")]
		public float time
		{
			[Token(Token = "0x6001156")]
			[Address(RVA = "0x13BCD38", Offset = "0x13BCD38", VA = "0x13BCD38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B88C", Offset = "0x3B88C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001157")]
			[Address(RVA = "0x13BCD40", Offset = "0x13BCD40", VA = "0x13BCD40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B89C", Offset = "0x3B89C")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700021B")]
		public bool repeatable
		{
			[Token(Token = "0x6001158")]
			[Address(RVA = "0x13BCD48", Offset = "0x13BCD48", VA = "0x13BCD48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B8AC", Offset = "0x3B8AC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001159")]
			[Address(RVA = "0x13BCD50", Offset = "0x13BCD50", VA = "0x13BCD50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B8BC", Offset = "0x3B8BC")]
			internal set
			{
			}
		}

		[Token(Token = "0x600115A")]
		public abstract void Forward();

		[Token(Token = "0x600115B")]
		public abstract void Backward();

		[Token(Token = "0x600115C")]
		[Address(RVA = "0x13BCD58", Offset = "0x13BCD58", VA = "0x13BCD58")]
		protected Occurrence()
		{
		}
	}
}
