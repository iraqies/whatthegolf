using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Tilemaps;

[Token(Token = "0x20004AC")]
public class GridFiller : GolfBehaviour
{
	[Serializable]
	[Token(Token = "0x20004AD")]
	public class TileMapData
	{
		[Token(Token = "0x40018A7")]
		[FieldOffset(Offset = "0x10")]
		public Tile targetTile;

		[Token(Token = "0x40018A8")]
		[FieldOffset(Offset = "0x18")]
		public Tile targetTileAlt;

		[Token(Token = "0x40018A9")]
		[FieldOffset(Offset = "0x20")]
		public Tile diagonalTopRight;

		[Token(Token = "0x40018AA")]
		[FieldOffset(Offset = "0x28")]
		public Tile diagonalTopLeft;

		[Token(Token = "0x40018AB")]
		[FieldOffset(Offset = "0x30")]
		public Tile diagonalBottomRight;

		[Token(Token = "0x40018AC")]
		[FieldOffset(Offset = "0x38")]
		public Tile diagonalBottomLeft;

		[Token(Token = "0x40018AD")]
		[FieldOffset(Offset = "0x40")]
		public Tile roundTopRight;

		[Token(Token = "0x40018AE")]
		[FieldOffset(Offset = "0x48")]
		public Tile roundTopLeft;

		[Token(Token = "0x40018AF")]
		[FieldOffset(Offset = "0x50")]
		public Tile roundBottomRight;

		[Token(Token = "0x40018B0")]
		[FieldOffset(Offset = "0x58")]
		public Tile roundBottomLeft;

		[Token(Token = "0x40018B1")]
		[FieldOffset(Offset = "0x60")]
		public Tile borderOuterBottomLeft;

		[Token(Token = "0x40018B2")]
		[FieldOffset(Offset = "0x68")]
		public Tile borderOuterBottomRight;

		[Token(Token = "0x40018B3")]
		[FieldOffset(Offset = "0x70")]
		public Tile borderOuterTopLeft;

		[Token(Token = "0x40018B4")]
		[FieldOffset(Offset = "0x78")]
		public Tile borderOuterTopRight;

		[Token(Token = "0x40018B5")]
		[FieldOffset(Offset = "0x80")]
		public Tile borderSideLeft;

		[Token(Token = "0x40018B6")]
		[FieldOffset(Offset = "0x88")]
		public Tile borderSideRight;

		[Token(Token = "0x40018B7")]
		[FieldOffset(Offset = "0x90")]
		public Tile borderTop;

		[Token(Token = "0x40018B8")]
		[FieldOffset(Offset = "0x98")]
		public Tile borderBottom;

		[Token(Token = "0x40018B9")]
		[FieldOffset(Offset = "0xA0")]
		public Tile borderInnerTopRight;

		[Token(Token = "0x40018BA")]
		[FieldOffset(Offset = "0xA8")]
		public Tile borderInnerTopLeft;

		[Token(Token = "0x40018BB")]
		[FieldOffset(Offset = "0xB0")]
		public Tile borderInnerBottomLeft;

		[Token(Token = "0x40018BC")]
		[FieldOffset(Offset = "0xB8")]
		public Tile borderInnerBottomRight;

		[Token(Token = "0x40018BD")]
		[FieldOffset(Offset = "0xC0")]
		public Tile borderDiaTopRight;

		[Token(Token = "0x40018BE")]
		[FieldOffset(Offset = "0xC8")]
		public Tile borderDiaTopLeft;

		[Token(Token = "0x40018BF")]
		[FieldOffset(Offset = "0xD0")]
		public Tile borderDiaBottomRight;

		[Token(Token = "0x40018C0")]
		[FieldOffset(Offset = "0xD8")]
		public Tile borderDiaBottomLeft;

		[Token(Token = "0x40018C1")]
		[FieldOffset(Offset = "0xE0")]
		public Tile borderRoundTopRight;

		[Token(Token = "0x40018C2")]
		[FieldOffset(Offset = "0xE8")]
		public Tile borderRoundTopLeft;

		[Token(Token = "0x40018C3")]
		[FieldOffset(Offset = "0xF0")]
		public Tile borderRoundBottomRight;

		[Token(Token = "0x40018C4")]
		[FieldOffset(Offset = "0xF8")]
		public Tile borderRoundBottomLeft;

		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x17B9338", Offset = "0x17B9338", VA = "0x17B9338")]
		public List<Tile> GetAllTiles()
		{
			return null;
		}

		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x17B95AC", Offset = "0x17B95AC", VA = "0x17B95AC")]
		public TileMapData()
		{
		}
	}

	[Token(Token = "0x4001887")]
	[FieldOffset(Offset = "0x20")]
	public GameObject normalMap;

	[Token(Token = "0x4001888")]
	[FieldOffset(Offset = "0x28")]
	public GameObject rotatedMap;

	[Token(Token = "0x4001889")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GridFilledTileMap currentTileMap;

	[Token(Token = "0x400188A")]
	[FieldOffset(Offset = "0x38")]
	public Tilemap hubBlueprint;

	[Token(Token = "0x400188B")]
	[FieldOffset(Offset = "0x40")]
	public Tilemap groundMap;

	[Token(Token = "0x400188C")]
	[FieldOffset(Offset = "0x48")]
	public GameObject hubSectionContainer;

	[Token(Token = "0x400188D")]
	[FieldOffset(Offset = "0x50")]
	public Tilemap secretMap;

	[Token(Token = "0x400188E")]
	[FieldOffset(Offset = "0x58")]
	public Tilemap leftBorder;

	[Token(Token = "0x400188F")]
	[FieldOffset(Offset = "0x60")]
	public Tilemap rightBorder;

	[Token(Token = "0x4001890")]
	[FieldOffset(Offset = "0x68")]
	public Tilemap rotatedRightBorder;

	[Token(Token = "0x4001891")]
	[FieldOffset(Offset = "0x70")]
	public Tilemap topBorder;

	[Token(Token = "0x4001892")]
	[FieldOffset(Offset = "0x78")]
	public Tilemap bottomBorder;

	[Token(Token = "0x4001893")]
	[FieldOffset(Offset = "0x80")]
	public Tilemap bottomCornerRightBorder;

	[Token(Token = "0x4001894")]
	[FieldOffset(Offset = "0x88")]
	public Tilemap bottomCornerLeftBorder;

	[Token(Token = "0x4001895")]
	[FieldOffset(Offset = "0x90")]
	public Tilemap topCornerRightBorder;

	[Token(Token = "0x4001896")]
	[FieldOffset(Offset = "0x98")]
	public Tilemap topCornerLeftBorder;

	[Token(Token = "0x4001897")]
	[FieldOffset(Offset = "0xA0")]
	public Tilemap innerCornerTopLeft;

	[Token(Token = "0x4001898")]
	[FieldOffset(Offset = "0xA8")]
	public Tilemap innerCornerTopRight;

	[Token(Token = "0x4001899")]
	[FieldOffset(Offset = "0xB0")]
	public Tilemap innerCornerBottomLeft;

	[Token(Token = "0x400189A")]
	[FieldOffset(Offset = "0xB8")]
	public Tilemap innerCornerBottomRight;

	[Token(Token = "0x400189B")]
	[FieldOffset(Offset = "0xC0")]
	public Tilemap diagonals;

	[Token(Token = "0x400189C")]
	[FieldOffset(Offset = "0xC8")]
	public Tilemap collison;

	[Token(Token = "0x400189D")]
	[FieldOffset(Offset = "0xD0")]
	public List<TilemapRenderer> AllRenders;

	[Token(Token = "0x400189E")]
	[FieldOffset(Offset = "0xD8")]
	public PhysicsMaterial2D colliderMat;

	[Token(Token = "0x400189F")]
	[FieldOffset(Offset = "0xE0")]
	public int xStart;

	[Token(Token = "0x40018A0")]
	[FieldOffset(Offset = "0xE4")]
	public int yStart;

	[Token(Token = "0x40018A1")]
	[FieldOffset(Offset = "0xE8")]
	public int xEnd;

	[Token(Token = "0x40018A2")]
	[FieldOffset(Offset = "0xEC")]
	public int yEnd;

	[Token(Token = "0x40018A3")]
	[FieldOffset(Offset = "0xF0")]
	public List<TileMapData> tileMaps;

	[Token(Token = "0x40018A4")]
	[FieldOffset(Offset = "0xF8")]
	public Tile debug;

	[Token(Token = "0x40018A5")]
	[FieldOffset(Offset = "0x100")]
	private List<Tilemap> allTilemaps;

	[Token(Token = "0x40018A6")]
	[FieldOffset(Offset = "0x108")]
	private HubSection[] hubSections;

	[Token(Token = "0x1700025D")]
	public Tilemap currentGroundMap
	{
		[Token(Token = "0x6001587")]
		[Address(RVA = "0x14B9684", Offset = "0x14B9684", VA = "0x14B9684")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700025E")]
	public Rigidbody2D currentRigid
	{
		[Token(Token = "0x6001588")]
		[Address(RVA = "0x14B96A0", Offset = "0x14B96A0", VA = "0x14B96A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001589")]
	[Address(RVA = "0x14B96F4", Offset = "0x14B96F4", VA = "0x14B96F4")]
	public void Init()
	{
	}

	[Token(Token = "0x600158A")]
	[Address(RVA = "0x14B9878", Offset = "0x14B9878", VA = "0x14B9878")]
	public void ActivateAllTileMaps()
	{
	}

	[Token(Token = "0x600158B")]
	[Address(RVA = "0x14B98FC", Offset = "0x14B98FC", VA = "0x14B98FC")]
	public void DisableAllTileMaps()
	{
	}

	[Token(Token = "0x600158C")]
	[Address(RVA = "0x14B9770", Offset = "0x14B9770", VA = "0x14B9770")]
	public void ActivateOnlyNeededTilemap()
	{
	}

	[Token(Token = "0x600158D")]
	[Address(RVA = "0x14B9980", Offset = "0x14B9980", VA = "0x14B9980", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x600158E")]
	[Address(RVA = "0x14BA8F8", Offset = "0x14BA8F8", VA = "0x14BA8F8")]
	public void PostPreCompile()
	{
	}

	[Token(Token = "0x600158F")]
	[Address(RVA = "0x14BA9D8", Offset = "0x14BA9D8", VA = "0x14BA9D8")]
	public void PrePreCompile()
	{
	}

	[Token(Token = "0x6001590")]
	[Address(RVA = "0x14B9CD8", Offset = "0x14B9CD8", VA = "0x14B9CD8")]
	public void AutoFill(bool isRotated)
	{
	}

	[Token(Token = "0x6001591")]
	[Address(RVA = "0x14BBD58", Offset = "0x14BBD58", VA = "0x14BBD58")]
	public List<Tilemap> GetAllTilemaps()
	{
		return null;
	}

	[Token(Token = "0x6001592")]
	[Address(RVA = "0x14BBD60", Offset = "0x14BBD60", VA = "0x14BBD60")]
	public void PreBuildScript(Action<float> onProgress, Action onComplete, bool forceBuild = false)
	{
	}

	[Token(Token = "0x6001593")]
	[Address(RVA = "0x14BA798", Offset = "0x14BA798", VA = "0x14BA798")]
	public void CreateCompositeCollider(GameObject target)
	{
	}

	[Token(Token = "0x6001594")]
	[Address(RVA = "0x14BC088", Offset = "0x14BC088", VA = "0x14BC088")]
	private TileBase CheckSectionsForTile(Vector3Int pos)
	{
		return null;
	}

	[Token(Token = "0x6001595")]
	[Address(RVA = "0x14BAA90", Offset = "0x14BAA90", VA = "0x14BAA90")]
	private bool CheckTile(TileMapData tiles, Vector3Int tilePos, HubSection currentSection, bool isRotated)
	{
		return default;
	}

	[Token(Token = "0x6001596")]
	[Address(RVA = "0x14BC4E4", Offset = "0x14BC4E4", VA = "0x14BC4E4")]
	public bool IsTileTarget(Vector3Int pos)
	{
		return default;
	}

	[Token(Token = "0x6001597")]
	[Address(RVA = "0x14BC64C", Offset = "0x14BC64C", VA = "0x14BC64C")]
	public bool IsTileTarget(TileMapData tiles, Vector3Int pos)
	{
		return default;
	}

	[Token(Token = "0x6001598")]
	[Address(RVA = "0x14BC340", Offset = "0x14BC340", VA = "0x14BC340")]
	public bool IsRound(TileMapData tiles, TileBase tile)
	{
		return default;
	}

	[Token(Token = "0x6001599")]
	[Address(RVA = "0x14BC748", Offset = "0x14BC748", VA = "0x14BC748")]
	public bool IsTileTargetOrDiagonalOrRound(TileMapData tiles, TileBase tile)
	{
		return default;
	}

	[Token(Token = "0x600159A")]
	[Address(RVA = "0x14BC7E0", Offset = "0x14BC7E0", VA = "0x14BC7E0")]
	public bool IsTileTargetOrOrRound(TileMapData tiles, TileBase tile)
	{
		return default;
	}

	[Token(Token = "0x600159B")]
	[Address(RVA = "0x14BC474", Offset = "0x14BC474", VA = "0x14BC474")]
	public bool IsTileTarget(TileMapData tiles, TileBase tile)
	{
		return default;
	}

	[Token(Token = "0x600159C")]
	[Address(RVA = "0x14BC878", Offset = "0x14BC878", VA = "0x14BC878")]
	public void ShowSectionsBaseOnly()
	{
	}

	[Token(Token = "0x600159D")]
	[Address(RVA = "0x14BCB18", Offset = "0x14BCB18", VA = "0x14BCB18")]
	public void ShowSectionsWithDecorationOnly()
	{
	}

	[Token(Token = "0x600159E")]
	[Address(RVA = "0x14BBDFC", Offset = "0x14BBDFC", VA = "0x14BBDFC")]
	public void ShowGridAndDecorationsOnly()
	{
	}

	[Token(Token = "0x600159F")]
	[Address(RVA = "0x14BCDB8", Offset = "0x14BCDB8", VA = "0x14BCDB8")]
	public void ShowGridOnly()
	{
	}

	[Token(Token = "0x60015A0")]
	[Address(RVA = "0x14BD044", Offset = "0x14BD044", VA = "0x14BD044")]
	public GridFiller()
	{
	}
}
