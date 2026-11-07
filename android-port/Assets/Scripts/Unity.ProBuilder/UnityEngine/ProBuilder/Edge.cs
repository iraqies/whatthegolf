using System;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Serializable]
	[Token(Token = "0x2000008")]
	public struct Edge : IEquatable<Edge>
	{
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x0")]
		public int a;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x4")]
		public int b;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Edge Empty;

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2A48944", Offset = "0x2A48944", VA = "0x2A48944")]
		public Edge(int a, int b)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2A4894C", Offset = "0x2A4894C", VA = "0x2A4894C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2A48AFC", Offset = "0x2A48AFC", VA = "0x2A48AFC", Slot = "4")]
		public bool Equals(Edge other)
		{
			return default;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2A48B40", Offset = "0x2A48B40", VA = "0x2A48B40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2A48C04", Offset = "0x2A48C04", VA = "0x2A48C04", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}
	}
}
