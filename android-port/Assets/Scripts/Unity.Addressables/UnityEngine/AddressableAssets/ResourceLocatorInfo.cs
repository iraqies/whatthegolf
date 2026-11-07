using Il2CppDummyDll;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.AddressableAssets
{
	[Token(Token = "0x200000C")]
	public class ResourceLocatorInfo
	{
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B125C", Offset = "0x1B125C")]
		private IResourceLocator Locator__BackingField;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B126C", Offset = "0x1B126C")]
		private string LocalHash__BackingField;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B127C", Offset = "0x1B127C")]
		private IResourceLocation CatalogLocation__BackingField;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B128C", Offset = "0x1B128C")]
		private bool ContentUpdateAvailable__BackingField;

		[Token(Token = "0x17000004")]
		public IResourceLocator Locator
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2A37984", Offset = "0x2A37984", VA = "0x2A37984")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1B14", Offset = "0x1B1B14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x2A3798C", Offset = "0x2A3798C", VA = "0x2A3798C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1B24", Offset = "0x1B1B24")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public string LocalHash
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x2A37994", Offset = "0x2A37994", VA = "0x2A37994")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1B34", Offset = "0x1B1B34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x2A3799C", Offset = "0x2A3799C", VA = "0x2A3799C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1B44", Offset = "0x1B1B44")]
			private set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public IResourceLocation CatalogLocation
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x2A379A4", Offset = "0x2A379A4", VA = "0x2A379A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1B54", Offset = "0x1B1B54")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x2A379AC", Offset = "0x2A379AC", VA = "0x2A379AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1B64", Offset = "0x1B1B64")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		internal bool ContentUpdateAvailable
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x2A379B4", Offset = "0x2A379B4", VA = "0x2A379B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1B74", Offset = "0x1B1B74")]
			get
			{
				return default;
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x2A379BC", Offset = "0x2A379BC", VA = "0x2A379BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1B84", Offset = "0x1B1B84")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public IResourceLocation HashLocation
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x2A29234", Offset = "0x2A29234", VA = "0x2A29234")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		public bool CanUpdateContent
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x2A29058", Offset = "0x2A29058", VA = "0x2A29058")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2A1F704", Offset = "0x2A1F704", VA = "0x2A1F704")]
		public ResourceLocatorInfo(IResourceLocator loc, string localHash, IResourceLocation remoteCatalogLocation)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2A379C4", Offset = "0x2A379C4", VA = "0x2A379C4")]
		internal void UpdateContent(IResourceLocator locator, string hash, IResourceLocation loc)
		{
		}
	}
}
