using System;
using System.Collections.Generic;
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
			return null;
		}
	}

	public GameObject normalMap;

	public GameObject rotatedMap;

	[SerializeField]
	private GridFilledTileMap currentTileMap;

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

	public Tilemap currentGroundMap => null;

	public Rigidbody2D currentRigid => null;

	public void Init()
	{
	}

	public void ActivateAllTileMaps()
	{
	}

	public void DisableAllTileMaps()
	{
	}

	public void ActivateOnlyNeededTilemap()
	{
	}

	public override void OnPrePlayOrPreCompile()
	{
	}

	public void PostPreCompile()
	{
	}

	public void PrePreCompile()
	{
	}

	public void AutoFill(bool isRotated)
	{
	}

	public List<Tilemap> GetAllTilemaps()
	{
		return null;
	}

	public void PreBuildScript(Action<float> onProgress, Action onComplete, bool forceBuild = false)
	{
	}

	public void CreateCompositeCollider(GameObject target)
	{
	}

	private TileBase CheckSectionsForTile(Vector3Int pos)
	{
		return null;
	}

	private bool CheckTile(TileMapData tiles, Vector3Int tilePos, HubSection currentSection, bool isRotated)
	{
		return false;
	}

	public bool IsTileTarget(Vector3Int pos)
	{
		return false;
	}

	public bool IsTileTarget(TileMapData tiles, Vector3Int pos)
	{
		return false;
	}

	public bool IsRound(TileMapData tiles, TileBase tile)
	{
		return false;
	}

	public bool IsTileTargetOrDiagonalOrRound(TileMapData tiles, TileBase tile)
	{
		return false;
	}

	public bool IsTileTargetOrOrRound(TileMapData tiles, TileBase tile)
	{
		return false;
	}

	public bool IsTileTarget(TileMapData tiles, TileBase tile)
	{
		return false;
	}

	public void ShowSectionsBaseOnly()
	{
	}

	public void ShowSectionsWithDecorationOnly()
	{
	}

	public void ShowGridAndDecorationsOnly()
	{
	}

	public void ShowGridOnly()
	{
	}
}
