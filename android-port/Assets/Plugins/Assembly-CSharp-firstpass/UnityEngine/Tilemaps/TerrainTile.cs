using System;
using Il2CppDummyDll;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	[Token(Token = "0x20000C8")]
	public class TerrainTile : TileBase
	{
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Sprite[] m_Sprites;

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1319D58", Offset = "0x1319D58", VA = "0x1319D58", Slot = "4")]
		public override void RefreshTile(Vector3Int location, ITilemap tileMap)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1319F38", Offset = "0x1319F38", VA = "0x1319F38", Slot = "5")]
		public override void GetTileData(Vector3Int location, ITilemap tileMap, ref TileData tileData)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1319F40", Offset = "0x1319F40", VA = "0x1319F40")]
		private void UpdateTile(Vector3Int location, ITilemap tileMap, ref TileData tileData)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1319E50", Offset = "0x1319E50", VA = "0x1319E50")]
		private bool TileValue(ITilemap tileMap, Vector3Int position)
		{
			return default;
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x131A5D8", Offset = "0x131A5D8", VA = "0x131A5D8")]
		private int GetIndex(byte mask)
		{
			return default;
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x131A95C", Offset = "0x131A95C", VA = "0x131A95C")]
		private Matrix4x4 GetTransform(byte mask)
		{
			return default;
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x131AC04", Offset = "0x131AC04", VA = "0x131AC04")]
		public TerrainTile()
		{
		}
	}
}
