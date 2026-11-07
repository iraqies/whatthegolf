using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007A6")]
public class JoustingElephant : MonoBehaviour
{
	[Token(Token = "0x4002870")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody elephantRigidbody;

	[Token(Token = "0x4002871")]
	[FieldOffset(Offset = "0x20")]
	public Transform rider;

	[Token(Token = "0x4002872")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody lance;

	[Token(Token = "0x4002873")]
	[FieldOffset(Offset = "0x30")]
	public LayerMask opponentLayer;

	[Token(Token = "0x4002874")]
	[FieldOffset(Offset = "0x34")]
	public float opponentDetectionRadius;

	[Token(Token = "0x4002875")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody[] ragdoll;

	[Token(Token = "0x4002876")]
	[FieldOffset(Offset = "0x40")]
	private Collider[] nearbyOpponents;

	[Token(Token = "0x600230E")]
	[Address(RVA = "0x14F7C20", Offset = "0x14F7C20", VA = "0x14F7C20")]
	private void Start()
	{
	}

	[Token(Token = "0x600230F")]
	[Address(RVA = "0x14F7CFC", Offset = "0x14F7CFC", VA = "0x14F7CFC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002310")]
	[Address(RVA = "0x14F7EE8", Offset = "0x14F7EE8", VA = "0x14F7EE8")]
	[Attribute(Name = "ContextMenu", RVA = "0x65FC4", Offset = "0x65FC4")]
	public void EnableRagdoll()
	{
	}

	[Token(Token = "0x6002311")]
	[Address(RVA = "0x14F7FC0", Offset = "0x14F7FC0", VA = "0x14F7FC0")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6002312")]
	[Address(RVA = "0x14F8010", Offset = "0x14F8010", VA = "0x14F8010")]
	public JoustingElephant()
	{
	}
}
