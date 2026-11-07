using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Malee
{
	[Serializable]
	[Token(Token = "0x200025D")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x34168", Offset = "0x34168")]
	public abstract class ReorderableArray<T> : ICloneable, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x4000F8F")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private List<T> array;

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x170001E8")]
		[Token(Token = "0x6000F8D")]
		public T get_Item(int index)
		{
			return (T)null;
		}

		[Token(Token = "0x6000F8E")]
		public void set_Item(int index, T value)
		{
		}

		[Token(Token = "0x170001E9")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000F8F")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001EA")]
		public int Count
		{
			[Token(Token = "0x6000F90")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000F8B")]
		public ReorderableArray()
		{
		}

		[Token(Token = "0x6000F8C")]
		public ReorderableArray(int length)
		{
		}

		[Token(Token = "0x6000F91")]
		public object Clone()
		{
			return null;
		}

		[Token(Token = "0x6000F92")]
		public bool Contains(T value)
		{
			return default;
		}

		[Token(Token = "0x6000F93")]
		public int IndexOf(T value)
		{
			return default;
		}

		[Token(Token = "0x6000F94")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x6000F95")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000F96")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x6000F97")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000F98")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000F99")]
		public bool Remove(T item)
		{
			return default;
		}

		[Token(Token = "0x6000F9A")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000F9B")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}
}
