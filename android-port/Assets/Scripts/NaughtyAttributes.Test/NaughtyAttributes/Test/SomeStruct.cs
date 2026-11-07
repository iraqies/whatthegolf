using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000030")]
	public struct SomeStruct
	{
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x0")]
		public int Int;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x4")]
		public float Float;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 Vector;
	}
}
