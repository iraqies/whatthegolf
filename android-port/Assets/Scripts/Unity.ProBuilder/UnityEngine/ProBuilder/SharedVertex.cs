using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.ProBuilder
{
	[Serializable]
	public sealed class SharedVertex : ICollection<int>, IEnumerable<int>, IEnumerable
	{
		[SerializeField]
		private int[] m_Vertices;

		// C# has no syntax for parameterized property 'Item'.
		public int get_Item(int i)
		{
			return 0;
		}

		public int Count => 0;

		public bool IsReadOnly => false;

		public SharedVertex(IEnumerable<int> indexes)
		{
		}

		public SharedVertex(SharedVertex sharedVertex)
		{
		}

		public IEnumerator<int> GetEnumerator()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public void Add(int item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(int item)
		{
			return false;
		}

		public void CopyTo(int[] array, int arrayIndex)
		{
		}

		public bool Remove(int item)
		{
			return false;
		}

		public static void GetSharedVertexLookup(IList<SharedVertex> sharedVertices, Dictionary<int, int> lookup)
		{
		}

		internal static SharedVertex[] ToSharedVertices(IEnumerable<KeyValuePair<int, int>> lookup)
		{
			return null;
		}

		private static SharedVertex[] ToSharedVertices(List<List<int>> list)
		{
			return null;
		}

		public static SharedVertex[] GetSharedVerticesWithPositions(IList<Vector3> positions)
		{
			return null;
		}

		internal static void SetCoincident(ref Dictionary<int, int> lookup, IEnumerable<int> vertices)
		{
		}
	}
}
