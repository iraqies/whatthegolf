using Il2CppDummyDll;

namespace ZXing
{
	[Token(Token = "0x200000C")]
	public sealed class Dimension
	{
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x10")]
		private readonly int width;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x14")]
		private readonly int height;

		[Token(Token = "0x17000008")]
		public int Width
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x2EB0EDC", Offset = "0x2EB0EDC", VA = "0x2EB0EDC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000009")]
		public int Height
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x2EB0EE4", Offset = "0x2EB0EE4", VA = "0x2EB0EE4")]
			get
			{
				return default;
			}
		}
	}
}
