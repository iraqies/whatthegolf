using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x2000467")]
public abstract class LevelCompleteAnalyticsPopupRequestBase : AnalyticsConsentPopupRequest
{
	[Token(Token = "0x2000468")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FB0C", Offset = "0x3FB0C")]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x40017CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TaskCompletionSource<bool> tcs;

		[Token(Token = "0x600148A")]
		[Address(RVA = "0x17D152C", Offset = "0x17D152C", VA = "0x17D152C")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600148B")]
		[Address(RVA = "0x17D1534", Offset = "0x17D1534", VA = "0x17D1534")]
		internal void _003CShowAndAwaitPopupInternal_003Eb__0(bool result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000469")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FB1C", Offset = "0x3FB1C")]
	private struct _003CShowAndAwaitPopupInternal_003Ed__3 : IAsyncStateMachine
	{
		[Token(Token = "0x40017CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40017CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		[Token(Token = "0x40017CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

		[Token(Token = "0x40017CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x600148C")]
		[Address(RVA = "0x17D1598", Offset = "0x17D1598", VA = "0x17D1598", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600148D")]
		[Address(RVA = "0x17D1954", Offset = "0x17D1954", VA = "0x17D1954", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x6001485")]
	[Address(RVA = "0x1526588", Offset = "0x1526588", VA = "0x1526588", Slot = "6")]
	protected override void AddListeners()
	{
	}

	[Token(Token = "0x6001486")]
	[Address(RVA = "0x152666C", Offset = "0x152666C", VA = "0x152666C", Slot = "7")]
	protected override void RemoveListeners()
	{
	}

	[Token(Token = "0x6001487")]
	[Address(RVA = "0x1526750", Offset = "0x1526750", VA = "0x1526750", Slot = "9")]
	protected override bool IsRequestValid()
	{
		return default;
	}

	[Token(Token = "0x6001488")]
	[Address(RVA = "0x15267F4", Offset = "0x15267F4", VA = "0x15267F4", Slot = "10")]
	protected override Task<bool> ShowAndAwaitPopupInternal()
	{
		return null;
	}

	[Token(Token = "0x6001489")]
	[Address(RVA = "0x15268F0", Offset = "0x15268F0", VA = "0x15268F0")]
	protected LevelCompleteAnalyticsPopupRequestBase()
	{
	}
}
