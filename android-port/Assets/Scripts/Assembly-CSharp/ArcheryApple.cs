using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001CA")]
[Attribute(Name = "RequireComponent", RVA = "0x3E1F0", Offset = "0x3E1F0")]
public class ArcheryApple : MonoBehaviour
{
	[Token(Token = "0x4000831")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector3 minVelOnceHit;

	[Token(Token = "0x4000832")]
	[FieldOffset(Offset = "0x24")]
	private bool wasHit;

	[Token(Token = "0x4000833")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rb;

	[Token(Token = "0x4000834")]
	[FieldOffset(Offset = "0x30")]
	private string arrowLayerName;

	[Token(Token = "0x4000835")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Collider col;

	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x141F878", Offset = "0x141F878", VA = "0x141F878")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x141F8D4", Offset = "0x141F8D4", VA = "0x141F8D4")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60007FB")]
	[Address(RVA = "0x141F96C", Offset = "0x141F96C", VA = "0x141F96C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60007FC")]
	[Address(RVA = "0x141FA84", Offset = "0x141FA84", VA = "0x141FA84")]
	public ArcheryApple()
	{
	}
}
