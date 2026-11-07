using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x200047E")]
public class SecondDeviceNotificationsPopupRequest : NotificationConsentPopupRequest
{
	[Token(Token = "0x200047F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FBCC", Offset = "0x3FBCC")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x400180B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TaskCompletionSource<bool> tcs;

		[Token(Token = "0x60014EE")]
		[Address(RVA = "0x184044C", Offset = "0x184044C", VA = "0x184044C")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60014EF")]
		[Address(RVA = "0x1840454", Offset = "0x1840454", VA = "0x1840454")]
		internal void _003CShowAndAwaitPopupInternal_003Eb__0(bool result)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000480")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FBDC", Offset = "0x3FBDC")]
	private struct _003CShowAndAwaitPopupInternal_003Ed__9 : IAsyncStateMachine
	{
		[Token(Token = "0x400180C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400180D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		[Token(Token = "0x400180E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SecondDeviceNotificationsPopupRequest _003C_003E4__this;

		[Token(Token = "0x400180F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass9_0 _003C_003E8__1;

		[Token(Token = "0x4001810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x60014F0")]
		[Address(RVA = "0x18404B8", Offset = "0x18404B8", VA = "0x18404B8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60014F1")]
		[Address(RVA = "0x1840860", Offset = "0x1840860", VA = "0x1840860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4001809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string title;

	[Token(Token = "0x400180A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string description;

	[Token(Token = "0x1700024D")]
	protected override bool CanBeSnoozed
	{
		[Token(Token = "0x60014E6")]
		[Address(RVA = "0x16804D8", Offset = "0x16804D8", VA = "0x16804D8", Slot = "4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700024E")]
	protected override ConsentRequestTypes RequestType
	{
		[Token(Token = "0x60014E7")]
		[Address(RVA = "0x16804E0", Offset = "0x16804E0", VA = "0x16804E0", Slot = "5")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60014E8")]
	[Address(RVA = "0x16804E8", Offset = "0x16804E8", VA = "0x16804E8", Slot = "6")]
	protected override void AddListeners()
	{
	}

	[Token(Token = "0x60014E9")]
	[Address(RVA = "0x16805CC", Offset = "0x16805CC", VA = "0x16805CC", Slot = "7")]
	protected override void RemoveListeners()
	{
	}

	[Token(Token = "0x60014EA")]
	[Address(RVA = "0x16806B0", Offset = "0x16806B0", VA = "0x16806B0", Slot = "9")]
	protected override bool IsRequestValid()
	{
		return default;
	}

	[Token(Token = "0x60014EB")]
	[Address(RVA = "0x1680A34", Offset = "0x1680A34", VA = "0x1680A34", Slot = "10")]
	protected override Task<bool> ShowAndAwaitPopupInternal()
	{
		return null;
	}

	[Token(Token = "0x60014EC")]
	[Address(RVA = "0x16806B4", Offset = "0x16806B4", VA = "0x16806B4")]
	private bool AreNotificationsEnabledOnDifferentDevice()
	{
		return default;
	}

	[Token(Token = "0x60014ED")]
	[Address(RVA = "0x1680B44", Offset = "0x1680B44", VA = "0x1680B44")]
	public SecondDeviceNotificationsPopupRequest()
	{
	}
}
