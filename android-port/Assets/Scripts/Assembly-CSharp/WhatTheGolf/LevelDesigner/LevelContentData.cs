using System;
using System.Collections.Generic;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Serializable]
	public sealed class LevelContentData
	{
		[SerializeField]
		private List<SelectableData> m_SelectableDatas;

		[SerializeField]
		private List<TerrainData> m_TerrainDatas;

		public List<SelectableData> selectableData => null;

		public List<TerrainData> terrainDatas
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
