using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000518")]
public class PackStarterManager : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000519")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4019C", Offset = "0x4019C")]
	private struct _003CStartPack_003Ed__8 : IAsyncStateMachine
	{
		[Token(Token = "0x4001A51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001A52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		[Token(Token = "0x4001A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ContentPack pack;

		[Token(Token = "0x4001A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isLevelNotification;

		[Token(Token = "0x4001A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public object[] args;

		[Token(Token = "0x4001A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x600175C")]
		[Address(RVA = "0x1821850", Offset = "0x1821850", VA = "0x1821850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600175D")]
		[Address(RVA = "0x1821A58", Offset = "0x1821A58", VA = "0x1821A58", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x200051A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x401AC", Offset = "0x401AC")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x4001A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IPackWithData pack;

		[Token(Token = "0x4001A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isLevelNotification;

		[Token(Token = "0x600175E")]
		[Address(RVA = "0x1820C64", Offset = "0x1820C64", VA = "0x1820C64")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600175F")]
		[Address(RVA = "0x1820C6C", Offset = "0x1820C6C", VA = "0x1820C6C")]
		internal bool _003CStartPack_003Eb__0(PackStarterDef s)
		{
			return default;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200051B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x401BC", Offset = "0x401BC")]
	private struct _003CStartPack_003Ed__9 : IAsyncStateMachine
	{
		[Token(Token = "0x4001A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		[Token(Token = "0x4001A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IPackWithData pack;

		[Token(Token = "0x4001A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isLevelNotification;

		[Token(Token = "0x4001A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PackStarterManager _003C_003E4__this;

		[Token(Token = "0x4001A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public object[] args;

		[Token(Token = "0x4001A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x6001760")]
		[Address(RVA = "0x1821AB4", Offset = "0x1821AB4", VA = "0x1821AB4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6001761")]
		[Address(RVA = "0x1821DC8", Offset = "0x1821DC8", VA = "0x1821DC8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200051C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x401CC", Offset = "0x401CC")]
	private struct _003CStartPack_003Ed__11 : IAsyncStateMachine
	{
		[Token(Token = "0x4001A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		[Token(Token = "0x4001A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BasePackStarter starter;

		[Token(Token = "0x4001A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IPackWithData pack;

		[Token(Token = "0x4001A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PackStarterManager _003C_003E4__this;

		[Token(Token = "0x4001A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public object[] args;

		[Token(Token = "0x4001A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ContentPack _003CcontentPack_003E5__2;

		[Token(Token = "0x4001A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x6001762")]
		[Address(RVA = "0x1821178", Offset = "0x1821178", VA = "0x1821178", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6001763")]
		[Address(RVA = "0x18217F4", Offset = "0x18217F4", VA = "0x18217F4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x200051D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x401DC", Offset = "0x401DC")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x4001A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TaskCompletionSource<bool> tcs;

		[Token(Token = "0x6001764")]
		[Address(RVA = "0x1820C04", Offset = "0x1820C04", VA = "0x1820C04")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6001765")]
		[Address(RVA = "0x1820C0C", Offset = "0x1820C0C", VA = "0x1820C0C")]
		internal void _003CPackFinishedAsync_003Eg__SetTaskFinished_007C0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200051E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x401EC", Offset = "0x401EC")]
	private struct _003CPackFinishedAsync_003Ed__13 : IAsyncStateMachine
	{
		[Token(Token = "0x4001A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001A6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4001A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

		[Token(Token = "0x4001A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x6001766")]
		[Address(RVA = "0x1820D7C", Offset = "0x1820D7C", VA = "0x1820D7C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6001767")]
		[Address(RVA = "0x182116C", Offset = "0x182116C", VA = "0x182116C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4001A4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<PackStarterDef> packStarters;

	[Token(Token = "0x4001A4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static PackStarterManager instance;

	[Token(Token = "0x4001A4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Action<ContentPack> PackStarted;

	[Token(Token = "0x4001A4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Action<string, bool> PackFinished;

	[Token(Token = "0x4001A50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string lastPackId;

	[Token(Token = "0x17000295")]
	public static PackStarterManager Instance
	{
		[Token(Token = "0x6001753")]
		[Address(RVA = "0x15D4A6C", Offset = "0x15D4A6C", VA = "0x15D4A6C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001754")]
		[Address(RVA = "0x15D4C4C", Offset = "0x15D4C4C", VA = "0x15D4C4C")]
		private set
		{
		}
	}

	[Token(Token = "0x6001755")]
	[Address(RVA = "0x15D4DC0", Offset = "0x15D4DC0", VA = "0x15D4DC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001756")]
	[Address(RVA = "0x15D4DC4", Offset = "0x15D4DC4", VA = "0x15D4DC4")]
	public static Task<bool> StartPack(ContentPack pack, bool isLevelNotification, params object[] args)
	{
		return null;
	}

	[Token(Token = "0x6001757")]
	[Address(RVA = "0x15D4EE8", Offset = "0x15D4EE8", VA = "0x15D4EE8")]
	public Task<bool> StartPack(IPackWithData pack, bool isLevelNotification, params object[] args)
	{
		return null;
	}

	[Token(Token = "0x6001758")]
	[Address(RVA = "0x15D5014", Offset = "0x15D5014", VA = "0x15D5014")]
	private Task<bool> StartPack(IPackWithData pack, BasePackStarter starter, params object[] args)
	{
		return null;
	}

	[Token(Token = "0x6001759")]
	[Address(RVA = "0x15D513C", Offset = "0x15D513C", VA = "0x15D513C")]
	private void PackCompleted(bool didComplete)
	{
	}

	[Token(Token = "0x600175A")]
	[Address(RVA = "0x15D5208", Offset = "0x15D5208", VA = "0x15D5208")]
	public static Task PackFinishedAsync()
	{
		return null;
	}

	[Token(Token = "0x600175B")]
	[Address(RVA = "0x15D52D4", Offset = "0x15D52D4", VA = "0x15D52D4")]
	public PackStarterManager()
	{
	}
}
