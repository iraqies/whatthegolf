using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x200046B")]
public abstract class ConsentPopupRequest
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200046C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FB2C", Offset = "0x3FB2C")]
	private struct _003COnActionReceived_003Ed__13 : IAsyncStateMachine
	{
		[Token(Token = "0x40017D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40017D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40017D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ConsentPopupRequest _003C_003E4__this;

		[Token(Token = "0x40017D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x60014A4")]
		[Address(RVA = "0x178F5F4", Offset = "0x178F5F4", VA = "0x178F5F4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60014A5")]
		[Address(RVA = "0x178F88C", Offset = "0x178F88C", VA = "0x178F88C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200046D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FB3C", Offset = "0x3FB3C")]
	private struct _003CShowAndAwaitPopup_003Ed__17 : IAsyncStateMachine
	{
		[Token(Token = "0x40017D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40017D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40017D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ConsentPopupRequest _003C_003E4__this;

		[Token(Token = "0x40017D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x178F898", Offset = "0x178F898", VA = "0x178F898", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x178FBB8", Offset = "0x178FBB8", VA = "0x178FBB8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200046E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FB4C", Offset = "0x3FB4C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40017DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40017DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<ConsentPopupRequest, bool> _003C_003E9__21_0;

		[Token(Token = "0x40017DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<ConsentPopupRequest, bool> _003C_003E9__21_1;

		[Token(Token = "0x40017DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<OverworldGoal, bool> _003C_003E9__22_0;

		[Token(Token = "0x60014A9")]
		[Address(RVA = "0x178F534", Offset = "0x178F534", VA = "0x178F534")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60014AA")]
		[Address(RVA = "0x178F53C", Offset = "0x178F53C", VA = "0x178F53C")]
		internal bool _003CHasSeenConsentPopupThisSession_003Eb__21_0(ConsentPopupRequest r)
		{
			return default;
		}

		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x178F5B8", Offset = "0x178F5B8", VA = "0x178F5B8")]
		internal bool _003CHasSeenConsentPopupThisSession_003Eb__21_1(ConsentPopupRequest r)
		{
			return default;
		}

		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x178F5D0", Offset = "0x178F5D0", VA = "0x178F5D0")]
		internal bool _003CLevelCompleteChecksPassed_003Eb__22_0(OverworldGoal g)
		{
			return default;
		}
	}

	[Token(Token = "0x40017CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D704", Offset = "0x4D704")]
	private bool HasBeenShownThisSession__BackingField;

	[Token(Token = "0x40017D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<ConsentPopupRequest> _allRequests;

	[Token(Token = "0x40017D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<ConsentRequestTypes> _priorityOrder;

	[Token(Token = "0x17000244")]
	protected abstract bool CanBeSnoozed
	{
		[Token(Token = "0x6001491")]
		get;
	}

	[Token(Token = "0x17000245")]
	private bool HasBeenShownThisSession
	{
		[Token(Token = "0x6001492")]
		[Address(RVA = "0x18AC964", Offset = "0x18AC964", VA = "0x18AC964")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621EC", Offset = "0x621EC")]
		get
		{
			return default;
		}
		[Token(Token = "0x6001493")]
		[Address(RVA = "0x18AC96C", Offset = "0x18AC96C", VA = "0x18AC96C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621FC", Offset = "0x621FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000246")]
	protected abstract ConsentRequestTypes RequestType
	{
		[Token(Token = "0x6001494")]
		get;
	}

	[Token(Token = "0x6001495")]
	[Address(RVA = "0x18AC974", Offset = "0x18AC974", VA = "0x18AC974")]
	public void Init(List<ConsentPopupRequest> allRequests)
	{
	}

	[Token(Token = "0x6001496")]
	protected abstract void AddListeners();

	[Token(Token = "0x6001497")]
	protected abstract void RemoveListeners();

	[Token(Token = "0x6001498")]
	[Address(RVA = "0x18ACA78", Offset = "0x18ACA78", VA = "0x18ACA78")]
	protected void OnActionReceived()
	{
	}

	[Token(Token = "0x6001499")]
	[Address(RVA = "0x18ACB10", Offset = "0x18ACB10", VA = "0x18ACB10")]
	private bool HasBeenDisabled()
	{
		return default;
	}

	[Token(Token = "0x600149A")]
	protected abstract bool IsFeatureEnabled();

	[Token(Token = "0x600149B")]
	protected abstract bool IsRequestValid();

	[Token(Token = "0x600149C")]
	[Address(RVA = "0x18ACBB8", Offset = "0x18ACBB8", VA = "0x18ACBB8")]
	private Task ShowAndAwaitPopup()
	{
		return null;
	}

	[Token(Token = "0x600149D")]
	[Address(RVA = "0x18ACC94", Offset = "0x18ACC94", VA = "0x18ACC94")]
	private void Snooze()
	{
	}

	[Token(Token = "0x600149E")]
	[Address(RVA = "0x18ACCF0", Offset = "0x18ACCF0", VA = "0x18ACCF0")]
	private bool IsSnoozed()
	{
		return default;
	}

	[Token(Token = "0x600149F")]
	protected abstract Task<bool> ShowAndAwaitPopupInternal();

	[Token(Token = "0x60014A0")]
	[Address(RVA = "0x18ACFE8", Offset = "0x18ACFE8", VA = "0x18ACFE8")]
	private bool HasSeenConsentPopupThisSession()
	{
		return default;
	}

	[Token(Token = "0x60014A1")]
	[Address(RVA = "0x18AD1F8", Offset = "0x18AD1F8", VA = "0x18AD1F8")]
	protected bool LevelCompleteChecksPassed()
	{
		return default;
	}

	[Token(Token = "0x60014A2")]
	[Address(RVA = "0x18AD3B0", Offset = "0x18AD3B0", VA = "0x18AD3B0")]
	protected ConsentPopupRequest()
	{
	}
}
