using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F1B")]
public class ReplayDaily : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000F1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x456B0", Offset = "0x456B0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4005186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4005187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<DailyChallengePackStarter, bool> _003C_003E9__3_0;

		[Token(Token = "0x4005188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<DailyChallengePackStarter, bool> _003C_003E9__4_0;

		[Token(Token = "0x60046AB")]
		[Address(RVA = "0x1832CB8", Offset = "0x1832CB8", VA = "0x1832CB8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60046AC")]
		[Address(RVA = "0x1832CC0", Offset = "0x1832CC0", VA = "0x1832CC0")]
		internal bool _003CReplay_003Eb__3_0(DailyChallengePackStarter p)
		{
			return default;
		}

		[Token(Token = "0x60046AD")]
		[Address(RVA = "0x1832CD8", Offset = "0x1832CD8", VA = "0x1832CD8")]
		internal bool _003CClose_003Eb__4_0(DailyChallengePackStarter p)
		{
			return default;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000F1D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x456C0", Offset = "0x456C0")]
	private struct _003CReplay_003Ed__3 : IAsyncStateMachine
	{
		[Token(Token = "0x4005189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400518A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400518B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ReplayDaily _003C_003E4__this;

		[Token(Token = "0x60046AE")]
		[Address(RVA = "0x1832FD8", Offset = "0x1832FD8", VA = "0x1832FD8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60046AF")]
		[Address(RVA = "0x1833314", Offset = "0x1833314", VA = "0x1833314", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000F1E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x456D0", Offset = "0x456D0")]
	private struct _003CClose_003Ed__4 : IAsyncStateMachine
	{
		[Token(Token = "0x400518C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400518D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400518E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ReplayDaily _003C_003E4__this;

		[Token(Token = "0x60046B0")]
		[Address(RVA = "0x1832CF0", Offset = "0x1832CF0", VA = "0x1832CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60046B1")]
		[Address(RVA = "0x1832FCC", Offset = "0x1832FCC", VA = "0x1832FCC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4005184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private PrizeController prizeController;

	[Token(Token = "0x4005185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private double time;

	[Token(Token = "0x60046A5")]
	[Address(RVA = "0x1649CAC", Offset = "0x1649CAC", VA = "0x1649CAC")]
	private void Start()
	{
	}

	[Token(Token = "0x60046A6")]
	[Address(RVA = "0x1649D78", Offset = "0x1649D78", VA = "0x1649D78")]
	public void Replay()
	{
	}

	[Token(Token = "0x60046A7")]
	[Address(RVA = "0x1649E10", Offset = "0x1649E10", VA = "0x1649E10")]
	public void Close()
	{
	}

	[Token(Token = "0x60046A8")]
	[Address(RVA = "0x1649EA8", Offset = "0x1649EA8", VA = "0x1649EA8")]
	private void Analytics()
	{
	}

	[Token(Token = "0x60046A9")]
	[Address(RVA = "0x1649EF0", Offset = "0x1649EF0", VA = "0x1649EF0")]
	public ReplayDaily()
	{
	}
}
