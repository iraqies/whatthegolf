using System;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	[Token(Token = "0x2001239")]
	public class SerializableSelectableData
	{
		[Token(Token = "0x400626B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int m_Id;

		[Token(Token = "0x400626C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Vector3 m_Position;

		[Token(Token = "0x400626D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 m_Rotation;

		[Token(Token = "0x1700095F")]
		public int id
		{
			[Token(Token = "0x6005402")]
			[Address(RVA = "0x168A6B8", Offset = "0x168A6B8", VA = "0x168A6B8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000960")]
		public Vector3 position
		{
			[Token(Token = "0x6005403")]
			[Address(RVA = "0x168A6C0", Offset = "0x168A6C0", VA = "0x168A6C0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000961")]
		public Vector3 rotation
		{
			[Token(Token = "0x6005404")]
			[Address(RVA = "0x168A6CC", Offset = "0x168A6CC", VA = "0x168A6CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005401")]
		[Address(RVA = "0x168A650", Offset = "0x168A650", VA = "0x168A650")]
		public SerializableSelectableData(int id, Vector3 position, Vector3 rotation)
		{
		}
	}
}
