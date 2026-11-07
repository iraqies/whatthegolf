using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Unity.Mathematics
{
	[Serializable]
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1B40E4", Offset = "0x1B40E4")]
	public struct float4 : IEquatable<float4>, IFormattable
	{
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0xC")]
		public float w;

		[Token(Token = "0x17000004")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1B4200", Offset = "0x1B4200")]
		public float3 xyz
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x2A3E034", Offset = "0x2A3E034", VA = "0x2A3E034")]
			get
			{
				return default;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2A3DFE0", Offset = "0x2A3DFE0", VA = "0x2A3DFE0")]
		public float4(float x, float y, float z, float w)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2A3DFEC", Offset = "0x2A3DFEC", VA = "0x2A3DFEC")]
		public float4(float3 xyz, float w)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2A3DFF8", Offset = "0x2A3DFF8", VA = "0x2A3DFF8")]
		public static float4 operator *(float4 lhs, float4 rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2A3E00C", Offset = "0x2A3E00C", VA = "0x2A3E00C")]
		public static float4 operator *(float4 lhs, float rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2A3E020", Offset = "0x2A3E020", VA = "0x2A3E020")]
		public static float4 operator +(float4 lhs, float4 rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2A3E040", Offset = "0x2A3E040", VA = "0x2A3E040", Slot = "4")]
		public bool Equals(float4 rhs)
		{
			return default;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2A3E07C", Offset = "0x2A3E07C", VA = "0x2A3E07C", Slot = "0")]
		public override bool Equals(object o)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2A3E140", Offset = "0x2A3E140", VA = "0x2A3E140", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2A3E188", Offset = "0x2A3E188", VA = "0x2A3E188", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2A3E340", Offset = "0x2A3E340", VA = "0x2A3E340", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2A3E4E8", Offset = "0x2A3E4E8", VA = "0x2A3E4E8")]
		public static implicit operator float4(Vector4 v)
		{
			return default;
		}
	}
}
