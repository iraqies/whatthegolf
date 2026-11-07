using System.Collections.Generic;
using UnityEngine;

namespace Triband.GolfTerrainTool
{
	public sealed class TerrainData : ScriptableObject
	{
		[SerializeField]
		private List<TerrainLayer> m_Layers;

		[SerializeField]
		private int m_PointCount;

		public List<TerrainLayer> layers => null;

		public int pointCount => 0;

		public void Init(int pointCount)
		{
		}
	}
}
