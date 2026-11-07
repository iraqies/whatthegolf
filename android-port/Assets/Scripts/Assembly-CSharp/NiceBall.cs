using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200082A")]
[Attribute(Name = "RequireComponent", RVA = "0x41830", Offset = "0x41830")]
public class NiceBall : MonoBehaviour
{
	[Token(Token = "0x4002C03")]
	[FieldOffset(Offset = "0x18")]
	public float radius;

	[Token(Token = "0x4002C04")]
	[FieldOffset(Offset = "0x1C")]
	public bool lockYbounceToZero;

	[Token(Token = "0x4002C05")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float bounceYAngleThreshold;

	[Token(Token = "0x4002C06")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float useNormalAsGravityAngleThreshold;

	[Token(Token = "0x4002C07")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float dampenYMultiplier;

	[Token(Token = "0x4002C08")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float dampenAngularVelocityMultiplier;

	[Token(Token = "0x4002C09")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float otherIsRigidMultiplier;

	[Token(Token = "0x4002C0A")]
	[FieldOffset(Offset = "0x38")]
	public Rigidbody rigidbody;

	[Token(Token = "0x4002C0B")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 lastVelocity;

	[Token(Token = "0x4002C0C")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 lastAngularVelocity;

	[Token(Token = "0x6002591")]
	[Address(RVA = "0x158D51C", Offset = "0x158D51C", VA = "0x158D51C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002592")]
	[Address(RVA = "0x158D588", Offset = "0x158D588", VA = "0x158D588")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002593")]
	[Address(RVA = "0x158D788", Offset = "0x158D788", VA = "0x158D788")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6002594")]
	[Address(RVA = "0x158D7C4", Offset = "0x158D7C4", VA = "0x158D7C4")]
	public void Push(Vector3 newForce)
	{
	}

	[Token(Token = "0x6002595")]
	[Address(RVA = "0x158D80C", Offset = "0x158D80C", VA = "0x158D80C")]
	private void OnCollisionEnter(Collision col)
	{
	}

	[Token(Token = "0x6002596")]
	[Address(RVA = "0x158DCF4", Offset = "0x158DCF4", VA = "0x158DCF4")]
	public void IgnoreLastCollision(float amount)
	{
	}

	[Token(Token = "0x6002597")]
	[Address(RVA = "0x158DD28", Offset = "0x158DD28", VA = "0x158DD28")]
	public NiceBall()
	{
	}
}
