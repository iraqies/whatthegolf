using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x2000036")]
	public class MeshCutter<M> : IMeshCutter where M : DynamicMesh
	{
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x0")]
		internal M dynamicMesh;

		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x0")]
		internal EasyDecal Parent;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x0")]
		internal IList<sbyte> vertexPositions;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x0")]
		internal List<int> outsideIndices;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x0")]
		internal List<int> trashedTriangleIndices;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x0")]
		internal IndexTrashBin indexTrash;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x0")]
		internal static Vector3 normalTop;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x0")]
		internal static Vector3 normalBottom;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x0")]
		internal static Vector3 normalRight;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x0")]
		internal static Vector3 normalLeft;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x0")]
		internal static Vector3 normalFront;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x0")]
		internal static Vector3 normalBack;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x0")]
		internal static Vector3 centerTop;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x0")]
		internal static Vector3 centerBottom;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x0")]
		internal static Vector3 centerRight;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x0")]
		internal static Vector3 centerLeft;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x0")]
		internal static Vector3 centerFront;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x0")]
		internal static Vector3 centerBack;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x0")]
		internal static MathPlane[] cutPlanes;

		[Token(Token = "0x60001DD")]
		public MeshCutter(EasyDecal parent)
		{
		}

		[Token(Token = "0x60001DE")]
		private void ch_002Esycoforge_002EDecal_002EProjectors_002EGeometry_002EIMeshCutter_002ECutMesh(DynamicMesh dynamicMesh)
		{
		}

		[Token(Token = "0x60001DF")]
		private void Cleanup()
		{
		}

		[Token(Token = "0x60001E0")]
		private void RemoveIndices(IndexTrashBin trash)
		{
		}

		[Token(Token = "0x60001E1")]
		private bool HasIntersection(sbyte vertexPositionA, sbyte vertexPositionB)
		{
			return default;
		}

		[Token(Token = "0x60001E2")]
		private void InitializeVertexPositions(DynamicMesh dynamicMesh, MathPlane plane)
		{
		}

		[Token(Token = "0x60001E3")]
		private void CutAlongPlane(DynamicMesh dynamicMesh, MathPlane plane)
		{
		}

		[Token(Token = "0x60001E4")]
		protected sbyte GetVertexPosition(MathPlane plane, Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x60001E5")]
		protected virtual void Cut(int indexA, int indexB, sbyte vertexPosA, MathPlane plane)
		{
		}

		[Token(Token = "0x60001E6")]
		protected Vector3 TransformPoint(Ray ray, float factor)
		{
			return default;
		}
	}
}
