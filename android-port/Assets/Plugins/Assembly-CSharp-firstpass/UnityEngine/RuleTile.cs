using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Tilemaps;

namespace UnityEngine
{
	[Serializable]
	[Token(Token = "0x20000BA")]
	public class RuleTile : TileBase
	{
		[Serializable]
		[Token(Token = "0x20000BB")]
		public class TilingRule
		{
			[Token(Token = "0x20000BC")]
			public enum Transform
			{
				[Token(Token = "0x4000394")]
				Fixed = 0,
				[Token(Token = "0x4000395")]
				Rotated = 1,
				[Token(Token = "0x4000396")]
				MirrorX = 2,
				[Token(Token = "0x4000397")]
				MirrorY = 3
			}

			[Token(Token = "0x20000BD")]
			public enum Neighbor
			{
				[Token(Token = "0x4000399")]
				DontCare = 0,
				[Token(Token = "0x400039A")]
				This = 1,
				[Token(Token = "0x400039B")]
				NotThis = 2
			}

			[Token(Token = "0x20000BE")]
			public enum OutputSprite
			{
				[Token(Token = "0x400039D")]
				Single = 0,
				[Token(Token = "0x400039E")]
				Random = 1,
				[Token(Token = "0x400039F")]
				Animation = 2
			}

			[Token(Token = "0x400038B")]
			[FieldOffset(Offset = "0x10")]
			public Neighbor[] m_Neighbors;

			[Token(Token = "0x400038C")]
			[FieldOffset(Offset = "0x18")]
			public Sprite[] m_Sprites;

			[Token(Token = "0x400038D")]
			[FieldOffset(Offset = "0x20")]
			public float m_AnimationSpeed;

			[Token(Token = "0x400038E")]
			[FieldOffset(Offset = "0x24")]
			public float m_PerlinScale;

			[Token(Token = "0x400038F")]
			[FieldOffset(Offset = "0x28")]
			public Transform m_RuleTransform;

			[Token(Token = "0x4000390")]
			[FieldOffset(Offset = "0x2C")]
			public OutputSprite m_Output;

			[Token(Token = "0x4000391")]
			[FieldOffset(Offset = "0x30")]
			public Tile.ColliderType m_ColliderType;

			[Token(Token = "0x4000392")]
			[FieldOffset(Offset = "0x34")]
			public Transform m_RandomTransform;

			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x135612C", Offset = "0x135612C", VA = "0x135612C")]
			public TilingRule()
			{
			}
		}

		[Token(Token = "0x4000385")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[,] RotatedOrMirroredIndexes;

		[Token(Token = "0x4000386")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int NeighborCount;

		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x18")]
		public Sprite m_DefaultSprite;

		[Token(Token = "0x4000388")]
		[FieldOffset(Offset = "0x20")]
		public Tile.ColliderType m_DefaultColliderType;

		[Token(Token = "0x4000389")]
		[FieldOffset(Offset = "0x28")]
		private TileBase[] m_CachedNeighboringTiles;

		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x30")]
		public List<TilingRule> m_TilingRules;

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x13F7C88", Offset = "0x13F7C88", VA = "0x13F7C88", Slot = "5")]
		public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x13F8528", Offset = "0x13F8528", VA = "0x13F8528")]
		private static float GetPerlinValue(Vector3Int position, float scale, float offset)
		{
			return default;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x13F8A38", Offset = "0x13F8A38", VA = "0x13F8A38", Slot = "6")]
		public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
		{
			return default;
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x13F8CAC", Offset = "0x13F8CAC", VA = "0x13F8CAC", Slot = "4")]
		public override void RefreshTile(Vector3Int location, ITilemap tileMap)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x13F830C", Offset = "0x13F830C", VA = "0x13F830C")]
		public bool RuleMatches(TilingRule rule, ref TileBase[] neighboringTiles, ref Matrix4x4 transform)
		{
			return default;
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x13F859C", Offset = "0x13F859C", VA = "0x13F859C")]
		private static Matrix4x4 ApplyRandomTransform(TilingRule.Transform type, Matrix4x4 original, float perlinScale, Vector3Int position)
		{
			return default;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x13F8E58", Offset = "0x13F8E58", VA = "0x13F8E58")]
		public bool RuleMatches(TilingRule rule, ref TileBase[] neighboringTiles, int angle)
		{
			return default;
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x13F8FFC", Offset = "0x13F8FFC", VA = "0x13F8FFC")]
		public bool RuleMatches(TilingRule rule, ref TileBase[] neighboringTiles, bool mirrorX, bool mirrorY)
		{
			return default;
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x13F8104", Offset = "0x13F8104", VA = "0x13F8104")]
		private void GetMatchingNeighboringTiles(ITilemap tilemap, Vector3Int position, ref TileBase[] neighboringTiles)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x13F91A8", Offset = "0x13F91A8", VA = "0x13F91A8")]
		private int GetRotatedIndex(int original, int rotation)
		{
			return default;
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x13F9324", Offset = "0x13F9324", VA = "0x13F9324")]
		private int GetMirroredIndex(int original, bool mirrorX, bool mirrorY)
		{
			return default;
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x13F94A4", Offset = "0x13F94A4", VA = "0x13F94A4")]
		private int GetIndexOfOffset(Vector3Int offset)
		{
			return default;
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x13F9500", Offset = "0x13F9500", VA = "0x13F9500")]
		public Vector3Int GetRotatedPos(Vector3Int original, int rotation)
		{
			return default;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x13F9608", Offset = "0x13F9608", VA = "0x13F9608")]
		public Vector3Int GetMirroredPos(Vector3Int original, bool mirrorX, bool mirrorY)
		{
			return default;
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x13F7B74", Offset = "0x13F7B74", VA = "0x13F7B74")]
		public RuleTile()
		{
		}
	}
}
