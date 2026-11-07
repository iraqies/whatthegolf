using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x200122F")]
	internal struct CursorData
	{
		[Token(Token = "0x4006249")]
		[FieldOffset(Offset = "0x0")]
		public readonly Vector3 position;

		[Token(Token = "0x400624A")]
		[FieldOffset(Offset = "0xC")]
		public readonly Vector3 delta;

		[Token(Token = "0x400624B")]
		[FieldOffset(Offset = "0x18")]
		public readonly Vector3 positionWS;

		[Token(Token = "0x400624C")]
		[FieldOffset(Offset = "0x24")]
		public readonly Vector3 deltaWS;

		[Token(Token = "0x60053C8")]
		[Address(RVA = "0x18C580C", Offset = "0x18C580C", VA = "0x18C580C")]
		public CursorData(Vector3 position, Vector3 delta, Vector3 positionWS, Vector3 deltaWS)
		{
		}
	}
}
