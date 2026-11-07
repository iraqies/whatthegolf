using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.ResourceManagement.Util;
using UnityEngine.SceneManagement;

namespace UnityEngine.ResourceManagement
{
	[Token(Token = "0x2000009")]
	public class ResourceManager : IDisposable
	{
		[Token(Token = "0x200000A")]
		public enum DiagnosticEventType
		{
			[Token(Token = "0x4000036")]
			AsyncOperationFail = 0,
			[Token(Token = "0x4000037")]
			AsyncOperationCreate = 1,
			[Token(Token = "0x4000038")]
			AsyncOperationPercentComplete = 2,
			[Token(Token = "0x4000039")]
			AsyncOperationComplete = 3,
			[Token(Token = "0x400003A")]
			AsyncOperationReferenceCount = 4,
			[Token(Token = "0x400003B")]
			AsyncOperationDestroy = 5
		}

		[Token(Token = "0x200000B")]
		public struct DiagnosticEventContext
		{
			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7D18", Offset = "0x1B7D18")]
			private readonly AsyncOperationHandle OperationHandle__BackingField;

			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7D28", Offset = "0x1B7D28")]
			private readonly DiagnosticEventType Type__BackingField;

			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7D38", Offset = "0x1B7D38")]
			private readonly int EventValue__BackingField;

			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7D48", Offset = "0x1B7D48")]
			private readonly IResourceLocation Location__BackingField;

			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7D58", Offset = "0x1B7D58")]
			private readonly object Context__BackingField;

			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7D68", Offset = "0x1B7D68")]
			private readonly string Error__BackingField;

			[Token(Token = "0x17000012")]
			public AsyncOperationHandle OperationHandle
			{
				[Token(Token = "0x6000086")]
				[Address(RVA = "0x2A77450", Offset = "0x2A77450", VA = "0x2A77450")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B83C4", Offset = "0x1B83C4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000013")]
			public DiagnosticEventType Type
			{
				[Token(Token = "0x6000087")]
				[Address(RVA = "0x2A77464", Offset = "0x2A77464", VA = "0x2A77464")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B83D4", Offset = "0x1B83D4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000014")]
			public int EventValue
			{
				[Token(Token = "0x6000088")]
				[Address(RVA = "0x2A7746C", Offset = "0x2A7746C", VA = "0x2A7746C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B83E4", Offset = "0x1B83E4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000015")]
			public IResourceLocation Location
			{
				[Token(Token = "0x6000089")]
				[Address(RVA = "0x2A77474", Offset = "0x2A77474", VA = "0x2A77474")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B83F4", Offset = "0x1B83F4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000016")]
			public object Context
			{
				[Token(Token = "0x600008A")]
				[Address(RVA = "0x2A7747C", Offset = "0x2A7747C", VA = "0x2A7747C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B8404", Offset = "0x1B8404")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000017")]
			public string Error
			{
				[Token(Token = "0x600008B")]
				[Address(RVA = "0x2A77484", Offset = "0x2A77484", VA = "0x2A77484")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B8414", Offset = "0x1B8414")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600008C")]
			[Address(RVA = "0x2A7748C", Offset = "0x2A7748C", VA = "0x2A7748C")]
			public DiagnosticEventContext(AsyncOperationHandle op, DiagnosticEventType type, [Optional][DefaultParameterValue(0)] int eventValue, [Optional] string error, [Optional] object context)
			{
			}
		}

		[Token(Token = "0x200000C")]
		private struct DeferredCallbackRegisterRequest
		{
			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal IAsyncOperation operation;

			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal bool incrementRefCount;
		}

		[Token(Token = "0x200000D")]
		private class CompletedOperation<TObject> : AsyncOperationBase<TObject>
		{
			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool m_Success;

			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Exception m_Exception;

			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool m_ReleaseDependenciesOnFailure;

			[Token(Token = "0x17000018")]
			protected override string DebugName
			{
				[Token(Token = "0x6000090")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600008D")]
			public CompletedOperation()
			{
			}

			[Token(Token = "0x600008E")]
			public void Init(TObject result, bool success, string errorMsg, bool releaseDependenciesOnFailure = true)
			{
			}

			[Token(Token = "0x600008F")]
			public void Init(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = true)
			{
			}

			[Token(Token = "0x6000091")]
			protected override bool InvokeWaitForCompletion()
			{
				return default;
			}

			[Token(Token = "0x6000092")]
			protected override void Execute()
			{
			}
		}

		[Token(Token = "0x200000E")]
		internal class InstanceOperation : AsyncOperationBase<GameObject>
		{
			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private AsyncOperationHandle<GameObject> m_dependency;

			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private InstantiationParameters m_instantiationParams;

			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private IInstanceProvider m_instanceProvider;

			[Token(Token = "0x400004A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private GameObject m_instance;

			[Token(Token = "0x400004B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Scene m_scene;

			[Token(Token = "0x17000019")]
			protected override string DebugName
			{
				[Token(Token = "0x6000096")]
				[Address(RVA = "0x2A7771C", Offset = "0x2A7771C", VA = "0x2A7771C", Slot = "31")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001A")]
			protected override float Progress
			{
				[Token(Token = "0x6000099")]
				[Address(RVA = "0x2A77904", Offset = "0x2A77904", VA = "0x2A77904", Slot = "30")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000093")]
			[Address(RVA = "0x2A6F8D0", Offset = "0x2A6F8D0", VA = "0x2A6F8D0")]
			public void Init(ResourceManager rm, IInstanceProvider instanceProvider, InstantiationParameters instantiationParams, AsyncOperationHandle<GameObject> dependency)
			{
			}

			[Token(Token = "0x6000094")]
			[Address(RVA = "0x2A77598", Offset = "0x2A77598", VA = "0x2A77598", Slot = "35")]
			internal override DownloadStatus GetDownloadStatus(HashSet<object> visited)
			{
				return default;
			}

			[Token(Token = "0x6000095")]
			[Address(RVA = "0x2A7766C", Offset = "0x2A7766C", VA = "0x2A7766C", Slot = "32")]
			public override void GetDependencies(List<AsyncOperationHandle> deps)
			{
			}

			[Token(Token = "0x6000097")]
			[Address(RVA = "0x2A7782C", Offset = "0x2A7782C", VA = "0x2A7782C")]
			public Scene InstanceScene()
			{
				return default;
			}

			[Token(Token = "0x6000098")]
			[Address(RVA = "0x2A77834", Offset = "0x2A77834", VA = "0x2A77834", Slot = "29")]
			protected override void Destroy()
			{
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x2A77958", Offset = "0x2A77958", VA = "0x2A77958", Slot = "33")]
			protected override bool InvokeWaitForCompletion()
			{
				return default;
			}

			[Token(Token = "0x600009B")]
			[Address(RVA = "0x2A77AA0", Offset = "0x2A77AA0", VA = "0x2A77AA0", Slot = "28")]
			protected override void Execute()
			{
			}

			[Token(Token = "0x600009C")]
			[Address(RVA = "0x2A77CDC", Offset = "0x2A77CDC", VA = "0x2A77CDC")]
			public InstanceOperation()
			{
			}
		}

		[Token(Token = "0x200000F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7A38", Offset = "0x1B7A38")]
		private sealed class _003C_003Ec__DisplayClass95_0<TObject>
		{
			[Token(Token = "0x400004C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<TObject> callback;

			[Token(Token = "0x400004D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool releaseDependenciesOnFailure;

			[Token(Token = "0x400004E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ResourceManager _003C_003E4__this;

			[Token(Token = "0x600009D")]
			public _003C_003Ec__DisplayClass95_0()
			{
			}

			[Token(Token = "0x600009E")]
			internal void _003CProvideResources_003Eb__0(AsyncOperationHandle x)
			{
			}

			[Token(Token = "0x600009F")]
			internal AsyncOperationHandle<IList<TObject>> _003CProvideResources_003Eb__1(AsyncOperationHandle resultHandle)
			{
				return default;
			}
		}

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal bool postProfilerEvents;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7CD8", Offset = "0x1B7CD8")]
		private static Action<AsyncOperationHandle, Exception> ExceptionHandler__BackingField;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7CE8", Offset = "0x1B7CE8")]
		private Func<IResourceLocation, string> InternalIdTransformFunc__BackingField;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7CF8", Offset = "0x1B7CF8")]
		private Action<UnityWebRequest> WebRequestOverride__BackingField;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal bool CallbackHooksEnabled;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ListWithEvents<IResourceProvider> m_ResourceProviders;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IAllocationStrategy m_allocator;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal ListWithEvents<IUpdateReceiver> m_UpdateReceivers;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<IUpdateReceiver> m_UpdateReceiversToRemove;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_UpdatingReceivers;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool m_InsideUpdateMethod;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal Dictionary<int, IResourceProvider> m_providerMap;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<IOperationCacheKey, IAsyncOperation> m_AssetOperationCache;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private HashSet<InstanceOperation> m_TrackedInstanceOperations;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal DelegateList<float> m_UpdateCallbacks;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<IAsyncOperation> m_DeferredCompleteCallbacks;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private HashSet<IResourceProvider> m_AssetBundleProviders;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_InsideExecuteDeferredCallbacksMethod;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<DeferredCallbackRegisterRequest> m_DeferredCallbacksToRegister;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Action<AsyncOperationHandle, DiagnosticEventType, int, object> m_obsoleteDiagnosticsHandler;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Action<DiagnosticEventContext> m_diagnosticsHandler;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Action<IAsyncOperation> m_ReleaseOpNonCached;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Action<IAsyncOperation> m_ReleaseOpCached;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Action<IAsyncOperation> m_ReleaseInstanceOp;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int s_GroupOperationTypeHash;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static int s_InstanceOperationTypeHash;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B7D08", Offset = "0x1B7D08")]
		private CertificateHandler CertificateHandlerInstance__BackingField;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool m_RegisteredForCallbacks;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Dictionary<Type, Type> m_ProviderOperationTypeCache;

		[Token(Token = "0x1700000A")]
		public static Action<AsyncOperationHandle, Exception> ExceptionHandler
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x2A6BBBC", Offset = "0x2A6BBBC", VA = "0x2A6BBBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B82EC", Offset = "0x1B82EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x2A6BC20", Offset = "0x2A6BC20", VA = "0x2A6BC20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B82FC", Offset = "0x1B82FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Func<IResourceLocation, string> InternalIdTransformFunc
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x2A6BC90", Offset = "0x2A6BC90", VA = "0x2A6BC90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B830C", Offset = "0x1B830C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x2A6BC98", Offset = "0x2A6BC98", VA = "0x2A6BC98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B831C", Offset = "0x1B831C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Action<UnityWebRequest> WebRequestOverride
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x2A6BCA0", Offset = "0x2A6BCA0", VA = "0x2A6BCA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B832C", Offset = "0x1B832C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x2A6BCA8", Offset = "0x2A6BCA8", VA = "0x2A6BCA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B833C", Offset = "0x1B833C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		internal int OperationCacheCount
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x2A6BCB0", Offset = "0x2A6BCB0", VA = "0x2A6BCB0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000E")]
		internal int InstanceOperationCount
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x2A6BD04", Offset = "0x2A6BD04", VA = "0x2A6BD04")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000F")]
		public IAllocationStrategy Allocator
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2A6BD50", Offset = "0x2A6BD50", VA = "0x2A6BD50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x2A6BD58", Offset = "0x2A6BD58", VA = "0x2A6BD58")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public IList<IResourceProvider> ResourceProviders
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x2A6BD60", Offset = "0x2A6BD60", VA = "0x2A6BD60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public CertificateHandler CertificateHandlerInstance
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x2A6BD68", Offset = "0x2A6BD68", VA = "0x2A6BD68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B834C", Offset = "0x1B834C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x2A6BD70", Offset = "0x2A6BD70", VA = "0x2A6BD70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B835C", Offset = "0x1B835C")]
			set
			{
			}
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2A5D178", Offset = "0x2A5D178", VA = "0x2A5D178")]
		public string TransformInternalId(IResourceLocation location)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2A6009C", Offset = "0x2A6009C", VA = "0x2A6009C")]
		public void AddUpdateReceiver(IUpdateReceiver receiver)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2A60248", Offset = "0x2A60248", VA = "0x2A60248")]
		public void RemoveUpdateReciever(IUpdateReceiver receiver)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2A6BD78", Offset = "0x2A6BD78", VA = "0x2A6BD78")]
		public ResourceManager([Optional] IAllocationStrategy alloc)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2A6C268", Offset = "0x2A6C268", VA = "0x2A6C268")]
		private void OnObjectAdded(object obj)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2A6C318", Offset = "0x2A6C318", VA = "0x2A6C318")]
		private void OnObjectRemoved(object obj)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2A6C390", Offset = "0x2A6C390", VA = "0x2A6C390")]
		internal void RegisterForCallbacks()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2A6C4B8", Offset = "0x2A6C4B8", VA = "0x2A6C4B8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B836C", Offset = "0x1B836C")]
		public void ClearDiagnosticsCallback()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2A6C4C0", Offset = "0x2A6C4C0", VA = "0x2A6C4C0")]
		public void ClearDiagnosticCallbacks()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2A6C4C8", Offset = "0x2A6C4C8", VA = "0x2A6C4C8")]
		public void UnregisterDiagnosticCallback(Action<DiagnosticEventContext> func)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2A6C5A8", Offset = "0x2A6C5A8", VA = "0x2A6C5A8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B83A4", Offset = "0x1B83A4")]
		public void RegisterDiagnosticCallback(Action<AsyncOperationHandle, DiagnosticEventType, int, object> func)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2A6C5B0", Offset = "0x2A6C5B0", VA = "0x2A6C5B0")]
		public void RegisterDiagnosticCallback(Action<DiagnosticEventContext> func)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2A6C634", Offset = "0x2A6C634", VA = "0x2A6C634")]
		internal void PostDiagnosticEvent(DiagnosticEventContext context)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2A6C7CC", Offset = "0x2A6C7CC", VA = "0x2A6C7CC")]
		public IResourceProvider GetResourceProvider(Type t, IResourceLocation location)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2A6CCA0", Offset = "0x2A6CCA0", VA = "0x2A6CCA0")]
		private Type GetDefaultTypeForLocation(IResourceLocation loc)
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2A6CE10", Offset = "0x2A6CE10", VA = "0x2A6CE10")]
		private int CalculateLocationsHash(IList<IResourceLocation> locations, [Optional] Type t)
		{
			return default;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2A6D2A0", Offset = "0x2A6D2A0", VA = "0x2A6D2A0")]
		private AsyncOperationHandle ProvideResource(IResourceLocation location, [Optional] Type desiredType, bool releaseDependenciesOnFailure = true)
		{
			return default;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2A6E6C8", Offset = "0x2A6E6C8", VA = "0x2A6E6C8")]
		internal IAsyncOperation GetOperationFromCache(IResourceLocation location, Type desiredType)
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2A6DBF0", Offset = "0x2A6DBF0", VA = "0x2A6DBF0")]
		internal IOperationCacheKey CreateCacheKeyForLocation(IResourceProvider provider, IResourceLocation location, [Optional] Type desiredType)
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		public AsyncOperationHandle<TObject> ProvideResource<TObject>(IResourceLocation location)
		{
			return default;
		}

		[Token(Token = "0x6000061")]
		public AsyncOperationHandle<TObject> StartOperation<TObject>(AsyncOperationBase<TObject> operation, AsyncOperationHandle dependency)
		{
			return default;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2A6E548", Offset = "0x2A6E548", VA = "0x2A6E548")]
		internal AsyncOperationHandle StartOperation(IAsyncOperation operation, AsyncOperationHandle dependency)
		{
			return default;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2A6E774", Offset = "0x2A6E774", VA = "0x2A6E774")]
		private void OnInstanceOperationDestroy(IAsyncOperation o)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2A6E8D4", Offset = "0x2A6E8D4", VA = "0x2A6E8D4")]
		private void OnOperationDestroyNonCached(IAsyncOperation o)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2A6E9C4", Offset = "0x2A6E9C4", VA = "0x2A6E9C4")]
		private void OnOperationDestroyCached(IAsyncOperation o)
		{
		}

		[Token(Token = "0x6000066")]
		internal T CreateOperation<T>(Type actualType, int typeHash, IOperationCacheKey cacheKey, Action<IAsyncOperation> onDestroyAction) where T : IAsyncOperation
		{
			return (T)null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2A6ECFC", Offset = "0x2A6ECFC", VA = "0x2A6ECFC")]
		internal void AddOperationToCache(IOperationCacheKey key, IAsyncOperation operation)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2A6EC44", Offset = "0x2A6EC44", VA = "0x2A6EC44")]
		internal bool RemoveOperationFromCache(IOperationCacheKey key)
		{
			return default;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2A6EDB8", Offset = "0x2A6EDB8", VA = "0x2A6EDB8")]
		internal bool IsOperationCached(IOperationCacheKey key)
		{
			return default;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2A6EE1C", Offset = "0x2A6EE1C", VA = "0x2A6EE1C")]
		internal int CachedOperationCount()
		{
			return default;
		}

		[Token(Token = "0x600006B")]
		public AsyncOperationHandle<TObject> CreateCompletedOperation<TObject>(TObject result, string errorMsg)
		{
			return default;
		}

		[Token(Token = "0x600006C")]
		public AsyncOperationHandle<TObject> CreateCompletedOperationWithException<TObject>(TObject result, Exception exception)
		{
			return default;
		}

		[Token(Token = "0x600006D")]
		internal AsyncOperationHandle<TObject> CreateCompletedOperationInternal<TObject>(TObject result, bool success, Exception exception, bool releaseDependenciesOnFailure = true)
		{
			return default;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2A685E4", Offset = "0x2A685E4", VA = "0x2A685E4")]
		public void Release(AsyncOperationHandle handle)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2A6EE70", Offset = "0x2A6EE70", VA = "0x2A6EE70")]
		public void Acquire(AsyncOperationHandle handle)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2A6EE94", Offset = "0x2A6EE94", VA = "0x2A6EE94")]
		private GroupOperation AcquireGroupOpFromCache(IOperationCacheKey key)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		public AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation<T>(IList<IResourceLocation> locations)
		{
			return default;
		}

		[Token(Token = "0x6000072")]
		internal AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGroupOperation<T>(IList<IResourceLocation> locations, bool allowFailedDependencies)
		{
			return default;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2A6EFFC", Offset = "0x2A6EFFC", VA = "0x2A6EFFC")]
		public AsyncOperationHandle<IList<AsyncOperationHandle>> CreateGenericGroupOperation(List<AsyncOperationHandle> operations, bool releasedCachedOpOnComplete = false)
		{
			return default;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2A6DDBC", Offset = "0x2A6DDBC", VA = "0x2A6DDBC")]
		internal AsyncOperationHandle<IList<AsyncOperationHandle>> ProvideResourceGroupCached(IList<IResourceLocation> locations, int groupHash, Type desiredType, Action<AsyncOperationHandle> callback, bool releaseDependenciesOnFailure = true)
		{
			return default;
		}

		[Token(Token = "0x6000075")]
		public AsyncOperationHandle<IList<TObject>> ProvideResources<TObject>(IList<IResourceLocation> locations, [Optional] Action<TObject> callback)
		{
			return default;
		}

		[Token(Token = "0x6000076")]
		public AsyncOperationHandle<IList<TObject>> ProvideResources<TObject>(IList<IResourceLocation> locations, bool releaseDependenciesOnFailure, [Optional] Action<TObject> callback)
		{
			return default;
		}

		[Token(Token = "0x6000077")]
		public AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback)
		{
			return default;
		}

		[Token(Token = "0x6000078")]
		public AsyncOperationHandle<TObject> CreateChainOperation<TObject>(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback)
		{
			return default;
		}

		[Token(Token = "0x6000079")]
		public AsyncOperationHandle<TObject> CreateChainOperation<TObject, TObjectDependency>(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure = true)
		{
			return default;
		}

		[Token(Token = "0x600007A")]
		public AsyncOperationHandle<TObject> CreateChainOperation<TObject>(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure = true)
		{
			return default;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2A6F268", Offset = "0x2A6F268", VA = "0x2A6F268")]
		public AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority)
		{
			return default;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2A6F3CC", Offset = "0x2A6F3CC", VA = "0x2A6F3CC")]
		public AsyncOperationHandle<SceneInstance> ProvideScene(ISceneProvider sceneProvider, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority)
		{
			return default;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2A6F50C", Offset = "0x2A6F50C", VA = "0x2A6F50C")]
		public AsyncOperationHandle<SceneInstance> ReleaseScene(ISceneProvider sceneProvider, AsyncOperationHandle<SceneInstance> sceneLoadHandle)
		{
			return default;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2A6F64C", Offset = "0x2A6F64C", VA = "0x2A6F64C")]
		public AsyncOperationHandle<GameObject> ProvideInstance(IInstanceProvider provider, IResourceLocation location, InstantiationParameters instantiateParameters)
		{
			return default;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2A6F900", Offset = "0x2A6F900", VA = "0x2A6F900")]
		public void CleanupSceneInstances(Scene scene)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2A6FCDC", Offset = "0x2A6FCDC", VA = "0x2A6FCDC")]
		private void ExecuteDeferredCallbacks()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2A6FEC8", Offset = "0x2A6FEC8", VA = "0x2A6FEC8")]
		internal void RegisterForDeferredCallback(IAsyncOperation op, bool incrementRefCount = true)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x2A6665C", Offset = "0x2A6665C", VA = "0x2A6665C")]
		internal void Update(float unscaledDeltaTime)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2A70058", Offset = "0x2A70058", VA = "0x2A70058", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2A70298", Offset = "0x2A70298", VA = "0x2A70298")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B83B4", Offset = "0x1B83B4")]
		private void _003C_002Ector_003Eb__54_0(IUpdateReceiver x)
		{
		}
	}
}
