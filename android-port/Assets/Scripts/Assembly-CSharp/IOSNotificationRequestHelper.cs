using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Unity.Notifications.iOS;
using UnityEngine.Networking;

[Token(Token = "0x200094D")]
public static class IOSNotificationRequestHelper
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200094E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x421C0", Offset = "0x421C0")]
	private struct _003CIsAppleReachable_003Ed__1 : IAsyncStateMachine
	{
		[Token(Token = "0x400333B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400333C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		[Token(Token = "0x400333D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TaskCompletionSource<bool> _003Ctcs_003E5__2;

		[Token(Token = "0x400333E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x6002B74")]
		[Address(RVA = "0x17C2688", Offset = "0x17C2688", VA = "0x17C2688", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002B75")]
		[Address(RVA = "0x17C29F0", Offset = "0x17C29F0", VA = "0x17C29F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200094F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x421D0", Offset = "0x421D0")]
	private struct _003CWaitForTimeOut_003Ed__2 : IAsyncStateMachine
	{
		[Token(Token = "0x400333F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4003340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4003341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TaskCompletionSource<bool> tcs;

		[Token(Token = "0x4003342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6002B76")]
		[Address(RVA = "0x17C2EC0", Offset = "0x17C2EC0", VA = "0x17C2EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002B77")]
		[Address(RVA = "0x17C30A8", Offset = "0x17C30A8", VA = "0x17C30A8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000950")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x421E0", Offset = "0x421E0")]
	private struct _003CSendWebRequest_003Ed__3 : IAsyncStateMachine
	{
		[Token(Token = "0x4003343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4003344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4003345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TaskCompletionSource<bool> tcs;

		[Token(Token = "0x4003346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityWebRequest _003CwebRequest_003E5__2;

		[Token(Token = "0x4003347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private object _003C_003Eu__1;

		[Token(Token = "0x6002B78")]
		[Address(RVA = "0x17C2A4C", Offset = "0x17C2A4C", VA = "0x17C2A4C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002B79")]
		[Address(RVA = "0x17C2EB4", Offset = "0x17C2EB4", VA = "0x17C2EB4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000951")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x421F0", Offset = "0x421F0")]
	private struct _003CAwaitAuthRequest_003Ed__4 : IAsyncStateMachine
	{
		[Token(Token = "0x4003348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4003349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<AuthorizationRequest> _003C_003Et__builder;

		[Token(Token = "0x400334A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private StringBuilder _003Csb_003E5__2;

		[Token(Token = "0x400334B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AuthorizationRequest _003Creq_003E5__3;

		[Token(Token = "0x400334C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x400334D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x6002B7A")]
		[Address(RVA = "0x17C210C", Offset = "0x17C210C", VA = "0x17C210C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002B7B")]
		[Address(RVA = "0x17C262C", Offset = "0x17C262C", VA = "0x17C262C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x6002B6F")]
	[Address(RVA = "0x14E26A4", Offset = "0x14E26A4", VA = "0x14E26A4")]
	public static Task<bool> IsAppleReachable()
	{
		return null;
	}

	[Token(Token = "0x6002B70")]
	[Address(RVA = "0x14E27A0", Offset = "0x14E27A0", VA = "0x14E27A0")]
	private static void WaitForTimeOut(TaskCompletionSource<bool> tcs)
	{
	}

	[Token(Token = "0x6002B71")]
	[Address(RVA = "0x14E2838", Offset = "0x14E2838", VA = "0x14E2838")]
	private static void SendWebRequest(TaskCompletionSource<bool> tcs)
	{
	}

	[Token(Token = "0x6002B72")]
	[Address(RVA = "0x14E28D0", Offset = "0x14E28D0", VA = "0x14E28D0")]
	public static Task<AuthorizationRequest> AwaitAuthRequest()
	{
		return null;
	}

	[Token(Token = "0x6002B73")]
	[Address(RVA = "0x14E29CC", Offset = "0x14E29CC", VA = "0x14E29CC")]
	public static string DeviceUniqueIdentifier()
	{
		return null;
	}
}
