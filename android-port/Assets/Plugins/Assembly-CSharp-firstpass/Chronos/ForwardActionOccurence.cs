using Il2CppDummyDll;

namespace Chronos
{
	[Token(Token = "0x200029C")]
	internal sealed class ForwardActionOccurence : Occurrence
	{
		[Token(Token = "0x4001130")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x372F4", Offset = "0x372F4")]
		private ForwardAction forward__BackingField;

		[Token(Token = "0x17000216")]
		private ForwardAction forward
		{
			[Token(Token = "0x6001140")]
			[Address(RVA = "0x13739B8", Offset = "0x13739B8", VA = "0x13739B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B80C", Offset = "0x3B80C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001141")]
			[Address(RVA = "0x13739C0", Offset = "0x13739C0", VA = "0x13739C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B81C", Offset = "0x3B81C")]
			set
			{
			}
		}

		[Token(Token = "0x6001142")]
		[Address(RVA = "0x13739C8", Offset = "0x13739C8", VA = "0x13739C8")]
		public ForwardActionOccurence(ForwardAction forward)
		{
		}

		[Token(Token = "0x6001143")]
		[Address(RVA = "0x13739F4", Offset = "0x13739F4", VA = "0x13739F4", Slot = "4")]
		public override void Forward()
		{
		}

		[Token(Token = "0x6001144")]
		[Address(RVA = "0x1373A0C", Offset = "0x1373A0C", VA = "0x1373A0C", Slot = "5")]
		public override void Backward()
		{
		}
	}
}
