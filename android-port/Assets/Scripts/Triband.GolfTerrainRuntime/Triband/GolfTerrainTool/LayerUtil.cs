using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.GolfTerrainTool
{
	[Token(Token = "0x200000C")]
	public static class LayerUtil
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x29FC298", Offset = "0x29FC298", VA = "0x29FC298")]
		public static void ApplyBrushToLayer(Brush brush, GolfTerrain golfTerrain, TerrainLayer layer, Vector3 position, Quaternion rotation, Vector3 scale, bool isEraser = false)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x29FBAB4", Offset = "0x29FBAB4", VA = "0x29FBAB4")]
		public static byte[] EvaluateLayers(CanvasParameters canvasParameters, List<TerrainLayer> layers)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x29FC914", Offset = "0x29FC914", VA = "0x29FC914")]
		private static void BlendAdd(CanvasParameters canvasParameters, ref byte[] values, byte[] layerValues)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x29FC9DC", Offset = "0x29FC9DC", VA = "0x29FC9DC")]
		private static void BlendSubtract(CanvasParameters canvasParameters, ref byte[] values, byte[] layerValues)
		{
		}
	}
}
