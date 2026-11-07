using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.AddressableAssets
{
	[Token(Token = "0x2000041")]
	internal class DynamicResourceLocator : IResourceLocator
	{
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x10")]
		private AddressablesImpl m_Addressables;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x18")]
		private string m_AtlasSpriteProviderId;

		[Token(Token = "0x17000035")]
		public string LocatorId
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x2A2E278", Offset = "0x2A2E278", VA = "0x2A2E278", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public virtual IEnumerable<object> Keys
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x2A2E2BC", Offset = "0x2A2E2BC", VA = "0x2A2E2BC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		private string AtlasSpriteProviderId
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x2A2E304", Offset = "0x2A2E304", VA = "0x2A2E304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public IEnumerable<IResourceLocation> AllLocations
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x2A2E788", Offset = "0x2A2E788", VA = "0x2A2E788")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2A2E7D0", Offset = "0x2A2E7D0", VA = "0x2A2E7D0")]
		public DynamicResourceLocator(AddressablesImpl addr)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2A2E7FC", Offset = "0x2A2E7FC", VA = "0x2A2E7FC", Slot = "6")]
		public bool Locate(object key, Type type, out IList<IResourceLocation> locations)
		{
			return default;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2A2ED94", Offset = "0x2A2ED94", VA = "0x2A2ED94")]
		internal void CreateDynamicLocations(Type type, IList<IResourceLocation> locations, string locName, string subKey, IResourceLocation mainLoc)
		{
		}
	}
}
