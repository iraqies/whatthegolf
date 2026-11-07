using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000004")]
internal class DelegateList<T>
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	private Func<Action<T>, LinkedListNode<Action<T>>> m_acquireFunc;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x0")]
	private Action<LinkedListNode<Action<T>>> m_releaseFunc;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x0")]
	private LinkedList<Action<T>> m_callbacks;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x0")]
	private bool m_invoking;

	[Token(Token = "0x17000001")]
	public int Count
	{
		[Token(Token = "0x6000004")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000003")]
	public DelegateList(Func<Action<T>, LinkedListNode<Action<T>>> acquireFunc, Action<LinkedListNode<Action<T>>> releaseFunc)
	{
	}

	[Token(Token = "0x6000005")]
	public void Add(Action<T> action)
	{
	}

	[Token(Token = "0x6000006")]
	public void Remove(Action<T> action)
	{
	}

	[Token(Token = "0x6000007")]
	public void Invoke(T res)
	{
	}

	[Token(Token = "0x6000008")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000009")]
	public static DelegateList<T> CreateWithGlobalCache()
	{
		return null;
	}
}
