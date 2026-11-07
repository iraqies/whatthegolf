using System.Collections.Generic;
using UnityEngine;

namespace Triband.GolfTerrainTool
{
	public static class LayerUtil
	{
		public static void ApplyBrushToLayer(Brush brush, GolfTerrain golfTerrain, TerrainLayer layer, Vector3 position, Quaternion rotation, Vector3 scale, bool isEraser = false)
		{
		}

		public static byte[] EvaluateLayers(CanvasParameters canvasParameters, List<TerrainLayer> layers)
		{
			return null;
		}

		private static void BlendAdd(CanvasParameters canvasParameters, ref byte[] values, byte[] layerValues)
		{
		}

		private static void BlendSubtract(CanvasParameters canvasParameters, ref byte[] values, byte[] layerValues)
		{
		}
	}
}
