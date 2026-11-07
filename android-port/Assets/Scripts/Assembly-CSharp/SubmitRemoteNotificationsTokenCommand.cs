using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

[Token(Token = "0x2000953")]
public class SubmitRemoteNotificationsTokenCommand
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000954")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x42200", Offset = "0x42200")]
	private struct _003CUploadToken_003Ed__5 : IAsyncStateMachine
	{
		[Token(Token = "0x4003351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4003352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4003353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SubmitRemoteNotificationsTokenCommand _003C_003E4__this;

		[Token(Token = "0x4003354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6002B82")]
		[Address(RVA = "0x185BE00", Offset = "0x185BE00", VA = "0x185BE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002B83")]
		[Address(RVA = "0x185C0B8", Offset = "0x185C0B8", VA = "0x185C0B8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000955")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x42210", Offset = "0x42210")]
	private struct _003CSendWebRequest_003Ed__6 : IAsyncStateMachine
	{
		[Token(Token = "0x4003355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4003356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4003357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WWWForm form;

		[Token(Token = "0x4003358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SubmitRemoteNotificationsTokenCommand _003C_003E4__this;

		[Token(Token = "0x4003359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityWebRequest _003Cwww_003E5__2;

		[Token(Token = "0x400335A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6002B84")]
		[Address(RVA = "0x185B8E8", Offset = "0x185B8E8", VA = "0x185B8E8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002B85")]
		[Address(RVA = "0x185BDF4", Offset = "0x185BDF4", VA = "0x185BDF4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400334F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly string _pushNotificationToken;

	[Token(Token = "0x4003350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string _deviceId;

	[Token(Token = "0x6002B7E")]
	[Address(RVA = "0x16E6E00", Offset = "0x16E6E00", VA = "0x16E6E00")]
	public SubmitRemoteNotificationsTokenCommand(string pushNotificationToken)
	{
	}

	[Token(Token = "0x6002B7F")]
	[Address(RVA = "0x16E6E2C", Offset = "0x16E6E2C", VA = "0x16E6E2C")]
	public void Execute()
	{
	}

	[Token(Token = "0x6002B80")]
	[Address(RVA = "0x16E6FC4", Offset = "0x16E6FC4", VA = "0x16E6FC4")]
	private void UploadToken()
	{
	}

	[Token(Token = "0x6002B81")]
	[Address(RVA = "0x16E705C", Offset = "0x16E705C", VA = "0x16E705C")]
	private Task SendWebRequest(WWWForm form)
	{
		return null;
	}
}
