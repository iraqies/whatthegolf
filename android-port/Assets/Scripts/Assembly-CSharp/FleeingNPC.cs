using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200093F")]
public class FleeingNPC : MonoBehaviour
{
	[Token(Token = "0x400328B")]
	[FieldOffset(Offset = "0x18")]
	public bool isFleeDirectionFixed;

	[Token(Token = "0x400328C")]
	[FieldOffset(Offset = "0x1C")]
	public Vector3 FleeDirection;

	[Token(Token = "0x400328D")]
	[FieldOffset(Offset = "0x28")]
	public float FleeSpeed;

	[Token(Token = "0x400328E")]
	[FieldOffset(Offset = "0x2C")]
	public bool canOnlyFleeOnce;

	[Token(Token = "0x400328F")]
	[FieldOffset(Offset = "0x30")]
	public float FleeThreshold;

	[Token(Token = "0x4003290")]
	[FieldOffset(Offset = "0x38")]
	public Animator Animator;

	[Token(Token = "0x4003291")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x4003292")]
	[FieldOffset(Offset = "0x48")]
	private bool canFlee;

	[Token(Token = "0x6002AF6")]
	[Address(RVA = "0x146C1EC", Offset = "0x146C1EC", VA = "0x146C1EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6002AF7")]
	[Address(RVA = "0x146C308", Offset = "0x146C308", VA = "0x146C308")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6002AF8")]
	[Address(RVA = "0x146C434", Offset = "0x146C434", VA = "0x146C434")]
	public FleeingNPC()
	{
	}
}
