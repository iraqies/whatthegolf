using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200007D")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x183518", Offset = "0x183518")]
	[Attribute(Name = "NullableAttribute", RVA = "0x183518", Offset = "0x183518")]
	internal struct StringBuffer
	{
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x0")]
		private char[] _buffer;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x8")]
		private int _position;

		[Token(Token = "0x17000071")]
		public int Position
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x2322978", Offset = "0x2322978", VA = "0x2322978")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x2322980", Offset = "0x2322980", VA = "0x2322980")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public bool IsEmpty
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x230AFBC", Offset = "0x230AFBC", VA = "0x230AFBC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000073")]
		public char[] InternalBuffer
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x2322A34", Offset = "0x2322A34", VA = "0x2322A34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x230AFCC", Offset = "0x230AFCC", VA = "0x230AFCC")]
		public StringBuffer(IArrayPool<char> bufferPool, int initalSize)
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x2322988", Offset = "0x2322988", VA = "0x2322988")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18928C", Offset = "0x18928C")]
		private StringBuffer(char[] buffer)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x230D780", Offset = "0x230D780", VA = "0x230D780")]
		public void Append(IArrayPool<char> bufferPool, char value)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x230D6BC", Offset = "0x230D6BC", VA = "0x230D6BC")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x1892A0", Offset = "0x1892A0")]
		public void Append([Attribute(Name = "NullableAttribute", RVA = "0x18C578", Offset = "0x18C578")] IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x2322994", Offset = "0x2322994", VA = "0x2322994")]
		private void EnsureSize(IArrayPool<char> bufferPool, int appendLength)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x2322A04", Offset = "0x2322A04", VA = "0x2322A04", Slot = "3")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x1892B4", Offset = "0x1892B4")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x2322A1C", Offset = "0x2322A1C", VA = "0x2322A1C")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x1892C8", Offset = "0x1892C8")]
		public string ToString(int start, int length)
		{
			return null;
		}
	}
}
