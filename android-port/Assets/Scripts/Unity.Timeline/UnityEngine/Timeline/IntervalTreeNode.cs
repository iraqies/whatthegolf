using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x2000021")]
	internal struct IntervalTreeNode
	{
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x0")]
		public long center;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x8")]
		public int first;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0xC")]
		public int last;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x10")]
		public int left;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x14")]
		public int right;
	}
}
