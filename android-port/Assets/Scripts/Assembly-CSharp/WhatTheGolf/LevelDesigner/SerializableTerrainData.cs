using System;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	[Token(Token = "0x200123A")]
	public class SerializableTerrainData
	{
		[Token(Token = "0x400626E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private byte[] m_Values;

		[Token(Token = "0x17000962")]
		public byte[] values
		{
			[Token(Token = "0x6005406")]
			[Address(RVA = "0x168A704", Offset = "0x168A704", VA = "0x168A704")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005405")]
		[Address(RVA = "0x168A6D8", Offset = "0x168A6D8", VA = "0x168A6D8")]
		public SerializableTerrainData(byte[] values)
		{
		}
	}
}
