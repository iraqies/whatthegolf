using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x2000473")]
public abstract class EmailPopupRequest : ConsentPopupRequest
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000474")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FB6C", Offset = "0x3FB6C")]
	private struct _003CShowPopup_003Ed__4 : IAsyncStateMachine
	{
		[Token(Token = "0x40017EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40017EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40017F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EmailPopupRequest _003C_003E4__this;

		[Token(Token = "0x60014C3")]
		[Address(RVA = "0x179EA58", Offset = "0x179EA58", VA = "0x179EA58", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60014C4")]
		[Address(RVA = "0x179ECEC", Offset = "0x179ECEC", VA = "0x179ECEC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x40017ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string description;

	[Token(Token = "0x17000248")]
	protected override ConsentRequestTypes RequestType
	{
		[Token(Token = "0x60014BC")]
		[Address(RVA = "0x1441990", Offset = "0x1441990", VA = "0x1441990", Slot = "5")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60014BD")]
	[Address(RVA = "0x1441998", Offset = "0x1441998", VA = "0x1441998", Slot = "8")]
	protected override bool IsFeatureEnabled()
	{
		return default;
	}

	[Token(Token = "0x60014BE")]
	[Address(RVA = "0x1441A40", Offset = "0x1441A40", VA = "0x1441A40")]
	protected Task ShowPopup()
	{
		return null;
	}

	[Token(Token = "0x60014BF")]
	[Address(RVA = "0x1441B1C", Offset = "0x1441B1C", VA = "0x1441B1C")]
	private void Disagree()
	{
	}

	[Token(Token = "0x60014C0")]
	[Address(RVA = "0x1441B20", Offset = "0x1441B20", VA = "0x1441B20")]
	private void Agree()
	{
	}

	[Token(Token = "0x60014C1")]
	[Address(RVA = "0x1441B68", Offset = "0x1441B68", VA = "0x1441B68")]
	protected void MarkAsSeen()
	{
	}

	[Token(Token = "0x60014C2")]
	[Address(RVA = "0x1441C38", Offset = "0x1441C38", VA = "0x1441C38")]
	protected EmailPopupRequest()
	{
	}
}
