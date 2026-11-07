using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

[Token(Token = "0x20001A7")]
public class MainMenu2Button : Button
{
	[Token(Token = "0x4000780")]
	[FieldOffset(Offset = "0x100")]
	private UINavigationHelper _navigationHelper;

	[Token(Token = "0x4000781")]
	[FieldOffset(Offset = "0x108")]
	public UnityEvent onSelected;

	[Token(Token = "0x6000756")]
	[Address(RVA = "0x15576D0", Offset = "0x15576D0", VA = "0x15576D0", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000757")]
	[Address(RVA = "0x1557738", Offset = "0x1557738", VA = "0x1557738", Slot = "36")]
	public override void OnSelect(BaseEventData eventData)
	{
	}

	[Token(Token = "0x6000758")]
	[Address(RVA = "0x155776C", Offset = "0x155776C", VA = "0x155776C", Slot = "27")]
	public override Selectable FindSelectableOnLeft()
	{
		return null;
	}

	[Token(Token = "0x6000759")]
	[Address(RVA = "0x1557B3C", Offset = "0x1557B3C", VA = "0x1557B3C", Slot = "28")]
	public override Selectable FindSelectableOnRight()
	{
		return null;
	}

	[Token(Token = "0x600075A")]
	[Address(RVA = "0x1557F38", Offset = "0x1557F38", VA = "0x1557F38", Slot = "29")]
	public override Selectable FindSelectableOnUp()
	{
		return null;
	}

	[Token(Token = "0x600075B")]
	[Address(RVA = "0x1558244", Offset = "0x1558244", VA = "0x1558244", Slot = "30")]
	public override Selectable FindSelectableOnDown()
	{
		return null;
	}

	[Token(Token = "0x600075C")]
	[Address(RVA = "0x1558550", Offset = "0x1558550", VA = "0x1558550")]
	public MainMenu2Button()
	{
	}
}
