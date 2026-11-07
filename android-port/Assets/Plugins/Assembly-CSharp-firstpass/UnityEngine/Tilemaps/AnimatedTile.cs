using System;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	public class AnimatedTile : TileBase
	{
		public Sprite[] m_AnimatedSprites;

		public float m_MinSpeed;

		public float m_MaxSpeed;

		public float m_AnimationStartTime;

		public Tile.ColliderType m_TileColliderType;

		public override void GetTileData(Vector3Int location, ITilemap tileMap, ref TileData tileData)
		{
		}

		public override bool GetTileAnimationData(Vector3Int location, ITilemap tileMap, ref TileAnimationData tileAnimationData)
		{
			return false;
		}
	}
}
