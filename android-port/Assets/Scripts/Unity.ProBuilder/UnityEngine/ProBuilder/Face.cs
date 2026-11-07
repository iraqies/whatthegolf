using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace UnityEngine.ProBuilder
{
	[Serializable]
	public sealed class Face
	{
		[SerializeField]
		private int[] m_Indexes;

		[SerializeField]
		private int m_SmoothingGroup;

		[SerializeField]
		private AutoUnwrapSettings m_Uv;

		[SerializeField]
		private Material m_Material;

		[SerializeField]
		private int m_SubmeshIndex;

		[SerializeField]
		private bool m_ManualUV;

		[SerializeField]
		internal int elementGroup;

		[SerializeField]
		private int m_TextureGroup;

		[NonSerialized]
		private int[] m_DistinctIndexes;

		[NonSerialized]
		private Edge[] m_Edges;

		public bool manualUV
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int textureGroup
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal int[] indexesInternal => null;

		internal int[] distinctIndexesInternal => null;

		public ReadOnlyCollection<int> distinctIndexes => null;

		internal Edge[] edgesInternal => null;

		public ReadOnlyCollection<Edge> edges => null;

		public int smoothingGroup => 0;

		[Obsolete]
		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int submeshIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public AutoUnwrapSettings uv
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public void SetIndexes(IEnumerable<int> indices)
		{
		}

		public Face()
		{
		}

		internal Face(IEnumerable<int> triangles, int submeshIndex, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs)
		{
		}

		public Face(Face other)
		{
		}

		public void CopyFrom(Face other)
		{
		}

		internal void InvalidateCache()
		{
		}

		private Edge[] CacheEdges()
		{
			return null;
		}

		private int[] CacheDistinctIndexes()
		{
			return null;
		}

		public bool IsQuad()
		{
			return false;
		}

		public int[] ToQuad()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
