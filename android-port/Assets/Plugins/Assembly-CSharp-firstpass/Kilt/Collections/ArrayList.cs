using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

namespace Kilt.Collections
{
	[Serializable]
	public class ArrayList<T> : FoldOutStruct
	{
		[SerializeField]
		private List<T> buffer;

		private Type type;

		[XmlIgnore]
		public int Count => 0;

		public List<T> Buffer => null;

		// C# has no syntax for parameterized property 'Item'.
		public virtual T get_Item(int i)
		{
			return default;
		}

		public ArrayList()
		{
		}

		public ArrayList(IList<T> p_list)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void Add(T item)
		{
		}

		protected void AddWithoutCallEvents(T item)
		{
		}

		public bool Contains(T item)
		{
			return false;
		}

		public T[] ToArray()
		{
			return null;
		}

		public void RemoveNulls()
		{
		}

		public bool RemoveChecking(T p_object, bool p_removeNulls = true)
		{
			return false;
		}

		public bool AddChecking(T p_object)
		{
			return false;
		}

		public void MergeList(ArrayList<T> p_otherList)
		{
		}

		public void UnmergeList(ArrayList<T> p_otherList)
		{
		}

		protected virtual void OnAdd(T p_item)
		{
		}

		protected virtual void OnRemove(T p_item)
		{
		}

		private static T[] CloneArray(IList<T> p_buffer)
		{
			return null;
		}
	}
}
