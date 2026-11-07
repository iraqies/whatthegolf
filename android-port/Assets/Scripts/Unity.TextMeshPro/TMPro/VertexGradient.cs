using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x200007C")]
	public struct VertexGradient
	{
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x0")]
		public Color topLeft;

		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x10")]
		public Color topRight;

		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0x20")]
		public Color bottomLeft;

		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0x30")]
		public Color bottomRight;

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x2ADE664", Offset = "0x2ADE664", VA = "0x2ADE664")]
		public VertexGradient(Color color)
		{
		}
	}
}
