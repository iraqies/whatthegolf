using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x2000036")]
	public class LRUCacheAllocationStrategy : IAllocationStrategy
	{
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x10")]
		private int m_poolMaxSize;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x14")]
		private int m_poolInitialCapacity;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x18")]
		private int m_poolCacheMaxSize;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x20")]
		private List<List<object>> m_poolCache;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<int, List<object>> m_cache;

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2A68738", Offset = "0x2A68738", VA = "0x2A68738")]
		public LRUCacheAllocationStrategy(int poolMaxSize, int poolCapacity, int poolCacheMaxSize, int initialPoolCacheCapacity)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2A688B0", Offset = "0x2A688B0", VA = "0x2A688B0")]
		private List<object> GetPool()
		{
			return null;
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x2A68984", Offset = "0x2A68984", VA = "0x2A68984")]
		private void ReleasePool(List<object> pool)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2A68A14", Offset = "0x2A68A14", VA = "0x2A68A14", Slot = "4")]
		public object New(Type type, int typeHash)
		{
			return null;
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2A68BA8", Offset = "0x2A68BA8", VA = "0x2A68BA8", Slot = "5")]
		public void Release(int typeHash, object obj)
		{
		}
	}
}
