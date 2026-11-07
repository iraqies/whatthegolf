using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

internal class ListWithEvents<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	private List<T> m_List;

	[CompilerGenerated]
	private Action<T> m_OnElementAdded;

	[CompilerGenerated]
	private Action<T> m_OnElementRemoved;

	// C# has no syntax for parameterized property 'Item'.
	public T get_Item(int index)
	{
		return default;
	}

	public void set_Item(int index, T value)
	{
	}

	public int Count => 0;

	public bool IsReadOnly => false;

	public event Action<T> OnElementAdded
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<T> OnElementRemoved
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void InvokeAdded(T element)
	{
	}

	private void InvokeRemoved(T element)
	{
	}

	public void Add(T item)
	{
	}

	public void Clear()
	{
	}

	public bool Contains(T item)
	{
		return false;
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
	}

	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	public int IndexOf(T item)
	{
		return 0;
	}

	public void Insert(int index, T item)
	{
	}

	public bool Remove(T item)
	{
		return false;
	}

	public void RemoveAt(int index)
	{
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
