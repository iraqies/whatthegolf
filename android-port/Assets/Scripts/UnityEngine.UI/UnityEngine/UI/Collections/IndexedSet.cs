using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI.Collections
{
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1F6A14", Offset = "0x1F6A14")]
	internal class IndexedSet<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<T> m_List;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<T, int> m_Dictionary;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x0")]
		private int m_EnabledObjectCount;

		[Token(Token = "0x17000154")]
		public int Count
		{
			[Token(Token = "0x6000513")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000155")]
		public int Capacity
		{
			[Token(Token = "0x6000514")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000156")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000515")]
			get
			{
				return default;
			}
		}

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000157")]
		[Token(Token = "0x600051A")]
		public T get_Item(int index)
		{
			return (T)null;
		}

		[Token(Token = "0x600051B")]
		public void set_Item(int index, T value)
		{
		}

		[Token(Token = "0x6000508")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x6000509")]
		public void Add(T item, bool isActive)
		{
		}

		[Token(Token = "0x600050A")]
		public bool AddUnique(T item, bool isActive = true)
		{
			return default;
		}

		[Token(Token = "0x600050B")]
		public bool EnableItem(T item)
		{
			return default;
		}

		[Token(Token = "0x600050C")]
		public bool DisableItem(T item)
		{
			return default;
		}

		[Token(Token = "0x600050D")]
		public bool Remove(T item)
		{
			return default;
		}

		[Token(Token = "0x600050E")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000511")]
		public bool Contains(T item)
		{
			return default;
		}

		[Token(Token = "0x6000512")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000516")]
		public int IndexOf(T item)
		{
			return default;
		}

		[Token(Token = "0x6000517")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x6000518")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000519")]
		private void Swap(int index1, int index2)
		{
		}

		[Token(Token = "0x600051C")]
		public void Sort(Comparison<T> sortLayoutFunction)
		{
		}

		[Token(Token = "0x600051D")]
		public IndexedSet()
		{
		}
	}
}
