using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.GolfTerrainTool
{
	[Token(Token = "0x200000D")]
	public static class MeshUtil
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x29FBC14", Offset = "0x29FBC14", VA = "0x29FBC14")]
		public static void UpdateMesh(CanvasParameters canvasParameters, MeshParameters parameters, ref Mesh mesh, byte[] values)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x29FCB1C", Offset = "0x29FCB1C", VA = "0x29FCB1C")]
		private static void InitialContour(CanvasParameters canvasParameters, byte[] values, ref List<Vector2> contourVertices, ref List<int> contourTriangles, ref List<int> contourEdges)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x29FD7B8", Offset = "0x29FD7B8", VA = "0x29FD7B8")]
		private static void SmoothContour(ref List<Vector2> contourVertices, ref List<int> contourTriangles, ref List<int> contourEdges)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x29FDE24", Offset = "0x29FDE24", VA = "0x29FDE24")]
		private static void GenerateEdgeNormals(ref List<Vector2> contourVertices, ref List<int> contourEdges, ref List<Vector3> edgeNormals)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x29FE0E0", Offset = "0x29FE0E0", VA = "0x29FE0E0")]
		private static void GenerateSurface(CanvasParameters canvasParameters, ref List<Vector2> contourVertices, ref List<int> contourTriangles, ref List<Vector3> meshVertices, ref List<int> meshTriangles, ref List<Vector3> meshNormals, ref List<Color32> meshColors)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x29FE36C", Offset = "0x29FE36C", VA = "0x29FE36C")]
		private static void GenerateBevel(MeshParameters parameters, ref List<int> contourEdges, ref List<Vector3> edgeNormals, ref Dictionary<int, int> edgeDictionary, ref List<Vector3> meshVertices, ref List<Vector3> meshNormals, ref List<Color32> meshColors)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x29FE6C8", Offset = "0x29FE6C8", VA = "0x29FE6C8")]
		private static void GenerateSkirt(MeshParameters parameters, ref List<int> contourEdges, ref List<Vector3> edgeNormals, ref Dictionary<int, int> edgeDictionary, ref List<Vector3> meshVertices, ref List<int> meshTriangles, ref List<Vector3> meshNormals, ref List<Color32> meshColors)
		{
		}

		[Token(Token = "0x600005E")]
		private static void Rotate2<T>(ref T v0, ref T v1, ref T v2, ref T v3)
		{
		}

		[Token(Token = "0x600005F")]
		private static void Rotate<T>(ref T v0, ref T v1, ref T v2, ref T v3)
		{
		}

		[Token(Token = "0x6000060")]
		private static void Rotate<T>(ref T v0, ref T v1, ref T v2)
		{
		}
	}
}
