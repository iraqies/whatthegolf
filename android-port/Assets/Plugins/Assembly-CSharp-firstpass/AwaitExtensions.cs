using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x2000004")]
public static class AwaitExtensions
{
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x32FFC", Offset = "0x32FFC")]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TaskCompletionSource<int> tcs;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Process process;

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1336A28", Offset = "0x1336A28", VA = "0x1336A28")]
		public _003C_003Ec__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1336A30", Offset = "0x1336A30", VA = "0x1336A30")]
		internal void _003CGetAwaiter_003Eb__0(object s, EventArgs e)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3300C", Offset = "0x3300C")]
	private struct _003CWrapErrors_003Ed__1 : IAsyncStateMachine
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Task task;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1336A9C", Offset = "0x1336A9C", VA = "0x1336A9C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1336C18", Offset = "0x1336C18", VA = "0x1336C18", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x12F4908", Offset = "0x12F4908", VA = "0x12F4908")]
	public static TaskAwaiter<int> GetAwaiter(this Process process)
	{
		return default;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x12F2198", Offset = "0x12F2198", VA = "0x12F2198")]
	public static void WrapErrors(this Task task)
	{
	}
}
