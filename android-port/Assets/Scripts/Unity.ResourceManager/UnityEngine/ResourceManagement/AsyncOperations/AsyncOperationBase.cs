using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	[Token(Token = "0x200006D")]
	public abstract class AsyncOperationBase<TObject> : IAsyncOperation
	{
		[Token(Token = "0x200006E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7C68", Offset = "0x1B7C68")]
		private sealed class _003C_003Ec__DisplayClass60_0
		{
			[Token(Token = "0x400012E")]
			[FieldOffset(Offset = "0x0")]
			public Action<AsyncOperationHandle> value;

			[Token(Token = "0x60002E4")]
			public _003C_003Ec__DisplayClass60_0()
			{
			}

			[Token(Token = "0x60002E5")]
			internal void _003Cadd_CompletedTypeless_003Eb__0(AsyncOperationHandle<TObject> s)
			{
			}
		}

		[Token(Token = "0x200006F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7C78", Offset = "0x1B7C78")]
		private sealed class _003C_003Ec__DisplayClass61_0
		{
			[Token(Token = "0x400012F")]
			[FieldOffset(Offset = "0x0")]
			public Action<AsyncOperationHandle> value;

			[Token(Token = "0x60002E6")]
			public _003C_003Ec__DisplayClass61_0()
			{
			}

			[Token(Token = "0x60002E7")]
			internal void _003Cremove_CompletedTypeless_003Eb__0(AsyncOperationHandle<TObject> s)
			{
			}
		}

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B825C", Offset = "0x1B825C")]
		private TObject Result__BackingField;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x0")]
		private int m_referenceCount;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x0")]
		internal AsyncOperationStatus m_Status;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x0")]
		internal Exception m_Error;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x0")]
		internal ResourceManager m_RM;

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x0")]
		internal int m_Version;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x0")]
		private DelegateList<AsyncOperationHandle> m_DestroyedAction;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x0")]
		private DelegateList<AsyncOperationHandle<TObject>> m_CompletedActionT;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x0")]
		private Action<IAsyncOperation> m_OnDestroyAction;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x0")]
		private Action<AsyncOperationHandle> m_dependencyCompleteAction;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x0")]
		protected internal bool HasExecuted;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B826C", Offset = "0x1B826C")]
		private Action m_Executed;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B827C", Offset = "0x1B827C")]
		private bool IsRunning__BackingField;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x0")]
		private TaskCompletionSource<TObject> m_taskCompletionSource;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x0")]
		private TaskCompletionSource<object> m_taskCompletionSourceTypeless;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x0")]
		private bool m_InDeferredCallbackQueue;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x0")]
		private DelegateList<float> m_UpdateCallbacks;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x0")]
		private Action<float> m_UpdateCallback;

		[Token(Token = "0x1700008D")]
		protected virtual float Progress
		{
			[Token(Token = "0x600029E")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008E")]
		protected virtual string DebugName
		{
			[Token(Token = "0x600029F")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		public TObject Result
		{
			[Token(Token = "0x60002A1")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B861C", Offset = "0x1B861C")]
			get
			{
				return (TObject)null;
			}
			[Token(Token = "0x60002A2")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B862C", Offset = "0x1B862C")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		internal int Version
		{
			[Token(Token = "0x60002A3")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000091")]
		internal bool CompletedEventHasListeners
		{
			[Token(Token = "0x60002A4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000092")]
		internal bool DestroyedEventHasListeners
		{
			[Token(Token = "0x60002A5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000093")]
		internal Action<IAsyncOperation> OnDestroy
		{
			[Token(Token = "0x60002A6")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		protected internal int ReferenceCount
		{
			[Token(Token = "0x60002A9")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000095")]
		public bool IsRunning
		{
			[Token(Token = "0x60002AA")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B865C", Offset = "0x1B865C")]
			get
			{
				return default;
			}
			[Token(Token = "0x60002AB")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B866C", Offset = "0x1B866C")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000096")]
		internal Task<TObject> Task
		{
			[Token(Token = "0x60002B2")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		private Task<object> UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002ETask
		{
			[Token(Token = "0x60002B3")]
			get
			{
				return UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_Task();
			}
		}

		[Token(Token = "0x17000098")]
		internal AsyncOperationStatus Status
		{
			[Token(Token = "0x60002BC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000099")]
		internal Exception OperationException
		{
			[Token(Token = "0x60002BD")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BE")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		internal object Current
		{
			[Token(Token = "0x60002C1")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		internal bool IsDone
		{
			[Token(Token = "0x60002C2")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700009C")]
		internal float PercentComplete
		{
			[Token(Token = "0x60002C3")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700009D")]
		internal AsyncOperationHandle<TObject> Handle
		{
			[Token(Token = "0x60002C5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700009E")]
		private int UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EVersion
		{
			[Token(Token = "0x60002D0")]
			get
			{
				return UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_Version();
			}
		}

		[Token(Token = "0x1700009F")]
		private int UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EReferenceCount
		{
			[Token(Token = "0x60002D1")]
			get
			{
				return UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_ReferenceCount();
			}
		}

		[Token(Token = "0x170000A0")]
		private float UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EPercentComplete
		{
			[Token(Token = "0x60002D2")]
			get
			{
				return UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_PercentComplete();
			}
		}

		[Token(Token = "0x170000A1")]
		private AsyncOperationStatus UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EStatus
		{
			[Token(Token = "0x60002D3")]
			get
			{
				return UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_Status();
			}
		}

		[Token(Token = "0x170000A2")]
		private Exception UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EOperationException
		{
			[Token(Token = "0x60002D4")]
			get
			{
				return UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_OperationException();
			}
		}

		[Token(Token = "0x170000A3")]
		private bool UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EIsDone
		{
			[Token(Token = "0x60002D5")]
			get
			{
				return UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_IsDone();
			}
		}

		[Token(Token = "0x170000A4")]
		private AsyncOperationHandle UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EHandle
		{
			[Token(Token = "0x60002D6")]
			get
			{
				return UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_Handle();
			}
		}

		[Token(Token = "0x170000A5")]
		private Action<IAsyncOperation> UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EOnDestroy
		{
			[Token(Token = "0x60002D7")]
			set
			{
				UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eset_OnDestroy(value);
			}
		}

		[Token(Token = "0x170000A6")]
		private string UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EDebugName
		{
			[Token(Token = "0x60002D8")]
			get
			{
				return UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_DebugName();
			}
		}

		[Token(Token = "0x170000A7")]
		private Type UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EResultType
		{
			[Token(Token = "0x60002DA")]
			get
			{
				return UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_ResultType();
			}
		}

		[Token(Token = "0x14000007")]
		internal event Action Executed
		{
			[Token(Token = "0x60002A7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B863C", Offset = "0x1B863C")]
			add
			{
			}
			[Token(Token = "0x60002A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B864C", Offset = "0x1B864C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		internal event Action<AsyncOperationHandle<TObject>> Completed
		{
			[Token(Token = "0x60002B6")]
			add
			{
			}
			[Token(Token = "0x60002B7")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		internal event Action<AsyncOperationHandle> Destroyed
		{
			[Token(Token = "0x60002B8")]
			add
			{
			}
			[Token(Token = "0x60002B9")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		internal event Action<AsyncOperationHandle> CompletedTypeless
		{
			[Token(Token = "0x60002BA")]
			add
			{
			}
			[Token(Token = "0x60002BB")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		private event Action<AsyncOperationHandle> UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002ECompletedTypeless
		{
			[Token(Token = "0x60002CC")]
			add
			{
				UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eadd_CompletedTypeless(value);
			}
			[Token(Token = "0x60002CD")]
			remove
			{
				UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eremove_CompletedTypeless(value);
			}
		}

		[Token(Token = "0x1400000C")]
		private event Action<AsyncOperationHandle> UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EDestroyed
		{
			[Token(Token = "0x60002CE")]
			add
			{
				UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eadd_Destroyed(value);
			}
			[Token(Token = "0x60002CF")]
			remove
			{
				UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eremove_Destroyed(value);
			}
		}

		[Token(Token = "0x600029C")]
		protected abstract void Execute();

		[Token(Token = "0x600029D")]
		protected virtual void Destroy()
		{
		}

		[Token(Token = "0x60002A0")]
		public virtual void GetDependencies(List<AsyncOperationHandle> dependencies)
		{
		}

		[Token(Token = "0x60002AC")]
		protected AsyncOperationBase()
		{
		}

		[Token(Token = "0x60002AD")]
		internal static string ShortenPath(string p, bool keepExtension)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		public void WaitForCompletion()
		{
		}

		[Token(Token = "0x60002AF")]
		protected virtual bool InvokeWaitForCompletion()
		{
			return default;
		}

		[Token(Token = "0x60002B0")]
		protected internal void IncrementReferenceCount()
		{
		}

		[Token(Token = "0x60002B1")]
		protected internal void DecrementReferenceCount()
		{
		}

		[Token(Token = "0x60002B3")]
		private Task<object> UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_Task()
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		private void RegisterForDeferredCallbackEvent(bool incrementReferenceCount = true)
		{
		}

		[Token(Token = "0x60002BF")]
		internal bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60002C0")]
		internal void Reset()
		{
		}

		[Token(Token = "0x60002C4")]
		internal void InvokeCompletionEvent()
		{
		}

		[Token(Token = "0x60002C6")]
		private void UpdateCallback(float unscaledDeltaTime)
		{
		}

		[Token(Token = "0x60002C7")]
		public void Complete(TObject result, bool success, string errorMsg)
		{
		}

		[Token(Token = "0x60002C8")]
		public void Complete(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure)
		{
		}

		[Token(Token = "0x60002C9")]
		public void Complete(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = true)
		{
		}

		[Token(Token = "0x60002CA")]
		internal void Start(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks)
		{
		}

		[Token(Token = "0x60002CB")]
		internal void InvokeExecute()
		{
		}

		[Token(Token = "0x60002CC")]
		private void UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eadd_CompletedTypeless(Action<AsyncOperationHandle> value)
		{
		}

		[Token(Token = "0x60002CD")]
		private void UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eremove_CompletedTypeless(Action<AsyncOperationHandle> value)
		{
		}

		[Token(Token = "0x60002CE")]
		private void UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eadd_Destroyed(Action<AsyncOperationHandle> value)
		{
		}

		[Token(Token = "0x60002CF")]
		private void UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eremove_Destroyed(Action<AsyncOperationHandle> value)
		{
		}

		[Token(Token = "0x60002D0")]
		private int UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_Version()
		{
			return default;
		}

		[Token(Token = "0x60002D1")]
		private int UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_ReferenceCount()
		{
			return default;
		}

		[Token(Token = "0x60002D2")]
		private float UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_PercentComplete()
		{
			return default;
		}

		[Token(Token = "0x60002D3")]
		private AsyncOperationStatus UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_Status()
		{
			return default;
		}

		[Token(Token = "0x60002D4")]
		private Exception UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_OperationException()
		{
			return null;
		}

		[Token(Token = "0x60002D5")]
		private bool UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_IsDone()
		{
			return default;
		}

		[Token(Token = "0x60002D6")]
		private AsyncOperationHandle UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_Handle()
		{
			return default;
		}

		[Token(Token = "0x60002D7")]
		private void UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eset_OnDestroy(Action<IAsyncOperation> value)
		{
		}

		[Token(Token = "0x60002D8")]
		private string UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_DebugName()
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		private object UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EGetResultAsObject()
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		private Type UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002Eget_ResultType()
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		private void UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EGetDependencies(List<AsyncOperationHandle> deps)
		{
		}

		[Token(Token = "0x60002DC")]
		private void UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EDecrementReferenceCount()
		{
		}

		[Token(Token = "0x60002DD")]
		private void UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EIncrementReferenceCount()
		{
		}

		[Token(Token = "0x60002DE")]
		private void UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EInvokeCompletionEvent()
		{
		}

		[Token(Token = "0x60002DF")]
		private void UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EStart(ResourceManager rm, AsyncOperationHandle dependency, DelegateList<float> updateCallbacks)
		{
		}

		[Token(Token = "0x60002E0")]
		internal virtual void ReleaseDependencies()
		{
		}

		[Token(Token = "0x60002E1")]
		private DownloadStatus UnityEngine_002EResourceManagement_002EAsyncOperations_002EIAsyncOperation_002EGetDownloadStatus(HashSet<object> visited)
		{
			return default;
		}

		[Token(Token = "0x60002E2")]
		internal virtual DownloadStatus GetDownloadStatus(HashSet<object> visited)
		{
			return default;
		}

		[Token(Token = "0x60002E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B867C", Offset = "0x1B867C")]
		private void _003C_002Ector_003Eb__38_0(AsyncOperationHandle o)
		{
		}
	}
}
