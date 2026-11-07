using System;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x200002D")]
	internal sealed class LocationCacheKey : IOperationCacheKey, IEquatable<IOperationCacheKey>
	{
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x10")]
		private readonly IResourceLocation m_Location;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x18")]
		private readonly Type m_DesiredType;

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2A6988C", Offset = "0x2A6988C", VA = "0x2A6988C")]
		public LocationCacheKey(IResourceLocation location, Type desiredType)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2A69988", Offset = "0x2A69988", VA = "0x2A69988", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2A69A48", Offset = "0x2A69A48", VA = "0x2A69A48", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2A69B50", Offset = "0x2A69B50", VA = "0x2A69B50", Slot = "4")]
		public bool Equals(IOperationCacheKey other)
		{
			return default;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2A69AF0", Offset = "0x2A69AF0", VA = "0x2A69AF0")]
		private bool Equals(LocationCacheKey other)
		{
			return default;
		}
	}
}
