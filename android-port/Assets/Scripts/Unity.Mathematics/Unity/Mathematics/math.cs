using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Unity.Mathematics
{
	public static class math
	{
		public enum RotationOrder : byte
		{
			XYZ = 0,
			XZY = 1,
			YXZ = 2,
			YZX = 3,
			ZXY = 4,
			ZYX = 5,
			Default = ZXY
		}

		[StructLayout((LayoutKind)2)]
		internal struct IntFloatUnion
		{
			[FieldOffset(0)]
			public int intValue;

			[FieldOffset(0)]
			public float floatValue;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(float x, float y, float z, float w)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 float4(float3 xyz, float w)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 transform(float4x4 a, float3 b)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(float4x4 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int asint(float x)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint asuint(float x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 asuint(float3 x)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 asuint(float4 x)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float min(float x, float y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 min(float3 x, float3 y)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float max(float x, float y)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 max(float3 x, float3 y)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float dot(float3 x, float3 y)
		{
			return 0f;
		}

		public static float cos(float x)
		{
			return 0f;
		}

		public static float3 cos(float3 x)
		{
			return default;
		}

		public static float sin(float x)
		{
			return 0f;
		}

		public static float3 sin(float3 x)
		{
			return default;
		}

		public static float sqrt(float x)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float rsqrt(float x)
		{
			return 0f;
		}

		public static float3 normalize(float3 x)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sincos(float3 x, out float3 s, out float3 c)
		{
			s = default;
			c = default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint rol(uint x, int n)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint csum(uint3 x)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint csum(uint4 x)
		{
			return 0u;
		}

		public unsafe static uint hash(void* pBuffer, int numBytes, uint seed = 0u)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 mul(float4x4 a, float4 b)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 mul(float4x4 a, float4x4 b)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion quaternion(float4 value)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(quaternion q)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint3 uint3(uint x, uint y, uint z)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(uint3 v)
		{
			return 0u;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint4 uint4(uint x, uint y, uint z, uint w)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint hash(uint4 v)
		{
			return 0u;
		}
	}
}
