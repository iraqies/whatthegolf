using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x20001BD")]
public class ScrollRectNested : ScrollRect
{
	[Token(Token = "0x40007CA")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private ScrollRect parentScrollRect;

	[Token(Token = "0x40007CB")]
	[FieldOffset(Offset = "0x130")]
	private bool routeToParent;

	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x167F868", Offset = "0x167F868", VA = "0x167F868", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x167F938", Offset = "0x167F938", VA = "0x167F938", Slot = "43")]
	public override void OnInitializePotentialDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x167FA58", Offset = "0x167FA58", VA = "0x167FA58", Slot = "46")]
	public override void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x167FBA0", Offset = "0x167FBA0", VA = "0x167FBA0", Slot = "44")]
	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x167FD98", Offset = "0x167FD98", VA = "0x167FD98", Slot = "45")]
	public override void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x167FED0", Offset = "0x167FED0", VA = "0x167FED0", Slot = "42")]
	public override void OnScroll(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x1680018", Offset = "0x1680018", VA = "0x1680018")]
	public ScrollRectNested()
	{
	}
}
