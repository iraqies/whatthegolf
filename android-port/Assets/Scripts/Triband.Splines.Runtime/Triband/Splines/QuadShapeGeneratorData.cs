using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "MovedFromAttribute", RVA = "0x1AFFA8", Offset = "0x1AFFA8")]
	public class QuadShapeGeneratorData : IShapeGeneratorData
	{
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float width;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float pivot;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool twoSided;

		[Token(Token = "0x17000021")]
		public float Width
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x2A024D8", Offset = "0x2A024D8", VA = "0x2A024D8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000022")]
		public float Pivot
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x2A024E0", Offset = "0x2A024E0", VA = "0x2A024E0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000023")]
		public bool TwoSided
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x2A024E8", Offset = "0x2A024E8", VA = "0x2A024E8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2A024F0", Offset = "0x2A024F0", VA = "0x2A024F0")]
		public QuadShapeGeneratorData()
		{
		}
	}
}
