using System;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x200002C")]
	internal sealed class IdCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey>
	{
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x10")]
		public string ID;

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2A5D268", Offset = "0x2A5D268", VA = "0x2A5D268")]
		public IdCacheKey(string id)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2A68138", Offset = "0x2A68138", VA = "0x2A68138")]
		private bool Equals(IdCacheKey other)
		{
			return default;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2A68168", Offset = "0x2A68168", VA = "0x2A68168", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2A68188", Offset = "0x2A68188", VA = "0x2A68188", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2A6822C", Offset = "0x2A6822C", VA = "0x2A6822C", Slot = "4")]
		public bool Equals(IOperationCacheKey other)
		{
			return default;
		}
	}
}
