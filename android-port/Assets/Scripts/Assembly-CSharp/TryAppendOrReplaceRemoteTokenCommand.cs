using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Unity.Notifications.iOS;

[Token(Token = "0x2000956")]
public class TryAppendOrReplaceRemoteTokenCommand
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000957")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x42220", Offset = "0x42220")]
	private struct _003CExecute_003Ed__0 : IAsyncStateMachine
	{
		[Token(Token = "0x400335B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400335C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400335D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TryAppendOrReplaceRemoteTokenCommand _003C_003E4__this;

		[Token(Token = "0x6002B89")]
		[Address(RVA = "0x186D964", Offset = "0x186D964", VA = "0x186D964", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002B8A")]
		[Address(RVA = "0x186DA9C", Offset = "0x186DA9C", VA = "0x186DA9C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000958")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x42230", Offset = "0x42230")]
	private struct _003CCheckRemoteToken_003Ed__1 : IAsyncStateMachine
	{
		[Token(Token = "0x400335E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400335F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4003360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<AuthorizationRequest> _003C_003Eu__1;

		[Token(Token = "0x6002B8B")]
		[Address(RVA = "0x186D54C", Offset = "0x186D54C", VA = "0x186D54C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6002B8C")]
		[Address(RVA = "0x186D958", Offset = "0x186D958", VA = "0x186D958", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x6002B86")]
	[Address(RVA = "0x172F688", Offset = "0x172F688", VA = "0x172F688")]
	public Task Execute()
	{
		return null;
	}

	[Token(Token = "0x6002B87")]
	[Address(RVA = "0x172F764", Offset = "0x172F764", VA = "0x172F764")]
	private void CheckRemoteToken()
	{
	}

	[Token(Token = "0x6002B88")]
	[Address(RVA = "0x172F7EC", Offset = "0x172F7EC", VA = "0x172F7EC")]
	public TryAppendOrReplaceRemoteTokenCommand()
	{
	}
}
