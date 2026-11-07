using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001E8")]
	public static class SdkCache
	{
		[Token(Token = "0x20001E9")]
		internal class CacheKey
		{
			[Token(Token = "0x400075C")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27A58", Offset = "0x27A58")]
			private ImmutableCredentials ImmutableCredentials__BackingField;

			[Token(Token = "0x400075D")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27A68", Offset = "0x27A68")]
			private RegionEndpoint RegionEndpoint__BackingField;

			[Token(Token = "0x400075E")]
			[FieldOffset(Offset = "0x20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27A78", Offset = "0x27A78")]
			private string ServiceUrl__BackingField;

			[Token(Token = "0x400075F")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27A88", Offset = "0x27A88")]
			private object CacheType__BackingField;

			[Token(Token = "0x170003D4")]
			public ImmutableCredentials ImmutableCredentials
			{
				[Token(Token = "0x6000F0B")]
				[Address(RVA = "0x129599C", Offset = "0x129599C", VA = "0x129599C")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B984", Offset = "0x2B984")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000F0C")]
				[Address(RVA = "0x12959A4", Offset = "0x12959A4", VA = "0x12959A4")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B994", Offset = "0x2B994")]
				private set
				{
				}
			}

			[Token(Token = "0x170003D5")]
			public RegionEndpoint RegionEndpoint
			{
				[Token(Token = "0x6000F0D")]
				[Address(RVA = "0x12959AC", Offset = "0x12959AC", VA = "0x12959AC")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B9A4", Offset = "0x2B9A4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000F0E")]
				[Address(RVA = "0x12959B4", Offset = "0x12959B4", VA = "0x12959B4")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B9B4", Offset = "0x2B9B4")]
				private set
				{
				}
			}

			[Token(Token = "0x170003D6")]
			public string ServiceUrl
			{
				[Token(Token = "0x6000F0F")]
				[Address(RVA = "0x12959BC", Offset = "0x12959BC", VA = "0x12959BC")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B9C4", Offset = "0x2B9C4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000F10")]
				[Address(RVA = "0x12959C4", Offset = "0x12959C4", VA = "0x12959C4")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B9D4", Offset = "0x2B9D4")]
				private set
				{
				}
			}

			[Token(Token = "0x170003D7")]
			public object CacheType
			{
				[Token(Token = "0x6000F11")]
				[Address(RVA = "0x12959CC", Offset = "0x12959CC", VA = "0x12959CC")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B9E4", Offset = "0x2B9E4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000F12")]
				[Address(RVA = "0x12959D4", Offset = "0x12959D4", VA = "0x12959D4")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B9F4", Offset = "0x2B9F4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000F13")]
			[Address(RVA = "0x12959DC", Offset = "0x12959DC", VA = "0x12959DC")]
			private CacheKey()
			{
			}

			[Token(Token = "0x6000F14")]
			[Address(RVA = "0x1295A08", Offset = "0x1295A08", VA = "0x1295A08")]
			public static CacheKey Create(AmazonServiceClient client, object cacheType)
			{
				return null;
			}

			[Token(Token = "0x6000F15")]
			[Address(RVA = "0x1295BF8", Offset = "0x1295BF8", VA = "0x1295BF8")]
			public static CacheKey Create(object cacheType)
			{
				return null;
			}

			[Token(Token = "0x6000F16")]
			[Address(RVA = "0x1295C70", Offset = "0x1295C70", VA = "0x1295C70", Slot = "2")]
			public override int GetHashCode()
			{
				return default;
			}

			[Token(Token = "0x6000F17")]
			[Address(RVA = "0x1295DA0", Offset = "0x1295DA0", VA = "0x1295DA0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default;
			}
		}

		[Token(Token = "0x20001EA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x25F40", Offset = "0x25F40")]
		private sealed class _003C_003Ec__DisplayClass5_0<TKey, TValue>
		{
			[Token(Token = "0x4000760")]
			[FieldOffset(Offset = "0x0")]
			public IEqualityComparer<TKey> keyComparer;

			[Token(Token = "0x6000F18")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000F19")]
			internal ICache _003CGetCache_003Eb__0(CacheKey k)
			{
				return null;
			}
		}

		[Token(Token = "0x400075A")]
		[FieldOffset(Offset = "0x0")]
		private static object cacheLock;

		[Token(Token = "0x400075B")]
		[FieldOffset(Offset = "0x8")]
		private static Cache<CacheKey, ICache> cache;

		[Token(Token = "0x6000F06")]
		[Address(RVA = "0x12707F0", Offset = "0x12707F0", VA = "0x12707F0")]
		public static void Clear()
		{
		}

		[Token(Token = "0x6000F07")]
		[Address(RVA = "0x1270874", Offset = "0x1270874", VA = "0x1270874")]
		public static void Clear(object cacheType)
		{
		}

		[Token(Token = "0x6000F08")]
		public static ICache<TKey, TValue> GetCache<TKey, TValue>(object client, object cacheIdentifier, IEqualityComparer<TKey> keyComparer)
		{
			return null;
		}

		[Token(Token = "0x6000F09")]
		public static ICache<TKey, TValue> GetCache<TKey, TValue>(AmazonServiceClient client, object cacheIdentifier, IEqualityComparer<TKey> keyComparer)
		{
			return null;
		}
	}
}
