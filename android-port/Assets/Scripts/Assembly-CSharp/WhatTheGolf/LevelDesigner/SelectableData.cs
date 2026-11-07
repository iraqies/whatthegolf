using System;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	[Token(Token = "0x2001234")]
	public class SelectableData
	{
		[Token(Token = "0x4006258")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SelectableDefinition m_SelectableDefinition;

		[Token(Token = "0x4006259")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 m_Position;

		[Token(Token = "0x400625A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector3 m_Rotation;

		[Token(Token = "0x1700094F")]
		public SelectableDefinition selectableDefinition
		{
			[Token(Token = "0x60053E3")]
			[Address(RVA = "0x1685E8C", Offset = "0x1685E8C", VA = "0x1685E8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000950")]
		public Vector3 position
		{
			[Token(Token = "0x60053E4")]
			[Address(RVA = "0x1685E94", Offset = "0x1685E94", VA = "0x1685E94")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000951")]
		public Quaternion rotation
		{
			[Token(Token = "0x60053E5")]
			[Address(RVA = "0x1685EA0", Offset = "0x1685EA0", VA = "0x1685EA0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60053E2")]
		[Address(RVA = "0x1685E18", Offset = "0x1685E18", VA = "0x1685E18")]
		public SelectableData(SelectableDefinition selectableDefinition, Vector3 position, Quaternion rotation)
		{
		}
	}
}
