using System.Collections.Generic;

public class RequestQueue<T>
{
	private List<T> _items;

	public bool requestInProgress;

	public T first => default;

	public void Add(T item)
	{
	}

	public void RemoveFirst()
	{
	}

	public bool Any()
	{
		return false;
	}
}
