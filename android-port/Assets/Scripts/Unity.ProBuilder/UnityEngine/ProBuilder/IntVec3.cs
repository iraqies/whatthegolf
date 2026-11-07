using System;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Token(Token = "0x200000C")]
	internal struct IntVec3 : IEquatable<IntVec3>
	{
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 value;

		[Token(Token = "0x17000018")]
		public float x
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x2A49C84", Offset = "0x2A49C84", VA = "0x2A49C84")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000019")]
		public float y
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x2A49C8C", Offset = "0x2A49C8C", VA = "0x2A49C8C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001A")]
		public float z
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x2A49C94", Offset = "0x2A49C94", VA = "0x2A49C94")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2A49C9C", Offset = "0x2A49C9C", VA = "0x2A49C9C")]
		public IntVec3(Vector3 vector)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2A49CA8", Offset = "0x2A49CA8", VA = "0x2A49CA8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2A49D74", Offset = "0x2A49D74", VA = "0x2A49D74", Slot = "4")]
		public bool Equals(IntVec3 p)
		{
			return default;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2A4A01C", Offset = "0x2A4A01C", VA = "0x2A4A01C")]
		public bool Equals(Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2A4A250", Offset = "0x2A4A250", VA = "0x2A4A250", Slot = "0")]
		public override bool Equals(object b)
		{
			return default;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2A4A350", Offset = "0x2A4A350", VA = "0x2A4A350", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2A49FA8", Offset = "0x2A49FA8", VA = "0x2A49FA8")]
		private static int round(float v)
		{
			return default;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2A4A4B0", Offset = "0x2A4A4B0", VA = "0x2A4A4B0")]
		public static implicit operator IntVec3(Vector3 p)
		{
			return default;
		}
	}
}
