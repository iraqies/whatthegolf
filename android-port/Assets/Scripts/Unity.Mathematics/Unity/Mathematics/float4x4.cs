using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Unity.Mathematics
{
	[Serializable]
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1B411C", Offset = "0x1B411C")]
	public struct float4x4 : IEquatable<float4x4>, IFormattable
	{
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x0")]
		public float4 c0;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x10")]
		public float4 c1;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		public float4 c2;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x30")]
		public float4 c3;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float4x4 identity;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2A3E4EC", Offset = "0x2A3E4EC", VA = "0x2A3E4EC")]
		public float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2A3E508", Offset = "0x2A3E508", VA = "0x2A3E508")]
		public float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2A3E53C", Offset = "0x2A3E53C", VA = "0x2A3E53C", Slot = "4")]
		public bool Equals(float4x4 rhs)
		{
			return default;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2A3E648", Offset = "0x2A3E648", VA = "0x2A3E648", Slot = "0")]
		public override bool Equals(object o)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2A3E7CC", Offset = "0x2A3E7CC", VA = "0x2A3E7CC", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2A3E8EC", Offset = "0x2A3E8EC", VA = "0x2A3E8EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2A3EDA4", Offset = "0x2A3EDA4", VA = "0x2A3EDA4", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2A3F24C", Offset = "0x2A3F24C", VA = "0x2A3F24C")]
		public static implicit operator float4x4(Matrix4x4 m)
		{
			return default;
		}
	}
}
