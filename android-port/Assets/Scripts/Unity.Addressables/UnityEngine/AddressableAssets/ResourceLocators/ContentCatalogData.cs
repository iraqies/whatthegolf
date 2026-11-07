using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	[Serializable]
	[Token(Token = "0x200004D")]
	public class ContentCatalogData
	{
		[Token(Token = "0x200004E")]
		private struct Bucket
		{
			[Token(Token = "0x4000103")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int dataOffset;

			[Token(Token = "0x4000104")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int[] entries;
		}

		[Token(Token = "0x200004F")]
		private class CompactLocation : IResourceLocation
		{
			[Token(Token = "0x4000105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ResourceLocationMap m_Locator;

			[Token(Token = "0x4000106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private string m_InternalId;

			[Token(Token = "0x4000107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private string m_ProviderId;

			[Token(Token = "0x4000108")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private object m_Dependency;

			[Token(Token = "0x4000109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private object m_Data;

			[Token(Token = "0x400010A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int m_HashCode;

			[Token(Token = "0x400010B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int m_DependencyHashCode;

			[Token(Token = "0x400010C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private string m_PrimaryKey;

			[Token(Token = "0x400010D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Type m_Type;

			[Token(Token = "0x17000047")]
			public string InternalId
			{
				[Token(Token = "0x6000233")]
				[Address(RVA = "0x2A3AE9C", Offset = "0x2A3AE9C", VA = "0x2A3AE9C", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000048")]
			public string ProviderId
			{
				[Token(Token = "0x6000234")]
				[Address(RVA = "0x2A3AEA4", Offset = "0x2A3AEA4", VA = "0x2A3AEA4", Slot = "5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000049")]
			public IList<IResourceLocation> Dependencies
			{
				[Token(Token = "0x6000235")]
				[Address(RVA = "0x2A3AEAC", Offset = "0x2A3AEAC", VA = "0x2A3AEAC", Slot = "6")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004A")]
			public bool HasDependencies
			{
				[Token(Token = "0x6000236")]
				[Address(RVA = "0x2A3AF80", Offset = "0x2A3AF80", VA = "0x2A3AF80", Slot = "9")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700004B")]
			public int DependencyHashCode
			{
				[Token(Token = "0x6000237")]
				[Address(RVA = "0x2A3AF90", Offset = "0x2A3AF90", VA = "0x2A3AF90", Slot = "8")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700004C")]
			public object Data
			{
				[Token(Token = "0x6000238")]
				[Address(RVA = "0x2A3AF98", Offset = "0x2A3AF98", VA = "0x2A3AF98", Slot = "10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004D")]
			public string PrimaryKey
			{
				[Token(Token = "0x6000239")]
				[Address(RVA = "0x2A3AFA0", Offset = "0x2A3AFA0", VA = "0x2A3AFA0", Slot = "11")]
				get
				{
					return null;
				}
				[Token(Token = "0x600023A")]
				[Address(RVA = "0x2A3AFA8", Offset = "0x2A3AFA8", VA = "0x2A3AFA8")]
				set
				{
				}
			}

			[Token(Token = "0x1700004E")]
			public Type ResourceType
			{
				[Token(Token = "0x600023B")]
				[Address(RVA = "0x2A3AFB0", Offset = "0x2A3AFB0", VA = "0x2A3AFB0", Slot = "12")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600023C")]
			[Address(RVA = "0x2A3AFB8", Offset = "0x2A3AFB8", VA = "0x2A3AFB8", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600023D")]
			[Address(RVA = "0x2A3AFC0", Offset = "0x2A3AFC0", VA = "0x2A3AFC0", Slot = "7")]
			public int Hash(Type t)
			{
				return default;
			}

			[Token(Token = "0x600023E")]
			[Address(RVA = "0x2A3B010", Offset = "0x2A3B010", VA = "0x2A3B010")]
			public CompactLocation(ResourceLocationMap locator, string internalId, string providerId, object dependencyKey, object data, int depHash, string primaryKey, Type type)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B11EC", Offset = "0x1B11EC")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400010E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400010F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<IResourceLocation, string> _003C_003E9__45_0;

			[Token(Token = "0x6000240")]
			[Address(RVA = "0x2A3ADE0", Offset = "0x2A3ADE0", VA = "0x2A3ADE0")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000241")]
			[Address(RVA = "0x2A3ADE8", Offset = "0x2A3ADE8", VA = "0x2A3ADE8")]
			internal string _003CGetData_003Eb__45_0(IResourceLocation d)
			{
				return null;
			}
		}

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int kMagic;

		[Token(Token = "0x40000F0")]
		private const int kVersion = 1;

		[NonSerialized]
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal string localHash;

		[NonSerialized]
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal IResourceLocation location;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		internal string m_LocatorId;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal string m_BuildResultHash;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ObjectInitializationData m_InstanceProviderData;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ObjectInitializationData m_SceneProviderData;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		internal List<ObjectInitializationData> m_ResourceProviderData;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private IList<ContentCatalogDataEntry> m_Entries;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B1444", Offset = "0x1B1444")]
		[SerializeField]
		internal string[] m_ProviderIds;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B1490", Offset = "0x1B1490")]
		[SerializeField]
		internal string[] m_InternalIds;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B14DC", Offset = "0x1B14DC")]
		internal string m_KeyDataString;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B1528", Offset = "0x1B1528")]
		[SerializeField]
		internal string m_BucketDataString;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B1574", Offset = "0x1B1574")]
		internal string m_EntryDataString;

		[Token(Token = "0x40000FE")]
		private const int kBytesPerInt32 = 4;

		[Token(Token = "0x40000FF")]
		private const int k_EntryDataItemPerEntry = 7;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B15C0", Offset = "0x1B15C0")]
		[SerializeField]
		internal string m_ExtraDataString;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		internal SerializedType[] m_resourceTypes;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private string[] m_InternalIdPrefixes;

		[Token(Token = "0x17000041")]
		public string ProviderId
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x2A2B180", Offset = "0x2A2B180", VA = "0x2A2B180")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x2A2B188", Offset = "0x2A2B188", VA = "0x2A2B188")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public ObjectInitializationData InstanceProviderData
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x2A2B190", Offset = "0x2A2B190", VA = "0x2A2B190")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x2A2B1A4", Offset = "0x2A2B1A4", VA = "0x2A2B1A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public ObjectInitializationData SceneProviderData
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x2A2B1B8", Offset = "0x2A2B1B8", VA = "0x2A2B1B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x2A2B1CC", Offset = "0x2A2B1CC", VA = "0x2A2B1CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public List<ObjectInitializationData> ResourceProviderData
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x2A2B1E0", Offset = "0x2A2B1E0", VA = "0x2A2B1E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x2A2B1E8", Offset = "0x2A2B1E8", VA = "0x2A2B1E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public string[] ProviderIds
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x2A2B304", Offset = "0x2A2B304", VA = "0x2A2B304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public string[] InternalIds
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x2A2B30C", Offset = "0x2A2B30C", VA = "0x2A2B30C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2A2B1F0", Offset = "0x2A2B1F0", VA = "0x2A2B1F0")]
		public ContentCatalogData(string id)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2A2B284", Offset = "0x2A2B284", VA = "0x2A2B284")]
		public ContentCatalogData()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2A2B314", Offset = "0x2A2B314", VA = "0x2A2B314")]
		internal static ContentCatalogData LoadFromFile(string path, int cacheSize = 1024)
		{
			return null;
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x2A2B374", Offset = "0x2A2B374", VA = "0x2A2B374")]
		internal void SaveToFile(string path)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2A2B3A4", Offset = "0x2A2B3A4", VA = "0x2A2B3A4")]
		internal void CleanData()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x2A2B174", Offset = "0x2A2B174", VA = "0x2A2B174")]
		internal ResourceLocationMap CreateCustomLocator([Optional][DefaultParameterValue("")] string overrideId, [Optional] string providerSuffix)
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x2A2B424", Offset = "0x2A2B424", VA = "0x2A2B424")]
		public ResourceLocationMap CreateLocator([Optional] string providerSuffix)
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x2A2C638", Offset = "0x2A2C638", VA = "0x2A2C638")]
		internal IList<ContentCatalogDataEntry> GetData()
		{
			return null;
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x2A2C4F8", Offset = "0x2A2C4F8", VA = "0x2A2C4F8")]
		internal static string ExpandInternalId(string[] internalIdPrefixes, string v)
		{
			return null;
		}
	}
}
