using System;
using Il2CppDummyDll;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	[Token(Token = "0x20000C5")]
	public class AnimatedTile : TileBase
	{
		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x18")]
		public Sprite[] m_AnimatedSprites;

		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0x20")]
		public float m_MinSpeed;

		[Token(Token = "0x40003BD")]
		[FieldOffset(Offset = "0x24")]
		public float m_MaxSpeed;

		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0x28")]
		public float m_AnimationStartTime;

		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0x2C")]
		public Tile.ColliderType m_TileColliderType;

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x12EDC6C", Offset = "0x12EDC6C", VA = "0x12EDC6C", Slot = "5")]
		public override void GetTileData(Vector3Int location, ITilemap tileMap, ref TileData tileData)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x12EDD10", Offset = "0x12EDD10", VA = "0x12EDD10", Slot = "6")]
		public override bool GetTileAnimationData(Vector3Int location, ITilemap tileMap, ref TileAnimationData tileAnimationData)
		{
			return default;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x12EDD88", Offset = "0x12EDD88", VA = "0x12EDD88")]
		public AnimatedTile()
		{
		}
	}
}
