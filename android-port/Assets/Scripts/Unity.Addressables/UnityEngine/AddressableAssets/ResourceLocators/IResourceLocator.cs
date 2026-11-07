using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	[Token(Token = "0x2000051")]
	public interface IResourceLocator
	{
		[Token(Token = "0x1700004F")]
		string LocatorId
		{
			[Token(Token = "0x6000242")]
			get;
		}

		[Token(Token = "0x17000050")]
		IEnumerable<object> Keys
		{
			[Token(Token = "0x6000243")]
			get;
		}

		[Token(Token = "0x6000244")]
		bool Locate(object key, Type type, out IList<IResourceLocation> locations);
	}
}
