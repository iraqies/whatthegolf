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

	private void Awake()
	{
		ShowGridAndDecorationsOnly();
		ActivateOnlyNeededTilemap();
	}

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
		base.OnPrePlayOrPreCompile();
		if (normalMap == null || rotatedMap == null)
		{
			Init();
			ShowGridAndDecorationsOnly();
			return;
		}

		normalMap.SetActive(true);
		rotatedMap.SetActive(true);
		GridFilledTileMap rotGrid = rotatedMap.GetComponent<GridFilledTileMap>();
		GridFilledTileMap normGrid = normalMap.GetComponent<GridFilledTileMap>();

		AutoFill(true);

		for (int i = rotatedMap.transform.childCount - 1; i >= 0; i--)
		{
			DestroyImmediate(rotatedMap.transform.GetChild(i).gameObject);
		}
		rotatedMap.transform.position = normalMap.transform.position;

		int childCount = normalMap.transform.childCount;
		for (int i = 0; i < childCount; i++)
		{
			Transform srcChild = normalMap.transform.GetChild(i);
			Transform clonedChild = Instantiate(srcChild, rotatedMap.transform, true);
			if (groundMap != null && srcChild.gameObject == groundMap.gameObject && rotGrid != null)
			{
				rotGrid.ground = clonedChild.GetComponent<Tilemap>();
			}
		}

		AutoFill(false);

		CreateCompositeCollider(normalMap);
		CreateCompositeCollider(rotatedMap);

		AllRenders = transform.GetComponentsInChildren<TilemapRenderer>().ToList();
		ActivateOnlyNeededTilemap();

		if (normGrid != null)
			normGrid.ground = groundMap;
	}

	public void PostPreCompile()
	{
		if (hubSections != null)
		{
			bool useRotated = false;
			if (PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null)
				useRotated = PlatformSettings.Instance.GetCurrent().useRotatedOverworldAndCameraInLevels;
			for (int i = 0; i < hubSections.Length; i++)
			{
				if (hubSections[i] != null)
					hubSections[i].PreBuildScript(useRotated);
			}
		}
		ActivateOnlyNeededTilemap();
	}

	public void PrePreCompile()
	{
		if (hubSectionContainer != null)
			hubSections = hubSectionContainer.GetComponentsInChildren<HubSection>(true);
		if (hubSections != null)
		{
			for (int i = 0; i < hubSections.Length; i++)
			{
				if (hubSections[i] != null)
					hubSections[i].Show();
			}
		}
		ActivateAllTileMaps();
	}

	public void AutoFill(bool isRotated)
	{
		gameObject.SetActive(true);
		if (hubSectionContainer != null)
			hubSections = hubSectionContainer.GetComponentsInChildren<HubSection>(true);
		if (hubSections == null || tileMaps == null || tileMaps.Count == 0)
			return;

		for (int i = 0; i < hubSections.Length; i++)
		{
			if (hubSections[i] != null)
				hubSections[i].PreBuildScript(isRotated);
		}
		for (int i = 0; i < hubSections.Length; i++)
		{
			if (hubSections[i] != null && hubSections[i].SectionTilemap != null)
				hubSections[i].SectionTilemap.enabled = false;
		}

		if (leftBorder != null) leftBorder.ClearAllTiles();
		if (rightBorder != null) rightBorder.ClearAllTiles();
		if (rotatedRightBorder != null) rotatedRightBorder.ClearAllTiles();
		if (collison != null) collison.ClearAllTiles();
		if (topBorder != null) topBorder.ClearAllTiles();
		if (bottomBorder != null) bottomBorder.ClearAllTiles();
		if (bottomCornerRightBorder != null) bottomCornerRightBorder.ClearAllTiles();
		if (bottomCornerLeftBorder != null) bottomCornerLeftBorder.ClearAllTiles();
		if (topCornerRightBorder != null) topCornerRightBorder.ClearAllTiles();
		if (topCornerLeftBorder != null) topCornerLeftBorder.ClearAllTiles();
		if (innerCornerTopLeft != null) innerCornerTopLeft.ClearAllTiles();
		if (innerCornerTopRight != null) innerCornerTopRight.ClearAllTiles();
		if (innerCornerBottomLeft != null) innerCornerBottomLeft.ClearAllTiles();
		if (innerCornerBottomRight != null) innerCornerBottomRight.ClearAllTiles();
		if (diagonals != null) diagonals.ClearAllTiles();
		if (groundMap != null) groundMap.ClearAllTiles();

		for (int sIdx = 0; sIdx < hubSections.Length; sIdx++)
		{
			HubSection sec = hubSections[sIdx];
			if (sec == null || sec.Container == null || !sec.Container.activeSelf)
				continue;

			Bounds b = sec.GetBounds(true);
			int minX = (int)b.min.x;
			int minY = (int)b.min.y;
			int sizeX = (int)(b.max.x - b.min.x);
			int sizeY = (int)(b.max.y - b.min.y);

			TileMapData tmData = (isRotated && sec.shouldRotateTilesForMobile && tileMaps.Count > 1)
				? tileMaps[1]
				: tileMaps[0];
			if (tmData == null) continue;

			if (isRotated && sec.shouldRotateTilesForMobile)
			{
				Matrix4x4 rotMat = Matrix4x4.Rotate(Quaternion.Euler(0f, 0f, -90f));
				foreach (var t in tmData.GetAllTiles())
				{
					if (t != null)
						t.transform = rotMat;
				}
				foreach (var goal in sec.GetComponentsInChildren<OverworldGoal>(true))
				{
					if (goal != null)
						goal.DontRotateBasedOnLevel = sec.shouldRotateTilesForMobile;
				}
			}
			else
			{
				Matrix4x4 idMat = Matrix4x4.Rotate(Quaternion.Euler(0f, 0f, 0f));
				foreach (var t in tmData.GetAllTiles())
				{
					if (t != null)
						t.transform = idMat;
				}
			}

			int endX = minX + sizeX;
			int endY = minY + sizeY;
			for (int x = minX; x < endX; x++)
			{
				for (int y = minY; y < endY; y++)
				{
					Vector3Int pos = new Vector3Int(x, y, 0);
					CheckTile(tmData, pos, sec, isRotated);
				}
			}

			if (sec.SectionTilemap != null)
			{
				var r = sec.SectionTilemap.GetComponent<Renderer>();
				if (r != null) r.enabled = false;
			}
		}

		if (leftBorder != null) leftBorder.RefreshAllTiles();
		if (rightBorder != null) rightBorder.RefreshAllTiles();
		if (rotatedRightBorder != null) rotatedRightBorder.RefreshAllTiles();
		if (collison != null) collison.RefreshAllTiles();
		if (topBorder != null) topBorder.RefreshAllTiles();
		if (bottomBorder != null) bottomBorder.RefreshAllTiles();
		if (bottomCornerRightBorder != null) bottomCornerRightBorder.RefreshAllTiles();
		if (bottomCornerLeftBorder != null) bottomCornerLeftBorder.RefreshAllTiles();
		if (topCornerRightBorder != null) topCornerRightBorder.RefreshAllTiles();
		if (topCornerLeftBorder != null) topCornerLeftBorder.RefreshAllTiles();
		if (innerCornerTopLeft != null) innerCornerTopLeft.RefreshAllTiles();
		if (innerCornerTopRight != null) innerCornerTopRight.RefreshAllTiles();
		if (innerCornerBottomLeft != null) innerCornerBottomLeft.RefreshAllTiles();
		if (innerCornerBottomRight != null) innerCornerBottomRight.RefreshAllTiles();
		if (diagonals != null) diagonals.RefreshAllTiles();
		if (groundMap != null) groundMap.RefreshAllTiles();

		for (int i = 0; i < hubSections.Length; i++)
		{
			if (hubSections[i] != null && hubSections[i].SectionTilemap != null)
				hubSections[i].SectionTilemap.enabled = true;
		}
	}

	public List<Tilemap> GetAllTilemaps()
	{
		return allTilemaps;
	}

	public void PreBuildScript(Action<float> onProgress, Action onComplete, bool forceBuild = false)
	{
		ShowGridAndDecorationsOnly();
		if (hubSectionContainer != null)
			hubSections = hubSectionContainer.GetComponentsInChildren<HubSection>(true);
		OnPrePlayOrPreCompile();
		onComplete?.Invoke();
	}

	public void CreateCompositeCollider(GameObject target)
	{
		if (target == null) return;
		var oldComp = target.GetComponent<CompositeCollider2D>();
		if (oldComp != null)
			DestroyImmediate(oldComp);

		var comp = target.AddComponent<CompositeCollider2D>();
		if (comp != null)
		{
			comp.vertexDistance = 0.005f;
			comp.offsetDistance = 1e-08f;
			comp.geometryType = CompositeCollider2D.GeometryType.Outlines;
			comp.generationType = CompositeCollider2D.GenerationType.Manual;
			comp.sharedMaterial = colliderMat;
			comp.GenerateGeometry();
		}
	}

	private TileBase CheckSectionsForTile(Vector3Int pos)
	{
		if (hubSections == null) return null;
		for (int i = 0; i < hubSections.Length; i++)
		{
			var sec = hubSections[i];
			if (sec == null || sec.SectionTilemap == null || !sec.SectionTilemap.gameObject.activeInHierarchy)
				continue;
			Bounds b = sec.GetBounds(false);
			if (!b.Contains(new Vector3(pos.x, pos.y, pos.z)))
				continue;
			Vector3 secPos = sec.transform.position;
			Vector3Int localPos = new Vector3Int(pos.x - (int)secPos.x, pos.y - (int)secPos.y, pos.z);
			TileBase tile = sec.SectionTilemap.GetTile(localPos);
			if (tile != null)
				return tile;
		}
		return null;
	}

	private bool CheckTile(TileMapData tiles, Vector3Int tilePos, HubSection currentSection, bool isRotated)
	{
		if (currentSection == null || currentSection.SectionTilemap == null || tiles == null)
			return false;

		Vector3 secPos = currentSection.transform.position;
		Vector3Int localPos = new Vector3Int(tilePos.x - (int)secPos.x, tilePos.y - (int)secPos.y, tilePos.z);
		TileBase centerTile = currentSection.SectionTilemap.GetTile(localPos);
		if (centerTile == null)
			return false;

		Vector3Int posTop, posBottom, posRight, posLeft, posTopLeft, posTopRight, posBottomLeft, posBottomRight;
		if (isRotated && currentSection.shouldRotateTilesForMobile)
		{
			posTop = tilePos + new Vector3Int(1, 0, 0);
			posBottom = tilePos + new Vector3Int(-1, 0, 0);
			posRight = tilePos + new Vector3Int(0, 1, 0);
			posLeft = tilePos + new Vector3Int(0, -1, 0);
			posTopLeft = tilePos + new Vector3Int(1, -1, 0);
			posTopRight = tilePos + new Vector3Int(1, 1, 0);
			posBottomLeft = tilePos + new Vector3Int(-1, -1, 0);
			posBottomRight = tilePos + new Vector3Int(-1, 1, 0);
		}
		else
		{
			posTop = tilePos + new Vector3Int(0, 1, 0);
			posBottom = tilePos + new Vector3Int(0, -1, 0);
			posLeft = tilePos + new Vector3Int(-1, 0, 0);
			posRight = tilePos + new Vector3Int(1, 0, 0);
			posTopRight = tilePos + new Vector3Int(1, 1, 0);
			posTopLeft = tilePos + new Vector3Int(-1, 1, 0);
			posBottomRight = tilePos + new Vector3Int(1, -1, 0);
			posBottomLeft = tilePos + new Vector3Int(-1, -1, 0);
		}

		TileBase tileTop = CheckSectionsForTile(posTop);
		TileBase tileBottom = CheckSectionsForTile(posBottom);
		TileBase tileRight = CheckSectionsForTile(posRight);
		TileBase tileLeft = CheckSectionsForTile(posLeft);
		TileBase tileTopLeft = CheckSectionsForTile(posTopLeft);
		TileBase tileTopRight = CheckSectionsForTile(posTopRight);
		TileBase tileBottomLeft = CheckSectionsForTile(posBottomLeft);
		TileBase tileBottomRight = CheckSectionsForTile(posBottomRight);

		bool changed = false;
		if (IsRound(tiles, centerTile))
		{
			if (centerTile == tiles.roundTopLeft)
			{
				if (collison != null) collison.SetTile(tilePos, tiles.borderRoundTopLeft);
				if (groundMap != null) groundMap.SetTile(tilePos, ((tilePos.x + tilePos.y) & 1) == 0 ? tiles.targetTile : tiles.targetTileAlt);
				changed = true;
			}
			else if (centerTile == tiles.roundTopRight)
			{
				if (collison != null) collison.SetTile(tilePos, tiles.borderRoundTopRight);
				if (groundMap != null) groundMap.SetTile(tilePos, ((tilePos.x + tilePos.y) & 1) == 0 ? tiles.targetTile : tiles.targetTileAlt);
				changed = true;
			}
			else if (centerTile == tiles.roundBottomLeft)
			{
				if (collison != null) collison.SetTile(tilePos, tiles.borderRoundBottomLeft);
				if (groundMap != null) groundMap.SetTile(tilePos, ((tilePos.x + tilePos.y) & 1) == 0 ? tiles.targetTile : tiles.targetTileAlt);
				changed = true;
			}
			else if (centerTile == tiles.roundBottomRight)
			{
				if (collison != null) collison.SetTile(tilePos, tiles.borderRoundBottomRight);
				if (groundMap != null) groundMap.SetTile(tilePos, ((tilePos.x + tilePos.y) & 1) == 0 ? tiles.targetTile : tiles.targetTileAlt);
				changed = true;
			}
		}
		else
		{
			if (tileTop == null)
			{
				if (topBorder != null) topBorder.SetTile(posTop, tiles.borderTop);
				changed = true;
			}
			if (tileBottom == null)
			{
				if (bottomBorder != null) bottomBorder.SetTile(posBottom, tiles.borderBottom);
				changed = true;
			}
			if (tileLeft == null)
			{
				if (leftBorder != null) leftBorder.SetTile(posLeft, tiles.borderSideLeft);
				changed = true;
			}
			if (tileRight == null)
			{
				Tilemap rbMap = (isRotated && currentSection.shouldRotateTilesForMobile) ? rotatedRightBorder : rightBorder;
				if (rbMap != null) rbMap.SetTile(posRight, tiles.borderSideRight);
				changed = true;
			}
			if (tileTopRight == null && tileTop == null && tileRight == null)
			{
				if (topCornerRightBorder != null) topCornerRightBorder.SetTile(posTopRight, tiles.borderOuterTopRight);
				changed = true;
			}
			if (tileTopLeft == null && tileTop == null && tileLeft == null)
			{
				if (topCornerLeftBorder != null) topCornerLeftBorder.SetTile(posTopLeft, tiles.borderOuterTopLeft);
				changed = true;
			}
			if (tileBottomLeft == null && tileRight == null && tileBottom == null)
			{
				if (bottomCornerLeftBorder != null) bottomCornerLeftBorder.SetTile(posBottomLeft, tiles.borderOuterBottomLeft);
				changed = true;
			}
			if (tileBottomRight == null && tileLeft == null && tileBottom == null)
			{
				if (bottomCornerRightBorder != null) bottomCornerRightBorder.SetTile(posBottomRight, tiles.borderOuterBottomRight);
				changed = true;
			}
		}

		if (groundMap != null)
		{
			groundMap.SetTile(tilePos, ((tilePos.x + tilePos.y) & 1) == 0 ? tiles.targetTile : tiles.targetTileAlt);
		}
		return changed;
	}

	public bool IsTileTarget(Vector3Int pos)
	{
		if (tileMaps != null && tileMaps.Count > 0)
		{
			bool any = false;
			for (int i = 0; i < tileMaps.Count; i++)
			{
				if (IsTileTarget(tileMaps[i], pos))
					any = true;
			}
			if (any)
				return true;
		}
		Tilemap gMap = currentGroundMap;
		if (gMap != null && gMap.GetTile(pos) != null)
			return true;
		return false;
	}

	public bool IsTileTarget(TileMapData tiles, Vector3Int pos)
	{
		if (tiles == null) return false;
		Tilemap gMap = currentGroundMap;
		if (gMap != null)
		{
			TileBase t = gMap.GetTile(pos);
			if (t != null && (t == tiles.targetTile || t == tiles.targetTileAlt))
				return true;
		}
		if (hubBlueprint != null)
		{
			TileBase bt = hubBlueprint.GetTile(pos);
			if (bt != null && (bt == tiles.targetTile || bt == tiles.targetTileAlt))
				return true;
		}
		return false;
	}

	public bool IsRound(TileMapData tiles, TileBase tile)
	{
		if (tiles == null || tile == null) return false;
		return tile == tiles.roundTopRight || tile == tiles.roundBottomLeft || tile == tiles.roundTopLeft || tile == tiles.roundBottomRight;
	}

	public bool IsTileTargetOrDiagonalOrRound(TileMapData tiles, TileBase tile)
	{
		if (tile != null) return true;
		return IsRound(tiles, tile);
	}

	public bool IsTileTargetOrOrRound(TileMapData tiles, TileBase tile)
	{
		if (tile != null) return true;
		return IsRound(tiles, tile);
	}

	public bool IsTileTarget(TileMapData tiles, TileBase tile)
	{
		return tile != null;
	}

	public void ShowSectionsBaseOnly()
	{
		gameObject.SetActive(false);
		if (hubSectionContainer != null)
			hubSections = hubSectionContainer.GetComponentsInChildren<HubSection>(true);
		if (hubSections == null) return;
		foreach (var s in hubSections)
		{
			if (s == null) continue;
			if (s.SectionTilemap != null)
			{
				s.SectionTilemap.enabled = true;
				var r = s.SectionTilemap.GetComponent<Renderer>();
				if (r != null) r.enabled = true;
			}
			if (s.DecorationsMaps != null)
			{
				foreach (var dm in s.DecorationsMaps)
				{
					if (dm != null)
					{
						var dr = dm.GetComponent<Renderer>();
						if (dr != null) dr.enabled = false;
					}
				}
			}
		}
	}

	public void ShowSectionsWithDecorationOnly()
	{
		gameObject.SetActive(false);
		if (hubSectionContainer != null)
			hubSections = hubSectionContainer.GetComponentsInChildren<HubSection>(true);
		if (hubSections == null) return;
		foreach (var s in hubSections)
		{
			if (s == null) continue;
			if (s.SectionTilemap != null)
			{
				s.SectionTilemap.enabled = true;
				var r = s.SectionTilemap.GetComponent<Renderer>();
				if (r != null) r.enabled = true;
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

	public void ShowGridOnly()
	{
		gameObject.SetActive(true);
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
							if (dr != null) dr.enabled = false;
						}
					}
				}
			}
		}
	}
}
