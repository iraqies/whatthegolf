using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace UnityEngine.AddressableAssets.ResourceProviders
{
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "DisplayNameAttribute", RVA = "0x1B11B4", Offset = "0x1B11B4")]
	public class ContentCatalogProvider : ResourceProviderBase
	{
		[Token(Token = "0x2000049")]
		public enum DependencyHashIndex
		{
			[Token(Token = "0x40000D1")]
			Remote = 0,
			[Token(Token = "0x40000D2")]
			Cache = 1,
			[Token(Token = "0x40000D3")]
			Count = 2
		}

		[Token(Token = "0x200004A")]
		internal class InternalOp
		{
			[Token(Token = "0x200004B")]
			internal class BundledCatalog
			{
				[Token(Token = "0x40000DF")]
				[FieldOffset(Offset = "0x10")]
				private readonly string m_BundlePath;

				[Token(Token = "0x40000E0")]
				[FieldOffset(Offset = "0x18")]
				private bool m_OpInProgress;

				[Token(Token = "0x40000E1")]
				[FieldOffset(Offset = "0x20")]
				private AssetBundleCreateRequest m_LoadBundleRequest;

				[Token(Token = "0x40000E2")]
				[FieldOffset(Offset = "0x28")]
				internal AssetBundle m_CatalogAssetBundle;

				[Token(Token = "0x40000E3")]
				[FieldOffset(Offset = "0x30")]
				private AssetBundleRequest m_LoadTextAssetRequest;

				[Token(Token = "0x40000E4")]
				[FieldOffset(Offset = "0x38")]
				private ContentCatalogData m_CatalogData;

				[Token(Token = "0x40000E5")]
				[FieldOffset(Offset = "0x40")]
				private WebRequestQueueOperation m_WebRequestQueueOperation;

				[Token(Token = "0x40000E6")]
				[FieldOffset(Offset = "0x48")]
				private AsyncOperation m_RequestOperation;

				[Token(Token = "0x40000E7")]
				[FieldOffset(Offset = "0x50")]
				private int m_WebRequestTimeout;

				[Token(Token = "0x40000E8")]
				[FieldOffset(Offset = "0x58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1384", Offset = "0x1B1384")]
				private Action<ContentCatalogData> m_OnLoaded;

				[Token(Token = "0x17000039")]
				public bool OpInProgress
				{
					[Token(Token = "0x6000207")]
					[Address(RVA = "0x2A3D47C", Offset = "0x2A3D47C", VA = "0x2A3D47C")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x1700003A")]
				public bool OpIsSuccess
				{
					[Token(Token = "0x6000208")]
					[Address(RVA = "0x2A3D484", Offset = "0x2A3D484", VA = "0x2A3D484")]
					get
					{
						return default;
					}
				}

				[Token(Token = "0x14000001")]
				public event Action<ContentCatalogData> OnLoaded
				{
					[Token(Token = "0x6000205")]
					[Address(RVA = "0x2A3C270", Offset = "0x2A3C270", VA = "0x2A3C270")]
					[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1EAC", Offset = "0x1B1EAC")]
					add
					{
					}
					[Token(Token = "0x6000206")]
					[Address(RVA = "0x2A3D3D8", Offset = "0x2A3D3D8", VA = "0x2A3D3D8")]
					[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1EBC", Offset = "0x1B1EBC")]
					remove
					{
					}
				}

				[Token(Token = "0x6000209")]
				[Address(RVA = "0x2A3C148", Offset = "0x2A3C148", VA = "0x2A3C148")]
				public BundledCatalog(string bundlePath, int webRequestTimeout = 0)
				{
				}

				[Token(Token = "0x600020A")]
				[Address(RVA = "0x2A3D4A4", Offset = "0x2A3D4A4", VA = "0x2A3D4A4", Slot = "1")]
				~BundledCatalog()
				{
				}

				[Token(Token = "0x600020B")]
				[Address(RVA = "0x2A3D55C", Offset = "0x2A3D55C", VA = "0x2A3D55C")]
				private void Unload()
				{
				}

				[Token(Token = "0x600020C")]
				[Address(RVA = "0x2A3C314", Offset = "0x2A3C314", VA = "0x2A3C314")]
				public void LoadCatalogFromBundleAsync()
				{
				}

				[Token(Token = "0x600020D")]
				[Address(RVA = "0x2A3D590", Offset = "0x2A3D590", VA = "0x2A3D590")]
				private void WebRequestOperationCompleted(AsyncOperation op)
				{
				}

				[Token(Token = "0x600020E")]
				[Address(RVA = "0x2A3D7D4", Offset = "0x2A3D7D4", VA = "0x2A3D7D4")]
				private void LoadTextAssetRequestComplete(AsyncOperation op)
				{
				}

				[Token(Token = "0x600020F")]
				[Address(RVA = "0x2A3BF58", Offset = "0x2A3BF58", VA = "0x2A3BF58")]
				public bool WaitForCompletion()
				{
					return default;
				}

				[Token(Token = "0x6000210")]
				[Address(RVA = "0x2A3D9A8", Offset = "0x2A3D9A8", VA = "0x2A3D9A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1ECC", Offset = "0x1B1ECC")]
				private void _003CLoadCatalogFromBundleAsync_003Eb__19_1(UnityWebRequestAsyncOperation asyncOp)
				{
				}

				[Token(Token = "0x6000211")]
				[Address(RVA = "0x2A3DA5C", Offset = "0x2A3DA5C", VA = "0x2A3DA5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1EDC", Offset = "0x1B1EDC")]
				private void _003CLoadCatalogFromBundleAsync_003Eb__19_0(AsyncOperation loadOp)
				{
				}
			}

			[Token(Token = "0x40000D4")]
			[FieldOffset(Offset = "0x10")]
			private string m_LocalDataPath;

			[Token(Token = "0x40000D5")]
			[FieldOffset(Offset = "0x18")]
			private string m_RemoteHashValue;

			[Token(Token = "0x40000D6")]
			[FieldOffset(Offset = "0x20")]
			internal string m_LocalHashValue;

			[Token(Token = "0x40000D7")]
			[FieldOffset(Offset = "0x28")]
			private ProvideHandle m_ProviderInterface;

			[Token(Token = "0x40000D8")]
			[FieldOffset(Offset = "0x40")]
			internal ContentCatalogData m_ContentCatalogData;

			[Token(Token = "0x40000D9")]
			[FieldOffset(Offset = "0x48")]
			private AsyncOperationHandle<ContentCatalogData> m_ContentCatalogDataLoadOp;

			[Token(Token = "0x40000DA")]
			[FieldOffset(Offset = "0x68")]
			private BundledCatalog m_BundledCatalog;

			[Token(Token = "0x40000DB")]
			[FieldOffset(Offset = "0x70")]
			private bool m_Retried;

			[Token(Token = "0x40000DC")]
			[FieldOffset(Offset = "0x71")]
			private bool m_DisableCatalogUpdateOnStart;

			[Token(Token = "0x40000DD")]
			[FieldOffset(Offset = "0x72")]
			private bool m_IsLocalCatalogInBundle;

			[Token(Token = "0x40000DE")]
			private const string kCatalogExt = ".json";

			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x2A3B174", Offset = "0x2A3B174", VA = "0x2A3B174")]
			public void Start(ProvideHandle providerInterface, bool disableCatalogUpdateOnStart, bool isLocalCatalogInBundle)
			{
			}

			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x2A3BE8C", Offset = "0x2A3BE8C", VA = "0x2A3BE8C")]
			private bool WaitForCompletionCallback()
			{
				return default;
			}

			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x2A3C058", Offset = "0x2A3C058", VA = "0x2A3C058")]
			public void Release()
			{
			}

			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x2A3B800", Offset = "0x2A3B800", VA = "0x2A3B800")]
			internal bool CanLoadCatalogFromBundle(string idToLoad, IResourceLocation location)
			{
				return default;
			}

			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x2A3B8D8", Offset = "0x2A3B8D8", VA = "0x2A3B8D8")]
			internal void LoadCatalog(string idToLoad, bool loadCatalogFromLocalBundle)
			{
			}

			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x2A3C600", Offset = "0x2A3C600", VA = "0x2A3C600")]
			private void CatalogLoadOpCompleteCallback(AsyncOperationHandle<ContentCatalogData> op)
			{
			}

			[Token(Token = "0x6000200")]
			[Address(RVA = "0x2A3C06C", Offset = "0x2A3C06C", VA = "0x2A3C06C")]
			private string GetTransformedInternalId(IResourceLocation loc)
			{
				return null;
			}

			[Token(Token = "0x6000201")]
			[Address(RVA = "0x2A3B2F8", Offset = "0x2A3B2F8", VA = "0x2A3B2F8")]
			internal string DetermineIdToLoad(IResourceLocation location, IList<object> dependencyObjects, bool disableCatalogUpdateOnStart = false)
			{
				return null;
			}

			[Token(Token = "0x6000202")]
			[Address(RVA = "0x2A3C6D4", Offset = "0x2A3C6D4", VA = "0x2A3C6D4")]
			private void OnCatalogLoaded(ContentCatalogData ccd)
			{
			}

			[Token(Token = "0x6000203")]
			[Address(RVA = "0x2A3CF50", Offset = "0x2A3CF50", VA = "0x2A3CF50")]
			public InternalOp()
			{
			}

			[Token(Token = "0x6000204")]
			[Address(RVA = "0x2A3CF58", Offset = "0x2A3CF58", VA = "0x2A3CF58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1E9C", Offset = "0x1B1E9C")]
			private void _003CLoadCatalog_003Eb__14_0(ContentCatalogData ccd)
			{
			}
		}

		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x1C")]
		public bool DisableCatalogUpdateOnStart;

		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x1D")]
		public bool IsLocalCatalogInBundle;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x20")]
		internal Dictionary<IResourceLocation, InternalOp> m_LocationToCatalogLoadOpMap;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x28")]
		private ResourceManager m_RM;

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2A2DF5C", Offset = "0x2A2DF5C", VA = "0x2A2DF5C")]
		public ContentCatalogProvider(ResourceManager resourceManagerInstance)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2A2DFF8", Offset = "0x2A2DFF8", VA = "0x2A2DFF8", Slot = "15")]
		public override void Release(IResourceLocation location, object obj)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2A2E0D4", Offset = "0x2A2E0D4", VA = "0x2A2E0D4", Slot = "17")]
		public override void Provide(ProvideHandle providerInterface)
		{
		}
	}
}
