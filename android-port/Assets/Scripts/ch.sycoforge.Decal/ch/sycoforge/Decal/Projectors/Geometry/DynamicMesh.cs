using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors.Geometry
{
	public class DynamicMesh : IMesh
	{
		private const int capacity = 4048;

		protected List<Vector2> uv;

		protected List<Vector2> uv2;

		protected List<Vector3> vertices;

		protected List<Vector3> normals;

		protected List<Vector4> tangents;

		protected List<Color> vertexColors;

		internal Color[] vertexColorsFreezed;

		internal RecreationMode mode;

		private int lastVertexCount;

		internal List<int> triangleIndices;

		internal IndexTrashBin trashBin;

		protected DecalBase Parent;

		protected bool freezed;

		private bool copiedOnce;

		protected static Vector3 projectionDirection;

		public List<Vector3> Vertices => null;

		public List<Vector3> Normals
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public List<Vector4> Tangents
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public List<Color> VertexColors => null;

		public List<int> TriangleIndices => null;

		public List<Vector2> UV => null;

		public List<Vector2> UV2 => null;

		internal int VerticesAmount => 0;

		internal int IndicesAmount => 0;

		public DynamicMesh(DecalBase parent, RecreationMode mode)
		{
		}

		internal void Freeze()
		{
		}

		internal void Unfreeze()
		{
		}

		public virtual void Clear()
		{
		}

		public void Add(Mesh mesh, Matrix4x4 localToWorld)
		{
		}

		public void Add(SimpleMesh mesh, Matrix4x4 localToWorld)
		{
		}

		public void Add(Terrain terrain, Matrix4x4 localToWorld)
		{
		}

		private void Add(IList<int> triangles, IList<Vector3> vertices, IList<Vector3> normals, IList<Vector4> tangents, IList<Vector2> uvs, Matrix4x4 localToWorldMatrix)
		{
		}

		protected void AddIndices(int indexA, int indexB, int indexC)
		{
		}

		protected virtual void AddMeshData(IList<Vector3> vertices, IList<Vector3> normals, IList<Vector4> tangents, IList<Vector2> uvs, Matrix4x4 localToWorld)
		{
		}

		protected virtual void OnProcessVertexIndex(int index, bool valid)
		{
		}

		public virtual Mesh ConvertToMesh(Mesh target, bool forceRecreation = false)
		{
			return null;
		}

		private void CopyGeometryData(Mesh mesh)
		{
		}

		internal virtual void RemoveRange(int startIndex, int count)
		{
		}

		internal void RemoveTriangleAt(int index)
		{
		}

		internal static void Assign(DynamicMesh dynMesh, Mesh mesh)
		{
		}
	}
}
