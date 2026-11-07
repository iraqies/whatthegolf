using Il2CppDummyDll;

namespace ZXing.QrCode.Internal
{
	[Token(Token = "0x2000021")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x21EE20", Offset = "0x21EE20")]
	public sealed class ByteMatrix
	{
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[][] bytes;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x18")]
		private readonly int width;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x1C")]
		private readonly int height;

		[Token(Token = "0x1700001B")]
		public int Height
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x2EA6CD0", Offset = "0x2EA6CD0", VA = "0x2EA6CD0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001C")]
		public int Width
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x2EA6CD8", Offset = "0x2EA6CD8", VA = "0x2EA6CD8")]
			get
			{
				return default;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x1700001D")]
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2EA6CE0", Offset = "0x2EA6CE0", VA = "0x2EA6CE0")]
		public int get_Item(int x, int y)
		{
			return default;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2EA6D34", Offset = "0x2EA6D34", VA = "0x2EA6D34")]
		public void set_Item(int x, int y, int value)
		{
		}

		[Token(Token = "0x1700001E")]
		public byte[][] Array
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x2EA6D88", Offset = "0x2EA6D88", VA = "0x2EA6D88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2EA6BBC", Offset = "0x2EA6BBC", VA = "0x2EA6BBC")]
		public ByteMatrix(int width, int height)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2EA6D90", Offset = "0x2EA6D90", VA = "0x2EA6D90")]
		public void set(int x, int y, bool value)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2EA6DE4", Offset = "0x2EA6DE4", VA = "0x2EA6DE4")]
		public void clear(byte value)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2EA6E80", Offset = "0x2EA6E80", VA = "0x2EA6E80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
