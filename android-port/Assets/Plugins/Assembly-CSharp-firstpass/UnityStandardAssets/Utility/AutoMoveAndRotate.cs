using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000046")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000047")]
		public class Vector3andSpace
		{
			[Token(Token = "0x400010A")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x400010B")]
			[FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x6000120")]
			[Address(RVA = "0x1336A18", Offset = "0x1336A18", VA = "0x1336A18")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x12F41F4", Offset = "0x12F41F4", VA = "0x12F41F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x12F421C", Offset = "0x12F421C", VA = "0x12F421C")]
		private void Update()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x12F42F0", Offset = "0x12F42F0", VA = "0x12F42F0")]
		public AutoMoveAndRotate()
		{
		}
	}
}
