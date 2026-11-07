using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x2000477")]
public class DailyOrSpecialCompleteNotificationPopupRequest : NotificationConsentPopupRequest
{
	[Token(Token = "0x2000478")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FB8C", Offset = "0x3FB8C")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x40017FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TaskCompletionSource<bool> tcs;

		[Token(Token = "0x60014D5")]
		[Address(RVA = "0x179882C", Offset = "0x179882C", VA = "0x179882C")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60014D6")]
		[Address(RVA = "0x1798834", Offset = "0x1798834", VA = "0x1798834")]
		internal void _003CShowAndAwaitPopupInternal_003Eb__0(bool result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000479")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FB9C", Offset = "0x3FB9C")]
	private struct _003CShowAndAwaitPopupInternal_003Ed__13 : IAsyncStateMachine
	{
		[Token(Token = "0x40017FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40017FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		[Token(Token = "0x40017FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DailyOrSpecialCompleteNotificationPopupRequest _003C_003E4__this;

		[Token(Token = "0x40017FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

		[Token(Token = "0x4001800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x60014D7")]
		[Address(RVA = "0x1798898", Offset = "0x1798898", VA = "0x1798898", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60014D8")]
		[Address(RVA = "0x1798CEC", Offset = "0x1798CEC", VA = "0x1798CEC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40017F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string titleDaily;

	[Token(Token = "0x40017F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string descriptionDaily;

	[Token(Token = "0x40017F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string titleSpecial;

	[Token(Token = "0x40017F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string descriptionSpecial;

	[Token(Token = "0x40017F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string contentPackId;

	[Token(Token = "0x40017FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool didComplete;

	[Token(Token = "0x1700024A")]
	protected override bool CanBeSnoozed
	{
		[Token(Token = "0x60014CD")]
		[Address(RVA = "0x18D1D8C", Offset = "0x18D1D8C", VA = "0x18D1D8C", Slot = "4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60014CE")]
	[Address(RVA = "0x18D1D94", Offset = "0x18D1D94", VA = "0x18D1D94", Slot = "6")]
	protected override void AddListeners()
	{
	}

	[Token(Token = "0x60014CF")]
	[Address(RVA = "0x18D1E80", Offset = "0x18D1E80", VA = "0x18D1E80", Slot = "7")]
	protected override void RemoveListeners()
	{
	}

	[Token(Token = "0x60014D0")]
	[Address(RVA = "0x18D1F6C", Offset = "0x18D1F6C", VA = "0x18D1F6C")]
	private void OnPackComplete(string contentPackId, bool didComplete)
	{
	}

	[Token(Token = "0x60014D1")]
	[Address(RVA = "0x18D1F7C", Offset = "0x18D1F7C", VA = "0x18D1F7C", Slot = "9")]
	protected override bool IsRequestValid()
	{
		return default;
	}

	[Token(Token = "0x60014D2")]
	[Address(RVA = "0x18D2028", Offset = "0x18D2028", VA = "0x18D2028")]
	private bool IsCurrentCampaignDailyOrSpecial()
	{
		return default;
	}

	[Token(Token = "0x60014D3")]
	[Address(RVA = "0x18D20C8", Offset = "0x18D20C8", VA = "0x18D20C8", Slot = "10")]
	protected override Task<bool> ShowAndAwaitPopupInternal()
	{
		return null;
	}

	[Token(Token = "0x60014D4")]
	[Address(RVA = "0x18D21D8", Offset = "0x18D21D8", VA = "0x18D21D8")]
	public DailyOrSpecialCompleteNotificationPopupRequest()
	{
	}
}
