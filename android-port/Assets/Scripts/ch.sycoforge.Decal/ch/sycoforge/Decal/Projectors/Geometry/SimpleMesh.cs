using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	public class SimpleMesh : IMesh
	{
		protected List<Vector2> uv;

		protected List<Vector2> uv2;

		protected List<Vector3> vertices;

		protected List<Vector3> normals;

		protected List<Vector4> tangents;

		protected List<Color> vertexColors;

		internal List<int> triangleIndices;

		public List<Vector3> Vertices => null;

		public List<Vector3> Normals => null;

		public List<Vector4> Tangents => null;

		public List<Color> VertexColors => null;

		public List<int> TriangleIndices => null;

		public List<Vector2> UV => null;
	}
}
