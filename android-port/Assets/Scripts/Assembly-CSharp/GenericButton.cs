using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005AA")]
public class GenericButton : MonoBehaviour
{
	[Token(Token = "0x4001CE8")]
	[FieldOffset(Offset = "0x18")]
	private Animator anim;

	[Token(Token = "0x4001CE9")]
	[FieldOffset(Offset = "0x20")]
	public bool isPressed;

	[Token(Token = "0x60019BF")]
	[Address(RVA = "0x148448C", Offset = "0x148448C", VA = "0x148448C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60019C0")]
	[Address(RVA = "0x14844E8", Offset = "0x14844E8", VA = "0x14844E8", Slot = "4")]
	protected virtual void OnPress()
	{
	}

	[Token(Token = "0x60019C1")]
	[Address(RVA = "0x14844EC", Offset = "0x14844EC", VA = "0x14844EC", Slot = "5")]
	protected virtual void OnToggle()
	{
	}

	[Token(Token = "0x60019C2")]
	[Address(RVA = "0x14844F0", Offset = "0x14844F0", VA = "0x14844F0")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60019C3")]
	[Address(RVA = "0x14845C4", Offset = "0x14845C4", VA = "0x14845C4")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60019C4")]
	[Address(RVA = "0x1484684", Offset = "0x1484684", VA = "0x1484684")]
	public GenericButton()
	{
	}
}
