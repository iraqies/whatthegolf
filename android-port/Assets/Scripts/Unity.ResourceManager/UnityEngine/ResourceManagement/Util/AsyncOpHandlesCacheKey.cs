using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x200002F")]
	internal sealed class AsyncOpHandlesCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey>
	{
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x10")]
		private readonly HashSet<AsyncOperationHandle> m_Handles;

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2A6086C", Offset = "0x2A6086C", VA = "0x2A6086C")]
		public AsyncOpHandlesCacheKey(IList<AsyncOperationHandle> handles)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2A60900", Offset = "0x2A60900", VA = "0x2A60900", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2A60920", Offset = "0x2A60920", VA = "0x2A60920", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2A60A74", Offset = "0x2A60A74", VA = "0x2A60A74", Slot = "4")]
		public bool Equals(IOperationCacheKey other)
		{
			return default;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2A609E8", Offset = "0x2A609E8", VA = "0x2A609E8")]
		private bool Equals(AsyncOpHandlesCacheKey other)
		{
			return default;
		}
	}
}
