using Il2CppDummyDll;
using UnityEngine.Events;

[Token(Token = "0x2000F0D")]
public class DPIFocusEvent : BaseDailyPrizeInteractions
{
	[Token(Token = "0x4005135")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent GetFocusEvent;

	[Token(Token = "0x4005136")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent LoseFocusEvent;

	[Token(Token = "0x600465E")]
	[Address(RVA = "0x18C8368", Offset = "0x18C8368", VA = "0x18C8368", Slot = "11")]
	public override void OnGetFocus()
	{
	}

	[Token(Token = "0x600465F")]
	[Address(RVA = "0x18C837C", Offset = "0x18C837C", VA = "0x18C837C", Slot = "10")]
	public override void OnLoseFocus()
	{
	}

	[Token(Token = "0x6004660")]
	[Address(RVA = "0x18C8390", Offset = "0x18C8390", VA = "0x18C8390")]
	public DPIFocusEvent()
	{
	}
}
