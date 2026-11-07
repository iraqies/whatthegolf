using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	[Token(Token = "0x200000C")]
	public class QuadShapeGenerator : ShapeGenerator<QuadShapeGeneratorData>
	{
		[Token(Token = "0x1700001F")]
		public override bool ClosedLoop
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x2A01DE4", Offset = "0x2A01DE4", VA = "0x2A01DE4", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000020")]
		public override bool AutoGenerateNormals
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x2A01DEC", Offset = "0x2A01DEC", VA = "0x2A01DEC", Slot = "9")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2A01DF4", Offset = "0x2A01DF4", VA = "0x2A01DF4", Slot = "5")]
		public override Shape2D Generate(float t, float length)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2A02148", Offset = "0x2A02148", VA = "0x2A02148")]
		private Vector2 GenerateUVs(float x, float t, float length)
		{
			return default;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2A0230C", Offset = "0x2A0230C", VA = "0x2A0230C", Slot = "6")]
		public override Shape GenerateStartCap()
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2A0242C", Offset = "0x2A0242C", VA = "0x2A0242C", Slot = "7")]
		public override Shape GenerateEndCap()
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2A02480", Offset = "0x2A02480", VA = "0x2A02480")]
		public QuadShapeGenerator()
		{
		}
	}
}
