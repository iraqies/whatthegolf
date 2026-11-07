using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x2000481")]
public class StartupNotificationsPopupRequest : NotificationConsentPopupRequest
{
	[Token(Token = "0x2000482")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FBEC", Offset = "0x3FBEC")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x4001813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TaskCompletionSource<bool> tcs;

		[Token(Token = "0x60014F9")]
		[Address(RVA = "0x185A554", Offset = "0x185A554", VA = "0x185A554")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60014FA")]
		[Address(RVA = "0x185A55C", Offset = "0x185A55C", VA = "0x185A55C")]
		internal void _003CShowAndAwaitPopupInternal_003Eb__0(bool result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000483")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FBFC", Offset = "0x3FBFC")]
	private struct _003CShowAndAwaitPopupInternal_003Ed__9 : IAsyncStateMachine
	{
		[Token(Token = "0x4001814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		[Token(Token = "0x4001816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public StartupNotificationsPopupRequest _003C_003E4__this;

		[Token(Token = "0x4001817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

		[Token(Token = "0x4001818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x60014FB")]
		[Address(RVA = "0x185A5C0", Offset = "0x185A5C0", VA = "0x185A5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60014FC")]
		[Address(RVA = "0x185AA14", Offset = "0x185AA14", VA = "0x185AA14", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4001811")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string title;

	[Token(Token = "0x4001812")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string description;

	[Token(Token = "0x1700024F")]
	protected override bool CanBeSnoozed
	{
		[Token(Token = "0x60014F2")]
		[Address(RVA = "0x16DB9C8", Offset = "0x16DB9C8", VA = "0x16DB9C8", Slot = "4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000250")]
	protected override ConsentRequestTypes RequestType
	{
		[Token(Token = "0x60014F3")]
		[Address(RVA = "0x16DB9D0", Offset = "0x16DB9D0", VA = "0x16DB9D0", Slot = "5")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60014F4")]
	[Address(RVA = "0x16DB9D8", Offset = "0x16DB9D8", VA = "0x16DB9D8", Slot = "6")]
	protected override void AddListeners()
	{
	}

	[Token(Token = "0x60014F5")]
	[Address(RVA = "0x16DBABC", Offset = "0x16DBABC", VA = "0x16DBABC", Slot = "7")]
	protected override void RemoveListeners()
	{
	}

	[Token(Token = "0x60014F6")]
	[Address(RVA = "0x16DBBA0", Offset = "0x16DBBA0", VA = "0x16DBBA0", Slot = "9")]
	protected override bool IsRequestValid()
	{
		return default;
	}

	[Token(Token = "0x60014F7")]
	[Address(RVA = "0x16DBBA8", Offset = "0x16DBBA8", VA = "0x16DBBA8", Slot = "10")]
	protected override Task<bool> ShowAndAwaitPopupInternal()
	{
		return null;
	}

	[Token(Token = "0x60014F8")]
	[Address(RVA = "0x16DBCB8", Offset = "0x16DBCB8", VA = "0x16DBCB8")]
	public StartupNotificationsPopupRequest()
	{
	}
}
