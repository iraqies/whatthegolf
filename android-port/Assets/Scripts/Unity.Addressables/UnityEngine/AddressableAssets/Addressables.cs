using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace UnityEngine.AddressableAssets
{
	[Token(Token = "0x200000E")]
	public static class Addressables
	{
		[Token(Token = "0x200000F")]
		public enum MergeMode
		{
			[Token(Token = "0x400001B")]
			None = 0,
			[Token(Token = "0x400001C")]
			UseFirst = None,
			[Token(Token = "0x400001D")]
			Union = 1,
			[Token(Token = "0x400001E")]
			Intersection = 2
		}

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static bool reinitializeAddressables;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static AddressablesImpl m_AddressablesInstance;

		[Token(Token = "0x4000015")]
		public const string kAddressablesRuntimeDataPath = "AddressablesRuntimeDataPath";

		[Token(Token = "0x4000016")]
		private const string k_AddressablesLogConditional = "ADDRESSABLES_LOG_ALL";

		[Token(Token = "0x4000017")]
		public const string kAddressablesRuntimeBuildLogPath = "AddressablesRuntimeBuildLog";

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string LibraryPath;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string BuildReportPath;

		[Token(Token = "0x1700000E")]
		private static AddressablesImpl m_Addressables
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2A146C8", Offset = "0x2A146C8", VA = "0x2A146C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public static ResourceManager ResourceManager
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2A1472C", Offset = "0x2A1472C", VA = "0x2A1472C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		internal static AddressablesImpl Instance
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2A1486C", Offset = "0x2A1486C", VA = "0x2A1486C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public static IInstanceProvider InstanceProvider
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2A14908", Offset = "0x2A14908", VA = "0x2A14908")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public static Func<IResourceLocation, string> InternalIdTransformFunc
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2A14B0C", Offset = "0x2A14B0C", VA = "0x2A14B0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2A14BDC", Offset = "0x2A14BDC", VA = "0x2A14BDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public static Action<UnityWebRequest> WebRequestOverride
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2A14CC4", Offset = "0x2A14CC4", VA = "0x2A14CC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2A14D94", Offset = "0x2A14D94", VA = "0x2A14D94")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public static string StreamingAssetsSubFolder
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2A14E7C", Offset = "0x2A14E7C", VA = "0x2A14E7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public static string BuildPath
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2A14F90", Offset = "0x2A14F90", VA = "0x2A14F90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public static string PlayerBuildDataPath
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2A15170", Offset = "0x2A15170", VA = "0x2A15170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public static string RuntimePath
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x2A1531C", Offset = "0x2A1531C", VA = "0x2A1531C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public static IEnumerable<IResourceLocator> ResourceLocators
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x2A154C8", Offset = "0x2A154C8", VA = "0x2A154C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B204C", Offset = "0x1B204C")]
		public static AsyncOperationHandle<IResourceLocator> InitializationOperation
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x2A16E5C", Offset = "0x2A16E5C", VA = "0x2A16E5C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2A149B0", Offset = "0x2A149B0", VA = "0x2A149B0")]
		public static string ResolveInternalId(string id)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2A156A0", Offset = "0x2A156A0", VA = "0x2A156A0")]
		internal static void InternalSafeSerializationLog(string msg, LogType logType = LogType.Log)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2A159FC", Offset = "0x2A159FC", VA = "0x2A159FC")]
		internal static void InternalSafeSerializationLogFormat(string format, LogType logType = LogType.Log, params object[] args)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2A15D94", Offset = "0x2A15D94", VA = "0x2A15D94")]
		public static void Log(string msg)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2A15E8C", Offset = "0x2A15E8C", VA = "0x2A15E8C")]
		public static void LogFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2A15F8C", Offset = "0x2A15F8C", VA = "0x2A15F8C")]
		public static void LogWarning(string msg)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2A16084", Offset = "0x2A16084", VA = "0x2A16084")]
		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2A16184", Offset = "0x2A16184", VA = "0x2A16184")]
		public static void LogError(string msg)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2A1627C", Offset = "0x2A1627C", VA = "0x2A1627C")]
		public static void LogException(AsyncOperationHandle op, Exception ex)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2A16408", Offset = "0x2A16408", VA = "0x2A16408")]
		public static void LogException(Exception ex)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2A164B0", Offset = "0x2A164B0", VA = "0x2A164B0")]
		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2A165B0", Offset = "0x2A165B0", VA = "0x2A165B0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1BE4", Offset = "0x1B1BE4")]
		public static AsyncOperationHandle<IResourceLocator> Initialize()
		{
			return default;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2A16620", Offset = "0x2A16620", VA = "0x2A16620")]
		public static AsyncOperationHandle<IResourceLocator> InitializeAsync()
		{
			return default;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2A16824", Offset = "0x2A16824", VA = "0x2A16824")]
		public static AsyncOperationHandle<IResourceLocator> InitializeAsync(bool autoReleaseHandle)
		{
			return default;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2A16A34", Offset = "0x2A16A34", VA = "0x2A16A34")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1BF4", Offset = "0x1B1BF4")]
		public static AsyncOperationHandle<IResourceLocator> LoadContentCatalog(string catalogPath, [Optional] string providerSuffix)
		{
			return default;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2A16AD4", Offset = "0x2A16AD4", VA = "0x2A16AD4")]
		public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, [Optional] string providerSuffix)
		{
			return default;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2A16D88", Offset = "0x2A16D88", VA = "0x2A16D88")]
		public static AsyncOperationHandle<IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle, [Optional] string providerSuffix)
		{
			return default;
		}

		[Token(Token = "0x6000068")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1C04", Offset = "0x1B1C04")]
		public static AsyncOperationHandle<TObject> LoadAsset<TObject>(IResourceLocation location)
		{
			return default;
		}

		[Token(Token = "0x6000069")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1C14", Offset = "0x1B1C14")]
		public static AsyncOperationHandle<TObject> LoadAsset<TObject>(object key)
		{
			return default;
		}

		[Token(Token = "0x600006A")]
		public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(IResourceLocation location)
		{
			return default;
		}

		[Token(Token = "0x600006B")]
		public static AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key)
		{
			return default;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2A16E68", Offset = "0x2A16E68", VA = "0x2A16E68")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1C24", Offset = "0x1B1C24")]
		public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocations(IList<object> keys, MergeMode mode, [Optional] Type type)
		{
			return default;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2A16F18", Offset = "0x2A16F18", VA = "0x2A16F18")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1C34", Offset = "0x1B1C34")]
		public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IList<object> keys, MergeMode mode, [Optional] Type type)
		{
			return default;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2A17134", Offset = "0x2A17134", VA = "0x2A17134")]
		public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(IEnumerable keys, MergeMode mode, [Optional] Type type)
		{
			return default;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2A17208", Offset = "0x2A17208", VA = "0x2A17208")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1C44", Offset = "0x1B1C44")]
		public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocations(object key, [Optional] Type type)
		{
			return default;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2A172A8", Offset = "0x2A172A8", VA = "0x2A172A8")]
		public static AsyncOperationHandle<IList<IResourceLocation>> LoadResourceLocationsAsync(object key, [Optional] Type type)
		{
			return default;
		}

		[Token(Token = "0x6000071")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1C54", Offset = "0x1B1C54")]
		public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(IList<IResourceLocation> locations, Action<TObject> callback)
		{
			return default;
		}

		[Token(Token = "0x6000072")]
		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback)
		{
			return default;
		}

		[Token(Token = "0x6000073")]
		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<IResourceLocation> locations, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			return default;
		}

		[Token(Token = "0x6000074")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1C64", Offset = "0x1B1C64")]
		public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(IList<object> keys, Action<TObject> callback, MergeMode mode)
		{
			return default;
		}

		[Token(Token = "0x6000075")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1C74", Offset = "0x1B1C74")]
		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<object> keys, Action<TObject> callback, MergeMode mode)
		{
			return default;
		}

		[Token(Token = "0x6000076")]
		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, MergeMode mode)
		{
			return default;
		}

		[Token(Token = "0x6000077")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1C84", Offset = "0x1B1C84")]
		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IList<object> keys, Action<TObject> callback, MergeMode mode, bool releaseDependenciesOnFailure)
		{
			return default;
		}

		[Token(Token = "0x6000078")]
		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(IEnumerable keys, Action<TObject> callback, MergeMode mode, bool releaseDependenciesOnFailure)
		{
			return default;
		}

		[Token(Token = "0x6000079")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1C94", Offset = "0x1B1C94")]
		public static AsyncOperationHandle<IList<TObject>> LoadAssets<TObject>(object key, Action<TObject> callback)
		{
			return default;
		}

		[Token(Token = "0x600007A")]
		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback)
		{
			return default;
		}

		[Token(Token = "0x600007B")]
		public static AsyncOperationHandle<IList<TObject>> LoadAssetsAsync<TObject>(object key, Action<TObject> callback, bool releaseDependenciesOnFailure)
		{
			return default;
		}

		[Token(Token = "0x600007C")]
		public static void Release<TObject>(TObject obj)
		{
		}

		[Token(Token = "0x600007D")]
		public static void Release<TObject>(AsyncOperationHandle<TObject> handle)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2A174A8", Offset = "0x2A174A8", VA = "0x2A174A8")]
		public static void Release(AsyncOperationHandle handle)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2A175C4", Offset = "0x2A175C4", VA = "0x2A175C4")]
		public static bool ReleaseInstance(GameObject instance)
		{
			return default;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2A177CC", Offset = "0x2A177CC", VA = "0x2A177CC")]
		public static bool ReleaseInstance(AsyncOperationHandle handle)
		{
			return default;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2A178AC", Offset = "0x2A178AC", VA = "0x2A178AC")]
		public static bool ReleaseInstance(AsyncOperationHandle<GameObject> handle)
		{
			return default;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2A17990", Offset = "0x2A17990", VA = "0x2A17990")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1CA4", Offset = "0x1B1CA4")]
		public static AsyncOperationHandle<long> GetDownloadSize(object key)
		{
			return default;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2A17A18", Offset = "0x2A17A18", VA = "0x2A17A18")]
		public static AsyncOperationHandle<long> GetDownloadSizeAsync(object key)
		{
			return default;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2A17B90", Offset = "0x2A17B90", VA = "0x2A17B90")]
		public static AsyncOperationHandle<long> GetDownloadSizeAsync(string key)
		{
			return default;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2A17C4C", Offset = "0x2A17C4C", VA = "0x2A17C4C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1CB4", Offset = "0x1B1CB4")]
		public static AsyncOperationHandle<long> GetDownloadSizeAsync(IList<object> keys)
		{
			return default;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2A18C84", Offset = "0x2A18C84", VA = "0x2A18C84")]
		public static AsyncOperationHandle<long> GetDownloadSizeAsync(IEnumerable keys)
		{
			return default;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2A18D40", Offset = "0x2A18D40", VA = "0x2A18D40")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1CC4", Offset = "0x1B1CC4")]
		public static AsyncOperationHandle DownloadDependencies(object key)
		{
			return default;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2A18DCC", Offset = "0x2A18DCC", VA = "0x2A18DCC")]
		public static AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle = false)
		{
			return default;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2A19160", Offset = "0x2A19160", VA = "0x2A19160")]
		public static AsyncOperationHandle DownloadDependenciesAsync(IList<IResourceLocation> locations, bool autoReleaseHandle = false)
		{
			return default;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2A19358", Offset = "0x2A19358", VA = "0x2A19358")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1CD4", Offset = "0x1B1CD4")]
		public static AsyncOperationHandle DownloadDependenciesAsync(IList<object> keys, MergeMode mode, bool autoReleaseHandle = false)
		{
			return default;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2A196B8", Offset = "0x2A196B8", VA = "0x2A196B8")]
		public static AsyncOperationHandle DownloadDependenciesAsync(IEnumerable keys, MergeMode mode, bool autoReleaseHandle = false)
		{
			return default;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2A1978C", Offset = "0x2A1978C", VA = "0x2A1978C")]
		public static void ClearDependencyCacheAsync(object key)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2A19AA4", Offset = "0x2A19AA4", VA = "0x2A19AA4")]
		public static void ClearDependencyCacheAsync(IList<IResourceLocation> locations)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2A1A078", Offset = "0x2A1A078", VA = "0x2A1A078")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1CE4", Offset = "0x1B1CE4")]
		public static void ClearDependencyCacheAsync(IList<object> keys)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2A1A638", Offset = "0x2A1A638", VA = "0x2A1A638")]
		public static void ClearDependencyCacheAsync(IEnumerable keys)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2A1A700", Offset = "0x2A1A700", VA = "0x2A1A700")]
		public static void ClearDependencyCacheAsync(string key)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2A1A7C8", Offset = "0x2A1A7C8", VA = "0x2A1A7C8")]
		public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle)
		{
			return default;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x2A1A894", Offset = "0x2A1A894", VA = "0x2A1A894")]
		public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<IResourceLocation> locations, bool autoReleaseHandle)
		{
			return default;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2A1A960", Offset = "0x2A1A960", VA = "0x2A1A960")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1CF4", Offset = "0x1B1CF4")]
		public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IList<object> keys, bool autoReleaseHandle)
		{
			return default;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2A1AA2C", Offset = "0x2A1AA2C", VA = "0x2A1AA2C")]
		public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(IEnumerable keys, bool autoReleaseHandle)
		{
			return default;
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2A1AAF8", Offset = "0x2A1AAF8", VA = "0x2A1AAF8")]
		public static AsyncOperationHandle<bool> ClearDependencyCacheAsync(string key, bool autoReleaseHandle)
		{
			return default;
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2A1ABC4", Offset = "0x2A1ABC4", VA = "0x2A1ABC4")]
		public static ResourceLocatorInfo GetLocatorInfo(string locatorId)
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2A1AEB4", Offset = "0x2A1AEB4", VA = "0x2A1AEB4")]
		public static ResourceLocatorInfo GetLocatorInfo(IResourceLocator locator)
		{
			return null;
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2A1AFF0", Offset = "0x2A1AFF0", VA = "0x2A1AFF0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1D04", Offset = "0x1B1D04")]
		public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, [Optional] Transform parent, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2A1B1B0", Offset = "0x2A1B1B0", VA = "0x2A1B1B0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1D14", Offset = "0x1B1D14")]
		public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, Vector3 position, Quaternion rotation, [Optional] Transform parent, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2A1B458", Offset = "0x2A1B458", VA = "0x2A1B458")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1D24", Offset = "0x1B1D24")]
		public static AsyncOperationHandle<GameObject> Instantiate(object key, [Optional] Transform parent, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2A1B640", Offset = "0x2A1B640", VA = "0x2A1B640")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1D34", Offset = "0x1B1D34")]
		public static AsyncOperationHandle<GameObject> Instantiate(object key, Vector3 position, Quaternion rotation, [Optional] Transform parent, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2A1B8E8", Offset = "0x2A1B8E8", VA = "0x2A1B8E8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1D44", Offset = "0x1B1D44")]
		public static AsyncOperationHandle<GameObject> Instantiate(object key, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2A1BA9C", Offset = "0x2A1BA9C", VA = "0x2A1BA9C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1D54", Offset = "0x1B1D54")]
		public static AsyncOperationHandle<GameObject> Instantiate(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2A1BB60", Offset = "0x2A1BB60", VA = "0x2A1BB60")]
		public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, [Optional] Transform parent, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2A1B2F0", Offset = "0x2A1B2F0", VA = "0x2A1B2F0")]
		public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, Vector3 position, Quaternion rotation, [Optional] Transform parent, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2A1B520", Offset = "0x2A1B520", VA = "0x2A1B520")]
		public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, [Optional] Transform parent, bool instantiateInWorldSpace = false, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2A1B780", Offset = "0x2A1B780", VA = "0x2A1B780")]
		public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, Vector3 position, Quaternion rotation, [Optional] Transform parent, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2A1B9AC", Offset = "0x2A1B9AC", VA = "0x2A1B9AC")]
		public static AsyncOperationHandle<GameObject> InstantiateAsync(object key, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2A1B0C0", Offset = "0x2A1B0C0", VA = "0x2A1B0C0")]
		public static AsyncOperationHandle<GameObject> InstantiateAsync(IResourceLocation location, InstantiationParameters instantiateParameters, bool trackHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2A1C3D0", Offset = "0x2A1C3D0", VA = "0x2A1C3D0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1D64", Offset = "0x1B1D64")]
		public static AsyncOperationHandle<SceneInstance> LoadScene(object key, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return default;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2A1C5A4", Offset = "0x2A1C5A4", VA = "0x2A1C5A4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1D74", Offset = "0x1B1D74")]
		public static AsyncOperationHandle<SceneInstance> LoadScene(IResourceLocation location, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return default;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2A1C498", Offset = "0x2A1C498", VA = "0x2A1C498")]
		public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return default;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2A1CA60", Offset = "0x2A1CA60", VA = "0x2A1CA60")]
		public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(object key, LoadSceneParameters loadSceneParameters, bool activateOnLoad = true, int priority = 100)
		{
			return default;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2A1C66C", Offset = "0x2A1C66C", VA = "0x2A1C66C")]
		public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			return default;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2A1CC34", Offset = "0x2A1CC34", VA = "0x2A1CC34")]
		public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad = true, int priority = 100)
		{
			return default;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2A1CD1C", Offset = "0x2A1CD1C", VA = "0x2A1CD1C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1D84", Offset = "0x1B1D84")]
		public static AsyncOperationHandle<SceneInstance> UnloadScene(SceneInstance scene, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2A1CEA4", Offset = "0x2A1CEA4", VA = "0x2A1CEA4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1D94", Offset = "0x1B1D94")]
		public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle handle, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2A1D03C", Offset = "0x2A1D03C", VA = "0x2A1D03C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1DA4", Offset = "0x1B1DA4")]
		public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2A1D1C4", Offset = "0x2A1D1C4", VA = "0x2A1D1C4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1DB4", Offset = "0x1B1DB4")]
		public static AsyncOperationHandle<SceneInstance> UnloadScene(AsyncOperationHandle<SceneInstance> handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2A1D37C", Offset = "0x2A1D37C", VA = "0x2A1D37C")]
		public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2A1D28C", Offset = "0x2A1D28C", VA = "0x2A1D28C")]
		public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, UnloadSceneOptions unloadOptions, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2A1CDCC", Offset = "0x2A1CDCC", VA = "0x2A1CDCC")]
		public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(SceneInstance scene, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2A1CF50", Offset = "0x2A1CF50", VA = "0x2A1CF50")]
		public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle handle, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2A1D0E0", Offset = "0x2A1D0E0", VA = "0x2A1D0E0")]
		public static AsyncOperationHandle<SceneInstance> UnloadSceneAsync(AsyncOperationHandle<SceneInstance> handle, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2A1D940", Offset = "0x2A1D940", VA = "0x2A1D940")]
		public static AsyncOperationHandle<List<string>> CheckForCatalogUpdates(bool autoReleaseHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2A1DB8C", Offset = "0x2A1DB8C", VA = "0x2A1DB8C")]
		public static AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs([Optional] IEnumerable<string> catalogs, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2A1DEC4", Offset = "0x2A1DEC4", VA = "0x2A1DEC4")]
		public static AsyncOperationHandle<List<IResourceLocator>> UpdateCatalogs(bool autoCleanBundleCache, [Optional] IEnumerable<string> catalogs, bool autoReleaseHandle = true)
		{
			return default;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2A1DF98", Offset = "0x2A1DF98", VA = "0x2A1DF98")]
		public static void AddResourceLocator(IResourceLocator locator, [Optional] string localCatalogHash, [Optional] IResourceLocation remoteCatalogLocation)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2A1E16C", Offset = "0x2A1E16C", VA = "0x2A1E16C")]
		public static void RemoveResourceLocator(IResourceLocator locator)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2A1E318", Offset = "0x2A1E318", VA = "0x2A1E318")]
		public static void ClearResourceLocators()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2A1E444", Offset = "0x2A1E444", VA = "0x2A1E444")]
		public static AsyncOperationHandle<bool> CleanBundleCache([Optional] IEnumerable<string> catalogsIds)
		{
			return default;
		}

		[Token(Token = "0x60000BA")]
		public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath) where T : IResourceProvider
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(IResourceLocation remoteCatalogLocation) where T : IResourceProvider
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		public static ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath, string remoteHashPath) where T : IResourceProvider
		{
			return null;
		}
	}
}
