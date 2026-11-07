using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	[Token(Token = "0x2000035")]
	public struct MathPlane
	{
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x0")]
		private Vector3 normal;

		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0xC")]
		private Vector3 origin;

		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x18")]
		private float distance;

		[Token(Token = "0x17000062")]
		public Vector3 Normal
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x2C69FEC", Offset = "0x2C69FEC", VA = "0x2C69FEC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000063")]
		public Vector3 Origin
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x2C69FF8", Offset = "0x2C69FF8", VA = "0x2C69FF8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2C6A004", Offset = "0x2C6A004", VA = "0x2C6A004")]
		public MathPlane(Vector3 inNormal, Vector3 inPoint)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2C6A08C", Offset = "0x2C6A08C", VA = "0x2C6A08C")]
		public float StretchFactor(Ray ray)
		{
			return default;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2C63338", Offset = "0x2C63338", VA = "0x2C63338")]
		internal static bool FloatEquals(float a, float b)
		{
			return default;
		}
	}
}
