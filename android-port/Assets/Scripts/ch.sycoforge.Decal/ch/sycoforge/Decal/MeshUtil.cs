using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x2000029")]
	public static class MeshUtil
	{
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x0")]
		private static List<Vector4> tangentsTemp;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x8")]
		private static Mesh cubeMesh24;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x10")]
		private static Vector3[] cubeVertices24;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x18")]
		private static Vector3[] cubeNormals24;

		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x20")]
		private static int[] cubeTriangles24;

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x2C6A8C4", Offset = "0x2C6A8C4", VA = "0x2C6A8C4")]
		public static List<int> AdjacentIndices(IList<Vector3> vertices, IList<int> triangles, int index)
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2C66DEC", Offset = "0x2C66DEC", VA = "0x2C66DEC")]
		internal static IList<Vector4> CalculateTangents(IList<Vector3> vertices, IList<Vector3> normals, IList<Vector2> uv, IList<int> triangles)
		{
			return null;
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2C663F8", Offset = "0x2C663F8", VA = "0x2C663F8")]
		internal static void CalculateNormals(IList<Vector3> normals, IList<Vector3> vertices, IList<int> triangles, float factor = 1f)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2C66B00", Offset = "0x2C66B00", VA = "0x2C66B00")]
		internal static void SmoothVertexNormals(IList<Vector3> normals, Vector3 inverseProjectionDir, float factor, float threshold)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2C6ADF4", Offset = "0x2C6ADF4", VA = "0x2C6ADF4")]
		internal static float FaceFactor(Vector3 normal, Vector3 inverseProjectionDir)
		{
			return default;
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2C59440", Offset = "0x2C59440", VA = "0x2C59440")]
		internal static Mesh MeshFromBoxCollider24(BoxCollider collider)
		{
			return null;
		}
	}
}
