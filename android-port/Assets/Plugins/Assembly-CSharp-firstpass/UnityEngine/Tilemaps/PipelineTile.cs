using System;
using Il2CppDummyDll;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	[Token(Token = "0x20000C6")]
	public class PipelineTile : TileBase
	{
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Sprite[] m_Sprites;

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x13BF8A8", Offset = "0x13BF8A8", VA = "0x13BF8A8", Slot = "4")]
		public override void RefreshTile(Vector3Int location, ITilemap tileMap)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x13BFA88", Offset = "0x13BFA88", VA = "0x13BFA88", Slot = "5")]
		public override void GetTileData(Vector3Int location, ITilemap tileMap, ref TileData tileData)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x13BFA90", Offset = "0x13BFA90", VA = "0x13BFA90")]
		private void UpdateTile(Vector3Int location, ITilemap tileMap, ref TileData tileData)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x13BF9A0", Offset = "0x13BF9A0", VA = "0x13BF9A0")]
		private bool TileValue(ITilemap tileMap, Vector3Int position)
		{
			return default;
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x13BFE44", Offset = "0x13BFE44", VA = "0x13BFE44")]
		private int GetIndex(byte mask)
		{
			return default;
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x13BFE70", Offset = "0x13BFE70", VA = "0x13BFE70")]
		private Matrix4x4 GetTransform(byte mask)
		{
			return default;
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x13BFFD0", Offset = "0x13BFFD0", VA = "0x13BFFD0")]
		public PipelineTile()
		{
		}
	}
}
