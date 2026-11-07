using System.Collections.Generic;
using Il2CppDummyDll;
using Triband.GolfTerrainTool;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Managers
{
	[Token(Token = "0x20012D4")]
	public sealed class TerrainManager : BaseManager, IRequireSerialization
	{
		[Token(Token = "0x4006571")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasParameters m_CanvasParameters;

		[Token(Token = "0x4006572")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshParameters m_MeshParameters;

		[Token(Token = "0x4006573")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RendererParameters m_RendererParameters;

		[Token(Token = "0x4006574")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudioMaterial m_GrassAudioMaterial;

		[Token(Token = "0x4006575")]
		private const string kGolfTerrainName = "GolfTerrain";

		[Token(Token = "0x4006576")]
		private const int kTerrainCount = 1;

		[Token(Token = "0x4006577")]
		[FieldOffset(Offset = "0x40")]
		private List<GolfTerrain> m_GolfTerrains;

		[Token(Token = "0x4006578")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<int, GolfTerrain> m_TerrainLayers;

		[Token(Token = "0x6005750")]
		[Address(RVA = "0x170FFF8", Offset = "0x170FFF8", VA = "0x170FFF8")]
		public TerrainManager()
		{
		}

		[Token(Token = "0x6005751")]
		[Address(RVA = "0x17100C4", Offset = "0x17100C4", VA = "0x17100C4")]
		private void Reset()
		{
		}

		[Token(Token = "0x6005752")]
		[Address(RVA = "0x1710164", Offset = "0x1710164", VA = "0x1710164", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005753")]
		[Address(RVA = "0x17105BC", Offset = "0x17105BC", VA = "0x17105BC", Slot = "5")]
		public void Load(LevelContentData levelData)
		{
		}

		[Token(Token = "0x6005754")]
		[Address(RVA = "0x17106A8", Offset = "0x17106A8", VA = "0x17106A8", Slot = "6")]
		public void Save(LevelContentData levelData)
		{
		}

		[Token(Token = "0x6005755")]
		[Address(RVA = "0x17107F4", Offset = "0x17107F4", VA = "0x17107F4")]
		public void PaintTerrainLayer(int layerIndex, Brush brush, Vector3 position, Quaternion rotation, Vector3 scale, bool isEraser = false)
		{
		}

		[Token(Token = "0x6005756")]
		[Address(RVA = "0x171092C", Offset = "0x171092C", VA = "0x171092C")]
		public Plane GetPaintPlane(int layerIndex)
		{
			return default;
		}

		[Token(Token = "0x6005757")]
		[Address(RVA = "0x17102AC", Offset = "0x17102AC", VA = "0x17102AC")]
		private GolfTerrain CreateGolfTerrain(int index, Vector3 position)
		{
			return null;
		}
	}
}
