using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Unity.Mathematics
{
	[Serializable]
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1B40AC", Offset = "0x1B40AC")]
	public struct float3 : IEquatable<float3>, IFormattable
	{
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x17000001")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1B41C4", Offset = "0x1B41C4")]
		public float4 yxxy
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x2A3DD0C", Offset = "0x2A3DD0C", VA = "0x2A3DD0C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000002")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1B41D8", Offset = "0x1B41D8")]
		public float4 zzyz
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x2A3DD1C", Offset = "0x2A3DD1C", VA = "0x2A3DD1C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000003")]
		[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x1B41EC", Offset = "0x1B41EC")]
		public float3 xyz
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x2A3DD2C", Offset = "0x2A3DD2C", VA = "0x2A3DD2C")]
			get
			{
				return default;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2A3DCBC", Offset = "0x2A3DCBC", VA = "0x2A3DCBC")]
		public float3(float x, float y, float z)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2A3DCC8", Offset = "0x2A3DCC8", VA = "0x2A3DCC8")]
		public static float3 operator *(float3 lhs, float rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2A3DCD8", Offset = "0x2A3DCD8", VA = "0x2A3DCD8")]
		public static float3 operator *(float lhs, float3 rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2A3DCEC", Offset = "0x2A3DCEC", VA = "0x2A3DCEC")]
		public static float3 operator +(float3 lhs, float3 rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2A3DCFC", Offset = "0x2A3DCFC", VA = "0x2A3DCFC")]
		public static float3 operator -(float3 lhs, float3 rhs)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2A3DD38", Offset = "0x2A3DD38", VA = "0x2A3DD38", Slot = "4")]
		public bool Equals(float3 rhs)
		{
			return default;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2A3DD68", Offset = "0x2A3DD68", VA = "0x2A3DD68", Slot = "0")]
		public override bool Equals(object o)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2A3DE1C", Offset = "0x2A3DE1C", VA = "0x2A3DE1C", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2A3DE58", Offset = "0x2A3DE58", VA = "0x2A3DE58", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2A3DF24", Offset = "0x2A3DF24", VA = "0x2A3DF24", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2A3DFD8", Offset = "0x2A3DFD8", VA = "0x2A3DFD8")]
		public static implicit operator Vector3(float3 v)
		{
			return default;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2A3DFDC", Offset = "0x2A3DFDC", VA = "0x2A3DFDC")]
		public static implicit operator float3(Vector3 v)
		{
			return default;
		}
	}
}
