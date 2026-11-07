using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Mathematics
{
	[Serializable]
	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1B418C", Offset = "0x1B418C")]
	public struct uint4 : IEquatable<uint4>, IFormattable
	{
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x0")]
		public uint x;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x4")]
		public uint y;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x8")]
		public uint z;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0xC")]
		public uint w;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2A412E0", Offset = "0x2A412E0", VA = "0x2A412E0")]
		public uint4(uint x, uint y, uint z, uint w)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2A412EC", Offset = "0x2A412EC", VA = "0x2A412EC")]
		public static uint4 operator *(uint4 lhs, uint4 rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2A41318", Offset = "0x2A41318", VA = "0x2A41318")]
		public static uint4 operator *(uint4 lhs, uint rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2A4133C", Offset = "0x2A4133C", VA = "0x2A4133C")]
		public static uint4 operator +(uint4 lhs, uint4 rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2A41368", Offset = "0x2A41368", VA = "0x2A41368")]
		public static uint4 operator +(uint4 lhs, uint rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2A4138C", Offset = "0x2A4138C", VA = "0x2A4138C")]
		public static uint4 operator <<(uint4 x, int n)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2A413B0", Offset = "0x2A413B0", VA = "0x2A413B0")]
		public static uint4 operator >>(uint4 x, int n)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2A413D4", Offset = "0x2A413D4", VA = "0x2A413D4")]
		public static uint4 operator |(uint4 lhs, uint4 rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2A413E0", Offset = "0x2A413E0", VA = "0x2A413E0", Slot = "4")]
		public bool Equals(uint4 rhs)
		{
			return default;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2A41424", Offset = "0x2A41424", VA = "0x2A41424", Slot = "0")]
		public override bool Equals(object o)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2A414E8", Offset = "0x2A414E8", VA = "0x2A414E8", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2A41530", Offset = "0x2A41530", VA = "0x2A41530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2A416E8", Offset = "0x2A416E8", VA = "0x2A416E8", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
}
