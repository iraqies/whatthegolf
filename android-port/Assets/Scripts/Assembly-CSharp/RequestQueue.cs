using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2000CB6")]
public class RequestQueue<T>
{
	[Token(Token = "0x400453D")]
	[FieldOffset(Offset = "0x0")]
	private List<T> _items;

	[Token(Token = "0x400453E")]
	[FieldOffset(Offset = "0x0")]
	public bool requestInProgress;

	[Token(Token = "0x17000619")]
	public T first
	{
		[Token(Token = "0x6003C04")]
		get
		{
			return (T)null;
		}
	}

	[Token(Token = "0x6003C05")]
	public void Add(T item)
	{
	}

	[Token(Token = "0x6003C06")]
	public void RemoveFirst()
	{
	}

	[Token(Token = "0x6003C07")]
	public bool Any()
	{
		return default;
	}

	[Token(Token = "0x6003C08")]
	public RequestQueue()
	{
	}
}
