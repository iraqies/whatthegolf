using System.Collections.Generic;
using Triband.GolfTerrainTool;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Managers
{
	public sealed class TerrainManager : BaseManager, IRequireSerialization
	{
		[SerializeField]
		private CanvasParameters m_CanvasParameters;

		[SerializeField]
		private MeshParameters m_MeshParameters;

		[SerializeField]
		private RendererParameters m_RendererParameters;

		[SerializeField]
		private AudioMaterial m_GrassAudioMaterial;

		private const string kGolfTerrainName = "GolfTerrain";

		private const int kTerrainCount = 1;

		private List<GolfTerrain> m_GolfTerrains;

		private Dictionary<int, GolfTerrain> m_TerrainLayers;

		private void Reset()
		{
		}

		public override void Init()
		{
		}

		public void Load(LevelContentData levelData)
		{
		}

		public void Save(LevelContentData levelData)
		{
		}

		public void PaintTerrainLayer(int layerIndex, Brush brush, Vector3 position, Quaternion rotation, Vector3 scale, bool isEraser = false)
		{
		}

		public Plane GetPaintPlane(int layerIndex)
		{
			return default;
		}

		private GolfTerrain CreateGolfTerrain(int index, Vector3 position)
		{
			return null;
		}
	}
}
