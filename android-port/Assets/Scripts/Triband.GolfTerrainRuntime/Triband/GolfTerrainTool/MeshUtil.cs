using System.Collections.Generic;
using UnityEngine;

namespace Triband.GolfTerrainTool
{
	public static class MeshUtil
	{
		public static void UpdateMesh(CanvasParameters canvasParameters, MeshParameters parameters, ref Mesh mesh, byte[] values)
		{
		}

		private static void InitialContour(CanvasParameters canvasParameters, byte[] values, ref List<Vector2> contourVertices, ref List<int> contourTriangles, ref List<int> contourEdges)
		{
		}

		private static void SmoothContour(ref List<Vector2> contourVertices, ref List<int> contourTriangles, ref List<int> contourEdges)
		{
		}

		private static void GenerateEdgeNormals(ref List<Vector2> contourVertices, ref List<int> contourEdges, ref List<Vector3> edgeNormals)
		{
		}

		private static void GenerateSurface(CanvasParameters canvasParameters, ref List<Vector2> contourVertices, ref List<int> contourTriangles, ref List<Vector3> meshVertices, ref List<int> meshTriangles, ref List<Vector3> meshNormals, ref List<Color32> meshColors)
		{
		}

		private static void GenerateBevel(MeshParameters parameters, ref List<int> contourEdges, ref List<Vector3> edgeNormals, ref Dictionary<int, int> edgeDictionary, ref List<Vector3> meshVertices, ref List<Vector3> meshNormals, ref List<Color32> meshColors)
		{
		}

		private static void GenerateSkirt(MeshParameters parameters, ref List<int> contourEdges, ref List<Vector3> edgeNormals, ref Dictionary<int, int> edgeDictionary, ref List<Vector3> meshVertices, ref List<int> meshTriangles, ref List<Vector3> meshNormals, ref List<Color32> meshColors)
		{
		}

		private static void Rotate2<T>(ref T v0, ref T v1, ref T v2, ref T v3)
		{
		}

		private static void Rotate<T>(ref T v0, ref T v1, ref T v2, ref T v3)
		{
		}

		private static void Rotate<T>(ref T v0, ref T v1, ref T v2)
		{
		}
	}
}
