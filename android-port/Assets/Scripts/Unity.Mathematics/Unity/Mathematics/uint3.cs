using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Mathematics
{
	[Serializable]
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1B4154", Offset = "0x1B4154")]
	public struct uint3 : IEquatable<uint3>, IFormattable
	{
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x0")]
		public uint x;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x4")]
		public uint y;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x8")]
		public uint z;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2A41014", Offset = "0x2A41014", VA = "0x2A41014")]
		public uint3(uint x, uint y, uint z)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2A41020", Offset = "0x2A41020", VA = "0x2A41020")]
		public static uint3 operator *(uint3 lhs, uint3 rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2A4103C", Offset = "0x2A4103C", VA = "0x2A4103C", Slot = "4")]
		public bool Equals(uint3 rhs)
		{
			return default;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2A41070", Offset = "0x2A41070", VA = "0x2A41070", Slot = "0")]
		public override bool Equals(object o)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2A41124", Offset = "0x2A41124", VA = "0x2A41124", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2A41160", Offset = "0x2A41160", VA = "0x2A41160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2A4122C", Offset = "0x2A4122C", VA = "0x2A4122C", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
}
