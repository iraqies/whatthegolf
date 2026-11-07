using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x2000D3F")]
public class WwiseClipLoader : MonoBehaviour
{
	[Token(Token = "0x2000D40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x447C0", Offset = "0x447C0")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x4004825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MusicTrack.AudioclipInfo audioClipInfo;

		[Token(Token = "0x4004826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<MusicClip, bool> _003C_003E9__0;

		[Token(Token = "0x6003E85")]
		[Address(RVA = "0x187A154", Offset = "0x187A154", VA = "0x187A154")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6003E86")]
		[Address(RVA = "0x187A15C", Offset = "0x187A15C", VA = "0x187A15C")]
		internal bool _003CLoadState_003Eb__0(MusicClip x)
		{
			return default;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000D41")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x447D0", Offset = "0x447D0")]
	private struct _003CLoadState_003Ed__11 : IAsyncStateMachine
	{
		[Token(Token = "0x4004827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MusicState state;

		[Token(Token = "0x400482A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onLoaded;

		[Token(Token = "0x400482B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MusicTransition transition;

		[Token(Token = "0x400482C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public WwiseClipLoader _003C_003E4__this;

		[Token(Token = "0x400482D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<Task> _003C_003Eu__1;

		[Token(Token = "0x6003E87")]
		[Address(RVA = "0x187A3A4", Offset = "0x187A3A4", VA = "0x187A3A4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003E88")]
		[Address(RVA = "0x187B6D0", Offset = "0x187B6D0", VA = "0x187B6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000D42")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x447E0", Offset = "0x447E0")]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000D43")]
		private struct _003C_003CWaitForLoad_003Eg__Wait_007C0_003Ed : IAsyncStateMachine
		{
			[Token(Token = "0x4004832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public _003C_003Ec__DisplayClass12_0 _003C_003E4__this;

			[Token(Token = "0x4004835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6003E8B")]
			[Address(RVA = "0x18830E0", Offset = "0x18830E0", VA = "0x18830E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6003E8C")]
			[Address(RVA = "0x18834F4", Offset = "0x18834F4", VA = "0x18834F4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400482E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TaskCompletionSource<bool> tcs;

		[Token(Token = "0x400482F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MusicTransition transition;

		[Token(Token = "0x4004830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WwiseClipLoader _003C_003E4__this;

		[Token(Token = "0x4004831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MusicState state;

		[Token(Token = "0x6003E89")]
		[Address(RVA = "0x187A1C0", Offset = "0x187A1C0", VA = "0x187A1C0")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6003E8A")]
		[Address(RVA = "0x187A1C8", Offset = "0x187A1C8", VA = "0x187A1C8")]
		internal void _003CWaitForLoad_003Eg__Wait_007C0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000D44")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x447F0", Offset = "0x447F0")]
	private struct _003CWaitForLoad_003Ed__12 : IAsyncStateMachine
	{
		[Token(Token = "0x4004836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MusicTransition transition;

		[Token(Token = "0x4004839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public WwiseClipLoader _003C_003E4__this;

		[Token(Token = "0x400483A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MusicState state;

		[Token(Token = "0x400483B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action onLoaded;

		[Token(Token = "0x6003E8D")]
		[Address(RVA = "0x187C16C", Offset = "0x187C16C", VA = "0x187C16C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003E8E")]
		[Address(RVA = "0x187C3D4", Offset = "0x187C3D4", VA = "0x187C3D4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000D45")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44800", Offset = "0x44800")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x400483C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MusicTrack.AudioclipInfo audioClipInfo;

		[Token(Token = "0x400483D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<MusicClip, bool> _003C_003E9__0;

		[Token(Token = "0x6003E8F")]
		[Address(RVA = "0x187A260", Offset = "0x187A260", VA = "0x187A260")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6003E90")]
		[Address(RVA = "0x187A268", Offset = "0x187A268", VA = "0x187A268")]
		internal bool _003CLoadTransitionSegment_003Eb__0(MusicClip x)
		{
			return default;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000D46")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44810", Offset = "0x44810")]
	private struct _003CLoadTransitionSegment_003Ed__13 : IAsyncStateMachine
	{
		[Token(Token = "0x400483E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400483F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public WwiseClipLoader _003C_003E4__this;

		[Token(Token = "0x4004841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MusicSegment segment;

		[Token(Token = "0x6003E91")]
		[Address(RVA = "0x187B6DC", Offset = "0x187B6DC", VA = "0x187B6DC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003E92")]
		[Address(RVA = "0x187C160", Offset = "0x187C160", VA = "0x187C160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000D47")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44820", Offset = "0x44820")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4004842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MusicTrack.AudioclipInfo audioClipInfo;

		[Token(Token = "0x4004843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<MusicClip, bool> _003C_003E9__0;

		[Token(Token = "0x6003E93")]
		[Address(RVA = "0x187A2CC", Offset = "0x187A2CC", VA = "0x187A2CC")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6003E94")]
		[Address(RVA = "0x187A2D4", Offset = "0x187A2D4", VA = "0x187A2D4")]
		internal bool _003CUnloadSegment_003Eb__0(MusicClip x)
		{
			return default;
		}
	}

	[Token(Token = "0x2000D48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44830", Offset = "0x44830")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x4004844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MusicTrack.AudioclipInfo audioClipInfo;

		[Token(Token = "0x4004845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<MusicClip, bool> _003C_003E9__0;

		[Token(Token = "0x6003E95")]
		[Address(RVA = "0x187A338", Offset = "0x187A338", VA = "0x187A338")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x6003E96")]
		[Address(RVA = "0x187A340", Offset = "0x187A340", VA = "0x187A340")]
		internal bool _003CUnloadState_003Eb__0(MusicClip x)
		{
			return default;
		}
	}

	[Token(Token = "0x4004820")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<AudioClip, int> segmentClips;

	[Token(Token = "0x4004821")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<MusicState> loadedStates;

	[Token(Token = "0x4004822")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<MusicSegment> loadedTransitions;

	[Token(Token = "0x4004823")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int maxStatesInMemory;

	[Token(Token = "0x4004824")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int maxTransitionsInMemory;

	[Token(Token = "0x6003E78")]
	[Address(RVA = "0x175CE28", Offset = "0x175CE28", VA = "0x175CE28")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003E79")]
	[Address(RVA = "0x175CF98", Offset = "0x175CF98", VA = "0x175CF98")]
	private void Update()
	{
	}

	[Token(Token = "0x6003E7A")]
	[Address(RVA = "0x175D208", Offset = "0x175D208", VA = "0x175D208")]
	private void LoadFile(MusicTrack.AudioclipInfo audioClipInfo)
	{
	}

	[Token(Token = "0x6003E7B")]
	[Address(RVA = "0x175DB70", Offset = "0x175DB70", VA = "0x175DB70")]
	private void UnloadFile(MusicTrack.AudioclipInfo audioClipInfo)
	{
	}

	[Token(Token = "0x6003E7C")]
	[Address(RVA = "0x175DFE4", Offset = "0x175DFE4", VA = "0x175DFE4")]
	public bool isMusicStateLoaded(MusicState state)
	{
		return default;
	}

	[Token(Token = "0x6003E7D")]
	[Address(RVA = "0x175E2F0", Offset = "0x175E2F0", VA = "0x175E2F0")]
	public bool isSegmentLoaded(MusicSegment segment)
	{
		return default;
	}

	[Token(Token = "0x6003E7E")]
	[Address(RVA = "0x175E954", Offset = "0x175E954", VA = "0x175E954")]
	public void LoadState(MusicState state, MusicTransition transition, bool fromLoading, Action onLoaded)
	{
	}

	[Token(Token = "0x6003E7F")]
	[Address(RVA = "0x175EA08", Offset = "0x175EA08", VA = "0x175EA08")]
	private Task WaitForLoad(MusicState state, MusicTransition transition, Action onLoaded)
	{
		return null;
	}

	[Token(Token = "0x6003E80")]
	[Address(RVA = "0x175EAFC", Offset = "0x175EAFC", VA = "0x175EAFC")]
	private void LoadTransitionSegment(MusicSegment segment)
	{
	}

	[Token(Token = "0x6003E81")]
	[Address(RVA = "0x175EB9C", Offset = "0x175EB9C", VA = "0x175EB9C")]
	private void UnloadSegment(MusicSegment segment)
	{
	}

	[Token(Token = "0x6003E82")]
	[Address(RVA = "0x175F1E4", Offset = "0x175F1E4", VA = "0x175F1E4")]
	private void UnloadState(MusicState state)
	{
	}

	[Token(Token = "0x6003E83")]
	[Address(RVA = "0x175FA8C", Offset = "0x175FA8C", VA = "0x175FA8C")]
	public WwiseClipLoader()
	{
	}

	[Token(Token = "0x6003E84")]
	[Address(RVA = "0x175FA9C", Offset = "0x175FA9C", VA = "0x175FA9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C51C", Offset = "0x6C51C")]
	internal static void _003CLoadFile_003Eg__WaitForCompletionError_007C7_0(AsyncOperationHandle arg1, Exception arg2)
	{
	}
}
