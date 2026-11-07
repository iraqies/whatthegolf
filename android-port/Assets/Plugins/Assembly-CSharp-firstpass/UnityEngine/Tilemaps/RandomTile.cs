using System;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	public class RandomTile : Tile
	{
		[SerializeField]
		public Sprite[] m_Sprites;

		public override void GetTileData(Vector3Int location, ITilemap tileMap, ref TileData tileData)
		{
		}
	}
}
