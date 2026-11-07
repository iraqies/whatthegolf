using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x2000484")]
public class LevelCompleteReviewPopupRequest : ReviewConsentPopupRequest
{
	[Token(Token = "0x2000485")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FC0C", Offset = "0x3FC0C")]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x4001819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TaskCompletionSource<bool> tcs;

		[Token(Token = "0x6001503")]
		[Address(RVA = "0x17D19B0", Offset = "0x17D19B0", VA = "0x17D19B0")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6001504")]
		[Address(RVA = "0x17D19B8", Offset = "0x17D19B8", VA = "0x17D19B8")]
		internal void _003CShowAndAwaitPopupInternal_003Eb__0(bool result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000486")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FC1C", Offset = "0x3FC1C")]
	private struct _003CShowAndAwaitPopupInternal_003Ed__5 : IAsyncStateMachine
	{
		[Token(Token = "0x400181A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400181B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		[Token(Token = "0x400181C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		[Token(Token = "0x400181D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x6001505")]
		[Address(RVA = "0x17D1A1C", Offset = "0x17D1A1C", VA = "0x17D1A1C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6001506")]
		[Address(RVA = "0x17D1DD4", Offset = "0x17D1DD4", VA = "0x17D1DD4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x17000251")]
	protected override bool CanBeSnoozed
	{
		[Token(Token = "0x60014FD")]
		[Address(RVA = "0x1526910", Offset = "0x1526910", VA = "0x1526910", Slot = "4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60014FE")]
	[Address(RVA = "0x1526918", Offset = "0x1526918", VA = "0x1526918", Slot = "6")]
	protected override void AddListeners()
	{
	}

	[Token(Token = "0x60014FF")]
	[Address(RVA = "0x15269FC", Offset = "0x15269FC", VA = "0x15269FC", Slot = "7")]
	protected override void RemoveListeners()
	{
	}

	[Token(Token = "0x6001500")]
	[Address(RVA = "0x1526AE0", Offset = "0x1526AE0", VA = "0x1526AE0", Slot = "9")]
	protected override bool IsRequestValid()
	{
		return default;
	}

	[Token(Token = "0x6001501")]
	[Address(RVA = "0x1526BA4", Offset = "0x1526BA4", VA = "0x1526BA4", Slot = "10")]
	protected override Task<bool> ShowAndAwaitPopupInternal()
	{
		return null;
	}

	[Token(Token = "0x6001502")]
	[Address(RVA = "0x1526CA0", Offset = "0x1526CA0", VA = "0x1526CA0")]
	public LevelCompleteReviewPopupRequest()
	{
	}
}
