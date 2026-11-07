using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Malee
{
	[Serializable]
	public abstract class ReorderableArray<T> : ICloneable, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[SerializeField]
		private List<T> array;

		// C# has no syntax for parameterized property 'Item'.
		public T get_Item(int index)
		{
			return default;
		}

		public void set_Item(int index, T value)
		{
		}

		public bool IsReadOnly => false;

		public int Count => 0;

		public ReorderableArray()
		{
		}

		public ReorderableArray(int length)
		{
		}

		public object Clone()
		{
			return null;
		}

		public bool Contains(T value)
		{
			return false;
		}

		public int IndexOf(T value)
		{
			return 0;
		}

		public void Insert(int index, T item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void Add(T item)
		{
		}

		public void Clear()
		{
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		public bool Remove(T item)
		{
			return false;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
