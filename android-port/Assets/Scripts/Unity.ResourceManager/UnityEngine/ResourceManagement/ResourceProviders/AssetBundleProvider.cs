using System;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x1B7A78", Offset = "0x1B7A78")]
	public class AssetBundleProvider : ResourceProviderBase
	{
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2A5CB04", Offset = "0x2A5CB04", VA = "0x2A5CB04")]
		internal static void WaitForAllUnloadingBundlesToComplete()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2A5CB08", Offset = "0x2A5CB08", VA = "0x2A5CB08", Slot = "17")]
		public override void Provide(ProvideHandle providerInterface)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2A5CE20", Offset = "0x2A5CE20", VA = "0x2A5CE20", Slot = "16")]
		public override Type GetDefaultType(IResourceLocation location)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2A5CEA8", Offset = "0x2A5CEA8", VA = "0x2A5CEA8", Slot = "15")]
		public override void Release(IResourceLocation location, object asset)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2A5D0F4", Offset = "0x2A5D0F4", VA = "0x2A5D0F4", Slot = "19")]
		internal virtual IOperationCacheKey CreateCacheKeyForLocation(ResourceManager rm, IResourceLocation location, Type desiredType)
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2A5D294", Offset = "0x2A5D294", VA = "0x2A5D294")]
		public AssetBundleProvider()
		{
		}
	}
}
