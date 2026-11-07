using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
	[Serializable]
	public struct float4 : IEquatable<float4>, IFormattable
	{
		public float x;

		public float y;

		public float z;

		public float w;

		[EditorBrowsable]
		public float3 xyz
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float4(float x, float y, float z, float w)
		{
			this.x = 0f;
			this.y = 0f;
			this.z = 0f;
			this.w = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public float4(float3 xyz, float w)
		{
			x = 0f;
			y = 0f;
			z = 0f;
			this.w = 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 operator *(float4 lhs, float4 rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 operator *(float4 lhs, float rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 operator +(float4 lhs, float4 rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(float4 rhs)
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

		public static implicit operator float4(Vector4 v)
		{
			return default;
		}
	}
}
