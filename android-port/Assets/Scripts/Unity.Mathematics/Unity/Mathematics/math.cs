using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Unity.Mathematics
{
	[Token(Token = "0x2000002")]
	public static class math
	{
		[Token(Token = "0x2000003")]
		public enum RotationOrder : byte
		{
			[Token(Token = "0x4000002")]
			XYZ = 0,
			[Token(Token = "0x4000003")]
			XZY = 1,
			[Token(Token = "0x4000004")]
			YXZ = 2,
			[Token(Token = "0x4000005")]
			YZX = 3,
			[Token(Token = "0x4000006")]
			ZXY = 4,
			[Token(Token = "0x4000007")]
			ZYX = 5,
			[Token(Token = "0x4000008")]
			Default = ZXY
		}

		[StructLayout((LayoutKind)2)]
		[Token(Token = "0x2000004")]
		internal struct IntFloatUnion
		{
			[Token(Token = "0x4000009")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int intValue;

			[Token(Token = "0x400000A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float floatValue;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2A3F39C", Offset = "0x2A3F39C", VA = "0x2A3F39C")]
		public static uint hash(float3 v)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2A3F3DC", Offset = "0x2A3F3DC", VA = "0x2A3F3DC")]
		public static float4 float4(float x, float y, float z, float w)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2A3F3E0", Offset = "0x2A3F3E0", VA = "0x2A3F3E0")]
		public static float4 float4(float3 xyz, float w)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2A3F3E4", Offset = "0x2A3F3E4", VA = "0x2A3F3E4")]
		public static uint hash(float4 v)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2A3F434", Offset = "0x2A3F434", VA = "0x2A3F434")]
		public static float4x4 float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2A3F458", Offset = "0x2A3F458", VA = "0x2A3F458")]
		public static float3 transform(float4x4 a, float3 b)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2A3F4C4", Offset = "0x2A3F4C4", VA = "0x2A3F4C4")]
		public static uint hash(float4x4 v)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2A3F5E4", Offset = "0x2A3F5E4", VA = "0x2A3F5E4")]
		public static int asint(float x)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2A3F5EC", Offset = "0x2A3F5EC", VA = "0x2A3F5EC")]
		public static uint asuint(float x)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2A3F5F4", Offset = "0x2A3F5F4", VA = "0x2A3F5F4")]
		public static uint3 asuint(float3 x)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2A3F608", Offset = "0x2A3F608", VA = "0x2A3F608")]
		public static uint4 asuint(float4 x)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2A3F624", Offset = "0x2A3F624", VA = "0x2A3F624")]
		public static float min(float x, float y)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2A3F660", Offset = "0x2A3F660", VA = "0x2A3F660")]
		public static float3 min(float3 x, float3 y)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2A3F6FC", Offset = "0x2A3F6FC", VA = "0x2A3F6FC")]
		public static float max(float x, float y)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2A3F738", Offset = "0x2A3F738", VA = "0x2A3F738")]
		public static float3 max(float3 x, float3 y)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2A3F7D4", Offset = "0x2A3F7D4", VA = "0x2A3F7D4")]
		public static float dot(float3 x, float3 y)
		{
			return default;
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2A3F7EC", Offset = "0x2A3F7EC", VA = "0x2A3F7EC")]
		public static float cos(float x)
		{
			return default;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2A3F85C", Offset = "0x2A3F85C", VA = "0x2A3F85C")]
		public static float3 cos(float3 x)
		{
			return default;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2A3F97C", Offset = "0x2A3F97C", VA = "0x2A3F97C")]
		public static float sin(float x)
		{
			return default;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2A3F9EC", Offset = "0x2A3F9EC", VA = "0x2A3F9EC")]
		public static float3 sin(float3 x)
		{
			return default;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2A3FB0C", Offset = "0x2A3FB0C", VA = "0x2A3FB0C")]
		public static float sqrt(float x)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2A3FB74", Offset = "0x2A3FB74", VA = "0x2A3FB74")]
		public static float rsqrt(float x)
		{
			return default;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2A3FBE4", Offset = "0x2A3FBE4", VA = "0x2A3FBE4")]
		public static float3 normalize(float3 x)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2A3FC84", Offset = "0x2A3FC84", VA = "0x2A3FC84")]
		public static void sincos(float3 x, out float3 s, out float3 c)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2A3FCE4", Offset = "0x2A3FCE4", VA = "0x2A3FCE4")]
		public static uint rol(uint x, int n)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2A3FCF0", Offset = "0x2A3FCF0", VA = "0x2A3FCF0")]
		public static uint csum(uint3 x)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2A3FD00", Offset = "0x2A3FD00", VA = "0x2A3FD00")]
		public static uint csum(uint4 x)
		{
			return default;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2A3FD18", Offset = "0x2A3FD18", VA = "0x2A3FD18")]
		public unsafe static uint hash(void* pBuffer, int numBytes, uint seed = 0u)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2A3FE7C", Offset = "0x2A3FE7C", VA = "0x2A3FE7C")]
		public static float4 mul(float4x4 a, float4 b)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x2A3FF10", Offset = "0x2A3FF10", VA = "0x2A3FF10")]
		public static float4x4 mul(float4x4 a, float4x4 b)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2A40154", Offset = "0x2A40154", VA = "0x2A40154")]
		public static quaternion quaternion(float4 value)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2A40158", Offset = "0x2A40158", VA = "0x2A40158")]
		public static uint hash(quaternion q)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2A401A8", Offset = "0x2A401A8", VA = "0x2A401A8")]
		public static uint3 uint3(uint x, uint y, uint z)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2A401B8", Offset = "0x2A401B8", VA = "0x2A401B8")]
		public static uint hash(uint3 v)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2A401F0", Offset = "0x2A401F0", VA = "0x2A401F0")]
		public static uint4 uint4(uint x, uint y, uint z, uint w)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2A40208", Offset = "0x2A40208", VA = "0x2A40208")]
		public static uint hash(uint4 v)
		{
			return default;
		}
	}
}
