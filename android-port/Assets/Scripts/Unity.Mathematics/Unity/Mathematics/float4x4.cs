using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
	[Serializable]
	public struct float4x4 : IEquatable<float4x4>, IFormattable
	{
		public float4 c0;

		public float4 c1;

		public float4 c2;

		public float4 c3;

		public static readonly float4x4 identity;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
		{
			this.c0 = default;
			this.c1 = default;
			this.c2 = default;
			this.c3 = default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
		{
			c0 = default;
			c1 = default;
			c2 = default;
			c3 = default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(float4x4 rhs)
		{
			return false;
		}

		public override bool Equals(object o)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		public static implicit operator float4x4(Matrix4x4 m)
		{
			return default;
		}
	}
}
