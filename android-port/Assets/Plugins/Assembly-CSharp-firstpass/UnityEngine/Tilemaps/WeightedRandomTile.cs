using System;
using Il2CppDummyDll;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	[Token(Token = "0x20000CA")]
	public class WeightedRandomTile : Tile
	{
		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		public WeightedSprite[] Sprites;

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x132D654", Offset = "0x132D654", VA = "0x132D654", Slot = "5")]
		public override void GetTileData(Vector3Int location, ITilemap tileMap, ref TileData tileData)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x132D7CC", Offset = "0x132D7CC", VA = "0x132D7CC")]
		public WeightedRandomTile()
		{
		}
	}
}
