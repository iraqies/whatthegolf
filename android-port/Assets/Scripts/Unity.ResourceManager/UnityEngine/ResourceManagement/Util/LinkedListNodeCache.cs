using System.Collections.Generic;

namespace UnityEngine.ResourceManagement.Util
{
	public class LinkedListNodeCache<T>
	{
		private int m_NodesCreated;

		private LinkedList<T> m_NodeCache;

		internal int CreatedNodeCount => 0;

		internal int CachedNodeCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public LinkedListNode<T> Acquire(T val)
		{
			return null;
		}

		public void Release(LinkedListNode<T> node)
		{
		}
	}
}
