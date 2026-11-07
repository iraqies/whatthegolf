using System;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	[Token(Token = "0x200123B")]
	public class TerrainData
	{
		[Token(Token = "0x400626F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private byte[] m_Values;

		[Token(Token = "0x17000963")]
		public byte[] values
		{
			[Token(Token = "0x6005408")]
			[Address(RVA = "0x170FF34", Offset = "0x170FF34", VA = "0x170FF34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005407")]
		[Address(RVA = "0x170FF08", Offset = "0x170FF08", VA = "0x170FF08")]
		public TerrainData(byte[] values)
		{
		}
	}
}
