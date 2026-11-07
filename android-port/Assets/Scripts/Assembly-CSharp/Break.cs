using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200087A")]
public class Break : MonoBehaviour
{
	[Token(Token = "0x4002E76")]
	[FieldOffset(Offset = "0x18")]
	private Rigidbody[] rigidShards;

	[Token(Token = "0x4002E77")]
	[FieldOffset(Offset = "0x20")]
	private Rigidbody[] parentRigidbodies;

	[Token(Token = "0x4002E78")]
	[FieldOffset(Offset = "0x28")]
	private Collider[] parentColliders;

	[Token(Token = "0x4002E79")]
	[FieldOffset(Offset = "0x30")]
	private Collider[] childColliders;

	[Token(Token = "0x4002E7A")]
	[FieldOffset(Offset = "0x38")]
	private bool broken;

	[Token(Token = "0x4002E7B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private double breakVelocity;

	[Token(Token = "0x4002E7C")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody rb;

	[Token(Token = "0x4002E7D")]
	[FieldOffset(Offset = "0x50")]
	public Collider[] toBeDestroyed;

	[Token(Token = "0x600271F")]
	[Address(RVA = "0x1705C48", Offset = "0x1705C48", VA = "0x1705C48")]
	private void Start()
	{
	}

	[Token(Token = "0x6002720")]
	[Address(RVA = "0x1705D44", Offset = "0x1705D44", VA = "0x1705D44")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6002721")]
	[Address(RVA = "0x1706050", Offset = "0x1706050", VA = "0x1706050")]
	public Break()
	{
	}
}
