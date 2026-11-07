using System.IO;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200003A")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x182BB0", Offset = "0x182BB0")]
	[Attribute(Name = "NullableAttribute", RVA = "0x182BB0", Offset = "0x182BB0")]
	internal class Base64Encoder
	{
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x10")]
		private readonly char[] _charsLine;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x18")]
		private readonly TextWriter _writer;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "NullableAttribute", RVA = "0x185668", Offset = "0x185668")]
		private byte[] _leftOverBytes;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x28")]
		private int _leftOverBytesCount;

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x22ABE6C", Offset = "0x22ABE6C", VA = "0x22ABE6C")]
		public Base64Encoder(TextWriter writer)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x22ABF08", Offset = "0x22ABF08", VA = "0x22ABF08")]
		private void ValidateEncode(byte[] buffer, int index, int count)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x22ABFD8", Offset = "0x22ABFD8", VA = "0x22ABFD8")]
		public void Encode(byte[] buffer, int index, int count)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x22AC280", Offset = "0x22AC280", VA = "0x22AC280")]
		private void StoreLeftOverBytes(byte[] buffer, int index, ref int count)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x22AC19C", Offset = "0x22AC19C", VA = "0x22AC19C")]
		private bool FulfillFromLeftover(byte[] buffer, int index, ref int count)
		{
			return default;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x22AC39C", Offset = "0x22AC39C", VA = "0x22AC39C")]
		public void Flush()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x22AC25C", Offset = "0x22AC25C", VA = "0x22AC25C")]
		private void WriteChars(char[] chars, int index, int count)
		{
		}
	}
}
