using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x20002AC")]
public class RotateUIRectTowardsMouse : MonoBehaviour, IDragHandler, IEventSystemHandler, IEndDragHandler
{
	[Token(Token = "0x4000E48")]
	[FieldOffset(Offset = "0x18")]
	public Animator ScanlinesAnimator;

	[Token(Token = "0x4000E49")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CorrectChannelObject;

	[Token(Token = "0x4000E4A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject FrogKingChannelObject;

	[Token(Token = "0x4000E4B")]
	[FieldOffset(Offset = "0x30")]
	public Canvas canvas;

	[Token(Token = "0x4000E4C")]
	[FieldOffset(Offset = "0x38")]
	public float regularAngle;

	[Token(Token = "0x4000E4D")]
	[FieldOffset(Offset = "0x3C")]
	public float regularTolerace;

	[Token(Token = "0x4000E4E")]
	[FieldOffset(Offset = "0x40")]
	public float secretAngle;

	[Token(Token = "0x4000E4F")]
	[FieldOffset(Offset = "0x44")]
	public float secretTolerace;

	[Token(Token = "0x4000E50")]
	[FieldOffset(Offset = "0x48")]
	public UnlockAchievement achievement;

	[Token(Token = "0x4000E51")]
	[FieldOffset(Offset = "0x50")]
	private bool isSecretShown;

	[Token(Token = "0x4000E52")]
	[FieldOffset(Offset = "0x51")]
	private bool isDraggingWithController;

	[Token(Token = "0x4000E53")]
	[FieldOffset(Offset = "0x54")]
	private float controllerUpDownValue;

	[Token(Token = "0x6000C46")]
	[Address(RVA = "0x165F99C", Offset = "0x165F99C", VA = "0x165F99C", Slot = "4")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000C47")]
	[Address(RVA = "0x165FA6C", Offset = "0x165FA6C", VA = "0x165FA6C")]
	private void UpdateAngle(Vector2 dir)
	{
	}

	[Token(Token = "0x6000C48")]
	[Address(RVA = "0x165FC78", Offset = "0x165FC78", VA = "0x165FC78")]
	public void Update()
	{
	}

	[Token(Token = "0x6000C49")]
	[Address(RVA = "0x165FDE8", Offset = "0x165FDE8", VA = "0x165FDE8", Slot = "5")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000C4A")]
	[Address(RVA = "0x165FAF0", Offset = "0x165FAF0", VA = "0x165FAF0")]
	private void UpdateSignal(float angle)
	{
	}

	[Token(Token = "0x6000C4B")]
	[Address(RVA = "0x165FE14", Offset = "0x165FE14", VA = "0x165FE14")]
	private void ToggleSignalLost(bool signalIsLost)
	{
	}

	[Token(Token = "0x6000C4C")]
	[Address(RVA = "0x165FE7C", Offset = "0x165FE7C", VA = "0x165FE7C")]
	public RotateUIRectTowardsMouse()
	{
	}
}
