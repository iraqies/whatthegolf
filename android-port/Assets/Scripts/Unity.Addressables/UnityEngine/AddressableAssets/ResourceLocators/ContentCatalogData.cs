using System;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	[Serializable]
	public class ContentCatalogData
	{
		private struct Bucket
		{
			public int dataOffset;

			public int[] entries;
		}

		private class CompactLocation : IResourceLocation
		{
			private ResourceLocationMap m_Locator;

			private string m_InternalId;

			private string m_ProviderId;

			private object m_Dependency;

			private object m_Data;

			private int m_HashCode;

			private int m_DependencyHashCode;

			private string m_PrimaryKey;

			private Type m_Type;

			public string InternalId => null;

			public string ProviderId => null;

			public IList<IResourceLocation> Dependencies => null;

			public bool HasDependencies => false;

			public int DependencyHashCode => 0;

			public object Data => null;

			public string PrimaryKey
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Type ResourceType => null;

			public override string ToString()
			{
				return null;
			}

			public int Hash(Type t)
			{
				return 0;
			}

			public CompactLocation(ResourceLocationMap locator, string internalId, string providerId, object dependencyKey, object data, int depHash, string primaryKey, Type type)
			{
			}
		}

		private static int kMagic;

		private const int kVersion = 1;

		[NonSerialized]
		internal string localHash;

		[NonSerialized]
		internal IResourceLocation location;

		[SerializeField]
		internal string m_LocatorId;

		[SerializeField]
		internal string m_BuildResultHash;

		[SerializeField]
		private ObjectInitializationData m_InstanceProviderData;

		[SerializeField]
		private ObjectInitializationData m_SceneProviderData;

		[SerializeField]
		internal List<ObjectInitializationData> m_ResourceProviderData;

		private IList<ContentCatalogDataEntry> m_Entries;

		[SerializeField]
		internal string[] m_ProviderIds;

		[SerializeField]
		internal string[] m_InternalIds;

		[SerializeField]
		internal string m_KeyDataString;

		[SerializeField]
		internal string m_BucketDataString;

		[SerializeField]
		internal string m_EntryDataString;

		private const int kBytesPerInt32 = 4;

		private const int k_EntryDataItemPerEntry = 7;

		[SerializeField]
		internal string m_ExtraDataString;

		[SerializeField]
		internal SerializedType[] m_resourceTypes;

		[SerializeField]
		private string[] m_InternalIdPrefixes;

		public string ProviderId
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public ObjectInitializationData InstanceProviderData
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public ObjectInitializationData SceneProviderData
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public List<ObjectInitializationData> ResourceProviderData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string[] ProviderIds => null;

		public string[] InternalIds => null;

		public ContentCatalogData(string id)
		{
		}

		public ContentCatalogData()
		{
		}

		internal static ContentCatalogData LoadFromFile(string path, int cacheSize = 1024)
		{
			return null;
		}

		internal void SaveToFile(string path)
		{
		}

		internal void CleanData()
		{
		}

		internal ResourceLocationMap CreateCustomLocator(string overrideId = "", string providerSuffix = null)
		{
			return null;
		}

		public ResourceLocationMap CreateLocator(string providerSuffix = null)
		{
			return null;
		}

		internal IList<ContentCatalogDataEntry> GetData()
		{
			return null;
		}

		internal static string ExpandInternalId(string[] internalIdPrefixes, string v)
		{
			return null;
		}
	}
}
