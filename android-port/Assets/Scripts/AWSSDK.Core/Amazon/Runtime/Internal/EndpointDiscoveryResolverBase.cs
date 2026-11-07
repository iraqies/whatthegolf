using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000153")]
	public abstract class EndpointDiscoveryResolverBase
	{
		[Token(Token = "0x2000154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25C88", Offset = "0x25C88")]
		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[Token(Token = "0x4000557")]
			[FieldOffset(Offset = "0x10")]
			public EndpointDiscoveryResolverBase _003C_003E4__this;

			[Token(Token = "0x4000558")]
			[FieldOffset(Offset = "0x18")]
			public string cacheKey;

			[Token(Token = "0x4000559")]
			[FieldOffset(Offset = "0x20")]
			public Func<IList<DiscoveryEndpointBase>> InvokeEndpointOperation;

			[Token(Token = "0x6000AE3")]
			[Address(RVA = "0x128AC74", Offset = "0x128AC74", VA = "0x128AC74")]
			public _003C_003Ec__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0x128AC7C", Offset = "0x128AC7C", VA = "0x128AC7C")]
			internal void _003CResolveEndpoints_003Eb__0()
			{
			}

			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0x128ACA4", Offset = "0x128ACA4", VA = "0x128ACA4")]
			internal void _003CResolveEndpoints_003Eb__1()
			{
			}
		}

		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0x10")]
		private IClientConfig _config;

		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0x18")]
		private Logger _logger;

		[Token(Token = "0x4000555")]
		[FieldOffset(Offset = "0x20")]
		private LruCache<string, IList<DiscoveryEndpointBase>> _cache;

		[Token(Token = "0x4000556")]
		[FieldOffset(Offset = "0x28")]
		private object objectCacheLock;

		[Token(Token = "0x170002D4")]
		public virtual int CacheCount
		{
			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0x11FDFE8", Offset = "0x11FDFE8", VA = "0x11FDFE8", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x11FCDD8", Offset = "0x11FCDD8", VA = "0x11FCDD8")]
		protected EndpointDiscoveryResolverBase(IClientConfig config, Logger logger)
		{
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x11FCF28", Offset = "0x11FCF28", VA = "0x11FCF28", Slot = "4")]
		public virtual IEnumerable<DiscoveryEndpointBase> ResolveEndpoints(EndpointOperationContextBase context, Func<IList<DiscoveryEndpointBase>> InvokeEndpointOperation)
		{
			return null;
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x11FDB54", Offset = "0x11FDB54", VA = "0x11FDB54")]
		private IEnumerable<DiscoveryEndpointBase> ProcessInvokeEndpointOperation(string cacheKey, Func<IList<DiscoveryEndpointBase>> InvokeEndpointOperation, bool endpointRequired)
		{
			return null;
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x11FDF64", Offset = "0x11FDF64", VA = "0x11FDF64", Slot = "5")]
		public virtual IList<DiscoveryEndpointBase> GetDiscoveryEndpointsFromCache(string cacheKey)
		{
			return null;
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x11FD4DC", Offset = "0x11FD4DC", VA = "0x11FD4DC")]
		private IEnumerable<DiscoveryEndpointBase> ProcessEndpointCache(string cacheKey, bool evictCacheKey, Uri evictUri, out bool refreshCache)
		{
			return null;
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x11FD200", Offset = "0x11FD200", VA = "0x11FD200")]
		private static string BuildEndpointDiscoveryCacheKey(EndpointOperationContextBase context)
		{
			return null;
		}
	}
}
