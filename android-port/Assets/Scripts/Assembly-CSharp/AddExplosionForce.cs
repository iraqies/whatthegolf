using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BA9")]
public class AddExplosionForce : MonoBehaviour
{
	[Token(Token = "0x400410B")]
	[FieldOffset(Offset = "0x18")]
	public Transform ExplosionPoint;

	[Token(Token = "0x400410C")]
	[FieldOffset(Offset = "0x20")]
	public float radius;

	[Token(Token = "0x400410D")]
	[FieldOffset(Offset = "0x24")]
	public float force;

	[Token(Token = "0x400410E")]
	[FieldOffset(Offset = "0x28")]
	public ForceMode mode;

	[Token(Token = "0x400410F")]
	[FieldOffset(Offset = "0x2C")]
	public bool executeOnEnable;

	[Token(Token = "0x4004110")]
	[FieldOffset(Offset = "0x2D")]
	public bool disableKinematic;

	[Token(Token = "0x4004111")]
	[FieldOffset(Offset = "0x30")]
	public Rigidbody[] m_rigidbodies;

	[Token(Token = "0x600384F")]
	[Address(RVA = "0x1405E6C", Offset = "0x1405E6C", VA = "0x1405E6C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003850")]
	[Address(RVA = "0x1405E80", Offset = "0x1405E80", VA = "0x1405E80")]
	public void Execute()
	{
	}

	[Token(Token = "0x6003851")]
	[Address(RVA = "0x1405FD8", Offset = "0x1405FD8", VA = "0x1405FD8")]
	public AddExplosionForce()
	{
	}
}
