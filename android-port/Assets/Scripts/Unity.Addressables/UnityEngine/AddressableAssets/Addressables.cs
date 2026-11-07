using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace UnityEngine.AddressableAssets
{
	public static class Addressables
	{
		public enum MergeMode
		{
			None = 0,
			UseFirst = None,
			Union = 1,
			Intersection = 2
		}

		internal static bool reinitializeAddressables;

		internal static AddressablesImpl m_AddressablesInstance;

		public const string kAddressablesRuntimeDataPath = "AddressablesRuntimeDataPath";

		private const string k_AddressablesLogConditional = "ADDRESSABLES_LOG_ALL";

		public const string kAddressablesRuntimeBuildLogPath = "AddressablesRuntimeBuildLog";

		public static string LibraryPath;

		public static string BuildReportPath;

		private static AddressablesImpl m_Addressables => null;

		public static ResourceManager ResourceManager => null;

		internal static AddressablesImpl Instance => null;

		public static IInstanceProvider InstanceProvider => null;

		public static Func<IResourceLocation, string> InternalIdTransformFunc
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static Action<UnityWebRequest> WebRequestOverride
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string StreamingAssetsSubFolder => null;

		public static string BuildPath => null;

		public static string PlayerBuildDataPath => null;

		public static string RuntimePath => null;

		public static IEnumerable<IResourceLocator> ResourceLocators => null;

		[Obsolete]
		public static AsyncOperationHandle<IResourceLocator> InitializationOperation => default;

		public static string ResolveInternalId(string id)
		{
			return null;
		}

		internal static void InternalSafeSerializationLog(string msg, LogType logType = LogType.Log)
		{
		}

		internal static void InternalSafeSerializationLogFormat(string format, LogType logType = LogType.Log, params object[] args)
		{
		}

		public static void Log(string msg)
		{
		}

		public static void LogFormat(string format, params object[] args)
		{
		}

		public static void LogWarning(string msg)
		{
		}

		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		public static void LogError(string msg)
		{
		}

		public static void LogException(AsyncOperationHandle op, Exception ex)
		{
		}

		public static void LogException(Exception ex)
		{
		}

		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		[Obsolete]
		public static AsyncOperationHandle<IResourceLocator> Initialize()
		{
			return default;
		}

		public static AsyncOperationHandle<IResourceLocator> InitializeAsync()
		{
			return default;
		}

		public static AsyncOperationHandle<IResourceLocator> InitializeAsync(bool autoReleaseHandle)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<IResourceLocator> LoadContentCatalog(string catalogPath, string providerSuffix = null)
		{
			return default;
		}

		public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, string providerSuffix = null)
		{
			return default;
		}

		public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle, string providerSuffix = null)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<TObject> LoadAsset<TObject>(IResourceLocation location)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<TObject> LoadAsset<TObject>(object key)
		{
			return default;
		}

		public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location)
		{
			return default;
		}

		public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocations(IList<object> keys, MergeMode mode, Type type = null)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IList<object> keys, MergeMode mode, Type type = null)
		{
			return default;
		}

		public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, MergeMode mode, Type type = null)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocations(object key, Type type = null)
		{
			return default;
		}

		public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, Type type = null)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(IList<IResourceLocation> locations, Action<TObject> callback)
		{
			return default;
		}

		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback)
		{
			return default;
		}

		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(IList<object> keys, Action<TObject> callback, MergeMode mode)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<object> keys, Action<TObject> callback, MergeMode mode)
		{
			return default;
		}

		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, MergeMode mode)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<object> keys, Action<TObject> callback, MergeMode mode, bool releaseDependenciesOnFailure)
		{
			return default;
		}

		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, MergeMode mode, bool releaseDependenciesOnFailure)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(object key, Action<TObject> callback)
		{
			return default;
		}

		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback)
		{
			return default;
		}

		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			return default;
		}

		public static void Release<TObject>(TObject obj)
		{
		}

		public static void Release<TObject>(AsyncOperationHandle<TObject> handle)
		{
		}

		public static void Release(AsyncOperationHandle handle)
		{
		}

		public static bool ReleaseInstance(GameObject instance)
		{
			return false;
		}

		public static bool ReleaseInstance(AsyncOperationHandle handle)
		{
			return false;
		}

		public static bool ReleaseInstance(AsyncOperationHandle<GameObject> handle)
		{
			return false;
		}

		[Obsolete]
		public static AsyncOperationHandle<long> GetDownloadSize(object key)
		{
			return default;
		}

		public static AsyncOperationHandle<long> GetDownloadSizeAsync(object key)
		{
			return default;
		}

		public static AsyncOperationHandle<long> GetDownloadSizeAsync(string key)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<long> GetDownloadSizeAsync(IList<object> keys)
		{
			return default;
		}

		public static AsyncOperationHandle<long> GetDownloadSizeAsync(IEnumerable keys)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle DownloadDependencies(object key)
		{
			return default;
		}

		public static AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = false)
		{
			return default;
		}

		public static AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = false)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle DownloadDependenciesAsync(IList<object> keys, MergeMode mode, bool autoReleaseHandle = false)
		{
			return default;
		}

		public static AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, MergeMode mode, bool autoReleaseHandle = false)
		{
			return default;
		}

		public static void ClearDependencyCacheAsync(object key)
		{
		}

		public static void ClearDependencyCacheAsync(IList<IResourceLocation> locations)
		{
		}

		[Obsolete]
		public static void ClearDependencyCacheAsync(IList<object> keys)
		{
		}

		public static void ClearDependencyCacheAsync(IEnumerable keys)
		{
		}

		public static void ClearDependencyCacheAsync(string key)
		{
		}

		public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle)
		{
			return default;
		}

		public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<object> keys, bool autoReleaseHandle)
		{
			return default;
		}

		public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle)
		{
			return default;
		}

		public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(string key, bool autoReleaseHandle)
		{
			return default;
		}

		public static ResourceLocatorInfo GetLocatorInfo(string locatorId)
		{
			return null;
		}

		public static ResourceLocatorInfo GetLocatorInfo(IResourceLocator locator)
		{
			return null;
		}

		[Obsolete]
		public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<GameObject> Instantiate(object key, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<GameObject> Instantiate(object key, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<GameObject> Instantiate(object key, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default;
		}

		public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
			return default;
		}

		public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true)
		{
			return default;
		}

		public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Transform parent = null, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
			return default;
		}

		public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, Transform parent = null, bool trackHandle = true)
		{
			return default;
		}

		public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default;
		}

		public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<SceneInstance> LoadScene(object key, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<SceneInstance> LoadScene(IResourceLocation location, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return default;
		}

		public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return default;
		}

		public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = true, int priority = 100)
		{
			return default;
		}

		public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return default;
		}

		public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad = true, int priority = 100)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<SceneInstance> UnloadScene(SceneInstance scene, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle handle, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Obsolete]
		public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = true)
		{
			return default;
		}

		public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = true)
		{
			return default;
		}

		public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = true)
		{
			return default;
		}

		public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, bool autoReleaseHandle = true)
		{
			return default;
		}

		public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, bool autoReleaseHandle = true)
		{
			return default;
		}

		public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = true)
		{
			return default;
		}

		public static AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = true)
		{
			return default;
		}

		public static AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(IEnumerable<string> catalogs = null, bool autoReleaseHandle = true)
		{
			return default;
		}

		public static AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(bool autoCleanBundleCache, IEnumerable<string> catalogs = null, bool autoReleaseHandle = true)
		{
			return default;
		}

		public static void AddResourceLocator(IResourceLocator locator, string localCatalogHash = null, IResourceLocation remoteCatalogLocation = null)
		{
		}

		public static void RemoveResourceLocator(IResourceLocator locator)
		{
		}

		public static void ClearResourceLocators()
		{
		}

		public static AsyncOperationHandle<bool> CleanBundleCache(IEnumerable<string> catalogsIds = null)
		{
			return default;
		}

		public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath) where T : IResourceProvider
		{
			return null;
		}

		public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(IResourceLocation remoteCatalogLocation) where T : IResourceProvider
		{
			return null;
		}

		public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath, string remoteHashPath) where T : IResourceProvider
		{
			return null;
		}
	}
}
