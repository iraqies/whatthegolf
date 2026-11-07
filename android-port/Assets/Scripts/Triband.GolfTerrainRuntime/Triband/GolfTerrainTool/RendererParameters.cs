using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.GolfTerrainTool
{
	[Serializable]
	[Token(Token = "0x2000007")]
	public sealed class RendererParameters : ScriptableObject
	{
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material m_Material;

		[Token(Token = "0x1700001E")]
		public Material material
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x29FED34", Offset = "0x29FED34", VA = "0x29FED34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x29FED3C", Offset = "0x29FED3C", VA = "0x29FED3C")]
			set
			{
			}
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x29FED2C", Offset = "0x29FED2C", VA = "0x29FED2C")]
		public RendererParameters()
		{
		}
	}
}
