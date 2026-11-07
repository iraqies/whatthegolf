using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ghost
{
	[Serializable]
	[Token(Token = "0x20010F2")]
	public struct Vector3Serializer
	{
		[Token(Token = "0x400593D")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x400593E")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x400593F")]
		[FieldOffset(Offset = "0x8")]
		public float z;

		[NonSerialized]
		[Token(Token = "0x4005940")]
		[FieldOffset(Offset = "0xC")]
		private Vector3 point;

		[NonSerialized]
		[Token(Token = "0x4005941")]
		[FieldOffset(Offset = "0x18")]
		private bool isSet;

		[Token(Token = "0x17000806")]
		public Vector3 V3
		{
			[Token(Token = "0x6004BD1")]
			[Address(RVA = "0x1748A68", Offset = "0x1748A68", VA = "0x1748A68")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004BD0")]
		[Address(RVA = "0x1748A50", Offset = "0x1748A50", VA = "0x1748A50")]
		public void Fill(Vector3 v3)
		{
		}
	}
}
