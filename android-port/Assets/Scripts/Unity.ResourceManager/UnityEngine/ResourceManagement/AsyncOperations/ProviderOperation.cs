using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.ResourceManagement.Util;
using UnityEngine.Scripting;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	[Token(Token = "0x2000077")]
	[Preserve]
	internal class ProviderOperation<TObject> : AsyncOperationBase<TObject>, IGenericProviderOperation, ICachable
	{
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x0")]
		private bool m_ReleaseDependenciesOnFailure;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x0")]
		private Action<int, object, bool, Exception> m_CompletionCallback;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x0")]
		private Action<int, IList<object>> m_GetDepCallback;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x0")]
		private Func<float> m_GetProgressCallback;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x0")]
		private Func<DownloadStatus> m_GetDownloadProgressCallback;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x0")]
		private Func<bool> m_WaitForCompletionCallback;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x0")]
		private bool m_ProviderCompletedCalled;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x0")]
		private DownloadStatus m_DownloadStatus;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x0")]
		private IResourceProvider m_Provider;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x0")]
		internal AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x0")]
		private IResourceLocation m_Location;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x0")]
		private int m_ProvideHandleVersion;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x0")]
		private bool m_NeedsRelease;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B829C", Offset = "0x1B829C")]
		private IOperationCacheKey UnityEngine_002EResourceManagement_002EAsyncOperations_002EICachable_002EKey__BackingField;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x0")]
		private ResourceManager m_ResourceManager;

		[Token(Token = "0x4000159")]
		private const float k_OperationWaitingToCompletePercentComplete = 0.99f;

		[Token(Token = "0x400015A")]
		internal const string kInvalidHandleMsg = "The ProvideHandle is invalid. After the handle has been completed, it can no longer be used";

		[Token(Token = "0x170000C8")]
		private IOperationCacheKey UnityEngine_002EResourceManagement_002EAsyncOperations_002EICachable_002EKey
		{
			[Token(Token = "0x600034E")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B86AC", Offset = "0x1B86AC")]
			get
			{
				return UnityEngine_002EResourceManagement_002EAsyncOperations_002EICachable_002Eget_Key();
			}
			[Token(Token = "0x600034F")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B86BC", Offset = "0x1B86BC")]
			set
			{
				UnityEngine_002EResourceManagement_002EAsyncOperations_002EICachable_002Eset_Key(value);
			}
		}

		[Token(Token = "0x170000C9")]
		public int ProvideHandleVersion
		{
			[Token(Token = "0x6000350")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000CA")]
		public IResourceLocation Location
		{
			[Token(Token = "0x6000351")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CB")]
		protected override string DebugName
		{
			[Token(Token = "0x6000359")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		public Type RequestedType
		{
			[Token(Token = "0x600035B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		public int DependencyCount
		{
			[Token(Token = "0x600035C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000CE")]
		protected override float Progress
		{
			[Token(Token = "0x6000360")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600034E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B86AC", Offset = "0x1B86AC")]
		private IOperationCacheKey UnityEngine_002EResourceManagement_002EAsyncOperations_002EICachable_002Eget_Key()
		{
			return null;
		}

		[Token(Token = "0x600034F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B86BC", Offset = "0x1B86BC")]
		private void UnityEngine_002EResourceManagement_002EAsyncOperations_002EICachable_002Eset_Key(IOperationCacheKey value)
		{
		}

		[Token(Token = "0x6000352")]
		public void SetDownloadProgressCallback(Func<DownloadStatus> callback)
		{
		}

		[Token(Token = "0x6000353")]
		public void SetWaitForCompletionCallback(Func<bool> callback)
		{
		}

		[Token(Token = "0x6000354")]
		protected override bool InvokeWaitForCompletion()
		{
			return default;
		}

		[Token(Token = "0x6000355")]
		internal override DownloadStatus GetDownloadStatus(HashSet<object> visited)
		{
			return default;
		}

		[Token(Token = "0x6000356")]
		public ProviderOperation()
		{
		}

		[Token(Token = "0x6000357")]
		public override void GetDependencies(List<AsyncOperationHandle> deps)
		{
		}

		[Token(Token = "0x6000358")]
		internal override void ReleaseDependencies()
		{
		}

		[Token(Token = "0x600035A")]
		public void GetDependencies(IList<object> dstList)
		{
		}

		[Token(Token = "0x600035D")]
		public TDepObject GetDependency<TDepObject>(int index)
		{
			return (TDepObject)null;
		}

		[Token(Token = "0x600035E")]
		public void SetProgressCallback(Func<float> callback)
		{
		}

		[Token(Token = "0x600035F")]
		public void ProviderCompleted<T>(T result, bool status, Exception e)
		{
		}

		[Token(Token = "0x6000361")]
		protected override void Execute()
		{
		}

		[Token(Token = "0x6000362")]
		public void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp)
		{
		}

		[Token(Token = "0x6000363")]
		public void Init(ResourceManager rm, IResourceProvider provider, IResourceLocation location, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp, bool releaseDependenciesOnFailure)
		{
		}

		[Token(Token = "0x6000364")]
		private bool WaitForCompletionHandler()
		{
			return default;
		}

		[Token(Token = "0x6000365")]
		protected override void Destroy()
		{
		}
	}
}
