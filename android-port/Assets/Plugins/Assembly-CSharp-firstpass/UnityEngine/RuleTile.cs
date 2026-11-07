using System;
using System.Collections.Generic;
using UnityEngine.Tilemaps;

namespace UnityEngine
{
	[Serializable]
	public class RuleTile : TileBase
	{
		[Serializable]
		public class TilingRule
		{
			public enum Transform
			{
				Fixed = 0,
				Rotated = 1,
				MirrorX = 2,
				MirrorY = 3
			}

			public enum Neighbor
			{
				DontCare = 0,
				This = 1,
				NotThis = 2
			}

			public enum OutputSprite
			{
				Single = 0,
				Random = 1,
				Animation = 2
			}

			public Neighbor[] m_Neighbors;

			public Sprite[] m_Sprites;

			public float m_AnimationSpeed;

			public float m_PerlinScale;

			public Transform m_RuleTransform;

			public OutputSprite m_Output;

			public Tile.ColliderType m_ColliderType;

			public Transform m_RandomTransform;
		}

		private static readonly int[,] RotatedOrMirroredIndexes;

		private static readonly int NeighborCount;

		public Sprite m_DefaultSprite;

		public Tile.ColliderType m_DefaultColliderType;

		private TileBase[] m_CachedNeighboringTiles;

		public List<TilingRule> m_TilingRules;

		public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
		{
		}

		private static float GetPerlinValue(Vector3Int position, float scale, float offset)
		{
			return 0f;
		}

		public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
		{
			return false;
		}

		public override void RefreshTile(Vector3Int location, ITilemap tileMap)
		{
		}

		public bool RuleMatches(TilingRule rule, ref TileBase[] neighboringTiles, ref Matrix4x4 transform)
		{
			return false;
		}

		private static Matrix4x4 ApplyRandomTransform(TilingRule.Transform type, Matrix4x4 original, float perlinScale, Vector3Int position)
		{
			return default;
		}

		public bool RuleMatches(TilingRule rule, ref TileBase[] neighboringTiles, int angle)
		{
			return false;
		}

		public bool RuleMatches(TilingRule rule, ref TileBase[] neighboringTiles, bool mirrorX, bool mirrorY)
		{
			return false;
		}

		private void GetMatchingNeighboringTiles(ITilemap tilemap, Vector3Int position, ref TileBase[] neighboringTiles)
		{
		}

		private int GetRotatedIndex(int original, int rotation)
		{
			return 0;
		}

		private int GetMirroredIndex(int original, bool mirrorX, bool mirrorY)
		{
			return 0;
		}

		private int GetIndexOfOffset(Vector3Int offset)
		{
			return 0;
		}

		public Vector3Int GetRotatedPos(Vector3Int original, int rotation)
		{
			return default;
		}

		public Vector3Int GetMirroredPos(Vector3Int original, bool mirrorX, bool mirrorY)
		{
			return default;
		}
	}
}
