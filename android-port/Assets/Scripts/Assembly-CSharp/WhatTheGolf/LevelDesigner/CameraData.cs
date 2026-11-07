using System;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	[Token(Token = "0x200122C")]
	public class CameraData
	{
		[Token(Token = "0x4006245")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector3 m_Position;

		[Token(Token = "0x4006246")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector3 m_Rotation;

		[Token(Token = "0x17000942")]
		public Vector3 position
		{
			[Token(Token = "0x60053C4")]
			[Address(RVA = "0x17E45F0", Offset = "0x17E45F0", VA = "0x17E45F0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000943")]
		public Quaternion rotation
		{
			[Token(Token = "0x60053C5")]
			[Address(RVA = "0x17E45FC", Offset = "0x17E45FC", VA = "0x17E45FC")]
			get
			{
				return default;
			}
		}
	}
}
