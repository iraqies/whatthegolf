using Il2CppDummyDll;
using ZXing.Common;

namespace ZXing.Aztec.Internal
{
	[Token(Token = "0x200007A")]
	public abstract class Token
	{
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x0")]
		public static Token EMPTY;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x10")]
		private readonly Token previous;

		[Token(Token = "0x17000071")]
		public Token Previous
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x2ED5C68", Offset = "0x2ED5C68", VA = "0x2ED5C68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x2ED2D50", Offset = "0x2ED2D50", VA = "0x2ED2D50")]
		protected Token(Token previous)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x2ED366C", Offset = "0x2ED366C", VA = "0x2ED366C")]
		public Token add(int value, int bitCount)
		{
			return null;
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x2ED3D84", Offset = "0x2ED3D84", VA = "0x2ED3D84")]
		public Token addBinaryShift(int start, int byteCount)
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		public abstract void appendTo(BitArray bitArray, byte[] text);
	}
}
