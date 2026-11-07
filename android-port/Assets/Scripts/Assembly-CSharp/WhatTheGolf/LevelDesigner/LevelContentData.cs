using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	[Token(Token = "0x2001230")]
	public sealed class LevelContentData
	{
		[Token(Token = "0x400624D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<SelectableData> m_SelectableDatas;

		[Token(Token = "0x400624E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<TerrainData> m_TerrainDatas;

		[Token(Token = "0x17000944")]
		public List<SelectableData> selectableData
		{
			[Token(Token = "0x60053CA")]
			[Address(RVA = "0x152741C", Offset = "0x152741C", VA = "0x152741C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000945")]
		public List<TerrainData> terrainDatas
		{
			[Token(Token = "0x60053CB")]
			[Address(RVA = "0x1527424", Offset = "0x1527424", VA = "0x1527424")]
			get
			{
				return null;
			}
			[Token(Token = "0x60053CC")]
			[Address(RVA = "0x152742C", Offset = "0x152742C", VA = "0x152742C")]
			set
			{
			}
		}

		[Token(Token = "0x60053C9")]
		[Address(RVA = "0x1527350", Offset = "0x1527350", VA = "0x1527350")]
		public LevelContentData()
		{
		}
	}
}
