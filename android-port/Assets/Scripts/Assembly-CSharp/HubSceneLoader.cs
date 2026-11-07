using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Core;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

[Token(Token = "0x2000094")]
public class HubSceneLoader : AddressableSingleton<HubSceneLoader>
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D6A8", Offset = "0x3D6A8")]
	private struct _003CLoadSceneAsync_003Ed__9 : IAsyncStateMachine
	{
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HubSceneLoader _003C_003E4__this;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool forceReload;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LoadSceneMode loadSceneMode;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SceneInstance? sceneToUnload;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _003CwasHubLoaded_003E5__2;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AsyncOperationHandle<SceneInstance> _003Chandle_003E5__3;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private object _003C_003Eu__1;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x17C0C44", Offset = "0x17C0C44", VA = "0x17C0C44", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x17C16DC", Offset = "0x17C16DC", VA = "0x17C16DC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Action BaseSceneLoaded;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int _loadCount;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool _busyLoading;

	[Token(Token = "0x17000068")]
	public bool HasBeenLoadedBefore
	{
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x14DE514", Offset = "0x14DE514", VA = "0x14DE514")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000069")]
	public bool IsHubBusyLoading
	{
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x14DE524", Offset = "0x14DE524", VA = "0x14DE524")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700006A")]
	public bool IsHubLoaded
	{
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x14DE52C", Offset = "0x14DE52C", VA = "0x14DE52C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x14DE5C0", Offset = "0x14DE5C0", VA = "0x14DE5C0")]
	public Task LoadSceneAsync([Optional][DefaultParameterValue(0)] LoadSceneMode loadSceneMode, [Optional] SceneInstance? sceneToUnload, bool forceReload = false)
	{
		return null;
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x14DE6D0", Offset = "0x14DE6D0", VA = "0x14DE6D0")]
	public HubSceneLoader()
	{
	}
}
