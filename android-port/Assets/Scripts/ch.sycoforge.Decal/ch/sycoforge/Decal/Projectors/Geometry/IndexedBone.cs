using System;
using Il2CppDummyDll;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	[Token(Token = "0x2000033")]
	internal class IndexedBone : IComparable<IndexedBone>
	{
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x10")]
		public int Index;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x14")]
		public float Weight;

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2C69E44", Offset = "0x2C69E44", VA = "0x2C69E44", Slot = "4")]
		public int CompareTo(IndexedBone other)
		{
			return default;
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2C69E70", Offset = "0x2C69E70", VA = "0x2C69E70")]
		public IndexedBone()
		{
		}
	}
}
