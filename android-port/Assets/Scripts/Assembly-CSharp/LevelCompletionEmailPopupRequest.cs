using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x2000475")]
public class LevelCompletionEmailPopupRequest : EmailPopupRequest
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000476")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FB7C", Offset = "0x3FB7C")]
	private struct _003CShowAndAwaitPopupInternal_003Ed__5 : IAsyncStateMachine
	{
		[Token(Token = "0x40017F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40017F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		[Token(Token = "0x40017F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LevelCompletionEmailPopupRequest _003C_003E4__this;

		[Token(Token = "0x40017F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x60014CB")]
		[Address(RVA = "0x17D1E30", Offset = "0x17D1E30", VA = "0x17D1E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60014CC")]
		[Address(RVA = "0x17D1FE8", Offset = "0x17D1FE8", VA = "0x17D1FE8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x17000249")]
	protected override bool CanBeSnoozed
	{
		[Token(Token = "0x60014C5")]
		[Address(RVA = "0x1526CA8", Offset = "0x1526CA8", VA = "0x1526CA8", Slot = "4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60014C6")]
	[Address(RVA = "0x1526CB0", Offset = "0x1526CB0", VA = "0x1526CB0", Slot = "6")]
	protected override void AddListeners()
	{
	}

	[Token(Token = "0x60014C7")]
	[Address(RVA = "0x1526D94", Offset = "0x1526D94", VA = "0x1526D94", Slot = "7")]
	protected override void RemoveListeners()
	{
	}

	[Token(Token = "0x60014C8")]
	[Address(RVA = "0x1526E78", Offset = "0x1526E78", VA = "0x1526E78", Slot = "9")]
	protected override bool IsRequestValid()
	{
		return default;
	}

	[Token(Token = "0x60014C9")]
	[Address(RVA = "0x1526E80", Offset = "0x1526E80", VA = "0x1526E80", Slot = "10")]
	protected override Task<bool> ShowAndAwaitPopupInternal()
	{
		return null;
	}

	[Token(Token = "0x60014CA")]
	[Address(RVA = "0x1526F8C", Offset = "0x1526F8C", VA = "0x1526F8C")]
	public LevelCompletionEmailPopupRequest()
	{
	}
}
