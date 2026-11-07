using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B0E")]
[Attribute(Name = "RequireComponent", RVA = "0x43470", Offset = "0x43470")]
public class KinematicOnCollision : MonoBehaviour
{
	[Token(Token = "0x4003DC5")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask CollisionMask;

	[Token(Token = "0x4003DC6")]
	[FieldOffset(Offset = "0x1C")]
	public float Delay;

	[Token(Token = "0x4003DC7")]
	[FieldOffset(Offset = "0x20")]
	public bool KinematicState;

	[Token(Token = "0x4003DC8")]
	[FieldOffset(Offset = "0x24")]
	public float ForceOnUnkinematic;

	[Token(Token = "0x4003DC9")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4003DCA")]
	[FieldOffset(Offset = "0x30")]
	private float timer;

	[Token(Token = "0x4003DCB")]
	[FieldOffset(Offset = "0x38")]
	private Collider col;

	[Token(Token = "0x60034C8")]
	[Address(RVA = "0x14FED84", Offset = "0x14FED84", VA = "0x14FED84")]
	private void Awake()
	{
	}

	[Token(Token = "0x60034C9")]
	[Address(RVA = "0x14FEE30", Offset = "0x14FEE30", VA = "0x14FEE30")]
	private void Update()
	{
	}

	[Token(Token = "0x60034CA")]
	[Address(RVA = "0x14FEEC8", Offset = "0x14FEEC8", VA = "0x14FEEC8")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60034CB")]
	[Address(RVA = "0x14FEFCC", Offset = "0x14FEFCC", VA = "0x14FEFCC")]
	public KinematicOnCollision()
	{
	}
}
