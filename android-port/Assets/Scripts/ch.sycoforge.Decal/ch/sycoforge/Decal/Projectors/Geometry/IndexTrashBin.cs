using System.Collections.Generic;
using Il2CppDummyDll;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	[Token(Token = "0x2000034")]
	internal sealed class IndexTrashBin
	{
		[Token(Token = "0x4000111")]
		private const int INVALID = -1;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x10")]
		private List<int> indices;

		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x18")]
		private int largestValidIndex;

		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x1C")]
		private int count;

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x2C612C0", Offset = "0x2C612C0", VA = "0x2C612C0")]
		internal void TrashIndex(int index)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x2C6094C", Offset = "0x2C6094C", VA = "0x2C6094C")]
		internal int ClampIndex(int index)
		{
			return default;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x2C60A98", Offset = "0x2C60A98", VA = "0x2C60A98")]
		internal void ClearBin()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x2C608C0", Offset = "0x2C608C0", VA = "0x2C608C0")]
		internal bool Contains(int index)
		{
			return default;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2C5FD84", Offset = "0x2C5FD84", VA = "0x2C5FD84")]
		public IndexTrashBin()
		{
		}
	}
}
