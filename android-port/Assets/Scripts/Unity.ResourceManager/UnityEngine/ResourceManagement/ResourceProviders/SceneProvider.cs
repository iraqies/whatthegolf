using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.SceneManagement;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Token(Token = "0x200005E")]
	public class SceneProvider : ISceneProvider2, ISceneProvider
	{
		[Token(Token = "0x200005F")]
		private class SceneOp : AsyncOperationBase<SceneInstance>, IUpdateReceiver
		{
			[Token(Token = "0x40000EE")]
			[FieldOffset(Offset = "0xA0")]
			private bool m_ActivateOnLoad;

			[Token(Token = "0x40000EF")]
			[FieldOffset(Offset = "0xA8")]
			private SceneInstance m_Inst;

			[Token(Token = "0x40000F0")]
			[FieldOffset(Offset = "0xB8")]
			private IResourceLocation m_Location;

			[Token(Token = "0x40000F1")]
			[FieldOffset(Offset = "0xC0")]
			private LoadSceneParameters m_LoadSceneParameters;

			[Token(Token = "0x40000F2")]
			[FieldOffset(Offset = "0xC8")]
			private int m_Priority;

			[Token(Token = "0x40000F3")]
			[FieldOffset(Offset = "0xD0")]
			private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp;

			[Token(Token = "0x40000F4")]
			[FieldOffset(Offset = "0xF0")]
			private ResourceManager m_ResourceManager;

			[Token(Token = "0x1700005B")]
			protected override string DebugName
			{
				[Token(Token = "0x6000227")]
				[Address(RVA = "0x2A783DC", Offset = "0x2A783DC", VA = "0x2A783DC", Slot = "31")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005C")]
			protected override float Progress
			{
				[Token(Token = "0x600022C")]
				[Address(RVA = "0x2A78C08", Offset = "0x2A78C08", VA = "0x2A78C08", Slot = "30")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000221")]
			[Address(RVA = "0x2A70FB8", Offset = "0x2A70FB8", VA = "0x2A70FB8")]
			public SceneOp(ResourceManager rm)
			{
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x2A77E7C", Offset = "0x2A77E7C", VA = "0x2A77E7C", Slot = "35")]
			internal override DownloadStatus GetDownloadStatus(HashSet<object> visited)
			{
				return default;
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x2A77F50", Offset = "0x2A77F50", VA = "0x2A77F50")]
			public void Init(IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp)
			{
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0x2A71018", Offset = "0x2A71018", VA = "0x2A71018")]
			public void Init(IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority, AsyncOperationHandle<IList<AsyncOperationHandle>> depOp)
			{
			}

			[Token(Token = "0x6000225")]
			[Address(RVA = "0x2A7802C", Offset = "0x2A7802C", VA = "0x2A7802C", Slot = "33")]
			protected override bool InvokeWaitForCompletion()
			{
				return default;
			}

			[Token(Token = "0x6000226")]
			[Address(RVA = "0x2A7830C", Offset = "0x2A7830C", VA = "0x2A7830C", Slot = "32")]
			public override void GetDependencies(List<AsyncOperationHandle> deps)
			{
			}

			[Token(Token = "0x6000228")]
			[Address(RVA = "0x2A7848C", Offset = "0x2A7848C", VA = "0x2A7848C", Slot = "28")]
			protected override void Execute()
			{
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0x2A789D0", Offset = "0x2A789D0", VA = "0x2A789D0")]
			internal SceneInstance InternalLoadScene(IResourceLocation location, bool loadingFromBundle, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority)
			{
				return default;
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0x2A78AFC", Offset = "0x2A78AFC", VA = "0x2A78AFC")]
			private AsyncOperation InternalLoad(string path, bool loadingFromBundle, LoadSceneParameters loadSceneParameters)
			{
				return null;
			}

			[Token(Token = "0x600022B")]
			[Address(RVA = "0x2A78B70", Offset = "0x2A78B70", VA = "0x2A78B70", Slot = "29")]
			protected override void Destroy()
			{
			}

			[Token(Token = "0x600022D")]
			[Address(RVA = "0x2A78CD8", Offset = "0x2A78CD8", VA = "0x2A78CD8", Slot = "36")]
			private void UnityEngine_002EResourceManagement_002EIUpdateReceiver_002EUpdate(float unscaledDeltaTime)
			{
			}
		}

		[Token(Token = "0x2000060")]
		private class UnloadSceneOp : AsyncOperationBase<SceneInstance>
		{
			[Token(Token = "0x40000F5")]
			[FieldOffset(Offset = "0xA0")]
			private SceneInstance m_Instance;

			[Token(Token = "0x40000F6")]
			[FieldOffset(Offset = "0xB0")]
			private AsyncOperationHandle<SceneInstance> m_sceneLoadHandle;

			[Token(Token = "0x40000F7")]
			[FieldOffset(Offset = "0xD0")]
			private UnloadSceneOptions m_UnloadOptions;

			[Token(Token = "0x1700005D")]
			protected override float Progress
			{
				[Token(Token = "0x6000233")]
				[Address(RVA = "0x2A791FC", Offset = "0x2A791FC", VA = "0x2A791FC", Slot = "30")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600022E")]
			[Address(RVA = "0x2A78DA0", Offset = "0x2A78DA0", VA = "0x2A78DA0")]
			public void Init(AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions options)
			{
			}

			[Token(Token = "0x600022F")]
			[Address(RVA = "0x2A78E40", Offset = "0x2A78E40", VA = "0x2A78E40", Slot = "28")]
			protected override void Execute()
			{
			}

			[Token(Token = "0x6000230")]
			[Address(RVA = "0x2A79138", Offset = "0x2A79138", VA = "0x2A79138", Slot = "33")]
			protected override bool InvokeWaitForCompletion()
			{
				return default;
			}

			[Token(Token = "0x6000231")]
			[Address(RVA = "0x2A79064", Offset = "0x2A79064", VA = "0x2A79064")]
			private void UnloadSceneCompleted(AsyncOperation obj)
			{
			}

			[Token(Token = "0x6000232")]
			[Address(RVA = "0x2A78FEC", Offset = "0x2A78FEC", VA = "0x2A78FEC")]
			private void UnloadSceneCompletedNoRelease(AsyncOperation obj)
			{
			}

			[Token(Token = "0x6000234")]
			[Address(RVA = "0x2A79250", Offset = "0x2A79250", VA = "0x2A79250")]
			public UnloadSceneOp()
			{
			}
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2A70B54", Offset = "0x2A70B54", VA = "0x2A70B54", Slot = "5")]
		public AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority)
		{
			return default;
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2A70BC8", Offset = "0x2A70BC8", VA = "0x2A70BC8", Slot = "6")]
		public AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority)
		{
			return default;
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2A710D8", Offset = "0x2A710D8", VA = "0x2A710D8", Slot = "7")]
		public AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle)
		{
			return default;
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2A711CC", Offset = "0x2A711CC", VA = "0x2A711CC", Slot = "4")]
		private AsyncOperationHandle<SceneInstance> UnityEngine_002EResourceManagement_002EResourceProviders_002EISceneProvider2_002EReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions)
		{
			return default;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2A712D8", Offset = "0x2A712D8", VA = "0x2A712D8")]
		public SceneProvider()
		{
		}
	}
}
