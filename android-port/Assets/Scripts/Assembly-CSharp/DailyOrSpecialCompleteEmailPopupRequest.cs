using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x2000471")]
public class DailyOrSpecialCompleteEmailPopupRequest : EmailPopupRequest
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000472")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FB5C", Offset = "0x3FB5C")]
	private struct _003CShowAndAwaitPopupInternal_003Ed__9 : IAsyncStateMachine
	{
		[Token(Token = "0x40017E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40017EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		[Token(Token = "0x40017EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DailyOrSpecialCompleteEmailPopupRequest _003C_003E4__this;

		[Token(Token = "0x40017EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x1798618", Offset = "0x1798618", VA = "0x1798618", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60014BB")]
		[Address(RVA = "0x17987D0", Offset = "0x17987D0", VA = "0x17987D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40017E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string _contentPackId;

	[Token(Token = "0x40017E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _didComplete;

	[Token(Token = "0x17000247")]
	protected override bool CanBeSnoozed
	{
		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x18D193C", Offset = "0x18D193C", VA = "0x18D193C", Slot = "4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60014B3")]
	[Address(RVA = "0x18D1944", Offset = "0x18D1944", VA = "0x18D1944", Slot = "6")]
	protected override void AddListeners()
	{
	}

	[Token(Token = "0x60014B4")]
	[Address(RVA = "0x18D1A30", Offset = "0x18D1A30", VA = "0x18D1A30", Slot = "7")]
	protected override void RemoveListeners()
	{
	}

	[Token(Token = "0x60014B5")]
	[Address(RVA = "0x18D1B1C", Offset = "0x18D1B1C", VA = "0x18D1B1C")]
	private void OnPackComplete(string contentPackId, bool didComplete)
	{
	}

	[Token(Token = "0x60014B6")]
	[Address(RVA = "0x18D1B2C", Offset = "0x18D1B2C", VA = "0x18D1B2C", Slot = "9")]
	protected override bool IsRequestValid()
	{
		return default;
	}

	[Token(Token = "0x60014B7")]
	[Address(RVA = "0x18D1BD8", Offset = "0x18D1BD8", VA = "0x18D1BD8")]
	private bool IsCurrentCampaignDailyOrSpecial()
	{
		return default;
	}

	[Token(Token = "0x60014B8")]
	[Address(RVA = "0x18D1C78", Offset = "0x18D1C78", VA = "0x18D1C78", Slot = "10")]
	protected override Task<bool> ShowAndAwaitPopupInternal()
	{
		return null;
	}

	[Token(Token = "0x60014B9")]
	[Address(RVA = "0x18D1D84", Offset = "0x18D1D84", VA = "0x18D1D84")]
	public DailyOrSpecialCompleteEmailPopupRequest()
	{
	}
}
