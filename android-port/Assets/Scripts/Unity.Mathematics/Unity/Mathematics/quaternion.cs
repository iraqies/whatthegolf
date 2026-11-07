using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Unity.Mathematics
{
	[Serializable]
	[Token(Token = "0x2000008")]
	public struct quaternion : IEquatable<quaternion>, IFormattable
	{
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x0")]
		public float4 value;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x0")]
		public static readonly quaternion identity;

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2A40250", Offset = "0x2A40250", VA = "0x2A40250")]
		public static implicit operator Quaternion(quaternion q)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2A40280", Offset = "0x2A40280", VA = "0x2A40280")]
		public quaternion(float x, float y, float z, float w)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2A4028C", Offset = "0x2A4028C", VA = "0x2A4028C")]
		public quaternion(float4 value)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2A40298", Offset = "0x2A40298", VA = "0x2A40298")]
		public static quaternion EulerXYZ(float3 xyz)
		{
			return default;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2A40348", Offset = "0x2A40348", VA = "0x2A40348")]
		public static quaternion EulerXZY(float3 xyz)
		{
			return default;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2A403F8", Offset = "0x2A403F8", VA = "0x2A403F8")]
		public static quaternion EulerYXZ(float3 xyz)
		{
			return default;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2A404A8", Offset = "0x2A404A8", VA = "0x2A404A8")]
		public static quaternion EulerYZX(float3 xyz)
		{
			return default;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2A40558", Offset = "0x2A40558", VA = "0x2A40558")]
		public static quaternion EulerZXY(float3 xyz)
		{
			return default;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2A40608", Offset = "0x2A40608", VA = "0x2A40608")]
		public static quaternion EulerZYX(float3 xyz)
		{
			return default;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2A406B8", Offset = "0x2A406B8", VA = "0x2A406B8")]
		public static quaternion Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2A40B1C", Offset = "0x2A40B1C", VA = "0x2A40B1C", Slot = "4")]
		public bool Equals(quaternion x)
		{
			return default;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2A40B58", Offset = "0x2A40B58", VA = "0x2A40B58", Slot = "0")]
		public override bool Equals(object x)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2A40C1C", Offset = "0x2A40C1C", VA = "0x2A40C1C", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2A40C64", Offset = "0x2A40C64", VA = "0x2A40C64", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2A40E1C", Offset = "0x2A40E1C", VA = "0x2A40E1C", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}
	}
}
