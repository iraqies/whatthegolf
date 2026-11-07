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
		private List<T> array = new List<T>();

		public T this[int index]
		{
			get => array[index];
			set => array[index] = value;
		}

		public bool IsReadOnly => false;

		public int Count => array != null ? array.Count : 0;

		public ReorderableArray()
		{
			array = new List<T>();
		}

		public ReorderableArray(int length)
		{
			array = new List<T>(length);
		}

		public object Clone()
		{
			var copy = (ReorderableArray<T>)MemberwiseClone();
			copy.array = array != null ? new List<T>(array) : new List<T>();
			return copy;
		}

		public bool Contains(T value) => array != null && array.Contains(value);

		public int IndexOf(T value) => array != null ? array.IndexOf(value) : -1;

		public void Insert(int index, T item)
		{
			if (array == null) array = new List<T>();
			array.Insert(index, item);
		}

		public void RemoveAt(int index) => array?.RemoveAt(index);

		public void Add(T item)
		{
			if (array == null) array = new List<T>();
			array.Add(item);
		}

		public void Clear() => array?.Clear();

		public void CopyTo(T[] target, int arrayIndex) => array?.CopyTo(target, arrayIndex);

		public bool Remove(T item) => array != null && array.Remove(item);

		public IEnumerator<T> GetEnumerator() => (array ?? (array = new List<T>())).GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}
