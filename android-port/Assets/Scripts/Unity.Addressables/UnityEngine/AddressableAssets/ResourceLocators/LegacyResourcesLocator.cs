using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	[Token(Token = "0x2000052")]
	public class LegacyResourcesLocator : IResourceLocator
	{
		[Token(Token = "0x17000051")]
		public IEnumerable<object> Keys
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x2A366C0", Offset = "0x2A366C0", VA = "0x2A366C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public string LocatorId
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x2A366C8", Offset = "0x2A366C8", VA = "0x2A366C8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x2A363F4", Offset = "0x2A363F4", VA = "0x2A363F4", Slot = "6")]
		public bool Locate(object key, Type type, out IList<IResourceLocation> locations)
		{
			return default;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2A3670C", Offset = "0x2A3670C", VA = "0x2A3670C")]
		public LegacyResourcesLocator()
		{
		}
	}
}
