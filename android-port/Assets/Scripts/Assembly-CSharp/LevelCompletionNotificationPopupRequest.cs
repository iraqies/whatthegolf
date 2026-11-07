using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x200047A")]
public class LevelCompletionNotificationPopupRequest : NotificationConsentPopupRequest
{
	[Token(Token = "0x200047B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FBAC", Offset = "0x3FBAC")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x4001803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TaskCompletionSource<bool> tcs;

		[Token(Token = "0x60014DF")]
		[Address(RVA = "0x17D2044", Offset = "0x17D2044", VA = "0x17D2044")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60014E0")]
		[Address(RVA = "0x17D204C", Offset = "0x17D204C", VA = "0x17D204C")]
		internal void _003CShowAndAwaitPopupInternal_003Eb__0(bool result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200047C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FBBC", Offset = "0x3FBBC")]
	private struct _003CShowAndAwaitPopupInternal_003Ed__7 : IAsyncStateMachine
	{
		[Token(Token = "0x4001804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		[Token(Token = "0x4001806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelCompletionNotificationPopupRequest _003C_003E4__this;

		[Token(Token = "0x4001807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

		[Token(Token = "0x4001808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x60014E1")]
		[Address(RVA = "0x17D20B0", Offset = "0x17D20B0", VA = "0x17D20B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60014E2")]
		[Address(RVA = "0x17D2458", Offset = "0x17D2458", VA = "0x17D2458", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4001801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string title;

	[Token(Token = "0x4001802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string description;

	[Token(Token = "0x1700024B")]
	protected override bool CanBeSnoozed
	{
		[Token(Token = "0x60014D9")]
		[Address(RVA = "0x1526F94", Offset = "0x1526F94", VA = "0x1526F94", Slot = "4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60014DA")]
	[Address(RVA = "0x1526F9C", Offset = "0x1526F9C", VA = "0x1526F9C", Slot = "6")]
	protected override void AddListeners()
	{
	}

	[Token(Token = "0x60014DB")]
	[Address(RVA = "0x1527080", Offset = "0x1527080", VA = "0x1527080", Slot = "7")]
	protected override void RemoveListeners()
	{
	}

	[Token(Token = "0x60014DC")]
	[Address(RVA = "0x1527164", Offset = "0x1527164", VA = "0x1527164", Slot = "9")]
	protected override bool IsRequestValid()
	{
		return default;
	}

	[Token(Token = "0x60014DD")]
	[Address(RVA = "0x152716C", Offset = "0x152716C", VA = "0x152716C", Slot = "10")]
	protected override Task<bool> ShowAndAwaitPopupInternal()
	{
		return null;
	}

	[Token(Token = "0x60014DE")]
	[Address(RVA = "0x152727C", Offset = "0x152727C", VA = "0x152727C")]
	public LevelCompletionNotificationPopupRequest()
	{
	}
}
