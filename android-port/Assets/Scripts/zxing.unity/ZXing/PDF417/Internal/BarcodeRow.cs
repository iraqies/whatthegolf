using Il2CppDummyDll;

namespace ZXing.PDF417.Internal
{
	[Token(Token = "0x200002F")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x21EE58", Offset = "0x21EE58")]
	internal sealed class BarcodeRow
	{
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x10")]
		private readonly sbyte[] row;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x18")]
		private int currentLocation;

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2E9FAFC", Offset = "0x2E9FAFC", VA = "0x2E9FAFC")]
		internal BarcodeRow(int width)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2E9FE30", Offset = "0x2E9FE30", VA = "0x2E9FE30")]
		internal void set(int x, bool black)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2E9FE6C", Offset = "0x2E9FE6C", VA = "0x2E9FE6C")]
		internal void addBar(bool black, int width)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2E9FD60", Offset = "0x2E9FD60", VA = "0x2E9FD60")]
		internal sbyte[] getScaledRow(int scale)
		{
			return null;
		}
	}
}
