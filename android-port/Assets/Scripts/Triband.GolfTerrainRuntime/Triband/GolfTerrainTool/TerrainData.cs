using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.GolfTerrainTool
{
	[Token(Token = "0x2000008")]
	public sealed class TerrainData : ScriptableObject
	{
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<TerrainLayer> m_Layers;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_PointCount;

		[Token(Token = "0x1700001F")]
		public List<TerrainLayer> layers
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x29FEDC8", Offset = "0x29FEDC8", VA = "0x29FEDC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public int pointCount
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x29FEDD0", Offset = "0x29FEDD0", VA = "0x29FEDD0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x29FED44", Offset = "0x29FED44", VA = "0x29FED44")]
		public TerrainData()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x29FEDD8", Offset = "0x29FEDD8", VA = "0x29FEDD8")]
		public void Init(int pointCount)
		{
		}
	}
}
