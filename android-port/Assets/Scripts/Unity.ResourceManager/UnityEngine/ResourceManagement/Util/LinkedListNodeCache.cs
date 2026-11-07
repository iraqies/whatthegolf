using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x2000038")]
	public class LinkedListNodeCache<T>
	{
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x0")]
		private int m_NodesCreated;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x0")]
		private LinkedList<T> m_NodeCache;

		[Token(Token = "0x1700002B")]
		internal int CreatedNodeCount
		{
			[Token(Token = "0x6000149")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002C")]
		internal int CachedNodeCount
		{
			[Token(Token = "0x600014A")]
			get
			{
				return default;
			}
			[Token(Token = "0x600014B")]
			set
			{
			}
		}

		[Token(Token = "0x6000147")]
		public LinkedListNode<T> Acquire(T val)
		{
			return null;
		}

		[Token(Token = "0x6000148")]
		public void Release(LinkedListNode<T> node)
		{
		}

		[Token(Token = "0x600014C")]
		public LinkedListNodeCache()
		{
		}
	}
}
