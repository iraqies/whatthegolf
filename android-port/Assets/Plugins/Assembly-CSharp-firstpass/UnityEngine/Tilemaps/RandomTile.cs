using System;
using Il2CppDummyDll;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	[Token(Token = "0x20000C7")]
	public class RandomTile : Tile
	{
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		public Sprite[] m_Sprites;

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x13D8F0C", Offset = "0x13D8F0C", VA = "0x13D8F0C", Slot = "5")]
		public override void GetTileData(Vector3Int location, ITilemap tileMap, ref TileData tileData)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x13D9028", Offset = "0x13D9028", VA = "0x13D9028")]
		public RandomTile()
		{
		}
	}
}
