using System;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	public class SerializableLevelContentData
	{
		[SerializeField]
		private SerializableSelectableData[] m_SelectableDatas;

		[SerializeField]
		private SerializableTerrainData[] m_TerrainDatas;

		public SerializableSelectableData[] selectableDatas => null;

		public SerializableTerrainData[] terrainDatas => null;

		public SerializableLevelContentData(SerializableSelectableData[] selectableDatas, SerializableTerrainData[] terrainDatas)
		{
		}
	}
}
