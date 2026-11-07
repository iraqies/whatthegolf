using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x2000489")]
public class WhatsNewPopupRequest : ConsentPopupRequest
{
	[Token(Token = "0x200048A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FC2C", Offset = "0x3FC2C")]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x4001821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DailyChallengeLevelDataContainer special;

		[Token(Token = "0x6001515")]
		[Address(RVA = "0x1877D2C", Offset = "0x1877D2C", VA = "0x1877D2C")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6001516")]
		[Address(RVA = "0x1877D34", Offset = "0x1877D34", VA = "0x1877D34")]
		internal bool _003CIsRequestValid_003Eb__0(WTGNotification n)
		{
			return default;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200048B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FC3C", Offset = "0x3FC3C")]
	private struct _003CShowAndAwaitPopupInternal_003Ed__9 : IAsyncStateMachine
	{
		[Token(Token = "0x4001822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		[Token(Token = "0x4001824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WhatsNewPopupRequest _003C_003E4__this;

		[Token(Token = "0x4001825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x6001517")]
		[Address(RVA = "0x1877D70", Offset = "0x1877D70", VA = "0x1877D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6001518")]
		[Address(RVA = "0x1878080", Offset = "0x1878080", VA = "0x1878080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4001820")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private WTGNotification? _notifForNewContent;

	[Token(Token = "0x17000253")]
	protected override bool CanBeSnoozed
	{
		[Token(Token = "0x600150D")]
		[Address(RVA = "0x1753220", Offset = "0x1753220", VA = "0x1753220", Slot = "4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000254")]
	protected override ConsentRequestTypes RequestType
	{
		[Token(Token = "0x600150E")]
		[Address(RVA = "0x1753228", Offset = "0x1753228", VA = "0x1753228", Slot = "5")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x600150F")]
	[Address(RVA = "0x1753230", Offset = "0x1753230", VA = "0x1753230", Slot = "6")]
	protected override void AddListeners()
	{
	}

	[Token(Token = "0x6001510")]
	[Address(RVA = "0x1753314", Offset = "0x1753314", VA = "0x1753314", Slot = "7")]
	protected override void RemoveListeners()
	{
	}

	[Token(Token = "0x6001511")]
	[Address(RVA = "0x17533F8", Offset = "0x17533F8", VA = "0x17533F8", Slot = "8")]
	protected override bool IsFeatureEnabled()
	{
		return default;
	}

	[Token(Token = "0x6001512")]
	[Address(RVA = "0x1753400", Offset = "0x1753400", VA = "0x1753400", Slot = "9")]
	protected override bool IsRequestValid()
	{
		return default;
	}

	[Token(Token = "0x6001513")]
	[Address(RVA = "0x1753728", Offset = "0x1753728", VA = "0x1753728", Slot = "10")]
	protected override Task<bool> ShowAndAwaitPopupInternal()
	{
		return null;
	}

	[Token(Token = "0x6001514")]
	[Address(RVA = "0x1753834", Offset = "0x1753834", VA = "0x1753834")]
	public WhatsNewPopupRequest()
	{
	}
}
