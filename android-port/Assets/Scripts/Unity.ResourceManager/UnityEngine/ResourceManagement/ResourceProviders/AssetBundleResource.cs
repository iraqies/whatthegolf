using System;
using Il2CppDummyDll;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Token(Token = "0x2000044")]
	public class AssetBundleResource : IAssetBundleResource, IUpdateReceiver
	{
		[Token(Token = "0x2000045")]
		public enum LoadType
		{
			[Token(Token = "0x40000C5")]
			None = 0,
			[Token(Token = "0x40000C6")]
			Local = 1,
			[Token(Token = "0x40000C7")]
			Web = 2
		}

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x10")]
		private AssetBundle m_AssetBundle;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x18")]
		private AsyncOperation m_RequestOperation;

		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x20")]
		internal WebRequestQueueOperation m_WebRequestQueueOperation;

		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x28")]
		internal ProvideHandle m_ProvideHandle;

		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x40")]
		internal AssetBundleRequestOptions m_Options;

		[NonSerialized]
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x48")]
		private bool m_RequestCompletedCallbackCalled;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x4C")]
		private int m_Retries;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x50")]
		private BundleSource m_Source;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x58")]
		private long m_BytesToDownload;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x60")]
		private long m_DownloadedBytes;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x68")]
		private bool m_Completed;

		[Token(Token = "0x40000BD")]
		private const int k_WaitForWebRequestMainThreadSleep = 1;

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x70")]
		private string m_TransformedInternalId;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x78")]
		private AssetBundleRequest m_PreloadRequest;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x80")]
		private bool m_PreloadCompleted;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x88")]
		private ulong m_LastDownloadedByteCount;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x90")]
		private float m_TimeoutTimer;

		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x94")]
		private int m_TimeoutOverFrames;

		[Token(Token = "0x17000046")]
		private bool HasTimedOut
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x2A5D5D8", Offset = "0x2A5D5D8", VA = "0x2A5D5D8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000047")]
		internal long BytesToDownload
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x2A5D618", Offset = "0x2A5D618", VA = "0x2A5D618")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2A5D748", Offset = "0x2A5D748", VA = "0x2A5D748")]
		internal UnityWebRequest CreateWebRequest(IResourceLocation loc)
		{
			return null;
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2A5D77C", Offset = "0x2A5D77C", VA = "0x2A5D77C")]
		internal UnityWebRequest CreateWebRequest(string url)
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2A5D9D4", Offset = "0x2A5D9D4", VA = "0x2A5D9D4")]
		public AssetBundleRequest GetAssetPreloadRequest()
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2A5DD00", Offset = "0x2A5DD00", VA = "0x2A5DD00")]
		private float PercentComplete()
		{
			return default;
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2A5DD18", Offset = "0x2A5DD18", VA = "0x2A5DD18")]
		private DownloadStatus GetDownloadStatus()
		{
			return default;
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2A5DC44", Offset = "0x2A5DC44", VA = "0x2A5DC44", Slot = "4")]
		public AssetBundle GetAssetBundle()
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2A5CB9C", Offset = "0x2A5CB9C", VA = "0x2A5CB9C")]
		public void Start(ProvideHandle provideHandle)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2A5E44C", Offset = "0x2A5E44C", VA = "0x2A5E44C")]
		private bool WaitForCompletionHandler()
		{
			return default;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2A5F45C", Offset = "0x2A5F45C", VA = "0x2A5F45C")]
		private void AddCallbackInvokeIfDone(AsyncOperation operation, Action<AsyncOperation> callback)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2A5F4F0", Offset = "0x2A5F4F0", VA = "0x2A5F4F0")]
		public static void GetLoadInfo(ProvideHandle handle, out LoadType loadType, out string path)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2A5F52C", Offset = "0x2A5F52C", VA = "0x2A5F52C")]
		internal static void GetLoadInfo(IResourceLocation location, ResourceManager resourceManager, out LoadType loadType, out string path)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2A5E228", Offset = "0x2A5E228", VA = "0x2A5E228")]
		private void BeginOperation()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2A5F860", Offset = "0x2A5F860", VA = "0x2A5F860")]
		private void LoadLocalBundle()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2A5FA58", Offset = "0x2A5FA58", VA = "0x2A5FA58")]
		internal WebRequestQueueOperation EnqueueWebRequest(string internalId)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2A5FAE8", Offset = "0x2A5FAE8", VA = "0x2A5FAE8")]
		internal void AddBeginWebRequestHandler(WebRequestQueueOperation webRequestQueueOperation)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2A5FF60", Offset = "0x2A5FF60", VA = "0x2A5FF60")]
		private void BeginWebRequestOperation(AsyncOperation asyncOp)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2A60114", Offset = "0x2A60114", VA = "0x2A60114", Slot = "5")]
		public void Update(float unscaledDeltaTime)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x2A5F3A4", Offset = "0x2A5F3A4", VA = "0x2A5F3A4")]
		private void LocalRequestOperationCompleted(AsyncOperation op)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2A5FC94", Offset = "0x2A5FC94", VA = "0x2A5FC94")]
		private void CompleteBundleLoad(AssetBundle bundle)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x2A5EC90", Offset = "0x2A5EC90", VA = "0x2A5EC90")]
		private void WebRequestOperationCompleted(AsyncOperation op)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2A5D050", Offset = "0x2A5D050", VA = "0x2A5D050")]
		public void Unload()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2A5CB94", Offset = "0x2A5CB94", VA = "0x2A5CB94")]
		public AssetBundleResource()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2A6085C", Offset = "0x2A6085C", VA = "0x2A6085C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B8504", Offset = "0x1B8504")]
		private void _003CGetAssetPreloadRequest_003Eb__25_0(AsyncOperation operation)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2A60868", Offset = "0x2A60868", VA = "0x2A60868")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B8514", Offset = "0x1B8514")]
		private void _003CAddBeginWebRequestHandler_003Eb__37_0(UnityWebRequestAsyncOperation asyncOp)
		{
		}
	}
}
