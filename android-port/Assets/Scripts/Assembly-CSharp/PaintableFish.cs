using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000311")]
public class PaintableFish : MonoBehaviour
{
	[Token(Token = "0x40010E6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RigidbodyThrower thrower;

	[Token(Token = "0x40010E7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Rigidbody rb;

	[Token(Token = "0x40010E8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector3 velThres;

	[Token(Token = "0x40010E9")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float offset;

	[Token(Token = "0x40010EA")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private ChangeColor cangeColor;

	[Token(Token = "0x40010EB")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private PlayAudioClipSetting playAudioClipSetting;

	[Token(Token = "0x40010EC")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject paintableFish;

	[Token(Token = "0x40010ED")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private ActionAfterNumEvents ticker;

	[Token(Token = "0x40010EE")]
	[FieldOffset(Offset = "0x58")]
	private RaycastHit _hit;

	[Token(Token = "0x40010EF")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private ParticleSystem PSystem;

	[Token(Token = "0x6000E21")]
	[Address(RVA = "0x15D71B8", Offset = "0x15D71B8", VA = "0x15D71B8")]
	private void Collapse()
	{
	}

	[Token(Token = "0x6000E22")]
	[Address(RVA = "0x15D72F4", Offset = "0x15D72F4", VA = "0x15D72F4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000E23")]
	[Address(RVA = "0x15D7448", Offset = "0x15D7448", VA = "0x15D7448")]
	public PaintableFish()
	{
	}
}
