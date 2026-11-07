using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
	[Serializable]
	public struct quaternion : IEquatable<quaternion>, IFormattable
	{
		public float4 value;

		public static readonly quaternion identity;

		public static implicit operator Quaternion(quaternion q)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public quaternion(float x, float y, float z, float w)
		{
			value = default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public quaternion(float4 value)
		{
			this.value = default;
		}

		public static quaternion EulerXYZ(float3 xyz)
		{
			return default;
		}

		public static quaternion EulerXZY(float3 xyz)
		{
			return default;
		}

		public static quaternion EulerYXZ(float3 xyz)
		{
			return default;
		}

		public static quaternion EulerYZX(float3 xyz)
		{
			return default;
		}

		public static quaternion EulerZXY(float3 xyz)
		{
			return default;
		}

		public static quaternion EulerZYX(float3 xyz)
		{
			return default;
		}

		public static quaternion Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(quaternion x)
		{
			return false;
		}

		public override bool Equals(object x)
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
	}
}
