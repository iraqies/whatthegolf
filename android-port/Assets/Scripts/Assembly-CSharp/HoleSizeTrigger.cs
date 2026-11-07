using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000069")]
public class HoleSizeTrigger : MonoBehaviour
{
	[Token(Token = "0x40001AB")]
	[FieldOffset(Offset = "0x18")]
	public float holeSizeTreshold;

	[Token(Token = "0x40001AC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject holeObject;

	[Token(Token = "0x40001AD")]
	[FieldOffset(Offset = "0x28")]
	public GameObject fenceBorder;

	[Token(Token = "0x40001AE")]
	[FieldOffset(Offset = "0x30")]
	public float fenceResizeScale;

	[Token(Token = "0x40001AF")]
	[FieldOffset(Offset = "0x38")]
	public UnityEvent OnHoleBig;

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x14D0F1C", Offset = "0x14D0F1C", VA = "0x14D0F1C")]
	private void Update()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x14D0FA4", Offset = "0x14D0FA4", VA = "0x14D0FA4")]
	public HoleSizeTrigger()
	{
	}
}
