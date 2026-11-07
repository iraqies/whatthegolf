using System;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	[Token(Token = "0x2001238")]
	public class SerializableLevelContentData
	{
		[Token(Token = "0x4006269")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SerializableSelectableData[] m_SelectableDatas;

		[Token(Token = "0x400626A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SerializableTerrainData[] m_TerrainDatas;

		[Token(Token = "0x1700095D")]
		public SerializableSelectableData[] selectableDatas
		{
			[Token(Token = "0x60053FF")]
			[Address(RVA = "0x168A038", Offset = "0x168A038", VA = "0x168A038")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700095E")]
		public SerializableTerrainData[] terrainDatas
		{
			[Token(Token = "0x6005400")]
			[Address(RVA = "0x168A040", Offset = "0x168A040", VA = "0x168A040")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60053FE")]
		[Address(RVA = "0x168A000", Offset = "0x168A000", VA = "0x168A000")]
		public SerializableLevelContentData(SerializableSelectableData[] selectableDatas, SerializableTerrainData[] terrainDatas)
		{
		}
	}
}
