using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "MovedFromAttribute", RVA = "0x1AFF70", Offset = "0x1AFF70")]
	public class BoxShapeGeneratorData : IShapeGeneratorData
	{
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector2 size;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector2 offset;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 pivot;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2A01DC8", Offset = "0x2A01DC8", VA = "0x2A01DC8")]
		public BoxShapeGeneratorData()
		{
		}
	}
}
