using System;
using System.Collections.Generic;

namespace UnityEngine.ProBuilder
{
	[Serializable]
	public sealed class Submesh
	{
		[SerializeField]
		internal int[] m_Indexes;

		[SerializeField]
		internal MeshTopology m_Topology;

		[SerializeField]
		internal int m_SubmeshIndex;

		public Submesh(int submeshIndex, MeshTopology topology, IEnumerable<int> indexes)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static Submesh[] GetSubmeshes(IEnumerable<Face> faces, int submeshCount, MeshTopology preferredTopology = MeshTopology.Triangles)
		{
			return null;
		}

		internal static void MapFaceMaterialsToSubmeshIndex(ProBuilderMesh mesh)
		{
		}
	}
}
