using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001E8")]
public class Weightlifter : MonoBehaviour
{
	[Token(Token = "0x4000914")]
	[FieldOffset(Offset = "0x18")]
	public float startDelay;

	[Token(Token = "0x4000915")]
	[FieldOffset(Offset = "0x1C")]
	public float explosionForce;

	[Token(Token = "0x4000916")]
	[FieldOffset(Offset = "0x20")]
	public float explosionRadius;

	[Token(Token = "0x4000917")]
	[FieldOffset(Offset = "0x28")]
	public Transform explosionForceOrigin;

	[Token(Token = "0x4000918")]
	[FieldOffset(Offset = "0x30")]
	public Rigidbody weight;

	[Token(Token = "0x4000919")]
	[FieldOffset(Offset = "0x38")]
	public Rigidbody[] props;

	[Token(Token = "0x400091A")]
	[FieldOffset(Offset = "0x40")]
	public Rigidbody weightLifterRigid;

	[Token(Token = "0x400091B")]
	[FieldOffset(Offset = "0x48")]
	private float timeAtStart;

	[Token(Token = "0x400091C")]
	[FieldOffset(Offset = "0x4C")]
	private bool didCollapse;

	[Token(Token = "0x6000889")]
	[Address(RVA = "0x1751988", Offset = "0x1751988", VA = "0x1751988")]
	private void Awake()
	{
	}

	[Token(Token = "0x600088A")]
	[Address(RVA = "0x17519C4", Offset = "0x17519C4", VA = "0x17519C4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600088B")]
	[Address(RVA = "0x1751A58", Offset = "0x1751A58", VA = "0x1751A58")]
	public void Collapse()
	{
	}

	[Token(Token = "0x600088C")]
	[Address(RVA = "0x1751D34", Offset = "0x1751D34", VA = "0x1751D34")]
	public Weightlifter()
	{
	}
}
