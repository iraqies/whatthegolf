using Il2CppDummyDll;

namespace Chronos
{
	[Token(Token = "0x200029B")]
	internal sealed class ActionOccurence : Occurrence
	{
		[Token(Token = "0x400112E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x372D4", Offset = "0x372D4")]
		private ForwardAction forward__BackingField;

		[Token(Token = "0x400112F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x372E4", Offset = "0x372E4")]
		private BackwardAction backward__BackingField;

		[Token(Token = "0x17000214")]
		private ForwardAction forward
		{
			[Token(Token = "0x6001139")]
			[Address(RVA = "0x12E9D84", Offset = "0x12E9D84", VA = "0x12E9D84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B7CC", Offset = "0x3B7CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600113A")]
			[Address(RVA = "0x12E9D8C", Offset = "0x12E9D8C", VA = "0x12E9D8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B7DC", Offset = "0x3B7DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000215")]
		private BackwardAction backward
		{
			[Token(Token = "0x600113B")]
			[Address(RVA = "0x12E9D94", Offset = "0x12E9D94", VA = "0x12E9D94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B7EC", Offset = "0x3B7EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600113C")]
			[Address(RVA = "0x12E9D9C", Offset = "0x12E9D9C", VA = "0x12E9D9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B7FC", Offset = "0x3B7FC")]
			set
			{
			}
		}

		[Token(Token = "0x600113D")]
		[Address(RVA = "0x12E9DA4", Offset = "0x12E9DA4", VA = "0x12E9DA4")]
		public ActionOccurence(ForwardAction forward, BackwardAction backward)
		{
		}

		[Token(Token = "0x600113E")]
		[Address(RVA = "0x12E9DDC", Offset = "0x12E9DDC", VA = "0x12E9DDC", Slot = "4")]
		public override void Forward()
		{
		}

		[Token(Token = "0x600113F")]
		[Address(RVA = "0x12E9DF8", Offset = "0x12E9DF8", VA = "0x12E9DF8", Slot = "5")]
		public override void Backward()
		{
		}
	}
}
