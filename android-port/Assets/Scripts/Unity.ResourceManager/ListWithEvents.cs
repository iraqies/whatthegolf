using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1B7A00", Offset = "0x1B7A00")]
internal class ListWithEvents<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
{
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x0")]
	private List<T> m_List;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7CB8", Offset = "0x1B7CB8")]
	private Action<T> m_OnElementAdded;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7CC8", Offset = "0x1B7CC8")]
	private Action<T> m_OnElementRemoved;

	// C# has no syntax for parameterized property 'Item'.
	// Its 'property:' attributes below are ignored by the compiler (CS0657).
	[property: Token(Token = "0x17000002")]
	[Token(Token = "0x6000010")]
	public T get_Item(int index)
	{
		return (T)null;
	}

	[Token(Token = "0x6000011")]
	public void set_Item(int index, T value)
	{
	}

	[Token(Token = "0x17000003")]
	public int Count
	{
		[Token(Token = "0x6000012")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000004")]
	public bool IsReadOnly
	{
		[Token(Token = "0x6000013")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<T> OnElementAdded
	{
		[Token(Token = "0x600000A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B82AC", Offset = "0x1B82AC")]
		add
		{
		}
		[Token(Token = "0x600000B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B82BC", Offset = "0x1B82BC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event Action<T> OnElementRemoved
	{
		[Token(Token = "0x600000C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B82CC", Offset = "0x1B82CC")]
		add
		{
		}
		[Token(Token = "0x600000D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B82DC", Offset = "0x1B82DC")]
		remove
		{
		}
	}

	[Token(Token = "0x600000E")]
	private void InvokeAdded(T element)
	{
	}

	[Token(Token = "0x600000F")]
	private void InvokeRemoved(T element)
	{
	}

	[Token(Token = "0x6000014")]
	public void Add(T item)
	{
	}

	[Token(Token = "0x6000015")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000016")]
	public bool Contains(T item)
	{
		return default;
	}

	[Token(Token = "0x6000017")]
	public void CopyTo(T[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x6000018")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	public int IndexOf(T item)
	{
		return default;
	}

	[Token(Token = "0x600001A")]
	public void Insert(int index, T item)
	{
	}

	[Token(Token = "0x600001B")]
	public bool Remove(T item)
	{
		return default;
	}

	[Token(Token = "0x600001C")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x600001D")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	public ListWithEvents()
	{
	}
}
