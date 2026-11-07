using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x200002E")]
	internal sealed class DependenciesCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey>
	{
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x10")]
		private readonly IList<IResourceLocation> m_Dependencies;

		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x18")]
		private readonly int m_DependenciesHash;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2A64A08", Offset = "0x2A64A08", VA = "0x2A64A08")]
		public DependenciesCacheKey(IList<IResourceLocation> dependencies, int dependenciesHash)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2A64A44", Offset = "0x2A64A44", VA = "0x2A64A44", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2A64A4C", Offset = "0x2A64A4C", VA = "0x2A64A4C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2A64B14", Offset = "0x2A64B14", VA = "0x2A64B14", Slot = "4")]
		public bool Equals(IOperationCacheKey other)
		{
			return default;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2A64AEC", Offset = "0x2A64AEC", VA = "0x2A64AEC")]
		private bool Equals(DependenciesCacheKey other)
		{
			return default;
		}
	}
}
