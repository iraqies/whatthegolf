using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridFiller : GolfBehaviour
{
	[Serializable]
	public class TileMapData
	{
		public Tile targetTile;
		public Tile targetTileAlt;
		public Tile diagonalTopRight;
		public Tile diagonalTopLeft;
		public Tile diagonalBottomRight;
		public Tile diagonalBottomLeft;
		public Tile roundTopRight;
		public Tile roundTopLeft;
		public Tile roundBottomRight;
		public Tile roundBottomLeft;
		public Tile borderOuterBottomLeft;
		public Tile borderOuterBottomRight;
		public Tile borderOuterTopLeft;
		public Tile borderOuterTopRight;
		public Tile borderSideLeft;
		public Tile borderSideRight;
		public Tile borderTop;
		public Tile borderBottom;
		public Tile borderInnerTopRight;
		public Tile borderInnerTopLeft;
		public Tile borderInnerBottomLeft;
		public Tile borderInnerBottomRight;
		public Tile borderDiaTopRight;
		public Tile borderDiaTopLeft;
		public Tile borderDiaBottomRight;
		public Tile borderDiaBottomLeft;
		public Tile borderRoundTopRight;
		public Tile borderRoundTopLeft;
		public Tile borderRoundBottomRight;
		public Tile borderRoundBottomLeft;

		public List<Tile> GetAllTiles()
		{
			return new List<Tile>
			{
				targetTile, targetTileAlt, diagonalTopRight, diagonalTopLeft,
				diagonalBottomRight, diagonalBottomLeft, roundTopRight, roundTopLeft,
				roundBottomRight, roundBottomLeft, borderOuterBottomLeft, borderOuterBottomRight,
				borderOuterTopLeft, borderOuterTopRight, borderSideLeft, borderSideRight,
				borderTop, borderBottom, borderInnerTopRight, borderInnerTopLeft,
				borderInnerBottomLeft, borderInnerBottomRight, borderDiaTopRight, borderDiaTopLeft,
				borderDiaBottomRight, borderDiaBottomLeft, borderRoundTopRight, borderRoundTopLeft,
				borderRoundBottomRight, borderRoundBottomLeft
			};
		}
	}

	public GameObject normalMap;
	public GameObject rotatedMap;
	[SerializeField] private GridFilledTileMap currentTileMap;
	public Tilemap hubBlueprint;
	public Tilemap groundMap;
	public GameObject hubSectionContainer;
	public Tilemap secretMap;
	public Tilemap leftBorder;
	public Tilemap rightBorder;
	public Tilemap rotatedRightBorder;
	public Tilemap topBorder;
	public Tilemap bottomBorder;
	public Tilemap bottomCornerRightBorder;
	public Tilemap bottomCornerLeftBorder;
	public Tilemap topCornerRightBorder;
	public Tilemap topCornerLeftBorder;
	public Tilemap innerCornerTopLeft;
	public Tilemap innerCornerTopRight;
	public Tilemap innerCornerBottomLeft;
	public Tilemap innerCornerBottomRight;
	public Tilemap diagonals;
	public Tilemap collison;
	public List<TilemapRenderer> AllRenders;
	public PhysicsMaterial2D colliderMat;
	public int xStart;
	public int yStart;
	public int xEnd;
	public int yEnd;
	public List<TileMapData> tileMaps;
	public Tile debug;
	private List<Tilemap> allTilemaps;
	private HubSection[] hubSections;

	public Tilemap currentGroundMap => currentTileMap != null && currentTileMap.ground != null ? currentTileMap.ground : groundMap;
	public Rigidbody2D currentRigid => currentTileMap != null ? currentTileMap.GetComponent<Rigidbody2D>() : GetComponentInChildren<Rigidbody2D>();

	public void Init()
	{
		if (AllRenders == null || AllRenders.Count == 0)
			AllRenders = GetComponentsInChildren<TilemapRenderer>(true).ToList();
		ActivateOnlyNeededTilemap();
	}

	public void ActivateAllTileMaps()
	{
		if (rotatedMap != null) rotatedMap.SetActive(true);
		if (normalMap != null)
		{
			normalMap.SetActive(true);
			currentTileMap = normalMap.GetComponent<GridFilledTileMap>();
		}
	}

	public void DisableAllTileMaps()
	{
		if (rotatedMap != null) rotatedMap.SetActive(false);
		if (normalMap != null)
		{
			normalMap.SetActive(false);
			currentTileMap = normalMap.GetComponent<GridFilledTileMap>();
		}
	}

	public void ActivateOnlyNeededTilemap()
	{
		bool useRotated = false;
		if (PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null)
			useRotated = PlatformSettings.Instance.GetCurrent().useRotatedOverworldAndCameraInLevels;

		if (useRotated)
		{
			if (rotatedMap != null)
			{
				rotatedMap.SetActive(true);
				currentTileMap = rotatedMap.GetComponent<GridFilledTileMap>();
			}
			if (normalMap != null) normalMap.SetActive(false);
		}
		else
		{
			if (rotatedMap != null) rotatedMap.SetActive(false);
			if (normalMap != null)
			{
				normalMap.SetActive(true);
				currentTileMap = normalMap.GetComponent<GridFilledTileMap>();
			}
		}
	}

	public override void OnPrePlayOrPreCompile()
	{
		Init();
		ShowGridAndDecorationsOnly();
	}

	public void PostPreCompile()
	{
		ActivateOnlyNeededTilemap();
	}

	public void PrePreCompile()
	{
		ActivateAllTileMaps();
	}

	public void AutoFill(bool isRotated) { }
	public List<Tilemap> GetAllTilemaps() => allTilemaps ?? new List<Tilemap>();

	public void PreBuildScript(Action<float> onProgress, Action onComplete, bool forceBuild = false)
	{
		ShowGridAndDecorationsOnly();
		ActivateOnlyNeededTilemap();
		onComplete?.Invoke();
	}

	public void CreateCompositeCollider(GameObject target) { }
	private TileBase CheckSectionsForTile(Vector3Int pos) => null;
	private bool CheckTile(TileMapData tiles, Vector3Int tilePos, HubSection currentSection, bool isRotated) => false;
	public bool IsTileTarget(Vector3Int pos) => false;
	public bool IsTileTarget(TileMapData tiles, Vector3Int pos) => false;
	public bool IsRound(TileMapData tiles, TileBase tile) => false;
	public bool IsTileTargetOrDiagonalOrRound(TileMapData tiles, TileBase tile) => false;
	public bool IsTileTargetOrOrRound(TileMapData tiles, TileBase tile) => false;
	public bool IsTileTarget(TileMapData tiles, TileBase tile) => false;
	public void ShowSectionsBaseOnly() { }
	public void ShowSectionsWithDecorationOnly() { }

	public void ShowGridAndDecorationsOnly()
	{
		gameObject.SetActive(true);
		if (hubBlueprint != null)
		{
			var r = hubBlueprint.GetComponent<Renderer>();
			if (r != null) r.enabled = false;
		}
		if (hubSectionContainer != null)
			hubSections = hubSectionContainer.GetComponentsInChildren<HubSection>(true);
		if (hubSections != null)
		{
			foreach (var s in hubSections)
			{
				if (s == null) continue;
				if (s.SectionTilemap != null)
				{
					var r = s.SectionTilemap.GetComponent<Renderer>();
					if (r != null) r.enabled = false;
				}
				if (s.DecorationsMaps != null)
				{
					foreach (var dm in s.DecorationsMaps)
					{
						if (dm != null)
						{
							var dr = dm.GetComponent<Renderer>();
							if (dr != null) dr.enabled = true;
						}
					}
				}
			}
		}
	}

	public void ShowGridOnly() { }
}
